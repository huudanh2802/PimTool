import { ErrorDto } from './../../../swagger/models/error-dto';
import { AddProjectDto } from './../../../swagger/models/add-project-dto';
import { ViewProjectDto } from './../../../swagger/models/view-project-dto';
import { ProjectStatus } from './../../constants';
import { ChangeDetectionStrategy, ChangeDetectorRef, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Subscription } from 'rxjs';
import { GroupService } from 'src/app/swagger/services/group.service';
import { ReactiveFormsModule, FormGroup, FormControl, Validators } from '@angular/forms';
import { DatePipe } from '@angular/common';
import { endDateLessThan } from '../../validators/customvalidators';

@Component({
  selector: 'pim-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})

export class FormComponent {

  projectForm: FormGroup;
  hasError: boolean;
  errorMessage: string;
  @Input() groupIds: number[];
  @Input() viewProjectDto: ViewProjectDto;
  @Input() serverError = new EventEmitter<ErrorDto>();
  @Output() addProject = new EventEmitter<AddProjectDto>();
  @Output() updateProject = new EventEmitter<ViewProjectDto>();

  statuses = ProjectStatus;
  selectedGroup: string = "Choose Group"
  private _subscription: Subscription;

  constructor(
    private datePipe: DatePipe,
    private _ref: ChangeDetectorRef
  ) { }

  ngOnInit(): void {
    this._subscription = new Subscription();
    this.hasError = false;
    if (this.viewProjectDto === undefined) {
      this.viewProjectDto = {} as ViewProjectDto;
      this.viewProjectDto.groupId = this.groupIds[0];
      this.viewProjectDto.status = ProjectStatus[0];
    }
    this.projectForm = new FormGroup({
      'projectNumber': new FormControl(this.viewProjectDto.projectNumber, [Validators.required, Validators.max(Math.pow(10, 4)), Validators.pattern("^[0-9]*$")]),
      'name': new FormControl(this.viewProjectDto.name, [Validators.required, Validators.maxLength(50)]),
      'customer': new FormControl(this.viewProjectDto.customer, [Validators.required, Validators.maxLength(50)]),
      'status': new FormControl(this.viewProjectDto.status, [Validators.required]),
      'startDate': new FormControl(this.datePipe.transform(this.viewProjectDto.startDate, 'yyyy-MM-dd'), [Validators.required]),
      'endDate': new FormControl(this.datePipe.transform(this.viewProjectDto.endDate, 'yyyy-MM-dd'), endDateLessThan('endDate', 'startDate')),
      'groupId': new FormControl(this.viewProjectDto.groupId, [Validators.required]),
      'visas': new FormControl(this.viewProjectDto.visas),
    });
    this._subscription.add(
      this.serverError.subscribe(error => {
        this.handleBackEndError(error);
      }));
  }

  handleBackEndError(error: ErrorDto) {
    // Bad Request
    if(error.Status===400){
      switch (error.Field) {
        case "Visas":
          this.visas.setErrors({ invalids: true });
          break;
        case "Group":
          this.groupId.setErrors({ invalids: true });
          break;
        case "ProjectNumber":
          this.projectNumber.setErrors({ invalids: true });
        default:
          break;
      }
    }
    //Concurrency
    else{

    }
    this.hasError=true;
    this.errorMessage = error.Message;
    this._ref.detectChanges();
  }

  ngOnChanges(): void {
    console.log(this.viewProjectDto);
  }
  get projectNumber() {
    return this.projectForm.get('projectNumber');
  }
  get name() {
    return this.projectForm.get('name');
  }
  get customer() {
    return this.projectForm.get('customer');
  }
  get startDate() {
    return this.projectForm.get('startDate');
  }
  get endDate() {
    return this.projectForm.get('endDate');
  }
  get groupId() {
    return this.projectForm.get('groupId');
  }
  get visas() {
    return this.projectForm.get('visas');
  }
  get status() {
    return this.projectForm.get('status');
  }

  ngOnDestroy(): void {
    this._subscription.unsubscribe();
  }

  onSubmit(): void {
    if (this.projectForm.valid) {
      this.hasError = false;
      // Newly created project
      if (this.viewProjectDto.projectNumber === undefined) {
        let addProjectDto = {} as AddProjectDto;
        let visas: string = this.projectForm.get('visas').value;
        addProjectDto = this.projectForm.value;
        if (visas !== null) {
          try {
            addProjectDto.visas = visas.split(',');
          }
          catch (TypeError) {
            addProjectDto.visas = visas.split('');
          }

        }
        this.addProject.emit(addProjectDto);
      }
      //Update existing project
      else {
        let updateProjectDto = {} as ViewProjectDto;
        let visas = this.projectForm.get('visas').value;
        updateProjectDto = this.projectForm.value;
        updateProjectDto.id = this.viewProjectDto.id;
        updateProjectDto.version = this.viewProjectDto.version;

        if (typeof (visas) === "object") {
          //Do nothing because visas wasn't modified
        }
        else {
          updateProjectDto.visas = visas.split(',');
        }
        this.updateProject.emit(updateProjectDto);
      }
    }
    else {
      this.projectForm.markAllAsTouched();

      //Check if any field is empty
      if (!Object.values(this.projectForm.value).every(formControl => formControl === null)) {
        console.log(this.projectForm.value);
        this.errorMessage = "Please enter all mandatory field!";
      }

      this.hasError = true;
      this._ref.detectChanges();
    }
  }

  onDismiss(): void {
    this.hasError = false;
    this._ref.detectChanges();
  }

}

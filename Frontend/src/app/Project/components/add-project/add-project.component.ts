import { Router, RouterModule, Routes } from '@angular/router';
import { ErrorDto } from './../../../swagger/models/error-dto';
import { AddProjectDto } from './../../../swagger/models/add-project-dto';
import { ChangeDetectorRef, Component, EventEmitter, OnInit, } from '@angular/core';
import { Subscription } from 'rxjs';
import { ProjectService } from 'src/app/swagger/services/project.service';
import { GroupService } from 'src/app/swagger/services/group.service';

@Component({
  selector: 'app-add-project',
  templateUrl: './add-project.component.html',
  styleUrls: ['./add-project.component.scss']
})
export class AddProjectComponent implements OnInit {
  newProject: AddProjectDto;
  hasData: boolean
  groupIds: number[];
  errorResponse :EventEmitter<ErrorDto>;
  private _subscription: Subscription;
  internalError: boolean;
  constructor(
    private _groupService: GroupService,
    private _projectService: ProjectService,
    private _ref: ChangeDetectorRef,
    private _router: Router
  ) { }

  ngOnInit(): void {
    this.hasData = false;
    this._subscription = new Subscription();
    this.errorResponse = new EventEmitter<ErrorDto>();

    this.getGroup();
  }

  ngOnDestroy(): void {
    this._subscription.unsubscribe();
  }


  getGroup(): void {
    this._subscription.add(
      this._groupService.getAllGroup().subscribe((response) => {
        this.groupIds = response.map(group => group.id);
        this.hasData = true;
        this._ref.detectChanges();
      },
      (error)=>{
        //Can't find Group
        if(error['status']===404){
          this.hasData=false;
          this._ref.detectChanges();
        }
      }));
  }

  addProject(addProjectDto: AddProjectDto): void {
    this._subscription.add(this._projectService.addProject(addProjectDto).subscribe(
      (response)=>{
        this._router.navigate(['']);
      },
      (error)=>{
        if(error['status']===400){
          let errorDto:ErrorDto= error['error']['Error'];
          errorDto.Status=error['status'];
          this.errorResponse.emit(errorDto);
        }
        else {
          this.hasData=false;
          this.internalError=true;
          this._ref.detectChanges();
        }
      }
    )
    );
  }
}

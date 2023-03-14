import { ViewProjectDto } from './../../../swagger/models/view-project-dto';
import { GroupDto } from './../../../swagger/models/group-dto';
import { GroupService } from './../../../swagger/services/group.service';
import { ChangeDetectorRef, Component, EventEmitter, OnInit } from '@angular/core';
import { ProjectService } from 'src/app/swagger/services/project.service';
import { Subscription } from 'rxjs';
import { ActivatedRoute, Router } from '@angular/router';
import { ErrorDto } from 'src/app/swagger/models/error-dto';


@Component({
  selector: 'pim-update-project',
  templateUrl: './update-project.component.html',
  styleUrls: ['./update-project.component.scss']
})

export class UpdateProjectComponent {
  groupIds:number[];
  hasData:boolean;
  project:ViewProjectDto;
  private _subscription:Subscription;
  errorResponse :EventEmitter<ErrorDto>;
  internalError: boolean;
  private _Id:number;
  constructor(
    private _projectService:ProjectService,
    private _groupService: GroupService,
    private _route:ActivatedRoute,
    private _ref:ChangeDetectorRef,
    private _router:Router,
    ) { }

  ngOnInit(): void {
    this._subscription=new Subscription();
    this.getGroup();
    this._Id=parseInt(this._route.snapshot.paramMap.get('id'));
    this.errorResponse = new EventEmitter<ErrorDto>();
    this.getProject(this._Id);

  }

  ngOnDestroy(): void {
    this._subscription.unsubscribe();
  }

  getProject(Id:number):void{
    this._subscription.add(
      this._projectService.getProject(Id).subscribe((response)=>{
        this.project=response;
        this.hasData=true;
        this._ref.detectChanges();
      },
      (error)=>{
        //Can't find project
        if(error['status']===404){
          this.hasData=false;
          this._ref.detectChanges();
        }
      }
      )
    )
  }
  getGroup():void{
    this._subscription.add(
      this._groupService.getAllGroup().subscribe((response)=>{
        this.groupIds=response.map(group=>group.id);
      },
      (error)=>{
        //Can't find Group
        if(error['status']===404){
          this.hasData=false;
          this._ref.detectChanges();
        }
      }));
  }

  updateProject(updateProjectDto:ViewProjectDto):void{
    this._subscription.add(this._projectService.updateProject(updateProjectDto).subscribe(
      (response)=>{
        this._router.navigate(['']);
      },
      (error)=>{
        if(error['status']===400||error['status']===409){
          let errorDto:ErrorDto = error['error']['Error'];
          errorDto.Status=error['status'];
          if(error['status']===409){
            console.log(this.project);
            this._ref.detectChanges;
          }
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

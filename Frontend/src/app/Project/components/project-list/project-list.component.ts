import { DeleteProjectDto } from './../../../swagger/models/delete-project-dto';
import { ViewProjectDto } from './../../../swagger/models/view-project-dto';
import { ProjectService } from './../../../swagger/services/project.service';
import { Component, ChangeDetectionStrategy, OnInit, SimpleChanges, ChangeDetectorRef, EventEmitter } from '@angular/core';
import { Subscription } from 'rxjs';
import { ErrorDto } from 'src/app/swagger/models/error-dto';

@Component({
    selector: 'pim-project-list',
    styleUrls: ['./project-list.component.scss'],
    templateUrl: './project-list.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})

export class ProjectListComponent implements OnInit{
  constructor(
    private _projectService:ProjectService,
    private _ref:ChangeDetectorRef){ }

  headers:string[];
  projects:ViewProjectDto[];
  private _subscription = new Subscription();

  hasData:boolean;
  errorResponse :EventEmitter<ErrorDto>;
  internalError: boolean;

  ngOnInit(): void {
    this.headers=["Number","Name","Customer","Status","Start Date","End Date","Group","Members"];
    this.hasData=false;
    this.errorResponse = new EventEmitter<ErrorDto>();
    this.getProjects();
  }

  ngOnDestroy(): void {
    this._subscription.unsubscribe();
  }
  getProjects():void {
    this._subscription.add(this._projectService.getAllProject()
      .subscribe((response)=>{
        this.projects=response;
        this.hasData=true;
        this._ref.detectChanges();
      },
      (error)=>{
        if(error['status']===400){
          let errorDto= error['error']['Error'];
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

  deleteProjects(deleteProjectDto:DeleteProjectDto):void{
    this._subscription.add(this._projectService.deleteProject(deleteProjectDto).subscribe()
    );
  }



}

import { DeleteProjectDto } from './../../../swagger/models/delete-project-dto';
import { ViewProjectDto } from './../../../swagger/models/view-project-dto';
import { Observable } from 'rxjs';
import { Component, ChangeDetectionStrategy, Input, OnInit, SimpleChanges, Output, EventEmitter } from '@angular/core';


@Component({
    selector: 'pim-grid',
    styleUrls: ['./grid.component.scss'],
    templateUrl: './grid.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})

export class GridComponent {
  @Input() headers:string[]=[];
  @Input() projects:ViewProjectDto[]=[];

  @Output() deleteProjects = new EventEmitter<DeleteProjectDto>();
  deleteProjectDto:DeleteProjectDto;

  ngOnInit(): void {
    this.deleteProjectDto = {} as DeleteProjectDto;
    this.deleteProjectDto.Ids=[];
  }

  isNewViewDtoType(val:ViewProjectDto):boolean{
    return val.status==='NEW';
  }

  deleteProjectRequest(project:ViewProjectDto){
    if(confirm("Are you sure you want to delete this project")){
      this.deleteProjectDto.Ids.push(project.id);
      this.deleteProjects.emit(this.deleteProjectDto);
    }
  }
  deleteMultipleProjectsRequest(){
    if(confirm("Are you sure you want to delete this project")){
      this.deleteProjects.emit(this.deleteProjectDto);
    }
  }

  onSelectedChange(e,project:ViewProjectDto){
    if(e.target.checked){
      this.deleteProjectDto.Ids.push(project.id);
    }
    else{
      this.deleteProjectDto.Ids.forEach((element,index)=>{
        if(element==project.id) this.deleteProjectDto.Ids.splice(index,1);
     });
    }
  }

}



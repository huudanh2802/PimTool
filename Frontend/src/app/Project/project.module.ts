import { DatePipe } from '@angular/common';
import { NgModule } from '@angular/core';

import { PIMBaseModule } from '@base';
import { ProjectListComponent } from './components';
import { UpdateProjectComponent } from './components';
import { ProjectRoutingModule } from './project-routing.module';
import { AddProjectComponent } from './components/add-project/add-project.component';

@NgModule({
    declarations: [ProjectListComponent, UpdateProjectComponent, AddProjectComponent],
    providers: [DatePipe],
    imports: [ProjectRoutingModule, PIMBaseModule]
})
export class ProjectModule {

}

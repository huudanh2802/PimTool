import { AddProjectComponent } from './components/add-project/add-project.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ProjectListComponent } from './components';
import { UpdateProjectComponent } from './components';

const routes: Routes = [
    { path: '', component: ProjectListComponent},
    {path:'add',component:AddProjectComponent},
    {path:'update/:id',component:UpdateProjectComponent},
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ProjectRoutingModule {
}

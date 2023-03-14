import { BaseService } from './../base-service';
import { StrictHttpResponse } from './../strict-http-response';
import { ViewProjectDto } from './../models/view-project-dto';
import { ApiConfiguration } from './../api-configuration';
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpRequest, HttpResponse } from '@angular/common/http';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { Observable, throwError } from 'rxjs';
import { catchError, map, } from 'rxjs/operators';
import { DeleteProjectDto } from '../models/delete-project-dto';
import { AddProjectDto } from '../models/add-project-dto';

@Injectable({
  providedIn: 'root'
})

export class ProjectService extends BaseService {

  private projectUrl = '/api/Project'

  constructor(
    http: HttpClient,
    config: ApiConfiguration
  ) {
    super(config, http);
  }

  /*Return all projects*/
  getAllProjectResponse(): Observable<StrictHttpResponse<Array<ViewProjectDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + this.projectUrl,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as StrictHttpResponse<Array<ViewProjectDto>>;
      })
    );
  }

  getAllProject(): Observable<Array<ViewProjectDto>> {
    return this.getAllProjectResponse().pipe(
      __map(_r => _r.body.sort((a,b)=> a.projectNumber-b.projectNumber))
    );
  }


  /**
   * @param id undefined
   */
  deleteProjectRequest(deleteProjectDto: DeleteProjectDto): Observable<StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = deleteProjectDto;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + this.projectUrl,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });
      console.log(req);
    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as StrictHttpResponse<null>;
      })
    );
  }

  //Delete mutiple projects
  deleteProject(deleteProjectDto: DeleteProjectDto): Observable<null> {
    return this.deleteProjectRequest(deleteProjectDto).pipe(
      __map(_r => _r.body));
  }

  getProjectResponse(id: number): Observable<StrictHttpResponse<ViewProjectDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + this.projectUrl + `/${id}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as StrictHttpResponse<ViewProjectDto>;
      })
    );
  }
  // Get a single project
  getProject(id: number): Observable<ViewProjectDto> {
    return this.getProjectResponse(id).pipe(
      __map(_r => _r.body)
    );
  }

  addProjectResponse(addProjectDto: AddProjectDto): Observable<StrictHttpResponse<AddProjectDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = addProjectDto;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + this.projectUrl,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as StrictHttpResponse<AddProjectDto>;
      })
    );
  }

  // Add a single project
  addProject(addProjectDto: AddProjectDto): Observable<AddProjectDto> {
    return this.addProjectResponse(addProjectDto).pipe(
      __map(_r => _r.body)
    );
  }
   updateProjectResponse(updateProjectDto: ViewProjectDto): Observable<StrictHttpResponse<ViewProjectDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = updateProjectDto;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + this.projectUrl + `/${updateProjectDto.id}`  ,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as StrictHttpResponse<ViewProjectDto>;
      })

    );
  }
  // Update a single project
  updateProject(updateProjectDto: ViewProjectDto):Observable<ViewProjectDto> {
    return this.updateProjectResponse(updateProjectDto).pipe(
      __map(_r => _r.body)
    );
  }


}

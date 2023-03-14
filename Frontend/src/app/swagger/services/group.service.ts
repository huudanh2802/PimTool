import { GroupDto } from './../models/group-dto';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ApiConfiguration } from './../api-configuration';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class GroupService {
  private getAllGroupUrl='/api/Group';
  constructor(
    private http:HttpClient,
    private api: ApiConfiguration,
  ) { }

  getAllGroup():Observable<GroupDto[]>{
    return this.http.get<GroupDto[]>(this.api.rootUrl+this.getAllGroupUrl);
  }
}

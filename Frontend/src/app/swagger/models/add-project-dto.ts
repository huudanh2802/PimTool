/* tslint:disable */
export interface AddProjectDto {
  projectNumber:number;
  name:string;
  customer:string;
  status:string;
  startDate:Date;
  endDate:Date;
  groupId:number;
  visas:string[];
}

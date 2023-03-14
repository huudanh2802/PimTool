export interface ViewProjectDto {
  id:number;
  projectNumber:number;
  name:string;
  customer:string;
  status:string;
  startDate:Date;
  endDate:Date;
  groupId:number;
  visas:string[];
  version:number;
}

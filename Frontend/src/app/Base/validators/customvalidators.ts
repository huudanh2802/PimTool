import { AbstractControl, FormControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export function endDateLessThan(endDate:string,startDate:string): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    if(control.value!==null){
      if(control.parent.get(startDate).value!==null&&control.parent.get(endDate).value!==null){
        const sDate=control.parent.get(startDate).value;
        const eDate=control.parent.get(endDate).value;
        return (sDate>eDate)?eDate:null;
      }
      else{
        return null;
      }
    }
    return null;
  }
}


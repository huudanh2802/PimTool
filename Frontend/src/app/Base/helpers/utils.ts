

export default class Utils{
  static isDate(val):boolean{
    var parsedDate = Date.parse(val);
    if(isNaN(val) && !isNaN(parsedDate)) {
      return true;
    }
    else{
      return false;
    }
  }
}

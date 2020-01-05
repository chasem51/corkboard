import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, map, tap} from 'rxjs/operators';
import { Helpers } from '../helpers/helpers';

@Injectable()
export class BaseService{
  constructor(private helper : Helpers) { }
  public extractData(res:Response){
    let body = res.json();
    return body || {};
  }
  public handleError(error: Response | any){
    let errorMsg: string;
    if(error instanceof Response){
      const body = error.json() || '';
      const err = body || JSON.stringify(body);
      errorMsg = '${error.status} - ${error.statusText}';
    }
    else{
      errorMsg = error.message ? error.message : error.toString();

    }
    console.error(errorMsg);
    return Observable.throw(errorMsg);
  }
  public header(){
    let header = new HttpHeaders({ 'Content-Type': 'application/json'});
    if(this.helper.isAuthenticated()){
      header = header.append('Authorization', 'Bearer' + this.helper.getToken());
    }
    return {headers: header};
  }
  public setToken(data:any){
    this.helper.setToken(data);
  }
  public failToken(error: Response | any){
    this.helper.failToken();
    return this.handleError(Response);
  }

}

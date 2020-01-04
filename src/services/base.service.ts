import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { catchError, map, tap } from 'rxjs/operators';
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
      errMsg = '${error.status} - ${error.statusText || ''} ${err}';
    }
    else{
      errMsg = error.message ? error.message : error.toString();

    }
    console.error(errMsg);
    return Observable.throw(errMsg);
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
    this.helper.failToken(data);
    return this.handleError(Response);
  }

}

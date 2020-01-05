import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, map, tap} from 'rxjs/operators';
import { BaseService } from './base.service';
import { User } from '../models/user';
import { AppConfig } from '../config/config';
import { Helpers } from '../helpers/helpers';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

@Injectable()
  export class UserService extends BaseService{
    private pathAPI = this.config.setting['PathAPI'];
    constructor(private http: HttpClient, private config: AppConfig,
      helper: Helpers){
        super(helper);}
      getUsers () : Observable<User[]> {
        return this.http.get(this.pathAPI + 'user', super.header()).pipe(this.handleError);
      }
  }

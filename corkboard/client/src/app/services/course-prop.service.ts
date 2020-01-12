import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { CourseProp } from '../models/courseprop';

@Injectable({
  providedIn: 'root'
})
export class CoursePropService {

  myAppUrl: string;
  myApiUrl: string;
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json; charset=utf-8'
    })
  };
  constructor(private http: HttpClient) {
      this.myAppUrl = environment.appUrl;
      this.myApiUrl = 'api/CourseProps/';
  }

  getCourseProps(): Observable<CourseProp[]> {
    return this.http.get<CourseProp[]>(this.myAppUrl + this.myApiUrl)
    .pipe(
      retry(1),
      catchError(this.errorHandler)
    );
  }

  getCourseProp(postId: number): Observable<CourseProp> {
      return this.http.get<CourseProp>(this.myAppUrl + this.myApiUrl + postId)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  saveCourseProp(courseProp): Observable<CourseProp> {
      return this.http.post<CourseProp>(this.myAppUrl + this.myApiUrl, JSON.stringify(courseProp), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  updateCourseProp(postId: number, courseProp): Observable<CourseProp> {
      return this.http.put<CourseProp>(this.myAppUrl + this.myApiUrl + postId, JSON.stringify(courseProp), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  deleteCourseProp(postId: number): Observable<CourseProp> {
      return this.http.delete<CourseProp>(this.myAppUrl + this.myApiUrl + postId)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  errorHandler(error) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
}

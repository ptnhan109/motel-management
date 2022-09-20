import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {AppResponse} from 'src/app/common/response'
import { getToken } from '../common/message';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(
    private http: HttpClient
  ) { }

  options = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': getToken()
    })
  };

  authenticate(user) : Observable<AppResponse<any>>{
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Auth`,user,this.options);
  }


  getProvides() : Observable<AppResponse<any>>{
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`,this.options);
  }
}

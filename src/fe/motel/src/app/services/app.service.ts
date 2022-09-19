import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {AppResponse} from 'src/app/common/response'

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
    })
  };

  authenticate(user) : Observable<AppResponse<any>>{
    console.log(`${environment.apiServer}/api/Auth`);
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Auth`,user,this.options);
  }
}

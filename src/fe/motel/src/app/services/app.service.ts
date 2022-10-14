import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import {AppResponse} from 'src/app/common/response'
import { getToken } from '../common/message';
import { tap } from 'rxjs/operators';

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

  get(url) : Observable<AppResponse<any>>{
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/${url}`,this.options);
  }

  getProvides() : Observable<AppResponse<any>>{
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`,this.options);
  }

  addProvide(provide) : Observable<AppResponse<any>>{
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`,provide,this.options);
  }

  deleteProvide(id): Observable<AppResponse<any>>{
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/Category/provide?id=${id}`,this.options);
  }

  updateProvide(provide) : Observable<AppResponse<any>>{
    return this.http.put<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`,provide,this.options);
  }


  getBoardings():Observable<AppResponse<any>>{
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/boarding`,this.options);
  }

  getBoarding(id):Observable<AppResponse<any>>{
    return this.get(`boarding/${id}`).pipe(
      tap(boardings => console.log(boardings))
    );
  }

  addBoardingHouse(boarding): Observable<AppResponse<any>>{
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Boarding`,boarding,this.options);
  }

  updateBoardingHouse(boarding):Observable<AppResponse<any>>{
    return this.http.put<AppResponse<any>>(`${environment.apiServer}/api/Boarding`,boarding,this.options);
  }

  deleteBoardingHouse(id):Observable<AppResponse<any>>{
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/Boarding/${id}`,this.options);
  }


}

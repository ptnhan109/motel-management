import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AppResponse } from 'src/app/common/response'
import { getToken } from '../common/message';
import { tap } from 'rxjs/operators';
import { param } from 'jquery';
import { ToUrlParam } from '../common/stringFormat';

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
    }),
  };
  formDataOption = {
    headers: new HttpHeaders({
      'Authorization': getToken(),
      'Accept': '*/*'
    })
  };

  fileDownloadOption = {
    headers: new HttpHeaders({
      'Authorization': getToken(),
      'Accept': '*/*'
    }),
    responseType: 'blob' as 'json'
  }

  queryParam(param) {
    return {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': getToken()
      }),
      params: new HttpParams({ fromObject: param })
    }
  }

  authenticate(user): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Auth`, user, this.options);
  }

  get(url): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/${url}`, this.options);
  }

  getProvides(): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`, this.options);
  }

  addProvide(provide): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`, provide, this.options);
  }

  deleteProvide(id): Observable<AppResponse<any>> {
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/Category/provide?id=${id}`, this.options);
  }

  updateProvide(provide): Observable<AppResponse<any>> {
    return this.http.put<AppResponse<any>>(`${environment.apiServer}/api/Category/provide`, provide, this.options);
  }


  getBoardings(): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/boarding`, this.options);
  }

  getBoarding(id): Observable<AppResponse<any>> {
    return this.get(`boarding/${id}`).pipe(
      tap(boardings => console.log(boardings))
    );
  }

  addBoardingHouse(boarding): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/Boarding`, boarding, this.options);
  }

  updateBoardingHouse(boarding): Observable<AppResponse<any>> {
    return this.http.put<AppResponse<any>>(`${environment.apiServer}/api/Boarding`, boarding, this.options);
  }

  deleteBoardingHouse(id): Observable<AppResponse<any>> {
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/Boarding/${id}`, this.options);
  }

  getFitments(): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/Category/fitment`, this.options);
  }

  createRoom(params, boardingId): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/room/${boardingId}/rooms`, params, this.formDataOption)
  }

  getRooms(param): Observable<AppResponse<any>> {
    var options = this.queryParam(param);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/room/rooms`, options);
  }
  getAllRooms(param): Observable<AppResponse<any>> {
    var options = this.queryParam(param);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/room/get-all`, options);
  }

  deleteRoom(id): Observable<AppResponse<any>> {
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/room/${id}`, this.options);
  }

  addDeposit(deposit): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/room/${deposit.roomId}/room-deposit`, deposit, this.options);
  }

  deleteDeposit(id): Observable<AppResponse<any>> {
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/room/${id}/room-deposit`, this.options);
  }

  getRoomDeposit(id): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/room/${id}/room-deposit`, this.options);
  }

  uploadFile(formData, type): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/file/${type}`, formData, this.formDataOption);
  }

  addCustomer(param): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/customer`, param, this.options)
  }

  getCustomers(filter): Observable<AppResponse<any>> {
    var options = this.queryParam(filter);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/customer/paging`, options);
  }
  getAllCustomers(filter): Observable<AppResponse<any>> {
    var options = this.queryParam(filter);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/customer/get-all`, options);
  }

  addContract(param): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/contract`, param, this.options);
  }

  getContracts(filter): Observable<AppResponse<any>> {
    var options = this.queryParam(filter);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/contract/paging`, options);
  }

  downloadContractFile(id): Observable<any> {
    return this.http.get<any>(`${environment.apiServer}/api/contract/${id}/export`, this.fileDownloadOption);
  }

  deleteContract(id): Observable<AppResponse<any>> {
    return this.http.delete<AppResponse<any>>(`${environment.apiServer}/api/contract/${id}`, this.options)
  }

  getContractByRoomId(id, type): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/contract/${id}/room?type=${type}`, this.options);
  }

  setRoomStatus(id, status): Observable<AppResponse<any>> {
    let request = {
      status: status,
      id: id
    };
    return this.http.patch<AppResponse<any>>(`${environment.apiServer}/api/room/${id}/status`, request, this.options)
  }

  getStageCode(): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/stage/code`, this.options);
  }

  addStage(param): Observable<AppResponse<any>> {
    return this.http.post<AppResponse<any>>(`${environment.apiServer}/api/stage`, param, this.options);
  }

  getStagePaging(filter): Observable<AppResponse<any>> {
    var options = this.queryParam(filter);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/stage/paging`, options);
  }

  getRoomInStagePaging(id, filter): Observable<AppResponse<any>> {
    var options = this.queryParam(filter);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/stage/${id}/rooms`, options)
  }

  getStageById(id): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/stage/${id}`, this.options);
  }

  getInvoiceById(id): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/invoice/${id}`, this.options);
  }

  updateInvoice(request): Observable<AppResponse<any>> {
    return this.http.put<AppResponse<any>>(`${environment.apiServer}/api/invoice/${request.id}`, request, this.options)
  }

  setRoomPaymentStatus(id, request): Observable<AppResponse<any>> {
    return this.http.patch<AppResponse<any>>(`${environment.apiServer}/api/invoice/${id}/room`, request, this.options);
  }

  getVehicles(model) {
    var options = this.queryParam(model);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/customer/vehicle-paging`, options)
  }


  getDashboardSummary(): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/report/summary`, this.options);
  }

  getDashboardStagePayment(): Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/report/stage-payments`, this.options);
  }


  getOwnerInfo() : Observable<AppResponse<any>> {
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/user/info`, this.options);
  }

  updateOwnerInfo(model : any) : Observable<AppResponse<any>> {
    return this.http.put<AppResponse<any>>(`${environment.apiServer}/api/user/info`,model, this.options);
  }

  getReportRevenue(filter): Observable<AppResponse<any>> {
    var param = ToUrlParam(filter);
    return this.http.get<AppResponse<any>>(`${environment.apiServer}/api/report/report-revenue-by-room${param}`, this.options);
  }
}

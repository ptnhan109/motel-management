import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize, map } from 'rxjs/operators';
import { getToken } from '../common/message';
import { UserServiceService } from './user-service.service';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor(
    private _router: Router,
    private _toast : ToastrService,
    private _authService : UserServiceService
  ) {

  }
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError(err => {
        if (err instanceof HttpErrorResponse) {

          if (err.status === 401 || err.status === 403) {
              this._toast.warning("Phiên đăng nhập đã hết hạn.");
              this._authService.removeToken();
              this.redirectToLoginPage();
          }

          if(err.status === 500){
            this._toast.error("Lỗi hệ thống");
            this.redirectToBadRequestPage();
          }
          return throwError(err);
        }
      }),
      finalize(() => {
      })
    );
  }

  redirectToLoginPage() {
    this._router.navigate(['/auth']);
  }

  redirectToBadRequestPage() {
    this._router.navigate(['/bad-request']);
  }
}
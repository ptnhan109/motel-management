import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize, map } from 'rxjs/operators';
import { getToken } from '../common/message';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor(
    private _router: Router
  ) {

  }
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError(err => {
        if (err instanceof HttpErrorResponse) {

          if (err.status === 401 || err.status === 403) {
              this.redirectToLoginPage();
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
}
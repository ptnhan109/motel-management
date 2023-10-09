import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { LOCALSTORAGE } from 'src/app/contants/Storage';
import { AppService } from 'src/app/services/app.service';
import { UserServiceService } from 'src/app/services/user-service.service';
import { ToastService } from 'src/app/theme/shared/components/toast/toast.service';

@Component({
  selector: 'app-authenticate',
  templateUrl: './authenticate.component.html',
  styleUrls: ['./authenticate.component.scss']
})
export class AuthenticateComponent implements OnInit {

  user = {
    password: "123456",
    phone: "0775331777"
  }
  constructor(
    private appService: AppService,
    private toast: ToastrService,
    private router: Router,
    private userService : UserServiceService

  ) { }

  ngOnInit(): void {
    this.isAuthenticated();
  }

  login() {
    if (!this.validate()) {
      return;
    }
    this.appService.authenticate(this.user).subscribe(result => {
      if (result.isSucceeded == true) {
        let token = `Bearer ${result.data.token}`;
        this.userService.setToken(token);
        this.toast.success("Đăng nhập thành công.");
        window.location.href = '/dashboard';

      } else {
        this.toast.error("Tên đăng nhập hoặc mật khẩu không chính xác.")
      }
    }
      ,
      error => {
        console.log(error);
      })
  }

  isAuthenticated(){
    let token = this.userService.getToken();
    console.log(token);
    if(token != null){
      window.location.href = '/dashboard';
    }
  }

  validate() {
    if (this.user.password == undefined || this.user.password == "") {
      this.toast.error("Mật khẩu không được trống");
      return false;
    }
    if (this.user.phone == undefined || this.user.phone == "") {
      this.toast.error("Tên đăng nhập không được để trống");
      return false;
    }

    return true;
  }

}

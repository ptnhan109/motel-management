import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';
import { ToastService } from 'src/app/theme/shared/components/toast/toast.service';

@Component({
  selector: 'app-authenticate',
  templateUrl: './authenticate.component.html',
  styleUrls: ['./authenticate.component.scss']
})
export class AuthenticateComponent implements OnInit {

  user = {
    password: "123456",
    phone:"0775331777"
  }
  constructor(
    private appService: AppService,
    private toast : ToastrService,
    private router : Router

  ) { }

  ngOnInit(): void {
  }

  login(){
    this.appService.authenticate(this.user).subscribe(result =>{
      if(result.isSucceeded == true){
        localStorage.setItem("imoma.token",result.data.token);
        this.toast.success("Đăng nhập thành công.");
        window.location.href='/dashboard';

      }else{
        this.toast.error("Quý khách sai tên đăng nhập hoặc mật khẩu.")
      }
    },
    error =>{
      console.log(error);
    })
  }

}

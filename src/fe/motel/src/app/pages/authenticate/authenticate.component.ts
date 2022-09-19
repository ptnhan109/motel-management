import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-authenticate',
  templateUrl: './authenticate.component.html',
  styleUrls: ['./authenticate.component.scss']
})
export class AuthenticateComponent implements OnInit {

  user = {
    password: "",
    phone:""
  }
  constructor(
    private appService: AppService

  ) { }

  ngOnInit(): void {
  }

  login(){
    this.appService.authenticate(this.user).subscribe(result =>{
      if(result.isSucceeded === true){
        localStorage.setItem("imoma.token",result.data.token);
      }else{
        alert("fail");
      }
    })
  }

}

import { Component, OnInit } from '@angular/core';
import { ToastrModule, ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-service',
  templateUrl: './service.component.html',
  styleUrls: ['./service.component.scss']
})
export class ServiceComponent implements OnInit {

  provides = [];
  provideInsert = {
    name: "",
    type: 0
  }

  provideUpdate = {
    id :"",
    type: 0,
    name: ""
  }
  constructor(
    private _service : AppService,
    private _toast : ToastrService,
  ) { }

  ngOnInit(): void {
    this.getProvides();
  }

  getProvides(){
    this._service.getProvides().subscribe(
      response =>{
        this.provides = response.data;
      }
    )
  }

  addProvide(){
    this._service.addProvide(this.provideInsert).subscribe(
      response =>{
        if(response.isSucceeded == true){
          this._toast.success("Thêm mới dịch vụ thành công");
          this.getProvides();
        }
      }
    )
  }

  removeProvide(id){
    this._service.deleteProvide(id).subscribe(
      response =>{
        if(response.isSucceeded == true){
          this._toast.success("Đã xóa dịch vụ");
          this.getProvides();
        }
      }
    )
  }

  getProvideUpdate(provide){
    this.provideUpdate = provide;
  }

  updateProvide(){
    this._service.updateProvide(this.provideUpdate).subscribe(
      response =>{
        if(response.isSucceeded == true){
          this._toast.success("Cập nhật dịch vụ thành công");
          this.getProvides();
        }
      }
    )
  }

}

import { Component, OnInit } from '@angular/core';
import { ToastrModule, ToastrService } from 'ngx-toastr';
import { FormatCurrency } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';
declare var bootbox:any;
@Component({
  selector: 'app-service',
  templateUrl: './service.component.html',
  styleUrls: ['./service.component.scss']
})
export class ServiceComponent implements OnInit {

  provides = [];
  provideInsert = {
    name: "",
    type: 0,
    defaultPrice: 0
  }

  provideUpdate = {
    id :"",
    type: 0,
    name: "",
    defaultPrice : 0
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
        console.log(this.provides);
      }
    )
  }

  addProvide(){
    if(!this.validateInsert()){
      return false;
    }
    this._service.addProvide(this.provideInsert).subscribe(
      response =>{
        if(response.isSucceeded == true){
          this._toast.success("Thêm mới dịch vụ thành công");
          this.getProvides();
        }
      }
    )
    return true;
  }

  removeProvide(id){
    bootbox.confirm("Bạn chắc chắn muốn xóa dịch vụ này?",(result : boolean) =>{
      if(result){
        this._service.deleteProvide(id).subscribe(
          response =>{
            if(response.isSucceeded == true){
              this._toast.success("Đã xóa dịch vụ");
              this.getProvides();
            }
          },
          error => console.log(error)
        )
      }
    })
    
  }

  getProvideUpdate(provide){
    this.provideUpdate.defaultPrice = provide.defaultPrice;
    this.provideUpdate.id = provide.id;
    this.provideUpdate.name = provide.name;
    this.provideUpdate.type = provide.type;
  }

  updateProvide(){
    if(!this.validateUpdate()){
      return false;
    }
    this._service.updateProvide(this.provideUpdate).subscribe(
      response =>{
        if(response.isSucceeded == true){
          this._toast.success("Cập nhật dịch vụ thành công");
          this.getProvides();
        }
      }
    )

    return true;
  }

  validateInsert(){
    if(this.provideInsert.name == undefined || this.provideInsert.name == ""){
      this._toast.error("Tên dịch vụ không được để trống.");
      return false;
    }

    return true;
  }

  validateUpdate(){
    if(this.provideUpdate.name == undefined || this.provideUpdate.name == ""){
      this._toast.error("Tên dịch vụ không được để trống.");
      return false;
    }

    return true;
  }

}

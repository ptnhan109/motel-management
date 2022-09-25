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
    bootbox.confirm({
      title: "Bạn chắc chắn muốn xóa dịch vụ này?",
      message: "Khi dịch vụ được xóa sẽ mất dữ liệu ở các khu trọ sử dụng dịch vụ",
      buttons: {
          cancel: {
              label: '<i class="fa fa-times"></i> Hủy bỏ'
          },
          confirm: {
              label: '<i class="fa fa-check"></i> Xác nhận'
          }
      },
      callback: function (result) {
          if(result){
            this._service.deleteProvide(id).subscribe(
              response =>{
                if(response.isSucceeded == true){
                  this._toast.success("Đã xóa dịch vụ");
                  this.getProvides();
                }
              }
            )
          }
      }
  });
    
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
  formatCurrency(input){
    return FormatCurrency(input);
  }

}

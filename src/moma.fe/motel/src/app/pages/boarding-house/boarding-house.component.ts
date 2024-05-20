import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';
declare var bootbox: any;

@Component({
  selector: 'app-boarding-house',
  templateUrl: './boarding-house.component.html',
  styleUrls: ['./boarding-house.component.scss']
})
export class BoardingHouseComponent implements OnInit {

  provides = [];
  boardings = [];
  boardingInfo = {
    name: "",
    address: "",
    description: "",
    startDatePayment: 1,
    endDatePayment: 5,
    months: 1,
    services: []
  };
  boardingUpdate = {
    id: "",
    name: "",
    address: "",
    description: "",
    months: 0,
    startDatePayment: 1,
    endDatePayment: 5,
    services: []
  }
  selectedProvides = [];
  constructor(
    private _service: AppService,
    private _toast: ToastrService
  ) {

  }

  ngOnInit(): void {
    this.getBoardings();

    this.getProvides();
  }

  addBoardingHouse() {
    if (!this.validate()) {
      return false;
    }
    this.boardingInfo.services = this.selectedProvides;
    this._service.addBoardingHouse(this.boardingInfo).subscribe(
      response => {
        if (response.isSucceeded == true) {
          this.getBoardings();
          this._toast.success("Thêm mới khu trọ thành công");
        }
      }
    )

    return true;
  }

  getProvides() {
    this._service.getProvides().subscribe(
      response => {
        this.provides = response.data;
      }
    )
  }

  getBoardings() {
    this._service.getBoardings().subscribe(
      response => {
        this.boardings = response.data;
      }
    )
  }

  getBoarding(id) {
    this._service.getBoarding(id).subscribe(
      response => {
        this.boardingUpdate = response.data;
      }
    )
  }

  setSelectProvide(id) {
    let provide = this.provides.find(x => x.id == id);
    let element = {
      serviceId: id,
      price: provide.defaultPrice
    };
    let index = this.selectedProvides.findIndex(x => x.id == id);
    console.log(index);
    if (index > -1) {
      this.selectedProvides.splice(index, 1);
    } else {
      this.selectedProvides.push(element);
    }
  }

  getPlaceHolder(type) {
    switch (type) {
      case 0: {
        return "Số tiền hàng tháng"
      }
      case 1: {
        return "Đơn giá 1 số"
      }
      case 2: {
        return "Đơn giá 1 khách thuê"
      }
      case 3: {
        return "Đơn giá 1 số"
      }
      default: {
        //statements; 
        break;
      }
    }
  }

  removeBoarding(id) {
    bootbox.confirm("Bạn chắc chắn muốn xóa khu trọ này, dữ liệu sau khi xóa sẽ không thể khôi phục?", (result: boolean) => {
      if (result) {
        this._service.deleteBoardingHouse(id).subscribe(
          response => {
            if (response.isSucceeded == true) {
              this._toast.success("Đã khu trọ thành công");
              this.getBoardings();
            }
          },
          error => console.log(error)
        )
      }
    })
  }

  validate() {
    if (this.boardingInfo.name == undefined || this.boardingInfo.name == '' || this.boardingInfo.name == null
      || this.boardingInfo.address == undefined || this.boardingInfo.address == '' || this.boardingInfo.address == null) {
      this._toast.error("Vui lòng điền đầy đủ thông tin.")

      return false;
    }

    return true;
  }





}

import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, RemoveNullable, SetPropertyToNull, toDateFormat } from 'src/app/common/stringFormat';
import { contractType, roomStatus } from 'src/app/contants/roomStatus';
import { AppService } from 'src/app/services/app.service';
import { ToastService } from 'src/app/theme/shared/components/toast/toast.service';
import { saveAs } from 'file-saver'
declare var bootbox: any;
@Component({
  selector: 'app-contracts',
  templateUrl: './contracts.component.html',
  styleUrls: ['./contracts.component.scss']
})
export class ContractsComponent implements OnInit {
  filter = {
    boardingHouseId: null,
    roomId: null
  }

  listFilter = {
    status: null,
    type: null,
    keyword: null,
    pageIndex: 1,
    pageSize: 10
  }

  paging = null;
  pageNumbers = [];
  contracts = [];

  isEnableType = false;

  addContract = {
    name: null,
    customerId: null,
    customerName: null,
    customerPhone: null,
    roomId: null,
    createdDate: null,
    expiredDate: null,
    depositedAmount: null,
    type: 1,
    contractDuration: null,
    terms: []
  }

  boardingId = null;
  boardings = [];
  rooms = [];
  customers = [];

  terms = [];

  constructor(
    private _service: AppService,
    private _toast: ToastrService
  ) { }

  ngOnInit(): void {
    this.getContracts(1);
    this.getMotels();
    this.getRooms();
    this.getCustomers();
  }

  addTerms() {
    this.terms.push({
      type: 0,
      content: ""
    });
  }

  removeTerms(index) {
    this.terms.splice(index, 1);
  }

  saveContract() {
    this.addContract.terms = this.terms;
    this.addContract.roomId = this.filter.roomId;
    if(!this.validate()){
      return false;
    }
    let request = RemoveNullable(this.addContract);
    this._service.addContract(request).subscribe(
      response => {
        if (response.isSucceeded) {
          this._toast.success("Thêm mới hợp đồng thành công.");
          SetPropertyToNull(this.addContract);
          this.addContract.type = 1;
          this.addTerms();
          this.getContracts(1);
        }
      },
      error =>{
        this._toast.error("Đã xảy ra lỗi.");
      }
    )

    return true;
  }


  getMotels() {
    this._service.getBoardings().subscribe(
      response => {
        this.boardings = response.data;
      }
    )
  }

  getRooms() {
    let request = RemoveNullable(this.filter);
    this._service.getAllRooms(request).subscribe(
      response => this.rooms = response.data
    )
  }

  getCustomers() {
    let room = this.rooms.filter(x => x.id == this.filter.roomId)[0];
    if (room != null) {
      if (room.status != roomStatus.hired) {
        if (room.status == roomStatus.deposited) {
          this._toast.warning("Khi tạo đặt cọc mới sẽ xóa đặt cọc trước đó");
        } else {
          this._toast.info("Phòng chưa có khách thuê, chỉ cho phép tạo hợp đồng đặt cọc.");
        }
        this.addContract.type = contractType.deposited;
        this.isEnableType = false;
      } else {
        this.addContract.type = contractType.rent;
        this.isEnableType = false;
      }
    }
    let request = RemoveNullable(this.filter);
    this._service.getAllCustomers(request).subscribe(
      response => this.customers = response.data
    )
  }

  getContracts(page) {
    this.listFilter.pageIndex = page;
    var request = RemoveNullable(this.listFilter);
    this._service.getContracts(request).subscribe(
      response => {
        this.paging = response.data;
        this.contracts = response.data.items;
        this.pageNumbers = [];
        for (let i = 1; i <= this.paging.totalPage; i++) {
          this.pageNumbers.push(i);
        }
      }
    )
  }

  removeContract(id){
    bootbox.confirm("Bạn chắc chắn muốn hợp đồng này?", (result: boolean) => {
      if (result) {
        this._service.deleteContract(id).subscribe(
          response => {
            if (response.isSucceeded == true) {
              this._toast.success("Đã hợp đồng thành công");
              this.getContracts(1);
            }
          },
          error => console.log(error)
        )
      }
    })
  }

  setContractName() {

    if (this.filter.roomId != null) {
      let room = this.rooms.filter(x => x.id == this.filter.roomId)[0];
      let name = room.name;
      let title = this.addContract.type == 0 ? "Hợp đồng đặt cọc phòng " : "Hợp đồng thuê phòng";
      this.addContract.name = `${title} ${name}`;
      this.addContract.customerId = null;
      this.addContract.customerName = null;
      this.addContract.customerPhone = null;
    }
  }

  setCustomerName() {
    if (this.addContract.customerId != null) {
      let customer = this.customers.filter(x => x.id == this.addContract.customerId)[0];
      this.addContract.customerName = customer.name;
      this.addContract.customerPhone = customer.phone;
    }
  }

  downloadContractFile(id, roomName) {
    this._service.downloadContractFile(id).subscribe(
      response => {
        saveAs(response, `HopDongDatCoc_Phong ${roomName}.docx`)
      }
    );
  }

  getRoomStatus(status) {
    switch (status) {
      case roomStatus.available:
        return "Phòng trống";
      case roomStatus.deposited:
        return "Đã đặt cọc";
      case roomStatus.hired:
        return "Đã cho thuê";
      case roomStatus.pending:
        return "Tạm dừng cho thuê"
      default:
        return "";
    }
  }

  formatExpiredDate(date) {
    return toDateFormat(date);
  }

  formatCurrency(value) {
    return FormatCurrency(value);
  }

  formatDuration(value) {
    if (value == null) {
      return "Không thời hạn";
    }
    return `${value} tháng`;
  }

  validate(){
    if(this.addContract.roomId == null || this.addContract.name == '' || this.addContract.name == null){
      this._toast.error("Vui lòng điền đầy đủ thông tin.");
      return false;
    }

    if(this.addContract.customerId == null && this.addContract.type == contractType.rent){
      this._toast.error("Người đại diện không được để trống.");
      return false;
    }

    if((this.addContract.customerName == null || this.addContract.customerName == '') && this.addContract.type == contractType.deposited){
      this._toast.error("Người đặt cọc không được trống.");
      return false;
    }

    if(this.addContract.type == contractType.deposited && this.addContract.expiredDate == null){
      this._toast.error("Hợp đồng đặt cọc cần có thời hạn.");
      return false;
    }

    return true;
  }

}

import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, RemoveNullable, SetPropertyToNull, toDateFormat } from 'src/app/common/stringFormat';
import { contractType, roomStatus } from 'src/app/contants/roomStatus';
import { AppService } from 'src/app/services/app.service';
import { ToastService } from 'src/app/theme/shared/components/toast/toast.service';

@Component({
  selector: 'app-contracts',
  templateUrl: './contracts.component.html',
  styleUrls: ['./contracts.component.scss']
})
export class ContractsComponent implements OnInit {
  filter = {
    boardingHouseId : null,
    roomId : null
  }

  listFilter = {
    status: null,
    type : null,
    keyword: null,
    pageIndex : 1,
    pageSize : 10
  }

  paging = null;
  pageNumbers = [];
  contracts = [];

  isEnableType = false;

  addContract = {
    name : null,
    customerId : null,
    customerName :null,
    customerPhone : null,
    roomId : null,
    createdDate : null,
    expiredDate : null,
    depositedAmount : null,
    type : 1,
    contractDuration: null,
    terms : []
  }

  boardingId = null;
  boardings = [];
  rooms = [];
  customers = [];

  terms = [];

  constructor(
    private _service : AppService,
    private _toast : ToastrService
  ) { }

  ngOnInit(): void {
    this.getContracts(1);
    this.addTerms();
    this.getMotels();
    this.getRooms();
    this.getCustomers();
  }

  addTerms(){
    this.terms.push({
      type: 0,
      content:""
    });
  }

  removeTerms(index){
    this.terms.splice(index,1);
  }

  saveContract(){
    this.addContract.terms = this.terms;
    this.addContract.roomId = this.filter.roomId;
    let request = RemoveNullable(this.addContract);
    this._service.addContract(request).subscribe(
      response => {
        if(response.isSucceeded){
          this._toast.success("Thêm mới hợp đồng thành công.");
          SetPropertyToNull(this.addContract);
          this.addContract.type = 1;
          this.addTerms();
        }
      }
    )
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

  getCustomers(){
    let room = this.rooms.filter(x => x.id == this.filter.roomId)[0];
    if(room != null){
      if(room.status != roomStatus.hired){
        this._toast.info("Phòng chưa có khách thuê, chỉ cho phép tạo hợp đồng đặt cọc.");
        this.addContract.type = contractType.deposited;
        this.isEnableType = false;
      }else{
        this.isEnableType = true;
      }
    }
    let request = RemoveNullable(this.filter);
    this._service.getAllCustomers(request).subscribe(
      response => this.customers = response.data
    )
  }

  getContracts(page){
    this.listFilter.pageIndex = page;
    var request = RemoveNullable(this.listFilter);
    this._service.getContracts(request).subscribe(
      response => {
        this.paging = response.data;
        this.contracts = response.data.items;
        console.log(this.contracts);
        for (let i = 1; i <= this.paging.totalPage; i++) {
          this.pageNumbers.push(i);
        }
      }
    )
  }

  setContractName(){

    if(this.filter.roomId != null){
      let room = this.rooms.filter(x => x.id == this.filter.roomId)[0];
      let name = room.name;
      let title = this.addContract.type == 0 ? "Hợp đồng đặt cọc phòng " : "Hợp đồng thuê phòng";
      this.addContract.name = `${title} ${name}`;
      this.addContract.customerId = null;
      this.addContract.customerName = null;
      this.addContract.customerPhone = null;
    }
  }

  setCustomerName(){
    if(this.addContract.customerId != null){
      let customer = this.customers.filter(x => x.id == this.addContract.customerId)[0];
      this.addContract.customerName = customer.name;
      this.addContract.customerPhone = customer.phone;
    }
  }

  getRoomStatus(status){
    switch(status){
      case roomStatus.available:
        return "Phòng trống";
      case roomStatus.deposited:
        return "Đã đặt cọc";
      case roomStatus.hired:
        return "Đã cho thuê";
      default:
        return "";
    }
  }

  formatExpiredDate(date){
    return toDateFormat(date);
  }

  formatCurrency(value){
    return FormatCurrency(value);
  }

  formatDuration(value){
    if(value == null){
      return "Không thời hạn";
    }
    return `${value} tháng`;
  }

}
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { element } from 'protractor';
import { FormatCurrency, RemoveNullable } from 'src/app/common/stringFormat';
import { paymentStatus } from 'src/app/contants/roomStatus';
import { AppService } from 'src/app/services/app.service';
declare var bootbox: any;

@Component({
  selector: 'app-invoice-single',
  templateUrl: './invoice-single.component.html',
  styleUrls: ['./invoice-single.component.scss']
})
export class InvoiceSingleComponent implements OnInit {

  filter = {
    boardingId: null,
    pageIndex: 1,
    pageSize: 50
  }
  id = null;
  stage = {
    id: null,
    isComplete: false,
    name: "",
    amountPaid: 0,
    totalAmount: 0,
    roomPaid: 0,
    totalRooms: 0,
    roomData: 0
  }
  invoices = [];
  invoiceDetail = {
    id: null,
    subtractDeposited: false,
    invoice: {
      amount: 0,
      boardingName: "",
      id: null,
      isComplete: false,
      name: null,
      paymentStatus: 0
    },
    contract: {
      contractDuration: null,
      createdDate: null,
      customerId: null,
      customerName: null,
      customerPhone: null,
      depositedAmount: 0,
      expiredDate: null,
      id: null,
      name: null,
      roomId: null,
      status: null,
      terms: null,
      type: null,
      advanceAmount: 0
    },
    room: {
      price: 0
    },
    boardingHouse: {
      id: null,
      months: null
    },
    items: []
  }
  others = [];
  constructor(
    private _service: AppService,
    private _route: ActivatedRoute,
    private _toast: ToastrService
  ) { }

  ngOnInit(): void {
    this.getStage();
    this.getRoomsInStage();
    this.onChangeNumber();
  }

  getRoomsInStage() {
    this._route.paramMap.subscribe(
      params => {
        let id = params.get('id');
        this.id = id;
        let request = RemoveNullable(this.filter);
        this._service.getRoomInStagePaging(id, request).subscribe(
          response => {
            this.invoices = response.data.items;
          }
        )
      }
    )
  }

  getStage() {
    this._route.paramMap.subscribe(
      params => {
        let id = params.get('id');
        this._service.getStageById(id).subscribe(
          response => {
            this.stage = response.data;
          }
        )
      }
    )
  }

  getInvoiceRoomById(id) {
    this._service.getInvoiceById(id).subscribe(
      response => {
        this.invoiceDetail = response.data;
        console.log(this.invoiceDetail);
        this.onChangeNumber();
      }
    )
  }

  getProvideType(type) {
    switch (type) {
      case 0:
        return "Thu theo phòng / tháng"
      case 1:
        return "Thu theo số"
      case 2:
        return "Thu theo khách thuê"
      case 3:
        return "Thu theo số lượng"
      default:
        return "Miễn phí"
    }
  }

  onChangeNumber() {
    let totalAmount = 0;
    this.invoiceDetail.items.forEach(
      element => {
        element.amount = (element.newValue - element.lastValue) * element.price;
        totalAmount = totalAmount + element.amount;
      }
    )
    this.others.forEach(
      element => {
        totalAmount += element.price;
      }
    )
    if (!this.invoiceDetail.subtractDeposited) {
      totalAmount += this.invoiceDetail.room.price;
    }

    this.invoiceDetail.invoice.amount = totalAmount;

  }
  changeRoomPrice() {
    if (this.invoiceDetail.subtractDeposited) {
      this.invoiceDetail.invoice.amount -= this.invoiceDetail.room.price;
      this.invoiceDetail.contract.advanceAmount -= this.invoiceDetail.room.price;
    } else {
      this.invoiceDetail.invoice.amount += this.invoiceDetail.room.price;
      this.invoiceDetail.contract.advanceAmount += this.invoiceDetail.room.price;
    }
  }

  addOtherElements() {
    this.others.push({
      name: "",
      price: 0
    });
    this.onChangeNumber();
  }
  removeOther(index) {
    this.others.splice(index, 1);
    this.onChangeNumber();
  }


  getPercent(sub, total) {
    if (total == 0) {
      return 0;
    }
    return Math.round((sub * 100) / total);
  }

  formatCurrency(input) {
    return FormatCurrency(input);
  }

  setRoomPaid(id) {
    this._service.getInvoiceById(id).subscribe(
      response => {
        this.invoiceDetail = response.data;
        let message = `<strong>Phòng ${this.invoiceDetail.invoice.name} </strong> đã thanh toán số tiền <strong> ${this.formatCurrency(this.invoiceDetail.invoice.amount)} đ </strong>. <br/> Khi bạn xác nhận thao tác này sẽ không thể hoàn tác.`;
        bootbox.confirm(message,(result : boolean) =>{
          if(result){
            let request = {
              stageRoomId : id,
              status : paymentStatus.paid
            }
            this._service.setRoomPaymentStatus(this.id,request).subscribe(response =>{
              this._toast.success(`Đã xác nhận thanh toán cho phòng ${this.invoiceDetail.invoice.name}.`);
              this.getRoomsInStage();
            })
          }
        })
      }
    )


  }


  saveInvoice() {
    let stageRoomId = this.invoiceDetail.items[0].stageRoomId;
    this.others.forEach(element => {
      this.invoiceDetail.items.push({
        id: null,
        stageRoomId: stageRoomId,
        provideId: null,
        lastValue: 0,
        newValue: 1,
        price: element.price,
        amount: element.price,
        name: element.name,
        provideType: 0
      });
    });
    console.log(this.invoiceDetail);
    this._service.updateInvoice(this.invoiceDetail).subscribe(
      response => {
        this._toast.success("Cập nhật số liệu thành công");
        this.getRoomsInStage();
      }
    )
  }
}

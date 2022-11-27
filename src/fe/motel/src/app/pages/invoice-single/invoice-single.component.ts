import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FormatCurrency, RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-invoice-single',
  templateUrl: './invoice-single.component.html',
  styleUrls: ['./invoice-single.component.scss']
})
export class InvoiceSingleComponent implements OnInit {

  filter = {
    boardingId : null,
    pageIndex : 1,
    pageSize : 50
  }
  stage = {
    id:null,
    isComplete: false,
    name : "",
    amountPaid : 0,
    totalAmount : 0,
    roomPaid : 0,
    totalRooms : 0,
    roomData : 0
  }
  invoices = [];
  invoiceDetail = {
    invoice : {
      amount : 0,
      boardingName: "",
      id: null,
      isComplete: false,
      name : null,
      paymentStatus: 0
    },
    contract:{
      contractDuration : null,
      createdDate : null,
      customerId: null,
      customerName: null,
      customerPhone : null,
      depositedAmount : 0,
      expiredDate : null,
      id : null,
      name : null,
      roomId : null,
      status : null,
      terms : null,
      type : null
    },
    items : []
  }
  constructor(
    private _service : AppService,
    private _route : ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getStage();
    this.getRoomsInStage();
  }

  getRoomsInStage(){
    this._route.paramMap.subscribe(
      params =>{
        let id = params.get('id');
        let request = RemoveNullable(this.filter);
        this._service.getRoomInStagePaging(id,request).subscribe(
          response =>{
            this.invoices = response.data.items;
            console.log(this.invoices);
          }
        )
      }
    )
  }

  getStage(){
    this._route.paramMap.subscribe(
      params =>{
        let id = params.get('id');
        this._service.getStageById(id).subscribe(
          response =>{
            this.stage = response.data;
            console.log(this.stage);
          }
        )
      }
    )
  }

  getInvoiceRoomById(id){
    this._service.getInvoiceById(id).subscribe(
      response =>{
        this.invoiceDetail = response.data;
        console.log(this.invoiceDetail);
      }
    )
  }



  getPercent(sub, total){
    if(total == 0){
      return 0;
    }
    return Math.round((sub * 100)/total);
  }

  formatCurrency(input){
    return FormatCurrency(input);
  }

}

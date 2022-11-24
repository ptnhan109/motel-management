import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, RemoveNullable, SetPropertyToNull } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-invoices',
  templateUrl: './invoices.component.html',
  styleUrls: ['./invoices.component.scss']
})
export class InvoicesComponent implements OnInit {

  filter = {
    boardingHouseId: null,
    status: 2
  }

  invoiceFilter = {
    keyword : null,
    pageIndex : 1,
    pageSize : 100
  }

  boardings = [];
  stage = {
    name: null,
    code: null,
    stageDate: null,
    rooms : []
  }

  checkAll = false;
  rooms = [];
  selectedRooms = [];
  stages = [];
  constructor(
    private _service: AppService,
    private _toast : ToastrService
  ) { }
  ngOnInit(): void {
    this.onInitCreate();
    this.getMotels();
    this.getRooms();
    this.getStagePaymentPaging();
  }

  onInitCreate() {
    var currentDate = new Date();
    this.stage.name = `Đợt thanh toán tiền tháng ${currentDate.getUTCMonth() + 1} năm ${currentDate.getFullYear()}`;
    this._service.getStageCode().subscribe(
      response => {
        this.stage.code = response.data;
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
    let request = RemoveNullable(this.filter)
    this._service.getAllRooms(request).subscribe(
      response => {
        this.rooms = response.data;
        this.rooms.forEach(room => {
          room.checked = false;
        })
      }
    )
  }

  getStagePaymentPaging(){
    let request = RemoveNullable(this.invoiceFilter);
    this._service.getStagePaging(request).subscribe(
      response =>{
        this.stages = response.data.items;
        console.log(this.stages);
      }
    )
  }

  formatCurrency(input) {
    return FormatCurrency(input);
  }

  selectedAllRoom() {
    this.rooms.forEach(room => {
      this.selectRoom(room.id);
    })
  }
  selectRoom(id) {
    let index = this.selectedRooms.indexOf(id);
    if (index > -1) {
      this.selectedRooms.splice(index, 1);
    } else {
      this.selectedRooms.push(id);
    }
  }

  setSelectedValue(id){
    let index = this.selectedRooms.indexOf(id);
    if(index > -1){
      return true;
    }else{
      return false;
    }
  }



  saveStage(){
    if(!this.validate()){
      return false;
    }
    this.stage.rooms = this.selectedRooms;
    var request = RemoveNullable(this.stage);
    this._service.addStage(request).subscribe(
      response =>{
        this._toast.success("Tạo đợt thanh toán thành công.");
      }
    )
    return true;
  }

  validate(){
    if(this.stage.name == '' || this.stage.name == undefined || this.stage.name == null
    || this.stage.stageDate == null ){
      this._toast.error("Vui lòng điền đầy đủ thông tin");
      return false;
    }
    if(this.selectedRooms.length == 0){
      this._toast.error("Vui lòng chọn phòng trong đợt thanh toán.");
      return false;
    }
    return true;
  }


}

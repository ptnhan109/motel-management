import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';
declare var bootbox: any;

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.scss']
})
export class RoomsComponent implements OnInit {
  pipe = new DatePipe('en-US');


  isSearch = false;
  boardings = [];
  fitments = [];
  selectedFitment = [];
  paging = null;
  pageNumber = [];
  rooms = [];
  filter = {
    startPrice: null,
    endPrice: null,
    boardingHouseId: null,
    status: null,
    keyword: null,
    isSelfContainer: null,
    pageIndex: 1,
    pageSize: 20
  }

  deposit = {
    roomId: null,
    dateStart: null,
    dateEnd: null,
    despositedValue: null,
    note: null,
    name: null,
    phone: null,
    address: null,
    identityNumber: null,
    isCreateContract:null
  }

  roomSelected = {
    name: null,
    id: null
  };

  constructor(
    private _service: AppService,
    private _toast: ToastrService,
  ) { }

  ngOnInit(): void {
    this.getRooms(1);
    this.getMotels();
  }

  showSearch() {
    if (this.isSearch) {
      this.isSearch = false;
    } else {
      this.isSearch = true;
    }
  }

  getMotels() {
    this._service.getBoardings().subscribe(
      response => this.boardings = response.data
    )
  }

  getFitments() {
    this._service.getFitments().subscribe(
      response => {
        this.fitments = response.data;
      }
    )
  }
  setSelectFitment(id) {
    let index = this.selectedFitment.indexOf(id);
    if (index > -1) {
      this.selectedFitment.splice(index, 1);
    } else {
      this.selectedFitment.push(id);
    }
  }

  getRooms(page) {
    this.filter.pageIndex = page;
    this.pageNumber = [];
    let filters = RemoveNullable(this.filter);
    this._service.getRooms(filters).subscribe(
      response => {
        this.paging = response.data;
        this.rooms = response.data.items;
        console.log(this.rooms);
        for (let i = 1; i <= this.paging.totalPage; i++) {
          this.pageNumber.push(i);
        }
      }
    )
  }

  removeRoom(id) {
    bootbox.confirm("Bạn chắc chắn muốn xóa phòng trọ này?", (result: boolean) => {
      if (result) {
        this._service.deleteRoom(id).subscribe(
          response => {
            if (response.isSucceeded == true) {
              this._toast.success("Xóa phòng trọ thành công.");
              this.getRooms(1);
            }
          },
          error => console.log(error)
        )
      }
    })
  }

  saveDeposit() {
    this.deposit.roomId = this.roomSelected.id;
    console.log(this.deposit);
    this._service.addDeposit(this.deposit).subscribe(
      response => {
        if (response.isSucceeded) {
          this.getRooms(1);
          this._toast.success("Đã đặt cọc phòng.");
        }
      }
    )
  }

  deleteRoomDeposit() {
    let id = this.roomSelected.id;
    this._service.deleteDeposit(id).subscribe(
      response => {
        if (response.isSucceeded) {
          this.getRooms(1);
          this._toast.success("Đã hủy cọc phòng thành công.");
        }
      }
    )
  }

  getRoomDeposit() {
    let id = this.roomSelected.id;
    this._service.getRoomDeposit(id).subscribe(
      response => {
        this.deposit = response.data;
        this.deposit.dateStart = this.pipe.transform(response.data.dateStart,'yyyy-MM-dd');
        this.deposit.dateEnd = this.pipe.transform(response.data.dateEnd,'yyyy-MM-dd');
        console.log(this.deposit);
      }
    )
  }

  formatCurrency(input) {
    return FormatCurrency(input);
  }

  formatStatus(status) {
    switch (status) {
      case 0:
        return 'Phòng trống';
      case 1:
        return 'Đã có đặt cọc';
      case 2:
        return 'Đã cho thuê';
      default:
        return '';
    }
  }

  formatStatusDisplay(status) {
    switch (status) {
      case 0:
        return 'badge badge-success';
      case 1:
        return 'badge badge-warning';
      case 2:
        return 'badge badge-secondary';
      default:
        return '';
    }
  }

  setRoomName(room) {
    this.roomSelected.name = room.name;
    this.roomSelected.id = room.id;
  }

}

import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, RemoveNullable, SetPropertyToNull } from 'src/app/common/stringFormat';
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
    pageSize: 15
  }

  deposit = {
    name: null,
    customerName: null,
    customerPhone: null,
    roomId: null,
    createdDate: null,
    expiredDate: null,
    type: 0,
    status: 0,
    depositedAmount: 0
  }

  roomSelected = {
    name: null,
    id: null,
    display: null
  };

  constructor(
    private _service: AppService,
    private _toast: ToastrService,
    private _route: ActivatedRoute
  ) { }

  ngOnInit(): void {

    this.Init();
  }

  Init() {
    this._route.paramMap.subscribe(
      parms => {
        this.getMotels();
        this.filter.boardingHouseId = parms.get('boardingId');
        this.getRooms(1);
      }
    )

  }

  showSearch() {
    if (this.isSearch) {
      this.isSearch = false;

    } else {
      this.isSearch = true;
    }
  }

  closeSearch() {
    this.isSearch = false;
    SetPropertyToNull(this.filter);
    this.filter.pageIndex = 1;
    this.filter.pageSize = 15;
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
    if (this.validateDeposit()) {
      console.log(this.deposit);
      let request = RemoveNullable(this.deposit);
      this._service.addContract(request).subscribe(
        response => {
          if (response.isSucceeded) {
            this._toast.success("Phòng đã được đặt cọc thành công.");
            SetPropertyToNull(this.deposit);
          }
        },
        error => {
          this._toast.error("Đã xảy ra lỗi.");
        }
      )
      return true;
    }

    return false;
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
    // let id = this.roomSelected.id;
    // this._service.getRoomDeposit(id).subscribe(
    //   response => {
    //     this.deposit = response.data;
    //     this.deposit.dateStart = this.pipe.transform(response.data.dateStart, 'yyyy-MM-dd');
    //     this.deposit.dateEnd = this.pipe.transform(response.data.dateEnd, 'yyyy-MM-dd');
    //     console.log(this.deposit);
    //   }
    // )
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
    if (room.description !== null && room.description !== '') {
      this.roomSelected.display = `${room.name} - ${room.description}`;
    } else {
      this.roomSelected.display = room.name;
    }
    this.deposit.name = `Hợp đồng đặt cọc phòng ${room.name}`;
    this.deposit.roomId = room.id;
  }

  validateDeposit() {
    if (this.deposit.name == '' || this.deposit.name == undefined || this.deposit.name == null
      || this.deposit.customerName == '' || this.deposit.customerName == undefined || this.deposit.customerName == null
      || this.deposit.createdDate == null
      || this.deposit.depositedAmount == null || this.deposit.depositedAmount == undefined
    ) {
      this._toast.error("Vui lòng điền đẩy đủ thông tin.");
      return false;
    }
    return true;
  }

}

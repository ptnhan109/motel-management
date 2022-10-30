import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.scss']
})
export class RoomsComponent implements OnInit {
  isSearch = false;
  boardings = [];
  fitments = [];
  selectedFitment = [];
  paging = null;
  pageNumber = [];
  rooms = [];
  filter = {
    startPrice: null,
    endPrice :null,
    boardingHouseId: null,
    status: null,
    keyword: null,
    pageIndex: 1,
    pageSize: 20
  }

  constructor(
    private _service : AppService,
    private _toast : ToastrService,
  ) { }

  ngOnInit(): void {
    this.getRooms();
    this.getMotels();
  }

  showSearch(){
    if(this.isSearch){
      this.isSearch = false;
    }else{
      this.isSearch = true;
    }
  }

  getMotels(){
    this._service.getBoardings().subscribe(
      response => this.boardings = response.data
    )
  }

  getFitments(){
    this._service.getFitments().subscribe(
      response => {
        this.fitments = response.data;
      }
    )
  }
  setSelectFitment(id){
    let index = this.selectedFitment.indexOf(id);
    if(index > -1){
      this.selectedFitment.splice(index,1);
    }else{
      this.selectedFitment.push(id);
    }
  }

  getRooms(){
    this._service.getRooms(this.filter).subscribe(
      response => {
        this.paging = response.data;
        this.rooms = response.data.items;
        console.log(this.paging);
        for(let i = 1; i <= this.paging.totalPage; i++){
          this.pageNumber.push(i);
        }
      }
    )
  }
  formatCurrency(input){
    return FormatCurrency(input);
  }

  formatStatus(status){
    switch(status){
      case 0:
        return 'Phòng trống';
      case 1:
        return 'Đã có cọc';
      case 2:
        return 'Đã cho thuê';
      default:
        return '';
    }
  }

  formatStatusDisplay(status){
    switch(status){
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

}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { param } from 'jquery';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';
declare var bootbox: any;

@Component({
  selector: 'app-room-single',
  templateUrl: './room-single.component.html',
  styleUrls: ['./room-single.component.scss']
})
export class RoomSingleComponent implements OnInit {

  header = 'Thêm mới'
  action = 'Thêm mới phòng trọ'

  boardings = [];
  fitments = [];
  selectedFitment = [];
  isSelfContainer = true;
  roomImages = [];
  isContinue = false;
  room = {
    id: null,
    boardingHouseId: null,
    name: null,
    price: null,
    floor: null,
    maxHuman: null,
    description: null,
    status: 0,
    location: null,
    isSelfContainer: this.isSelfContainer
  }
  constructor(
    private _service: AppService,
    private _toast: ToastrService,
    private _route: Router,
    private _router : ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getMotels();
    this.getFitments();
    this.initAction();
  }

  initAction(){
    this._router.paramMap.subscribe(
      params =>{
        let id = params.get('id');
        if(id != null){
          this.room.id = id;
          this.action = 'Cập nhật nhà trọ';
          this.header = 'Cập nhật';


        }
      }
    )
  }

  getRoomById(id){
    
  }

  getMotels() {
    this._service.getBoardings().subscribe(
      response => { this.boardings = response.data; this.room.boardingHouseId = this.boardings[0].id; }
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
    console.log(this.selectedFitment);
  }

  selectedFiles(files: FileList) {
    for (let i = 0; i < files.length; i++) {
      this.roomImages.push(files[i]);
    }
  }
  SaveRoom() {
    if(!this.validate()){
      return;
    }
    var form = new FormData();
    // form.append("Id",this.room.id);
    form.append("BoardingHouseId", this.room.boardingHouseId);
    form.append("Name", this.room.name);
    form.append("Price", this.room.price);
    form.append("Floor", this.room.floor);
    form.append("MaxHuman", this.room.maxHuman);
    form.append("Description", this.room.description);
    form.append("Status", JSON.stringify(this.room.status));
    form.append("Location", this.room.location);
    form.append("IsSelfContainer", JSON.stringify(this.isSelfContainer));
    let fitmentIds = this.fitments.map(element => element.id);
    for (let i = 0; i < fitmentIds.length; i++) {
      form.append("Fitments[]", fitmentIds[i]);
    }

    for (let i = 0; i < this.roomImages.length; i++) {
      form.append('RoomImages[]', this.roomImages[i]);
    }

    this._service.createRoom(form, this.room.boardingHouseId).subscribe(
      response => {
        if (response.isSucceeded) {
          if (this.room.id == null) {
            this._toast.success("Thêm mới phòng trọ thành công.");
            if (!this.isContinue) {
              this._route.navigateByUrl('/room');
            }
          } else {
            this._toast.success("Cập nhật phòng trọ thành công.");
          }
        }
      }
    )
  }

  validate() {
    if (this.room.name == undefined || this.room.name == '' || this.room.name == null
      || this.room.price == undefined || this.room.price == null
    ) {
      this._toast.error("Vui lòng điền đầy đủ thông tin");
      return false;
    }

    return true;
  }

  goBack() {
    this._route.navigateByUrl('/room');
  }

}

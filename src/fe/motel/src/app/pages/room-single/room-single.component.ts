import { Component, OnInit } from '@angular/core';
import { param } from 'jquery';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-room-single',
  templateUrl: './room-single.component.html',
  styleUrls: ['./room-single.component.scss']
})
export class RoomSingleComponent implements OnInit {

  boardings = [];
  fitments = [];
  selectedFitment = [];
  isSelfContainer = true;
  roomImages = [];
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
  ) { }

  ngOnInit(): void {
    this.getMotels();
    this.getFitments();

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
    var form = new FormData();
    form.append("Id",this.room.id);
    form.append("boardingHouseId",this.room.boardingHouseId);
    form.append("name",this.room.name);
    form.append("price",this.room.price);
    form.append("floor",this.room.floor);
    form.append("maxHuman",this.room.maxHuman);
    form.append("description",this.room.description);
    // form.append("status",JSON.stringify(this.room.status));
    form.append("location",this.room.location);
    // form.append("isSelfContainer",JSON.stringify(this.isSelfContainer));
    // form.append("fitments",JSON.stringify(this.fitments));
    // form.append("roomImages",JSON.stringify(this.roomImages));
    // for(let i = 0; i <this.roomImages.length; i++){
    //   form.append('roomImages[]',this.roomImages[i],this.roomImages[i].name);
    // }
    // console.log(form);
    
    this._service.createRoom(form,this.room.boardingHouseId).subscribe(
      response => console.log(response)
    )
  }

}

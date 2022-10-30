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
    // form.append("Id",this.room.id);
    form.append("BoardingHouseId",this.room.boardingHouseId);
    form.append("Name",this.room.name);
    form.append("Price",this.room.price);
    form.append("Floor",this.room.floor);
    form.append("MaxHuman",this.room.maxHuman);
    form.append("Description",this.room.description);
    form.append("Status",JSON.stringify(this.room.status));
    form.append("Location",this.room.location);
    form.append("IsSelfContainer",JSON.stringify(this.isSelfContainer));
    let fitmentIds = this.fitments.map(element => element.id);
    for(let i = 0; i < fitmentIds.length; i++){
      form.append("Fitments[]",fitmentIds[i]);
    }

    for(let i = 0; i <this.roomImages.length; i++){
      form.append('RoomImages[]',this.roomImages[i]);
    }
    
    this._service.createRoom(form,this.room.boardingHouseId).subscribe(
      response => console.log(response)
    )
  }

}

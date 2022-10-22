import { Component, OnInit } from '@angular/core';
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
  roomImages =[];
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
    console.log(this.selectedFitment);
  }

  selectedFiles(files : FileList) {
    for(let i = 0; i < files.length; i++){
      this.roomImages.push(files[i]);
    }
  }
  SaveRoom() {
    console.log(this.roomImages);
  }

}

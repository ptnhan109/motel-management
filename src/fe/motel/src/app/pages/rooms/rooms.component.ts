import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
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
  

  constructor(
    private _service : AppService,
    private _toast : ToastrService,
  ) { }

  ngOnInit(): void {
    this.getMotels();
    this.getFitments();
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
    console.log(this.selectedFitment);
  }

}

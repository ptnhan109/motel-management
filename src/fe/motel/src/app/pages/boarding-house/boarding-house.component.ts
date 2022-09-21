import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-boarding-house',
  templateUrl: './boarding-house.component.html',
  styleUrls: ['./boarding-house.component.scss']
})
export class BoardingHouseComponent implements OnInit {

  provides = [];
  selectedProvides = [];
  constructor(
    private _service : AppService
  ) { }

  ngOnInit(): void {
    this.getProvides();
  }

  addBoardingHouse(){
    console.log(this.selectedProvides);
  }

  getProvides(){
    this._service.getProvides().subscribe(
      response =>{
        this.provides = response.data;
      }
    )
  }

  setSelectProvide(id){
    let index = this.selectedProvides.indexOf(id);
    if( index > -1){
      this.selectedProvides.splice(index,1);
    }else{
      this.selectedProvides.push(id);
    }
  }



}

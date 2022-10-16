import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.scss']
})
export class RoomsComponent implements OnInit {
  isSearch = false;
  constructor() { }

  ngOnInit(): void {
  }

  showSearch(){
    if(this.isSearch){
      this.isSearch = false;
    }else{
      this.isSearch = true;
    }
  }

}

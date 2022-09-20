import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-service',
  templateUrl: './service.component.html',
  styleUrls: ['./service.component.scss']
})
export class ServiceComponent implements OnInit {

  provides = [];
  constructor(
    private _service : AppService
  ) { }

  ngOnInit(): void {
    this.getProvides();
  }

  getProvides(){
    this._service.getProvides().subscribe(
      response =>{
        this.provides = response.data;
        console.log(this.provides);
      }
    )
  }

}

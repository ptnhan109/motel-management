import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-boarding-house-single',
  templateUrl: './boarding-house-single.component.html',
  styleUrls: ['./boarding-house-single.component.scss']
})
export class BoardingHouseSingleComponent implements OnInit {

  id = '';
  boarding = {
    id :"",
    name :"",
    address :"",
    description:"",
    months: 0,
    startDatePayment: 1,
    endDatePayment: 5,
    services : []
  }
  constructor(
    private _service : AppService,
    private _route : ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.id = this._route.snapshot.paramMap.get('id');
    this.getBoarding();
  }

  getBoarding(){
    this._service.getBoarding(this.id).subscribe(
      response =>{
        if(response.isSucceeded){
          this.boarding = response.data;
          console.log(this.boarding);
        }
      }
    )
  }


}

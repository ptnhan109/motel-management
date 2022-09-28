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
  };
  provides = [];
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
          this.getServices();
        }
      }
    )
  }

  getServices(){
    this._service.getProvides().subscribe(
      response =>{
        this.provides = response.data;
        this.fillProvide();
      }
    )
  }

  fillProvide(){
    this.provides.forEach(e =>{
      let provide = this.boarding.services.find(c => c.provideId == e.id);
      if(provide == null){
        e.checked = false;
      }else{
        e.checked = true;
        e.defaultPrice = provide.price;
      }
    });
    console.log(this.provides);
  }


}

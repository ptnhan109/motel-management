import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
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
    private _route : ActivatedRoute,
    private _toast : ToastrService
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
  }

  updateBoardingHouse(){
    if(!this.validate()){
      return false;
    }
    this.boarding.services = this.provides.filter(c => c.checked == true);
    let services = [];
    this.boarding.services.forEach((service) => {
      let add = {
        boardingHouseId : this.id,
        serviceId: service.id,
        price: service.defaultPrice
      }
      services.push(add)
    })
    let request = {
      id : this.boarding.id,
      name : this.boarding.name,
      address: this.boarding.address,
      description: this.boarding.description,
      months : this.boarding.months,
      startDatePayment: this.boarding.startDatePayment,
      endDatePayment: this.boarding.endDatePayment,
      services: services
    }
    this._service.updateBoardingHouse(request).subscribe(
      response =>{
        console.log(response)
        this._toast.success("Cập nhật khu trọ thành công.")
      },
      error =>{
        this._toast.error("Cập nhật thất bại");
        console.log(error);
      }
    )
  }

  validate(){
    if (this.boarding.name == undefined || this.boarding.name == '' || this.boarding.name == null
      || this.boarding.address == undefined || this.boarding.address == '' || this.boarding.address == null) {
        this._toast.error("Vui lòng điền đầy đủ thông tin.")

        return false;
    }

    return true;
  }


}

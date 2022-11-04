import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.scss']
})
export class CustomersComponent implements OnInit {

  boardings = [];
  rooms = [];
  addVehicles = [];
  filter = {
    boardingHouseId : null,
    roomId : null,
    keyword: null
  }
  addCustomerRequest = {
    name: "",
    phone :"",
    birthDay: null,
    identificationCitizen:"",
    idFactory:"",
    address :"",
    email :"",
    career : 0,
    gender : 1,
    roomId: null,
    avatarPath :null,
    fontIdentityPath:null,
    backIdentityPath: null,
    vehicles: []
  }
  constructor(
    private _service : AppService,
    private _toast : ToastrService
  ) { }

  ngOnInit(): void {
    this.getMotels();
    this.getRooms();
    this.addVehicleElements();
  }
  addVehicleElements(){
    this.addVehicles.push({
      type:1,
      licensePlate:"",
      color:""
    });
  }
  removeVehicles(index){
    this.addVehicles.splice(index,1);
  }

  getMotels() {
    this._service.getBoardings().subscribe(
      response => this.boardings = response.data
    )
  }

  getRooms(){
    console.log(this.filter);
    let request = RemoveNullable(this.filter);
    this._service.getAllRooms(request).subscribe(
      response => this.rooms = response.data
    )
  }
  uploadFontIdentity(files: FileList){
    let file = files.item(0);
    let form = new FormData();
    form.append("file",file);
    this._service.uploadFile(form,2).subscribe(
      response => this.addCustomerRequest.fontIdentityPath = response.data
    );
  }
  uploadBackIdentity(files: FileList){
    let file = files.item(0);
    let form = new FormData();
    form.append("file",file);
    this._service.uploadFile(form,2).subscribe(
      response => this.addCustomerRequest.backIdentityPath = response.data
    );
  }
  uploadAvatarIdentity(files: FileList){
    let file = files.item(0);
    let form = new FormData();
    form.append("file",file);
    this._service.uploadFile(form,2).subscribe(
      response => this.addCustomerRequest.avatarPath = response.data
    );
  }
  SaveCustomer(){
    this.addCustomerRequest.roomId = this.filter.roomId;
    this.addCustomerRequest.vehicles = this.addVehicles;
    console.log(this.addCustomerRequest);
    this._service.addCustomer(this.addCustomerRequest).subscribe(
      response => {
        if(response.isSucceeded){
          this._toast.success("Thêm mới khách thuê thành công.")
        }
      }
    )
  }

}

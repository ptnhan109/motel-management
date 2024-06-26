import { ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, GetAvatar, GetCareer, RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';
import { UiModalComponent } from 'src/app/theme/shared/components/modal/ui-modal/ui-modal.component';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.scss']
})

export class CustomersComponent implements OnInit {
  @ViewChild('createCustomer') private createCustomer: UiModalComponent;
  message = 'Customer page is loading :)'
  boardings = [];
  rooms = [];
  addVehicles = [];
  paging = null;
  customers = [];
  filter = {
    boardingHouseId: null,
    roomId: null,
    keyword: null,
    pageIndex: 1,
    pageSize: 20
  }
  addCustomerRequest = {
    name: "",
    phone: "",
    birthDay: null,
    identificationCitizen: "",
    idFactory: "",
    address: "",
    email: "",
    career: 0,
    gender: 1,
    roomId: null,
    avatarPath: null,
    fontIdentityPath: null,
    backIdentityPath: null,
    vehicles: []
  }
  pageNumbers= [];
  constructor(
    private _changeDetec: ChangeDetectorRef,
    private _service: AppService,
    private _toast: ToastrService,
    private _route: ActivatedRoute
  ) { }

  ngOnInit(): void {

    this.getMotels();
    this.getRooms();
    this.addVehicleElements();
    this.getCustomer(1);
  }
  addVehicleElements() {
    this.addVehicles.push({
      type: 1,
      licensePlate: "",
      color: ""
    });
  }
  removeVehicles(index) {
    this.addVehicles.splice(index, 1);
  }

  getMotels() {
    this._service.getBoardings().subscribe(
      response => this.boardings = response.data
    )
  }

  getRooms() {
    let request = RemoveNullable(this.filter);
    this._service.getAllRooms(request).subscribe(
      response => this.rooms = response.data
    )
  }

  getCustomer(page) {
    this.filter.pageIndex = page;
    this.pageNumbers = [];
    let filter = RemoveNullable(this.filter);
    this._service.getCustomers(filter).subscribe(
      response => {
        this.paging = response.data;
        this.customers = response.data.items;
        for (let i = 1; i <= this.paging.totalPage; i++) {
          this.pageNumbers.push(i);
        }
      }
    )
  }

  getCareer(career){
    return GetCareer(career);
  }

  getAvatar(avatar){
    return GetAvatar(avatar);
  }

  currenyFormat(price){
    return FormatCurrency(price);
  }


  uploadFontIdentity(files: FileList) {
    let file = files.item(0);
    let form = new FormData();
    form.append("file", file);
    this._service.uploadFile(form, 2).subscribe(
      response => this.addCustomerRequest.fontIdentityPath = response.data
    );
  }
  uploadBackIdentity(files: FileList) {
    let file = files.item(0);
    let form = new FormData();
    form.append("file", file);
    this._service.uploadFile(form, 2).subscribe(
      response => this.addCustomerRequest.backIdentityPath = response.data
    );
  }
  uploadAvatarIdentity(files: FileList) {
    let file = files.item(0);
    let form = new FormData();
    form.append("file", file);
    this._service.uploadFile(form, 2).subscribe(
      response => this.addCustomerRequest.avatarPath = response.data
    );
  }
  saveCustomer() {
    if(!this.validateAddCustomer()){
      return false;
    }
    this.addCustomerRequest.roomId = this.filter.roomId;
    this.addCustomerRequest.vehicles = this.addVehicles;
    this._service.addCustomer(this.addCustomerRequest).subscribe(
      response => {
        if (response.isSucceeded) {
          this._toast.success("Thêm mới khách thuê thành công.");
          this.getCustomer(1);
          return true;
        }
      }
    )
  }

  validateAddCustomer(){
    if(this.addCustomerRequest.name == undefined || this.addCustomerRequest.name == null || this.addCustomerRequest.name == ''
    || this.addCustomerRequest.roomId == null
    || this.addCustomerRequest.phone == null || this.addCustomerRequest.phone == ''
    || this.addCustomerRequest.identificationCitizen == null || this.addCustomerRequest.identificationCitizen == ''
    ){
      this._toast.error("Vui lòng điền đẩy đủ thông tin cần thiết.");
      return false;
      
    }
    return true;
  }

}

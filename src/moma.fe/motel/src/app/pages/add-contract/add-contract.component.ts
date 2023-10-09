import { Component, getModuleFactory, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ContractType } from 'src/app/common/contractType';
import { RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-add-contract',
  templateUrl: './add-contract.component.html',
  styleUrls: ['./add-contract.component.scss']
})
export class AddContractComponent implements OnInit {

  step = "SelectRoom";
  image = {
    front : "../../../assets/defaults/identity-image-front.jpg",
    back : "../../../assets/defaults/identity-image-back.jpg",
    avatar :"../../../assets/defaults/avatar.jpg"
  }
  boardings = [];
  rooms = [];
  filter = {
    boardingHouseId: null,
    roomId: null,
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

  addContract = {
    name: null,
    customerId: null,
    customerName: null,
    customerPhone: null,
    roomId: null,
    createdDate: null,
    expiredDate: null,
    depositedAmount: 0,
    type: 1,
    contractDuration: null,
    terms: [],
    advanceAmount: 0
  }

  room = {
    name: null,
    id: null
  }
  constructor(
    private _service: AppService,
    private _route: ActivatedRoute,
    private _toast: ToastrService,
    private _router: Router
  ) { }

  ngOnInit(): void {
    this.getMotels();
    this.getRooms();
    this.getContract();
    this.addVehicleElements();
  }

  changeStep(step) {
    if (step == 'AddContract') {
      if (!this.validateCustomer()) {
        return false;
      }
    }
    this.step = step;
    return true;
  }

  getMotels() {
    this._service.getBoardings().subscribe(
      response => this.boardings = response.data
    )
  }

  getRooms() {
    let request = RemoveNullable(this.filter);
    this._service.getAllRooms(request).subscribe(
      response => {
        this.rooms = response.data;
        this._route.paramMap.subscribe(
          param => {
            this.filter.roomId = param.get('roomId');
            let room = response.data.filter(c => c.id == this.filter.roomId)[0];
            this.room.id = room.id;
            this.room.name = room.name;

            this.addContract.name = `Hợp đồng thuê phòng ${this.room.name}`;
            if (room == null) {
              this.filter.roomId = null;
            } else {
              this.filter.boardingHouseId = response.data.filter(c => c.id == this.filter.roomId)[0].boardingHouseId;
              this.addCustomerRequest.roomId = room.id;
            }
          }
        )
      }
    )
  }

  getContract() {
    this._route.paramMap.subscribe(
      param => {
        let roomId = param.get('roomId');
        this._service.getContractByRoomId(roomId, ContractType.Deposited).subscribe(
          response => {
            this.addCustomerRequest.name = response.data.customerName;
            this.addCustomerRequest.phone = response.data.customerPhone;

            this.addContract.customerName = response.data.customerName;
            this.addContract.customerPhone = response.data.customerPhone;

            this.addContract.depositedAmount = response.data.depositedAmount;

          }
        )
      }
    )
  }

  uploadFontIdentity(files: FileList) {
    let file = files.item(0);
    let form = new FormData();
    form.append("file", file);
    this._service.uploadFile(form, 2).subscribe(
      response => {
        this.addCustomerRequest.fontIdentityPath = response.data;
        this.image.front = `${environment.apiServer}/files${response.data}`;
      }
    );
  }
  uploadBackIdentity(files: FileList) {
    let file = files.item(0);
    let form = new FormData();
    form.append("file", file);
    this._service.uploadFile(form, 2).subscribe(
      response => {
        this.addCustomerRequest.backIdentityPath = response.data;
        this.image.back = `${environment.apiServer}/files${response.data}`;
      }
    );
  }
  uploadAvatarIdentity(files: FileList) {
    let file = files.item(0);
    let form = new FormData();
    form.append("file", file);
    this._service.uploadFile(form, 2).subscribe(
      response => {
        this.addCustomerRequest.avatarPath = response.data;
        this.image.avatar = `${environment.apiServer}/files${response.data}`;
      }
    );
  }

  addVehicleElements() {
    this.addCustomerRequest.vehicles.push({
      type: 1,
      licensePlate: "",
      color: ""
    });
  }
  removeVehicles(index) {
    this.addCustomerRequest.vehicles.splice(index, 1);
  }

  addTerms() {
    this.addContract.terms.push({
      type: 0,
      content: ""
    });
  }

  validateCustomer() {
    if (this.addCustomerRequest.name == undefined || this.addCustomerRequest.name == null || this.addCustomerRequest.name == ''
      || this.addCustomerRequest.roomId == null
      || this.addCustomerRequest.phone == null || this.addCustomerRequest.phone == ''
      || this.addCustomerRequest.identificationCitizen == null || this.addCustomerRequest.identificationCitizen == ''
    ) {
      this._toast.error("Vui lòng điền đẩy đủ thông tin khách thuê.");
      return false;
    }

    return true;
  }


  saveContract() {
    this.addCustomerRequest.roomId = this.filter.roomId;
    this.addContract.roomId = this.filter.roomId;
    this._service.addCustomer(this.addCustomerRequest).subscribe(
      customer => {
        this.addContract.customerId = customer.data;
        this._service.addContract(this.addContract).subscribe(
          contract => {
            this._toast.success(`"Đã tạo hợp đồng cho phòng ${this.room.name}"`);
            this._router.navigate(['/contracts']);
          }
        )
      }
    )

  }


}

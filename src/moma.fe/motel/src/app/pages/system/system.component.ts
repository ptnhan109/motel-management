import { Component, OnInit } from '@angular/core';
import * as moment from 'moment';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';
import { UserServiceService } from 'src/app/services/user-service.service';
declare var bootbox: any;
@Component({
  selector: 'app-system',
  templateUrl: './system.component.html',
  styleUrls: ['./system.component.scss']
})
export class SystemComponent implements OnInit {

  info: any = {
    name: null,
    phone: null,
    dayOfBirth: null,
    city: 'Hà Nội',
    identityNumber: null,
    identityProvider: null,
    identityDate: null,
    address: null,
    email: null,
    accountBankNumber: null,
    bankName: null
  }
  constructor(
    private _service: AppService,
    private _toast : ToastrService
  ) { }

  ngOnInit(): void {
    this._service.getOwnerInfo().subscribe((response: any) => {
      this.info.name = response.data.name;
      this.info.phone = response.data.phone;
      this.info.dayOfBirth = moment(response.data.dayOfBirth).format("YYYY-MM-DD");
      this.info.identityNumber = response.data.identityNumber;
      this.info.identityProvider = response.data.identityProvider;
      this.info.identityDate = response.data.identityDate;
      this.info.address = response.data.address;
      this.info.email = response.data.email;
      this.info.accountBankNumber = response.data.accountBankNumber;
      this.info.bankName = response.data.bankName;
    })
  }

  submit() {
    this._service.updateOwnerInfo(this.info).subscribe((response : any) =>{
      this._toast.success("Cập nhật thông tin thành công");
    })
  }

}

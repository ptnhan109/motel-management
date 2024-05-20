import { ChangeDetectorRef, Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { FormatCurrency, GetAvatar, GetCareer, RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';
import { UiModalComponent } from 'src/app/theme/shared/components/modal/ui-modal/ui-modal.component';

@Component({
  selector: 'app-vehicle',
  templateUrl: './vehicle.component.html',
  styleUrls: ['./vehicle.component.scss']
})
export class VehicleComponent implements OnInit {
  @ViewChild('createCustomer') private createCustomer: UiModalComponent;
  message = 'Customer page is loading :)'
  boardings = [];
  rooms = [];
  addVehicles = [];
  paging = null;
  customers = [];
  filter = {
    keyword: "",
    pageIndex: 1,
    pageSize: 20
  }
  pageNumbers = [];
  constructor(
    private _changeDetec: ChangeDetectorRef,
    private _service: AppService,
    private _toast: ToastrService,
    private _route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.GetVehicles();
  }

  GetVehicles() {
    this._service.getVehicles(this.filter).subscribe((response) => {
      this.paging = response.data;
      this.customers = response.data.items;
      for (let i = 1; i <= this.paging.totalPage; i++) {
        this.pageNumbers.push(i);
      }
    })
  }

}

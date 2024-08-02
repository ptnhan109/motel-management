import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';
import { FormatCurrency } from 'src/app/common/stringFormat';
import * as moment from 'moment';

@Component({
  selector: 'app-report-revenue',
  templateUrl: './report-revenue.component.html',
  styleUrls: ['./report-revenue.component.scss']
})
export class ReportRevenueComponent implements OnInit {

  filter: any = {
    fromDate: new Date(),
    toDate: new Date(),
    boardingHouseId: null
  }

  items : any[] = [];
  months: any[] = [];
  totals : any[] = [];

  boardings: any[] = [];
  constructor(
    private _service: AppService,
    private _toast: ToastrService,
  ) { }

  ngOnInit(): void {
    this.filter.fromDate = moment().startOf('year').format('YYYY-MM-DD');
    this.filter.toDate = moment().endOf('year').format('YYYY-MM-DD');
    this.GetAllBoardingHouse();
    this.GetReport();
  }

  GetAllBoardingHouse() {
    this._service.getBoardings().subscribe(
      response => this.boardings = response.data
    )
  }

  GetReport() {
    this.filter.fromDate = moment(this.filter.fromDate).format('YYYY-MM-DD');
    this.filter.toDate = moment(this.filter.toDate).format('YYYY-MM-DD');
    this._service.getReportRevenue(this.filter).subscribe(
      response => {
        if (response.isSucceeded) {
          this.items = response.data.items;
          this.months = response.data.months;
          this.totals = response.data.totals;
        }
      }
    )
  }



}

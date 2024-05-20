import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})

export class DashboardComponent implements OnInit {

  summary =
    {
      totalRooms: 6,
      totalRoomHired: 2,
      totalCustomer: 0,
      totalRoomDeposited: 2,
      totalDepositedAmount: 0,
      totalRoomPending: 1
    }
  constructor(
    private _service: AppService
  ) { }

  ngOnInit(): void {
    this.Init();
  }

  Init() {
    this._service.getDashboardSummary().subscribe((response) => {
      if (response.isSucceeded) {
        this.summary = response.data;
      }
    })
  }

}

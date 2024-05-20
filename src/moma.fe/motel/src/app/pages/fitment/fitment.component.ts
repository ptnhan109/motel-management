import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppService } from 'src/app/services/app.service';
import { FormatCurrency } from 'src/app/common/stringFormat';

@Component({
  selector: 'app-fitment',
  templateUrl: './fitment.component.html',
  styleUrls: ['./fitment.component.scss']
})
export class FitmentComponent implements OnInit {

  fitments = [];
  fitment: any = {
    id: null,
    name: null,
    recoupPrice: 0,
    description: null
  }
  constructor(
    private _service: AppService,
    private _toast: ToastrService,
  ) { }

  ngOnInit(): void {
    this.getFitments();
  }

  getFitments() {
    this._service.getFitments().subscribe(
      response => {
        this.fitments = response.data;
      }
    )
  }

  getFitmentUpdate(fitment) {
    this.fitment.id = fitment.id;
    this.fitment.name = fitment.name;

    this.fitment.recoupPrice = fitment.recoupPrice;
    this.fitment.description = null;
    this.fitment.type = fitment.type;
  }

  formatCurrency(input) {
    return FormatCurrency(input);
  }

}

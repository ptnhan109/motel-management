import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RemoveNullable } from 'src/app/common/stringFormat';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-invoice-single',
  templateUrl: './invoice-single.component.html',
  styleUrls: ['./invoice-single.component.scss']
})
export class InvoiceSingleComponent implements OnInit {

  filter = {
    boardingId : null,
    pageIndex : 1,
    pageSize : 50
  }
  invoices = [];
  constructor(
    private _service : AppService,
    private _route : ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getRoomsInStage();
  }

  getRoomsInStage(){
    this._route.paramMap.subscribe(
      params =>{
        let id = params.get('id');
        let request = RemoveNullable(this.filter);
        this._service.getRoomInStagePaging(id,request).subscribe(
          response =>{
            console.log(response);
            this.invoices = response.data.items;
          }
        )
      }
    )
  }

}

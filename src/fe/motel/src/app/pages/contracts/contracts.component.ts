import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contracts',
  templateUrl: './contracts.component.html',
  styleUrls: ['./contracts.component.scss']
})
export class ContractsComponent implements OnInit {

  addContract = {
    name : null,
    customerId : null,
    customerName :null,
    customerPhone : null,
    roomId : null,
    createdDate : null,
    expiredDate : null,
    depositedAmount : null,
    type : null,
    contractDuration: null,
    terms : []
  }

  constructor() { }

  ngOnInit(): void {
  }

  saveContract(){
    console.log(this.addContract);
  }

}

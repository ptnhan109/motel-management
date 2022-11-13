import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-contract',
  templateUrl: './add-contract.component.html',
  styleUrls: ['./add-contract.component.scss']
})
export class AddContractComponent implements OnInit {

  step = "SelectRoom";
  constructor() { }

  ngOnInit(): void {
  }

  changeStep(step){
    this.step = step;
  }

}

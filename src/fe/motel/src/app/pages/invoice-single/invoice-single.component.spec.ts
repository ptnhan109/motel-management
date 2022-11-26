import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InvoiceSingleComponent } from './invoice-single.component';

describe('InvoiceSingleComponent', () => {
  let component: InvoiceSingleComponent;
  let fixture: ComponentFixture<InvoiceSingleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InvoiceSingleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InvoiceSingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

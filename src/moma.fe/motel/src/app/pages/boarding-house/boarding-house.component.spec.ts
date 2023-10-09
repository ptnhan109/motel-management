import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardingHouseComponent } from './boarding-house.component';

describe('BoardingHouseComponent', () => {
  let component: BoardingHouseComponent;
  let fixture: ComponentFixture<BoardingHouseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BoardingHouseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BoardingHouseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

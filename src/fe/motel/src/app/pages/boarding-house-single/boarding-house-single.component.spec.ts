import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardingHouseSingleComponent } from './boarding-house-single.component';

describe('BoardingHouseSingleComponent', () => {
  let component: BoardingHouseSingleComponent;
  let fixture: ComponentFixture<BoardingHouseSingleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BoardingHouseSingleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BoardingHouseSingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

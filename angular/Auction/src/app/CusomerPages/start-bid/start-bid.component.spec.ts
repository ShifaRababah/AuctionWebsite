import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartBidComponent } from './start-bid.component';

describe('StartBidComponent', () => {
  let component: StartBidComponent;
  let fixture: ComponentFixture<StartBidComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StartBidComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StartBidComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

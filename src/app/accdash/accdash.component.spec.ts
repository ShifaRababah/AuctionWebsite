import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccdashComponent } from './accdash.component';

describe('AccdashComponent', () => {
  let component: AccdashComponent;
  let fixture: ComponentFixture<AccdashComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AccdashComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AccdashComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

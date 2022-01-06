import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SidebarcustComponent } from './sidebarcust.component';

describe('SidebarcustComponent', () => {
  let component: SidebarcustComponent;
  let fixture: ComponentFixture<SidebarcustComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SidebarcustComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SidebarcustComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

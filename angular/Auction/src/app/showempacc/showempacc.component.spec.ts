import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowempaccComponent } from './showempacc.component';

describe('ShowempaccComponent', () => {
  let component: ShowempaccComponent;
  let fixture: ComponentFixture<ShowempaccComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowempaccComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowempaccComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

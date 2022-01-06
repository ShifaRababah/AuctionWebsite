import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowcusaccComponent } from './showcusacc.component';

describe('ShowcusaccComponent', () => {
  let component: ShowcusaccComponent;
  let fixture: ComponentFixture<ShowcusaccComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowcusaccComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowcusaccComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

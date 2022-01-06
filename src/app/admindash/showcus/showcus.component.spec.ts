import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowcusComponent } from './showcus.component';

describe('ShowcusComponent', () => {
  let component: ShowcusComponent;
  let fixture: ComponentFixture<ShowcusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowcusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowcusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

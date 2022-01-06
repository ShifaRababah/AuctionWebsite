import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccsidebarComponent } from './accsidebar.component';

describe('AccsidebarComponent', () => {
  let component: AccsidebarComponent;
  let fixture: ComponentFixture<AccsidebarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AccsidebarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AccsidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

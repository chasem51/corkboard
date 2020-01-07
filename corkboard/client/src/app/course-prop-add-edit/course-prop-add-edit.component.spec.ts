import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CoursePropAddEditComponent } from './course-prop-add-edit.component';

describe('CoursePropAddEditComponent', () => {
  let component: CoursePropAddEditComponent;
  let fixture: ComponentFixture<CoursePropAddEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CoursePropAddEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CoursePropAddEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

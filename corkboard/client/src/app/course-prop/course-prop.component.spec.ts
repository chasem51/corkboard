import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CoursePropComponent } from './course-prop.component';

describe('CoursePropComponent', () => {
  let component: CoursePropComponent;
  let fixture: ComponentFixture<CoursePropComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CoursePropComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CoursePropComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

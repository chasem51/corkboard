import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CoursePropsComponent } from './course-props.component';

describe('CoursePropsComponent', () => {
  let component: CoursePropsComponent;
  let fixture: ComponentFixture<CoursePropsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CoursePropsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CoursePropsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

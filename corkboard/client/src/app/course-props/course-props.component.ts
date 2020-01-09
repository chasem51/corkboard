import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { CoursePropService } from '../services/course-prop.service';
import { CourseProp } from '../models/courseprop';

@Component({
  selector: 'app-course-props',
  templateUrl: './course-props.component.html',
  styleUrls: ['./course-props.component.scss']
})
export class CoursePropsComponent implements OnInit {
  courseProps$: Observable<CourseProp[]>;

  constructor(private  coursePropService: CoursePropService) {
  }

  ngOnInit() {
    this.loadCourseProps();
  }

  loadCourseProps() {
    this.courseProps$ = this.coursePropService.getCourseProps();
  }

  delete(postId) {
    const ans = confirm('Do you want to delete Course with id: ' + postId);
    if (ans) {
      this.coursePropService.deleteCourseProp(postId).subscribe((data) => {
        this.loadCourseProps();
      });
    }
  }
}

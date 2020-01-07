import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CoursePropsComponent } from './course-props/course-props.component';
import { CoursePropComponent } from './course-prop/course-prop.component';
import { CoursePropAddEditComponent } from './course-prop-add-edit/course-prop-add-edit.component';

const routes: Routes = [
  { path: '', component: CoursePropsComponent, pathMatch: 'full' },
  { path: 'CourseProp/:id', component: CoursePropComponent },
  { path: 'add', component: CoursePropAddEditComponent },
  { path: 'CourseProp/edit/:id', component: CoursePropAddEditComponent },
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

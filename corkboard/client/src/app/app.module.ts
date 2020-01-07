import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoursePropsComponent } from './course-props/course-props.component';
import { CoursePropComponent } from './course-prop/course-prop.component';
import { CoursePropAddEditComponent } from './course-prop-add-edit/course-prop-add-edit.component';
import { CoursePropService } from './services/course-prop.service';

@NgModule({
  declarations: [
    AppComponent,
    CoursePropsComponent,
    CoursePropComponent,
    CoursePropAddEditComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [
    CoursePropService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

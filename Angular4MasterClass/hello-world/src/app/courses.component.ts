import { Component } from '@angular/core';
import { CourseService } from './course.service'

@Component({
  selector: 'courses', // uses css selectors, also supports extra html tag
  template: `
    <h2>{{title}}</h2>
    <ul>
      <li *ngFor='let course of courses'> {{this.course}} </li>
    </ul>
    `
})
export class CoursesComponent {
  title = 'List of Courses';
  courses;

  constructor(service: CourseService) {
    this.courses = service.getCourses();
  }
}

import { Component } from '@angular/core';

@Component({
  selector: 'courses', // uses css selectors, also supports extra html tag
  template: '<h2>{{title}}</h2>' // brackets except valid JS as well
})
export class CoursesComponent {
  title = 'List of Courses';
}

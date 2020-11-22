import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';
import { Student } from './student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {
  student:Student=new Student();
  students:Array<Student>=[];
  constructor(studentService:StudentService) { 
    studentService.getStudent().subscribe(t=>{this.students=t},error=>{console.log(error);
    }
    )
  }

  ngOnInit(): void {
  }

}

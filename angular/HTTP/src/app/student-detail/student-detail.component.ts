import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';
import { Student } from './studentDetail';

@Component({
  selector: 'app-student-detail',
  templateUrl: './student-detail.component.html',
  styleUrls: ['./student-detail.component.css']
})
export class StudentDetailComponent implements OnInit {

  studentDetail:Student=new Student();
  students:Array<Student>=[];
  constructor(studentService:StudentService) { 
    studentService.getStudent().subscribe(t=>{this.students=t},error=>{console.log(error);
    }
    )
  }
  ngOnInit(): void {
  }

}

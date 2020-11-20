import { Component, OnInit } from '@angular/core';
import { StudentsService } from '../students.service';

@Component({
  selector: 'app-students-detail',
  templateUrl: './students-detail.component.html',
  styleUrls: ['./students-detail.component.css']
})
export class StudentsDetailComponent implements OnInit {

  public students:any=[];
  constructor(private _studentsService:StudentsService) { }

  ngOnInit(): void {
    this.students=this._studentsService.getStudents();
  }

}

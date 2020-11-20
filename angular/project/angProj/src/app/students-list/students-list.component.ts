import { Component, OnInit } from '@angular/core';
import{StudentsService} from '../students.service';
@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css']
})
export class StudentsListComponent implements OnInit {
  public students:any=[];

  constructor(private _studentsService : StudentsService) { }

  ngOnInit() {
    this.students=this._studentsService.getStudents();
  }

}

import { Injectable } from '@angular/core';
// import { from } from 'rxjs';
import{HttpClient} from '@angular/common/http';
import { Student } from './student/student';
@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpClient:HttpClient) {
   }
   getStudent(){
     return this.httpClient.get<Array<Student>>('http://localhost:3000/students')
   }
}
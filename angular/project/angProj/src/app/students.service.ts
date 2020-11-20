import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  constructor() { }
  getStudents(){
    return ([
      
      {"id":1,"name":"A","age":20},
      {"id":2,"name":"B","age":21},
      {"id":3,"name":"C","age":22},
      {"id":4,"name":"D","age":23},
    ]);
  }
}

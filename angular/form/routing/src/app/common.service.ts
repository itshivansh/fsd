import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CommonService {

  constructor(private _http:HttpClient) { }
  createUser(user: object){
    console.log("user created");
    return this._http.post("http://localhost:3000/users",user,{headers:new HttpHeaders({
      'Content-Type':'application/json'
    })
  });
  }
  getAllUser(){}
  updateUser(){}
  deleteUser(){}
}

import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  data:any;
  constructor() { }

  ngOnInit(): void {
  }
   Register(regForm:NgForm){
    console.log(regForm.value);
     this.data=regForm.value;
   }

}

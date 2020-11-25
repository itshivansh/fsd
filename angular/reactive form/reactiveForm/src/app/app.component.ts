import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'reactiveForm';
  // email=new FormControl('');
  // updateEmail(){
  //   this.email.setValue('test@testdomain.com')
  // }
  userprofileForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    age: new FormControl(''),
    email:new FormControl(''),
  });

  onSubmit(){
    console.warn(this.userprofileForm.value);
    console.log(this.userprofileForm.controls['firstName'].value);
  }
}

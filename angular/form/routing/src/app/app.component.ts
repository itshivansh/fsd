import { Component } from '@angular/core';
import { Subscriber } from 'rxjs';
import { CommonService } from './common.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'routing';

  constructor(private commonService:CommonService){}
  addUser(formObj:object){
    console.log(formObj)
    this.commonService.createUser(formObj).subscribe((res)=>{
      console.log("User added")},error=>{(console.log(error));
      
    })
  }
}

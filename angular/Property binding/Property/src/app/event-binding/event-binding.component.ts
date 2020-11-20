import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-event-binding',
  templateUrl: './event-binding.component.html',
  styleUrls: ['./event-binding.component.css']
})
export class EventBindingComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  message:string="";
  onAddCart(){
   this.message="Added to cart";
  }
  // onInputClick(event){
  //   console.log(event.target.value);
  // }
}

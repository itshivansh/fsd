import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-component',
  templateUrl: './component.component.html',
  styleUrls: ['./component.component.css']
})
export class ComponentComponent implements OnInit {
  public greet = "Welcome";
  public myId="testId";
  public isDisabled="true";
  constructor() { }

  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  //selector: '.app-check',
  selector: '[app-check]',
  templateUrl: './check.component.html',
  //template:`Welcome {{name}}`,
  styleUrls: ['./check.component.css']
})
export class CheckComponent implements OnInit {
public name = "user";
  constructor() { }

  ngOnInit(): void {
  }

}

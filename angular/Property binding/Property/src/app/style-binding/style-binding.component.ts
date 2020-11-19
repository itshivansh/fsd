import { Component, OnInit } from '@angular/core';
import { bindCallback } from 'rxjs';

@Component({
  selector: 'app-style-binding',
  templateUrl: './style-binding.component.html',
  styleUrls: ['./style-binding.component.css']
})
export class StyleBindingComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  myStyle={
    'background':'whitesmoke',
    'margin-top':'100px',
    'margin-bottom':'100px',
    'color':'red'

  }
}

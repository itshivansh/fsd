import { Component, OnInit } from '@angular/core';
import { CommonService } from '../common.service';

@Component({
  selector: 'app-list-restaurent',
  templateUrl: './list-restaurent.component.html',
  styleUrls: ['./list-restaurent.component.css']
})
export class ListRestaurentComponent implements OnInit {
public collection:any;
  constructor(private commonService:CommonService) { }

  ngOnInit(): void {
    this.commonService.getRestoList().subscribe((res)=>{
      this.collection=res;
      console.log(this.collection);
    });
  }

}

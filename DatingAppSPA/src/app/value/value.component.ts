import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.scss']
})
export class ValueComponent implements OnInit {
values:any='';
  constructor(private httpClient:HttpClient) { }

  ngOnInit() {
    this.getValue();
  }
  getValue()
  {
    this.httpClient.get("http://localhost:5005/api/value").subscribe(response=>{
      this.values=response;
    },error=>{
      console.log(error);
    })
  }
}

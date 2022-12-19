import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebarcust',
  templateUrl: './sidebarcust.component.html',
  styleUrls: ['./sidebarcust.component.css']
})
export class SidebarcustComponent implements OnInit {

  constructor( private myRouter: Router) { }
  clearStorage() {
    localStorage.clear();
    window.location.reload();
    this.myRouter.navigate([''])
   

  }

  ngOnInit(): void {
  }

}

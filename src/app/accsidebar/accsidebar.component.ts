import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-accsidebar',
  templateUrl: './accsidebar.component.html',
  styleUrls: ['./accsidebar.component.css']
})
export class AccsidebarComponent implements OnInit {

  constructor( private myRouter: Router) { }
  clearStorage() {
    localStorage.clear();
    window.location.reload();

    this.myRouter.navigate([''])
   
   

  }

  ngOnInit(): void {
  }

}

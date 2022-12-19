import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  isLogged: boolean = false
  isLogout: boolean = false
  constructor(private myRouter: Router) {

    if (localStorage.getItem('userData') != null) {
      this.isLogged = true;
    }
    
    if (localStorage.getItem('userData') == null) {
      this.isLogout = true;
    }

  }

  ngOnInit(): void {
  }

  clearStorage() {
    localStorage.clear();
    window.location.reload();
    this.myRouter.navigate([''])
 
  
  

  }
  
}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import jwtDecode from 'jwt-decode';
import { AuthService } from 'src/app/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginform: FormGroup | any
  UserData: any
  token1: any
  constructor(private router: Router, private auth: AuthService) {
    this.loginform = new FormGroup(
      {
        Email: new FormControl('', [Validators.required]),
        password: new FormControl('', [Validators.required])


      }

    )

  }

  ngOnInit(): void {
  }

  showlogin() {
    this.UserData = this.auth.GetUserByEmail(this.loginform.value)
    this.auth.validtoken(this.loginform.value)
    this.token1 = jwtDecode(this.auth.token)
    console.log(this.token1)
    console.log(this.token1.role)

    localStorage.setItem('userData', this.UserData)
    localStorage.setItem('Tokenid', this.token1.role)


    switch (this.token1.role) {
      case "1":
        {
          this.router.navigate(['Admin'])
          break;
        }
      case "2":
        {
          this.router.navigate(['Accountant'])
          break;
        }
      case "4":
        {
          this.router.navigate([''])
          break;
        }



    }
  }

}
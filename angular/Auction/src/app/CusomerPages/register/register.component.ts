import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeserviceService } from 'src/app/homeservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  createuser: FormGroup | any;
  constructor(public home: HomeserviceService, private fb: FormBuilder) {

    this.createuser = this.fb.group({

      Name: new FormControl(null, Validators.required),

      Email: new FormControl(null, [Validators.required, Validators.email]),
      Password: new FormControl(null, [Validators.required]),
      PhoneNumber: new FormControl(null, [Validators.required, Validators.minLength(8)])
      // Password: new FormControl(null, [Validators.required, Validators.pattern('^[+][(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]$')]),




    })
  }

  ngOnInit(): void {
  }

  createuser1() {
    this.home.createuser(this.createuser.value);
    window.location.reload()
  }

}
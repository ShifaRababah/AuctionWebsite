import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AdminserviceService } from 'src/app/adminservice.service';

@Component({
  selector: 'app-addemp',
  templateUrl: './addemp.component.html',
  styleUrls: ['./addemp.component.css']
})
export class AddempComponent implements OnInit {

  createemp: FormGroup | any;
  constructor(public adS: AdminserviceService, private fb1: FormBuilder , private toast:ToastrService) {

    this.createemp = this.fb1.group({

      Name: new FormControl(''),
      Email: new FormControl(''),
      PhoneNumber: new FormControl(''),
      Salary: new FormControl(''),
      Position: new FormControl(''),
      Password: new FormControl(''),
      RoleId: new FormControl('')





    })
  }

  ngOnInit(): void {
  }
  createemp1() {
    this.adS.createemp(this.createemp.value);
    window.location.reload()
    this.toast.success("Add Employee Succesfully") 
,(err:any)=>{
this.toast.error("Add Employee Failed")
  }
  window.location.reload()
  }

}

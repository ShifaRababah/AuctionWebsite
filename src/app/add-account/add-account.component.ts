import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AdminserviceService } from '../adminservice.service';

@Component({
  selector: 'app-add-account',
  templateUrl: './add-account.component.html',
  styleUrls: ['./add-account.component.css']
})
export class AddAccountComponent implements OnInit {
  emailList: any
  selectedUser: any

  createAccount: FormGroup | any;
  constructor(public ad: AdminserviceService, private fb: FormBuilder, private toast: ToastrService) {
    ad.getallemp().subscribe((data: any) => {
      this.emailList = data;
      console.log(this.emailList)



    })



    this.createAccount = this.fb.group({

      Value: new FormControl(null, [Validators.required]),

      Description: new FormControl(null, Validators.required),
      Date: new FormControl(null, [Validators.required]),




    })



  }



  ngOnInit(): void {
  }

  createAccount1() {
    let x = this.createAccount.value;
    let selectUserint = parseInt(this.selectedUser);
    x.userId = selectUserint;
    this.ad.createAccount(x)
    console.log(this.selectedUser)




  }


}


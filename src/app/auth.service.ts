import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  token: string | any
  constructor(private httpclient: HttpClient, private toast: ToastrService) {
  }


  validtoken(form: any) {
    const headerDict = {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    };
    const requestOptions = {
      headers: new HttpHeaders(headerDict),
    };
    return this.httpclient.post('https://localhost:44326/api/JWT/JWT1', form, requestOptions).subscribe((res) => {
      this.token = res
      console.log(this.token)
      this.toast.success("Login Succesfully")
    }, (error: any) => { this.toast.error("Login Failed") })








  }
  GetUserByEmail(form: any) {

    this.httpclient.post('https://localhost:44326/api/Customer/GetUserByEmail1', form).subscribe((data: any) => {


      localStorage.setItem('userId', data[0].userId)
    })
  }

  getAllCategories() {
    return this.httpclient.get('https://localhost:44326/api/Category')

  }
}

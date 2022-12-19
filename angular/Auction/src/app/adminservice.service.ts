import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AdminserviceService {

  constructor(private http: HttpClient, private toast: ToastrService) {
  }
  data: any = [{}]

  data2: any = [{}]
  data3: any = [{}]


  getallCustomer() {
    this.http.get('https://localhost:44326/api/Customer/showCustomer').subscribe((Response: any) => { this.data = Response })

  }

  getallemp() {
    return this.http.get('https://localhost:44326/api/Employee/showEmp')

  }

  createemp(form: FormGroup) {
    const headerDict = {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    };
    const requestOptions = {
      headers: new HttpHeaders(headerDict),
    };
    this.http.post('https://localhost:44326/api/Employee/AddNewEmployee', form, requestOptions).subscribe((res) => { console.log("yes") })

  }


  getCountCust() {

    return this.http.get('https://localhost:44326/api/Customer/CountCustomer')
  }


  getCountEmp() {

    return this.http.get('https://localhost:44326/api/Employee/CountEmp')
  }

  getCountOrd() {

    return this.http.get('https://localhost:44326/api/Employee/Countord')
  }



  getallAccount() {
    this.http.get('https://localhost:44326/api/Account/showAccount').subscribe((Response: any) => { this.data2 = Response })

  }

  createAccount(form: FormGroup) {
    const headerDict = {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    };
    const requestOptions = {
      headers: new HttpHeaders(headerDict),
    };
    return this.http.post('https://localhost:44326/api/Account/CreateAccount', form, requestOptions).subscribe((res) => {
      this.data2 = res
      this.toast.success("Sent Succesfully")
      console.log(this.data2)
    }, (error: any) => { this.toast.error("Send Failed") })


  }

  GetAllOrder() {
    this.http.get('https://localhost:44326/api/Employee/GetAllOrder').subscribe((Response: any) => { this.data3 = Response })

  }

  ProfitsByDate(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Employee/ProfitsByDate', form)


  }

}

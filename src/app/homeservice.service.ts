import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EmailValidator, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
 

@Injectable({
  providedIn: 'root'
})
export class HomeserviceService {

  constructor(private httpclient:HttpClient ,private toast:ToastrService) { }
  data:any = [{}]

createuser(form:FormGroup)
{
  const headerDict = {
    'Content-Type': 'application/json',
    Accept: 'application/json',
  };
  const requestOptions = {
    headers: new HttpHeaders(headerDict),
  };
  this.httpclient.post('https://localhost:44326/api/Customer/RegisterCustomer',form,requestOptions).subscribe((res)=>{this.data=res
console.log(this.data)
this.toast.success("Registered Succesfully") 
},(err:any)=>{
this.toast.error("Registered Failed")
  })
}

}


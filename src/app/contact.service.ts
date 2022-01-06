import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  constructor(private httpclient:HttpClient ,private toast:ToastrService) { }
  data:any = [{}]

  createContact(form:FormGroup)
  {
    const headerDict = {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    };
    const requestOptions = {
      headers: new HttpHeaders(headerDict),
    };
   return this.httpclient.post('https://localhost:44326/api/Testimonial/CreateTestimonial',form,requestOptions).subscribe((res)=>{this.data=res
  this.toast.success("Sent Succesfully") 
    },(error:any)=>{this.toast.error("Send Failed")})
  
  
    }
  
  
  GetAllTestimonial() {
    console.log(this.httpclient.get('https://localhost:44326/api/Testimonial').subscribe((Response:any)=>{this.data=Response}))
    console.log(this.data)
    return this.httpclient.get('https://localhost:44326/api/Testimonial').subscribe((Response:any)=>{this.data=Response})
      }
  }
  

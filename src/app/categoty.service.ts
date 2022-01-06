import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategotyService {

  constructor(public http:HttpClient) { }

  data:any = [{}]
  
  GetAllCategory() {
    console.log(this.http.get('https://localhost:44326/api/Category').subscribe((Response:any)=>{this.data=Response}))
    console.log(this.data)
    return this.http.get('https://localhost:44326/api/Category').subscribe((Response:any)=>{this.data=Response})
      }
}

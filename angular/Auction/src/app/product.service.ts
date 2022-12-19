import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(public http: HttpClient, private toast: ToastrService) { }

  data: any = [{}]
  title: any = [{}]
  productid: any = [{}]
  id: any


  GetAllProduct() {

    return this.http.get('https://localhost:44326/api/Product')
  }



  createproduct11(form: FormGroup) {
    const headerDict = {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    };
    const requestOptions = {
      headers: new HttpHeaders(headerDict),
    };
    this.http.post('https://localhost:44326/api/Product/CreateProduct', form, requestOptions).subscribe((res) => {
      this.data = res

      this.toast.success("Ad posted Successfully!")
    }, (error: any) => { this.toast.error("Ad posted Failed!") })


  }

  getAllCategories() {
    return this.http.get('https://localhost:44326/api/Category')

  }




  uplodImage(file: FormData) {
    return this.http.post('https://localhost:44326/api/Product/uploadImage', file, { responseType: 'text' });

  }


  SearchForProduct(Title: string) {

    console.log(Title)
    const headerDict = {
      'Content-Type': 'application/json',
      'Accept': 'application/json'
    }
    const requestOptions = {
      headers: new HttpHeaders(headerDict),
    };

    this.http.post('https://localhost:44326/api/Product/SearchForProduct', { Title: Title }, requestOptions).subscribe((res) => { this.title = res })

    console.log(this.title)
  }


  getCountproduct() {

    return this.http.get('https://localhost:44326/api/Product/Countproduct')
  }


  listofsearch(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Product/SearchForProduct', form)


  }


  ResultProductById(form: FormGroup) {

    return this.http.post('https://localhost:44326/api/Product/GetProductById', form)

  }

  UpdateAuctionAndInsertCart(form: FormGroup) {

    return this.http.put('https://localhost:44326/api/Auction/UpdateAuction', form)

  }

  GetProductUserId(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Product/GetProductUserId', form)
  }
  ApprovalSell(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Product/ApprovalSell', form)
  }

  GetCartByUserId(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Product/GetCartByUserId', form)
  }

  getallBankbyuserid(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Bank/getallBankbyuserid', form)
  }

  updateBalance(form: FormGroup) {
    return this.http.put('https://localhost:44326/api/Bank/updateBalance', form)



  }
  GetOrderbyUserID(form: FormGroup) {
    return this.http.post('https://localhost:44326/api/Product/GetOrderbyUserID', form)
  }


}


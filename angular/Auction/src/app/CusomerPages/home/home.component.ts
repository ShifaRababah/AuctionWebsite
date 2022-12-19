import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CategotyService } from 'src/app/categoty.service';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements OnInit {

  isLogged: boolean = false;
  isSold: boolean = false;
  ProductList: any
  searchform: FormGroup | any
  listofproSearch: any
  constructor(http: HttpClient, public Pro: ProductService, public cat: CategotyService) {

    if (localStorage.getItem('userData') != null) {
      this.isLogged = true;
    }

    this.Pro.GetAllProduct().subscribe((data: any) => {

      this.ProductList = data;
      data.forEach((x: any) => {
        console.warn(x);

      });
    })
    this.searchform = new FormGroup(
      {
        Title: new FormControl('', [Validators.required])



      }

    )



    this.cat.GetAllCategory()



  }

 
  searchnow() {
    //this.listofproSearch = 
    this.Pro.listofsearch(this.searchform.value).subscribe((data: any) => {

      this.listofproSearch = data;
      console.log(this.listofproSearch)

    })



  }



  ngOnInit(): void {
  }

}
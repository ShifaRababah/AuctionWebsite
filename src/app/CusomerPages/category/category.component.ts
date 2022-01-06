import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CategotyService } from 'src/app/categoty.service';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  ProductList: any
  constructor(http: HttpClient, public Pro: ProductService, public cat: CategotyService) {

    this.Pro.GetAllProduct().subscribe((data: any) => {
      this.ProductList = data;
      data.forEach((x: any) => {
        console.warn(x);

      });
    })
    this.cat.GetAllCategory()
  }
  

  ngOnInit(): void {
  }

}

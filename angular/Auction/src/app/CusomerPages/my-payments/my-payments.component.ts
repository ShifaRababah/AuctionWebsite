import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-my-payments',
  templateUrl: './my-payments.component.html',
  styleUrls: ['./my-payments.component.css']
})
export class MyPaymentsComponent implements OnInit {
  idUserform: FormGroup | any
  finalform: FormGroup | any
  prouser: any | null
  allproforUser: any | null


  constructor(private router: Router, private fb: FormBuilder,
    private productService: ProductService) {
    this.idUserform = this.fb.group({

    })
    this.finalform = this.fb.group({

    })


    this.prouser = localStorage.getItem('userId');
    let prouserint = parseInt(this.prouser)
    console.log(this.prouser)
    let x = this.idUserform.value
    x.userid = prouserint
    this.productService.GetCartByUserId(x).subscribe((data: any) => {
      this.allproforUser = data;
      console.log(this.allproforUser)



    })






  }

  finalstep(i: any) {
console.log(i)
    let productID = this.allproforUser[i].productId
    let Total = this.allproforUser[i].price
    let profit = Total * 0.8;
    let x1 = this.idUserform.value
    x1.productId = productID
    x1.total = Total;
    x1.profits = profit;
    this.productService.ApprovalSell(x1).subscribe((data: any) => {

      console.log("true")
window.location.reload()
    })

  }

  ngOnInit(): void {
  }

}
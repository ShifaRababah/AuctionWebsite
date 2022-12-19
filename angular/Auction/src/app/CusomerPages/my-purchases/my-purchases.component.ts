import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-my-purchases',
  templateUrl: './my-purchases.component.html',
  styleUrls: ['./my-purchases.component.css']
})
export class MyPurchasesComponent implements OnInit {
  sellform: FormGroup | any
  currentuser: any | null
  allOrderForUser: any | null

  constructor(private router: Router, private fb: FormBuilder,
    private productService: ProductService) {
    this.sellform = this.fb.group({

    })
    this.currentuser = localStorage.getItem('userId');
    let curruserint = parseInt(this.currentuser)
    let x = this.sellform.value
    x.userid = curruserint
    this.productService.GetOrderbyUserID(x).subscribe((data: any) => {
      this.allOrderForUser = data;
      console.log(this.allOrderForUser)



    })




  }

  ngOnInit(): void {
  }

}

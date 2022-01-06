import { Xliff2 } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-my-ads',
  templateUrl: './my-ads.component.html',
  styleUrls: ['./my-ads.component.css']
})
export class MyAdsComponent implements OnInit {
  idUserform: FormGroup | any
  finalform: FormGroup | any
  prouser: any | null
  allproforUser: any | null
  updatebb: any
  bankUser: FormGroup | any
  Bankinfo: any | null
  updatebalance: any
  balancform: FormGroup | any


  constructor(private router: Router, private fb: FormBuilder,
    private productService: ProductService, private toast: ToastrService) {



    this.idUserform = this.fb.group({

    })
    this.finalform = this.fb.group({

    })
    this.bankUser = this.fb.group({

    })
    this.balancform = this.fb.group({

    })


    this.prouser = localStorage.getItem('userId');
    let prouserint = parseInt(this.prouser)
    console.log(this.prouser)
    let x = this.idUserform.value
    x.userid = prouserint
    this.productService.GetProductUserId(x).subscribe((data: any) => {
      this.allproforUser = data;
      console.log(this.allproforUser)





    })
    let useridint1 = parseInt(this.prouser)







  }

  finalstep(i: any, b: any) {





    console.log(i)
    console.log(b);

    console.log(this.allproforUser[i].userId)


    console.log(this.Bankinfo)

    let productID = this.allproforUser[i].productId
    let Total = this.allproforUser[i].price
    let UserIdToOrder = this.allproforUser[i].userId
    let Title = this.allproforUser[i].title;
    let Image = this.allproforUser[i].image;

    let profit = Total * (1 - 0.88);
    let x1 = this.idUserform.value
    x1.productId = productID
    x1.total = Total;
    x1.profits = profit;
    x1.userId = UserIdToOrder;
    x1.title = Title;
    x1.image = Image;
    console.log(x1.userid);
    this.productService.ApprovalSell(x1).subscribe((data: any) => {

      console.log("true")
      let xbank = this.bankUser.value
      xbank.userid = this.allproforUser[i].userId
      this.productService.getallBankbyuserid(xbank).subscribe((data: any) => {

        this.Bankinfo = data;
        console.log(data);




        this.updatebalance = this.Bankinfo[0].balance - b;

        console.log(this.updatebalance)

        let xx = this.balancform.value
        xx.balance = this.updatebalance;
        xx.userId = this.allproforUser[i].userId

        this.productService.updateBalance(xx).subscribe((data: any) => {
          console.log("true");

          this.toast.success("Done")
          window.location.reload();
        })



      })

    })


    //this.toast.success("Sessefully Accept")
    // 






  }

  ngOnInit(): void {
  }

}
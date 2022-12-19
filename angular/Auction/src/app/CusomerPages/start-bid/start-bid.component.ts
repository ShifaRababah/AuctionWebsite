import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-start-bid',
  templateUrl: './start-bid.component.html',
  styleUrls: ['./start-bid.component.css']
})
export class StartBidComponent implements OnInit {
  dataid: any | null
  proform: FormGroup | any
  bidform: FormGroup | any
  productSelected: any
  bankuser: FormGroup | any
  userid: any | null
  balancform: FormGroup | any
  updatell: any
  constructor(private route: ActivatedRoute,

    private router: Router, private fb: FormBuilder,
    private productService: ProductService, private toast: ToastrService) {
    this.userid = localStorage.getItem('userId');
    this.proform = this.fb.group({

    })
    this.bidform = this.fb.group({
      price: new FormControl('', [Validators.required])


    })
    console.log(this.bidform)
    this.bankuser = this.fb.group({

    })
    this.balancform = this.fb.group({

    })
    let useridint1 = parseInt(this.userid)

    let xbank = this.bankuser.value
    xbank.userid = useridint1

    this.dataid = Number(this.route.snapshot.paramMap.get('id'));

    let proid = this.dataid
    let x = this.proform.value
    x.productid = proid



    //this.productService.ResultProductById();


    this.productService.ResultProductById(x).subscribe((data: any) => {
      this.productSelected = data;
      console.log(this.productSelected)
    })



    console.log(useridint1)

    this.productService.getallBankbyuserid(xbank).subscribe((data: any) => {
      console.log(data);

      this.bankuser = data;
      console.log(this.bankuser[0].balance)

    })



  }

  bidNow() {
    let x1 = this.bidform.value

    let useridint = parseInt(this.userid)
    if (x1.price <= this.bankuser[0].balance) {
      let updatebalance = this.bankuser[0].balance - x1.price;
      this.updatell = updatebalance

      console.log(updatebalance)


      let proid2 = this.dataid

      x1.productid = proid2
      x1.userid = useridint
      this.productService.UpdateAuctionAndInsertCart(x1).subscribe((data: any) => {

        this.toast.success(" your bid is send ! ")
        window.location.reload();


      }, (error: any) => { this.toast.error("your bid is Failed") })



    }
    else {
      this.toast.error("your Balance  in Bank is low ! ")
    }

  }

  ngOnInit(): void {





  }
}
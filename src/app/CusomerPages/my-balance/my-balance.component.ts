import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-my-balance',
  templateUrl: './my-balance.component.html',
  styleUrls: ['./my-balance.component.css']
})
export class MyBalanceComponent implements OnInit {
  userid: any | null
  bankuser: FormGroup | any
  BankInfoforUser: any
  constructor(private route: ActivatedRoute,

    private router: Router, private fb: FormBuilder,
    private productService: ProductService, private toast: ToastrService) {

    this.bankuser = this.fb.group({

    })
    this.userid = localStorage.getItem('userId');
    let useridint1 = parseInt(this.userid)

    let xbank = this.bankuser.value
    xbank.userid = useridint1

    this.productService.getallBankbyuserid(xbank).subscribe((data: any) => {
      console.log(data);

      this.BankInfoforUser = data;
      console.log(this.BankInfoforUser)


    })

  }

  ngOnInit(): void {
  }

}

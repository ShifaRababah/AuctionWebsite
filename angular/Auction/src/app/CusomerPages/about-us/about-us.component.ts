import { Component, OnInit } from '@angular/core';
import { AdminserviceService } from 'src/app/adminservice.service';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-about-us',
  templateUrl: './about-us.component.html',
  styleUrls: ['./about-us.component.css']
})
export class AboutUsComponent implements OnInit {
  countpro1: any
  countCust1: any
  countEmpl1: any
  countord1: any
  constructor(public pro: ProductService , public admin:AdminserviceService) {

    this.pro.getCountproduct().subscribe((data: any) => {
      var countpro = data;
      this.countpro1 = countpro.countpro;


    })
    this.admin.getCountCust().subscribe((data :any)=> {
      var countCust =data;
      this.countCust1 = countCust.countCust;
    })
    this.admin.getCountEmp().subscribe((data :any)=> {
      var countEmpl =data;
      this.countEmpl1 = countEmpl.countEmpl;
    })

    this.admin.getCountOrd().subscribe((data :any)=> {
      var countord =data;
      this.countord1 = countord.countord;
    })




  }

  ngOnInit(): void {
  }

}

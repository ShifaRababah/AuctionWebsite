import { Component, OnInit } from '@angular/core';
import { AdminserviceService } from '../adminservice.service';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-accdash',
  templateUrl: './accdash.component.html',
  styleUrls: ['./accdash.component.css']
})
export class AccdashComponent implements OnInit {
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

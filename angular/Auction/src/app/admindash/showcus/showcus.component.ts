import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AdminserviceService } from 'src/app/adminservice.service';

@Component({
  selector: 'app-showcus',
  templateUrl: './showcus.component.html',
  styleUrls: ['./showcus.component.css']
})
export class ShowcusComponent implements OnInit {

  constructor(public ad: AdminserviceService, http: HttpClient) {


    this.ad.getallCustomer()

  }

  ngOnInit(): void {
  }

}

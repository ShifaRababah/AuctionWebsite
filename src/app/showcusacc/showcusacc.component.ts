import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AdminserviceService } from '../adminservice.service';

@Component({
  selector: 'app-showcusacc',
  templateUrl: './showcusacc.component.html',
  styleUrls: ['./showcusacc.component.css']
})
export class ShowcusaccComponent implements OnInit {

  constructor(public ad: AdminserviceService, http: HttpClient) {


    this.ad.getallCustomer()

  }

  ngOnInit(): void {
  }

}

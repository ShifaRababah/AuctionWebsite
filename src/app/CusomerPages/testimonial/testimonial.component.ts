import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ContactService } from 'src/app/contact.service';

@Component({
  selector: 'app-testimonial',
  templateUrl: './testimonial.component.html',
  styleUrls: ['./testimonial.component.css']
})
export class TestimonialComponent implements OnInit {

  constructor(http:HttpClient, public Testm:ContactService) { 

    this.Testm.GetAllTestimonial()
  }

  ngOnInit(): void {
  }

}

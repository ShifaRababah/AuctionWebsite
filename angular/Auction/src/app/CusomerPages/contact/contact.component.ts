import { NonNullAssert } from '@angular/compiler';
import { isNull, not } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ContactService } from 'src/app/contact.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {


  createContact:FormGroup|any;
  constructor(public conta:ContactService,private fb:FormBuilder, private toast:ToastrService) 
   {

        this.createContact=this.fb.group({
    
      Email:new FormControl(null,[Validators.required, Validators.email]),
          
      Name:new FormControl(null, Validators.required),
      Massege:new FormControl(null, [Validators.required, Validators.minLength(8)]),
    
          
      
      
        })}

  ngOnInit(): void {
  }

  createContact1()
  {
    this.conta.createContact(this.createContact.value);
 


  }
}



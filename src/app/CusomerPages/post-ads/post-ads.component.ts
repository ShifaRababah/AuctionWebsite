import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ProductService } from 'src/app/product.service';
@Component({
  selector: 'app-post-ads',
  templateUrl: './post-ads.component.html',
  styleUrls: ['./post-ads.component.css']
})

export class PostAdsComponent implements OnInit {

  createproduct11: FormGroup | any
  selectedFile: string = "";
  nameIamge: string = '';
  imagefile: File | any = null
  userid: any | null
  categoriesList: any
  selectedCat: any

  constructor(public pro: ProductService, private fb: FormBuilder, private router: Router) {

    pro.getAllCategories().subscribe((data: any) => {
      this.categoriesList = data;
      console.warn(this.categoriesList);

    })
    this.createproduct11 = this.fb.group({

      Title: new FormControl(''),

      PriceProduct: new FormControl(''),
      StartDate: new FormControl(''),
      EndDate: new FormControl(''),
      Image: new FormControl(''),
      Description: new FormControl(''),




    })
  }

  ngOnInit(): void {
  }

  createproduct1() {

    this.userid = localStorage.getItem('userId');
    let useridint = parseInt(this.userid)
    let x = this.createproduct11.value;
    x.Image = this.nameIamge
    x.userId = useridint;
    let selectint = parseInt(this.selectedCat);
    x.categoryId = selectint;
    console.log(x);
    this.pro.createproduct11(x)
    console.log(this.selectedCat)
    // alert(this.selectedCat)

  }
  printcat() {
    // alert(this.selectedCat)



  }

  processFile(file: any) {
    let fileToUpload = <File>file[0];//c://fakepath/
    this.selectedFile = fileToUpload.name
    const formData = new FormData();
    this.nameIamge = fileToUpload.name
    formData.append('file', fileToUpload, fileToUpload.name);
    this.pro.uplodImage(formData).subscribe((res: any) => {
      this.nameIamge = res;
      console.log('shifa :' + res);
    });
  }



}
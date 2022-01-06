import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import html2canvas from 'html2canvas';
import jspdf from 'jspdf';
import { AdminserviceService } from 'src/app/adminservice.service';
import * as XLSX from 'xlsx';

@Component({
  selector: 'app-showorders',
  templateUrl: './showorders.component.html',
  styleUrls: ['./showorders.component.css']
})
export class ShowordersComponent implements OnInit {
  searchform: FormGroup | any
  listofordersearch: any
  constructor(public ad: AdminserviceService, http: HttpClient) {
    this.searchform = new FormGroup(
      {
        StartDate: new FormControl('', [Validators.required]),
        EndDate: new FormControl('', [Validators.required])




      }

    )
    this.allorder();

  }
  searchnow() {
    //this.listofproSearch = 
    this.ad.ProfitsByDate(this.searchform.value).subscribe((data: any) => {

      this.listofordersearch = data;
      console.log(this.listofordersearch)

    })
  }
  allorder() {
    this.ad.GetAllOrder();



  }

  generatePDF() {
    console.log("ff")
    var data: any = document.getElementById('Prof');
    html2canvas(data).then(canvas => {
      var imgWidth = 208;
      var imgHeight = canvas.height * imgWidth / canvas.width;
      const contentDataURL = canvas.toDataURL('image/png')
      let pdf: any = new jspdf('p', 'mm', 'a4');
      var position = 0;
      pdf.addImage(contentDataURL, 'PNG', 0, position, imgWidth, imgHeight)
      pdf.save('ProfitsReport.pdf');
    });
  }
  generatePDF1() {
    console.log("ff")
    var data: any = document.getElementById('Prof1');
    html2canvas(data).then(canvas => {
      var imgWidth = 208;
      var imgHeight = canvas.height * imgWidth / canvas.width;
      const contentDataURL = canvas.toDataURL('image/png')
      let pdf: any = new jspdf('p', 'mm', 'a4');
      var position = 0;
      pdf.addImage(contentDataURL, 'PNG', 0, position, imgWidth, imgHeight)
      pdf.save('ProfitsReport.pdf');
    });
  }
  fileName = 'Order Report.xlsx';
  exportexcel(): void {
    /* table id is passed over here */
    let element = document.getElementById('Prof');
    const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(element);

    /* generate workbook and add the worksheet */
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

    /* save to file */
    XLSX.writeFile(wb, this.fileName);

  }
  exportexcel1(): void {
    /* table id is passed over here */
    let element = document.getElementById('Prof1');
    const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(element);

    /* generate workbook and add the worksheet */
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

    /* save to file */
    XLSX.writeFile(wb, this.fileName);

  }

  ngOnInit(): void {
  }

}
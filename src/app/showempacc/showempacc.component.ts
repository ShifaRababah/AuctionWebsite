import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import html2canvas from 'html2canvas';
import jspdf from 'jspdf';
import { AdminserviceService } from '../adminservice.service';

@Component({
  selector: 'app-showempacc',
  templateUrl: './showempacc.component.html',
  styleUrls: ['./showempacc.component.css']
})
export class ShowempaccComponent implements OnInit {

  data1: any
  constructor(public ad: AdminserviceService, http: HttpClient) {

    this.ad.getallemp().subscribe((Response: any) => { this.data1 = Response })
  }

  ngOnInit(): void {
  }

  generatePDF() {
    var data: any = document.getElementById('Emp');
    html2canvas(data).then(canvas => {
      var imgWidth = 208;
      var imgHeight = canvas.height * imgWidth / canvas.width;
      const contentDataURL = canvas.toDataURL('image/png')
      let pdf: any = new jspdf('p', 'mm', 'a4');
      var position = 0;
      pdf.addImage(contentDataURL, 'PNG', 0, position, imgWidth, imgHeight)
      pdf.save('SalaryReport.pdf');
    });
  }


}

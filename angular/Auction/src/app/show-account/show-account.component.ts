import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import html2canvas from 'html2canvas';
import jspdf from 'jspdf';
import { AdminserviceService } from '../adminservice.service';

@Component({
  selector: 'app-show-account',
  templateUrl: './show-account.component.html',
  styleUrls: ['./show-account.component.css']
})
export class ShowAccountComponent implements OnInit {

  constructor(public ad: AdminserviceService, http: HttpClient) {

    this.ad.getallAccount();
  }

  generatePDF() {
    var data: any = document.getElementById('Acc');
    html2canvas(data).then(canvas => {
      var imgWidth = 208;
      var imgHeight = canvas.height * imgWidth / canvas.width;
      const contentDataURL = canvas.toDataURL('image/png')
      let pdf: any = new jspdf('p', 'mm', 'a4');
      var position = 0;
      pdf.addImage(contentDataURL, 'PNG', 0, position, imgWidth, imgHeight)
      pdf.save('AccountReport.pdf');
    });
  }

  ngOnInit(): void {
  }

}

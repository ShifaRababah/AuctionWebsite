import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AdminGuard implements CanActivate {
  tokenn: any
  constructor(private router: Router, private toast: ToastrService) {


  }
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    this.tokenn = localStorage.getItem('Tokenid')
    console.log(this.tokenn)

    if (this.tokenn == 1) {
      console.log("welcoome to admin")
      //this.router.navigate(['Admin1'])

    }
    else {
      console.log("you cant go to admin !")
    
      this.router.navigate(['/'])

    }


    return true;
  }

}
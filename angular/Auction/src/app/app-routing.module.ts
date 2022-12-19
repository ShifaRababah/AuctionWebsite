import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountantGuard } from './accountant.guard';
import { AdminGuard } from './admin.guard';
import { StartBidComponent } from './CusomerPages/start-bid/start-bid.component';
import { CustomerGuard } from './customer.guard';

const routes: Routes = [{ path: '', loadChildren: () => import('./customer-lazy/customer-lazy-routing.module').then(s => s.CustomerLazyRoutingModule) },
{ path: 'Accountant', loadChildren: () => import('./acc-lazy/acc-lazy-routing.module').then(s => s.AccLazyRoutingModule),canActivate:[AccountantGuard]},
{ path: 'Admin', loadChildren: () => import('./admin-lazy/admin-lazy-routing.module').then(s => s.AdminLazyRoutingModule),canActivate:[AdminGuard]},
{ path: 'StartBid/:id', component: StartBidComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

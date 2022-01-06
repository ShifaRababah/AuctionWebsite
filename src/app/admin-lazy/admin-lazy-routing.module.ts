import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddempComponent } from '../admindash/addemp/addemp.component';
import { AdmindashComponent } from '../admindash/admindash.component';
import { ShowcusComponent } from '../admindash/showcus/showcus.component';
import { ShowempComponent } from '../admindash/showemp/showemp.component';
import { ShowordersComponent } from '../admindash/showorders/showorders.component';
import { ShowempaccComponent } from '../showempacc/showempacc.component';



const routes: Routes = [{ path: '', component: AdmindashComponent }, { path: 'showcustomer', component: ShowcusComponent }, { path: 'showemp', component: ShowempComponent }, { path: 'addemp', component: AddempComponent }
, { path: 'showorders', component:ShowordersComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminLazyRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccdashComponent } from '../accdash/accdash.component';
import { AddAccountComponent } from '../add-account/add-account.component';
import { ShowAccountComponent } from '../show-account/show-account.component';
import { ShowcusaccComponent } from '../showcusacc/showcusacc.component';
import { ShowempaccComponent } from '../showempacc/showempacc.component';

const routes: Routes = [{ path: '', component:AccdashComponent },{path: 'showemp',component:ShowempaccComponent}, {path: 'showcus',component:ShowcusaccComponent}, {path:'showacc',component:ShowAccountComponent}
,{path:'addacc',component:AddAccountComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccLazyRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutUsComponent } from '../CusomerPages/about-us/about-us.component';
import { CategoryComponent } from '../CusomerPages/category/category.component';
import { ContactComponent } from '../CusomerPages/contact/contact.component';
import { CustomerComponent } from '../CusomerPages/customer/customer.component';
import { HomeComponent } from '../CusomerPages/home/home.component';
import { LoginComponent } from '../CusomerPages/login/login.component';
import { MyAdsComponent } from '../CusomerPages/my-ads/my-ads.component';
import { MyBalanceComponent } from '../CusomerPages/my-balance/my-balance.component';
import { MyPaymentsComponent } from '../CusomerPages/my-payments/my-payments.component';
import { MyPurchasesComponent } from '../CusomerPages/my-purchases/my-purchases.component';
import { PostAdsComponent } from '../CusomerPages/post-ads/post-ads.component';
import { RegisterComponent } from '../CusomerPages/register/register.component';
import { ServiceComponent } from '../CusomerPages/service/service.component';
import { StartBidComponent } from '../CusomerPages/start-bid/start-bid.component';
import { TestimonialComponent } from '../CusomerPages/testimonial/testimonial.component';

const routes: Routes = [{ path: '', component: HomeComponent }, { path: 'Category', component: CategoryComponent },
{ path: 'StartBid', component: StartBidComponent }, { path: 'About', component: AboutUsComponent },
{ path: 'Testimonial', component: TestimonialComponent }, { path: 'Service', component: ServiceComponent },
{ path: 'Contact', component: ContactComponent }, { path: 'Login', component: LoginComponent },
{ path: 'Register1', component: RegisterComponent }, { path: 'Post-Ads', component: PostAdsComponent },
{ path: 'CustomerDashboard', component: CustomerComponent }, { path: 'MyAds', component: MyAdsComponent },
{ path: 'MyPayment', component: MyPaymentsComponent },
{ path: 'MyBalance', component: MyBalanceComponent },
{ path: 'MyPurchases', component: MyPurchasesComponent }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerLazyRoutingModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './CusomerPages/navbar/navbar.component';
import { FooterComponent } from './CusomerPages/footer/footer.component';
import { HomeComponent } from './CusomerPages/home/home.component';
import { AboutUsComponent } from './CusomerPages/about-us/about-us.component';
import { CategoryComponent } from './CusomerPages/category/category.component';
import { ContactComponent } from './CusomerPages/contact/contact.component';
import { MyAdsComponent } from './CusomerPages/my-ads/my-ads.component';
import { MyPaymentsComponent } from './CusomerPages/my-payments/my-payments.component';
import { PostAdsComponent } from './CusomerPages/post-ads/post-ads.component';
import { ServiceComponent } from './CusomerPages/service/service.component';
import { StartBidComponent } from './CusomerPages/start-bid/start-bid.component';
import { TestimonialComponent } from './CusomerPages/testimonial/testimonial.component';
import { LoginComponent } from './CusomerPages/login/login.component';
import { RegisterComponent } from './CusomerPages/register/register.component';
import { CustomerComponent } from './CusomerPages/customer/customer.component';
import { AdminsidebarComponent } from './adminsidebar/adminsidebar.component';
import { AdmindashComponent } from './admindash/admindash.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SidebarcustComponent } from './CusomerPages/sidebarcust/sidebarcust.component';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddempComponent } from './admindash/addemp/addemp.component';
import { ShowcusComponent } from './admindash/showcus/showcus.component';
import { ShowempComponent } from './admindash/showemp/showemp.component';
import { AdminGuard } from './admin.guard';
import { AccsidebarComponent } from './accsidebar/accsidebar.component';
import { AccdashComponent } from './accdash/accdash.component';
import { ShowempaccComponent } from './showempacc/showempacc.component';
import { ShowcusaccComponent } from './showcusacc/showcusacc.component';
import { ShowAccountComponent } from './show-account/show-account.component';
import { AddAccountComponent } from './add-account/add-account.component';
import { ShowordersComponent } from './admindash/showorders/showorders.component';
import { MyBalanceComponent } from './CusomerPages/my-balance/my-balance.component';
import { MyPurchasesComponent } from './CusomerPages/my-purchases/my-purchases.component';





@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    HomeComponent,
    AboutUsComponent,
    CategoryComponent,
    ContactComponent,
    MyAdsComponent,
    MyPaymentsComponent,
    PostAdsComponent,
    ServiceComponent,
    StartBidComponent,
    TestimonialComponent,
    LoginComponent,
    RegisterComponent,
    CustomerComponent,
    AdminsidebarComponent,
    AdmindashComponent,

    SidebarcustComponent,
    AddempComponent,
    ShowcusComponent,
    ShowempComponent,
    AccsidebarComponent,
    AccdashComponent,
    ShowempaccComponent,
    ShowcusaccComponent,
    ShowAccountComponent,
    AddAccountComponent,
    ShowordersComponent,
    MyBalanceComponent,

    MyPurchasesComponent,







  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot({ progressBar: true, progressAnimation: "increasing" }),
    BrowserAnimationsModule,


  ],
  providers: [AdminGuard],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]


})
export class AppModule { }

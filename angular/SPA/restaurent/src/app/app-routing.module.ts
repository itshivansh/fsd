import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddRestaurentComponent } from './add-restaurent/add-restaurent.component';
import { ListRestaurentComponent } from './list-restaurent/list-restaurent.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { UpdateRestaurentComponent } from './update-restaurent/update-restaurent.component';

const routes: Routes = [
  {path:'add',component:AddRestaurentComponent},
  {path:'update',component:UpdateRestaurentComponent},
  {path:'list',component:ListRestaurentComponent},
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent}
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

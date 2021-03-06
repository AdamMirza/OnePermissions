import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { NavComponent } from './nav/nav.component';
import { UserPermissionsComponent } from './user-permissions/user-permissions.component';
import { HomeComponent } from './home/home.component'


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'permissions', component: UserPermissionsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

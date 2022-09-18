import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthenticateComponent } from './authenticate/authenticate.component';
import { AdminComponent } from './theme/layout/admin/admin.component';

const routes: Routes = [
  {
    path: '',
    component: AuthenticateComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

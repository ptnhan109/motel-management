import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './theme/layout/admin/admin.component';
import { AuthComponent } from './theme/layout/auth/auth.component';
import { AuthenticateComponent } from './pages/authenticate/authenticate.component'
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { BoardingHouseComponent } from './pages/boarding-house/boarding-house.component';
import { FitmentComponent } from './pages/fitment/fitment.component';
import { ServiceComponent } from './pages/service/service.component';

const routes: Routes = [
  {
    path: '',
    component: AdminComponent,
    children: [
      {
        path: '',
        redirectTo: '/auth',
        pathMatch: 'full'
      },
      {
        path: 'dashboard',
        component: DashboardComponent
      },
      {
        path: 'boarding-house',
        component: BoardingHouseComponent
      },
      {
        path: 'fitment',
        component: FitmentComponent
      },
      {
        path: 'service',
        component: ServiceComponent
      }
    ]
  },
  {
    path: '',
    component: AuthComponent,
    children: [
      {
        path: 'auth',
        component: AuthenticateComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

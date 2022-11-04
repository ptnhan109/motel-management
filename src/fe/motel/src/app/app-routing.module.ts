import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './theme/layout/admin/admin.component';
import { AuthComponent } from './theme/layout/auth/auth.component';
import { AuthenticateComponent } from './pages/authenticate/authenticate.component'
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { BoardingHouseComponent } from './pages/boarding-house/boarding-house.component';
import { FitmentComponent } from './pages/fitment/fitment.component';
import { ServiceComponent } from './pages/service/service.component';
import { BoardingHouseSingleComponent } from './pages/boarding-house-single/boarding-house-single.component';
import { RoomsComponent } from './pages/rooms/rooms.component';
import { RoomSingleComponent } from './pages/room-single/room-single.component';
import { CustomersComponent } from './pages/customers/customers.component';

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
        path: 'boarding-house/:id',
        component: BoardingHouseSingleComponent
      },
      {
        path: 'fitment',
        component: FitmentComponent
      },
      {
        path: 'service',
        component: ServiceComponent
      },
      {
        path: 'room',
        component: RoomsComponent
      },
      {
        path:'add-room',
        component: RoomSingleComponent
      },
      {
        path:'customers',
        component: CustomersComponent
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

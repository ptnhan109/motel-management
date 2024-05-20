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
import { ContractsComponent } from './pages/contracts/contracts.component';
import { RegisterComponent } from './pages/register/register.component';
import { AddContractComponent } from './pages/add-contract/add-contract.component';
import { BadrequestComponent } from './pages/errors/badrequest/badrequest.component';
import { InvoicesComponent } from './pages/invoices/invoices.component';
import { InvoiceSingleComponent } from './pages/invoice-single/invoice-single.component';
import { SystemComponent } from './pages/system/system.component';
import { VehicleComponent } from './pages/vehicle/vehicle.component';

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
        path: 'room/:boardingId',
        component: RoomsComponent
      }
      ,
      {
        path: 'room-single',
        component: RoomSingleComponent
      },
      {
        path: 'room-single/:id',
        component: RoomSingleComponent
      },
      {
        path: 'customers',
        component: CustomersComponent
      },
      {
        path: 'contracts',
        component: ContractsComponent
      },
      {
        path: 'add-contract-customer',
        component: AddContractComponent
      },
      {
        path: 'add-contract-customer/:roomId',
        component: AddContractComponent
      },
      {
        path: 'invoice',
        component: InvoicesComponent
      },
      {
        path: 'system',
        component: SystemComponent
      },
      {
        path: 'vehicles',
        component: VehicleComponent
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
      },
      {
        path: 'register',
        component: RegisterComponent
      },
      {
        path: 'bad-request',
        component: BadrequestComponent
      },
      {
        path: 'invoice-single/:id',
        component: InvoiceSingleComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

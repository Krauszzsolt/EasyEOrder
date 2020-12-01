import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { LayoutComponent } from './layout/layout.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

const routes: Routes = [
  {
    path: '',
    component: LayoutComponent,
    children: [
      {
        path: 'restaurant',
        loadChildren: () => import('./../feature/restaurant/restaurant.module').then((m) => m.RestaurantModule),
        canActivate: [AuthGuard]
      },
      {
        path: 'cart',
        loadChildren: () => import('./../feature/cart/cart.module').then((m) => m.CartModule),
        canActivate: [AuthGuard]
      },
      {
        path: 'food',
        loadChildren: () => import('./../feature/food/food.module').then((m) => m.FoodModule),
        canActivate: [AuthGuard]
      },
      {
        path: 'login',
        component: LoginComponent,
      },
      {
        path: 'registration',
        component: RegistrationComponent,
      },
      {
        path: '',
        redirectTo: 'login',
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CoreRoutingModule {}

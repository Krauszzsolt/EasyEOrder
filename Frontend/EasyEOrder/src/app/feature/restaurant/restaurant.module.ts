import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RestaurantRoutingModule } from './restaurant-routing.module';
import { RestaurantListComponent } from './restaurant-list/restaurant-list.component';
import { RestaurantService } from './service/restaurant.service';

@NgModule({
  declarations: [RestaurantListComponent],
  imports: [
    CommonModule,
    RestaurantRoutingModule
  ]
})
export class RestaurantModule { }

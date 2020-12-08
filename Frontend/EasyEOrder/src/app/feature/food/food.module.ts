import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FoodRoutingModule } from './food-routing.module';
import { FoodListComponent } from './food-list/food-list.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { FoodAddComponent } from './food-add-dialog/food-add.component';
import { FoodDetailDialogComponent } from './food-detail-dialog/food-detail-dialog.component';

@NgModule({
  declarations: [FoodListComponent, FoodAddComponent, FoodDetailDialogComponent],
  imports: [CommonModule, FoodRoutingModule, SharedModule],
  entryComponents: [FoodAddComponent, FoodDetailDialogComponent],
})
export class FoodModule {}

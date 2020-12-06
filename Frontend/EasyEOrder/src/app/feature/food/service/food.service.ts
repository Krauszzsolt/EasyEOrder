import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { FoodClient, FoodCreateDto, PageableListOfFoodGroupByTypeDto } from 'src/app/shared/client/clients';

@Injectable({
  providedIn: 'root',
})
export class FoodService {
  constructor(private foodClient: FoodClient) {}



  GetAllFood(menuId: string, searchTerm?: string, index?: number, pageSize?: number): Observable<PageableListOfFoodGroupByTypeDto> {
    return this.foodClient.food_GetAll(menuId, '', 1, 1);
  }

  getFood(id: string) {
    return this.foodClient.food_Get(id);
  }

  addFood(newFood: FoodCreateDto): Observable<void> {
    return this.foodClient.food_Post(newFood);
  }

  editFood(id: string, newFood: FoodCreateDto): Observable<void> {
    return this.foodClient.food_Put(id, newFood);
  }

  deleteFood(id: string): Observable<void> {
    return this.foodClient.food_Delete(id);
  }
}

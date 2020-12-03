import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PageableListOfRestaruantDTO, RestaurantClient } from 'src/app/shared/client/clients';

@Injectable({
  providedIn: 'root',
})
export class RestaurantService {
  constructor(private restaurantClient: RestaurantClient) {}

  getRestaurant(): Observable<PageableListOfRestaruantDTO> {
    return this.restaurantClient.restaurant_GetAllRestaurant(0, 1);
  }
}

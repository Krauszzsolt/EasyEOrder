import { Component, OnInit } from '@angular/core';
import { PageableListOfRestaruantDTO } from 'src/app/shared/client/clients';
import { RestaurantService } from '../service/restaurant.service';

@Component({
  selector: 'app-restaurant-list',
  templateUrl: './restaurant-list.component.html',
  styleUrls: ['./restaurant-list.component.sass'],
})
export class RestaurantListComponent implements OnInit {
  constructor(private restaurantService: RestaurantService) {}
  public pageableListOfRestaruantDTO: PageableListOfRestaruantDTO;
  ngOnInit() {
    this.restaurantService.getRestaurant().subscribe((x) => {
      this.pageableListOfRestaruantDTO = x;
      console.log(this.pageableListOfRestaruantDTO);
    });
  }
}

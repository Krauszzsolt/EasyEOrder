import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/service/auth.service';
import { ApplicationUserDto, PageableListOfRestaruantDTO } from 'src/app/shared/client/clients';
import { RestaurantService } from '../service/restaurant.service';

@Component({
  selector: 'app-restaurant-list',
  templateUrl: './restaurant-list.component.html',
  styleUrls: ['./restaurant-list.component.scss'],
})
export class RestaurantListComponent implements OnInit {
  constructor(public dialog: MatDialog, private restaurantService: RestaurantService, private authService: AuthService, private router: Router) {}
  public search$: Observable<String>;
  public modifiedTittle = [];
  public user: Observable<ApplicationUserDto> = new Observable();
  public pageableListOfRestaruantDTO: PageableListOfRestaruantDTO;

  ngOnInit() {
    this.restaurantService.getRestaurant().subscribe((x) => {
      this.pageableListOfRestaruantDTO = x;
    });
    this.user = this.authService.getUser();
  }

  public select(id: string) {
    this.restaurantService.setMenuId(id);
    this.router.navigateByUrl(`food`);
  }
}

import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/service/auth.service';
import { ApplicationUserDto, PageableListOfFoodGroupByTypeDto } from 'src/app/shared/client/clients';
import { FoodAddComponent } from '../food-add/food-add.component';
import { FoodService } from '../service/food.service';

@Component({
  selector: 'app-food-list',
  templateUrl: './food-list.component.html',
  styleUrls: ['./food-list.component.scss'],
})
export class FoodListComponent implements OnInit {
  constructor(public dialog: MatDialog, private foodService: FoodService, private authService: AuthService, private router: Router) {}
  public search$: Observable<String>;
  public user: Observable<ApplicationUserDto> = new Observable();
  foodList: PageableListOfFoodGroupByTypeDto;

  categoryOptions = ['Levesek', 'Főételek'];

  public menuId = localStorage.getItem('menuId');
  ngOnInit() {
    this.user = this.authService.getUser();
    this.foodService.GetAllFood(this.menuId).subscribe((resp) => {
      console.log(resp);
      this.foodList = resp;
    });
  }

  public detail(id: number) {
    const dialogRef = this.dialog.open(FoodAddComponent);

    dialogRef.afterClosed().subscribe((result) => {});
  }  
  
  public add(id: number) {
    const dialogRef = this.dialog.open(FoodAddComponent);

    dialogRef.afterClosed().subscribe((result) => {});
  }
}

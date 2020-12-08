import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/service/auth.service';
import { ApplicationUserDto, PageableListOfFoodGroupByTypeDto } from 'src/app/shared/client/clients';
import { FoodAddComponent } from '../food-add-dialog/food-add.component';
import { FoodDetailDialogComponent } from '../food-detail-dialog/food-detail-dialog.component';
import { FoodService } from '../service/food.service';

@Component({
  selector: 'app-food-list',
  templateUrl: './food-list.component.html',
  styleUrls: ['./food-list.component.scss'],
})
export class FoodListComponent implements OnInit {
  constructor(public dialog: MatDialog, private foodService: FoodService, private authService: AuthService, private router: Router) {}
  public search$: Observable<string>;
  public user: Observable<ApplicationUserDto> = new Observable();
  foodList: PageableListOfFoodGroupByTypeDto;

  categoryOptions = ['Levesek', 'Főételek'];

  public menuId = localStorage.getItem('menuId');
  ngOnInit() {
    this.user = this.authService.getUser();
    if (this.menuId) {
      this.foodService.GetAllFood(this.menuId).subscribe((resp) => {
        this.foodList = resp;
      });
    }
  }

  public detail(id: string) {
    const dialogRef = this.dialog.open(FoodDetailDialogComponent, {
      data: {
        id,
      },
    });

    dialogRef.afterClosed().subscribe((result) => {
      this.foodService.GetAllFood(this.menuId).subscribe((resp) => {
        this.foodList = resp;
      });
    });
  }

  public add() {
    const dialogRef = this.dialog.open(FoodAddComponent, {
      data: {
        id: this.menuId,
      },
    });

    dialogRef.afterClosed().subscribe((result) => {
      this.foodService.GetAllFood(this.menuId).subscribe((resp) => {
        this.foodList = resp;
      });
    });
  }
}

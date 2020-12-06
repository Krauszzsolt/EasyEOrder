import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/service/auth.service';
import { ApplicationUserDto, FoodDetailsDto } from 'src/app/shared/client/clients';
import { CartService } from '../../cart/service/cart.service';
import { FoodService } from '../service/food.service';

@Component({
  selector: 'app-detail-dialog',
  templateUrl: './detail-dialog.component.html',
  styleUrls: ['./detail-dialog.component.scss'],
})
export class DetailDialogComponent implements OnInit {
  constructor(
    public dialogRef: MatDialogRef<DetailDialogComponent>,
    private authService: AuthService,
    private cartService: CartService,
    private foodService: FoodService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.id = data.id;
  }
  id: string;
  loading = false;
  error = '';
  url: string | ArrayBuffer = '/assets/img/rest_1.jpg';
  allergens = [
    { index: 0, name: 'Glutén' },
    { index: 1, name: 'Laktóz' },
  ];

  categories = [
    { index: 1, name: 'Leves' },
    { index: 2, name: 'Főétel' },
  ];

  public user: Observable<ApplicationUserDto> = new Observable();
  foodDetailsDto: FoodDetailsDto;

  ngOnInit(): void {
    this.foodService.getFood(this.id).subscribe((x) => {
      this.foodDetailsDto = x;
    });
    this.user = this.authService.getUser();
  }

  delete() {
    this.foodService.deleteFood(this.id).subscribe((x) => {
      this.dialogRef.close();
    });
  }

  putCart() {
    this.cartService.addFoodToCart(this.id).subscribe((x) => {
      this.dialogRef.close();
    });
  }

  onSubmit(): void {
    // stop here if form is invalid
    //   if (this.foodForm.invalid) {
    //     return;
    //   }
    //   this.foodCreateDto = new FoodCreateDto({
    //     id: undefined,
    //     isAvailable: undefined,
    //     rating: undefined,
    //     name: this.f.name.value,
    //     price: this.f.price.value,
    //     description: this.f.description.value,
    //     allergens: this.f.allergens.value,
    //     category: this.f.category.value,
    //     menuId: this.id
    //   });
    //   this.loading = true;
    //   this.foodService.addFood(this.foodCreateDto).subscribe({
    //     next: () => {
    //       this.dialogRef.close();
    //     },
    //     error: (error) => {
    //       this.error = error;
    //       this.loading = false;
    //     },
    //   });
  }
}

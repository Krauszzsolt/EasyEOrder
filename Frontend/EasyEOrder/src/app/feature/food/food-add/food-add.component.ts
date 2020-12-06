import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { ActivatedRoute } from '@angular/router';
import { FoodCreateDto, FoodDetailsDto } from 'src/app/shared/client/clients';
import { FoodService } from '../service/food.service';

@Component({
  selector: 'app-food-add',
  templateUrl: './food-add.component.html',
  styleUrls: ['./food-add.component.scss'],
})
export class FoodAddComponent implements OnInit {
  constructor(public dialogRef: MatDialogRef<FoodAddComponent>, private formBuilder: FormBuilder, private foodService: FoodService, @Inject(MAT_DIALOG_DATA) public data: any) {
    this.id = data.id;
  }
  id: string;
  foodForm: FormGroup;
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
  foodCreateDto: FoodCreateDto;

  // foodDetailsDto:FoodDetailsDto

  ngOnInit(): void {
    // this.foodService.getFood(this.id).subscribe((x) => {
    //   this.foodDetailsDto = x;
    // });

    this.foodForm = this.formBuilder.group({
      name: ['', Validators.required],
      price: [0],
      description: [''],
      allergens: [],
      category: [],
      menuId: [],
    });
  }

  get f() {
    return this.foodForm.controls;
  }

  onSubmit(): void {
    // stop here if form is invalid
    if (this.foodForm.invalid) {
      return;
    }

    this.foodCreateDto = new FoodCreateDto({
      id: undefined,
      isAvailable: undefined,
      rating: undefined,
      name: this.f.name.value,
      price: this.f.price.value,
      description: this.f.description.value,
      allergens: this.f.allergens.value,
      category: this.f.category.value,
      menuId: this.id
    });
    this.loading = true;
    this.foodService.addFood(this.foodCreateDto).subscribe({
      next: () => {
        this.dialogRef.close();
      },
      error: (error) => {
        this.error = error;
        this.loading = false;
      },
    });
  }
}

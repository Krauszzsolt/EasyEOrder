import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-food-list',
  templateUrl: './food-list.component.html',
  styleUrls: ['./food-list.component.scss']
})
export class FoodListComponent implements OnInit {
public menuId = localStorage.getItem('menuId');
  constructor() { }

  ngOnInit() {
  }

}

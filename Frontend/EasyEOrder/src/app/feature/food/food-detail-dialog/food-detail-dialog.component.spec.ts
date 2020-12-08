import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FoodDetailDialogComponent } from './food-detail-dialog.component';

describe('DetailDialogComponent', () => {
  let component: FoodDetailDialogComponent;
  let fixture: ComponentFixture<FoodDetailDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FoodDetailDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FoodDetailDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

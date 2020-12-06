import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CartClient, CartDto } from 'src/app/shared/client/clients';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  constructor(private cartClient: CartClient) {}

  addFoodToCart(foodId: string): Observable<void> {
    return this.cartClient.cart_AddToCart(foodId);
  }

  removeFoodToCart(foodId: string): Observable<void> {
    return this.cartClient.cart_RemoveFromCart(foodId);
  }

  buyCart(): Observable<void> {
    return this.cartClient.cart_BuyCartContent();
  }

  getCart(): Observable<CartDto> {
    return this.cartClient.cart_Get();
  }
}

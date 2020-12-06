import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/core/service/auth.service';
import { ApplicationUserDto, CartDto } from 'src/app/shared/client/clients';
import { CartService } from '../service/cart.service';

@Component({
  selector: 'app-cart-list',
  templateUrl: './cart-list.component.html',
  styleUrls: ['./cart-list.component.scss'],
})
export class CartListComponent implements OnInit {
  constructor(private cartService: CartService, private authService: AuthService, private router: Router) {}
  public search$: Observable<String>;
  public user: Observable<ApplicationUserDto> = new Observable();
  cartDto: CartDto;
  isEmpty: boolean;
  categoryOptions = ['Levesek', 'Főételek'];

  public menuId = localStorage.getItem('menuId');
  ngOnInit() {
    this.user = this.authService.getUser();
    this.cartService.getCart().subscribe(
      (resp) => {
        this.cartDto = resp;
      },
      (error) => {
        this.cartDto = undefined;
      }
    );
  }

  delete(id) {
    this.cartService.removeFoodToCart(id).subscribe((x) => {
      this.cartService.getCart().subscribe((resp) => {
        this.cartDto = resp;
      });
    });
  }

  buyCart() {
    this.cartService.buyCart().subscribe((x) => {
      this.cartService.getCart().subscribe(
        (resp) => {
          this.cartDto = resp;
        },
        (error) => {
          this.cartDto = undefined;
        }
      );
    });
  }
}

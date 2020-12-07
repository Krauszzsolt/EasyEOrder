import { HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { tokenNotExpired } from 'angular2-jwt';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { ApplicationUserDto, LoginDto, RegisterDto, UserClient } from 'src/app/shared/client/clients';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private currentUserSubject: BehaviorSubject<ApplicationUserDto>;

  constructor(private usersService: UserClient, private router: Router) {
    this.currentUserSubject = new BehaviorSubject<ApplicationUserDto>(JSON.parse(localStorage.getItem('currentUser')));
  }

  public get currentUserValue(): ApplicationUserDto {
    return this.currentUserSubject.value;
  }

  public getUser(): Observable<ApplicationUserDto> {
    return this.currentUserSubject.asObservable();
  }

  public getToken(): string {
    return localStorage.getItem('token');
  }

  public login(loginDto: LoginDto): Observable<ApplicationUserDto> {
    return this.usersService.user_Authenticate(loginDto).pipe(
      tap((x) => {
        localStorage.setItem('token', x.token);
        localStorage.setItem('currentUser', JSON.stringify(x));
        this.currentUserSubject.next(x);
      })
    );
  }

  public register(registerDto: RegisterDto): Observable<any> {
    return this.usersService.user_Register(registerDto).pipe(
      tap((x) => {
        localStorage.setItem('token', x.token);
        localStorage.setItem('currentUser', JSON.stringify(x));
        this.currentUserSubject.next(x);
      })
    );
  }

  public logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('currentUser');
    localStorage.removeItem('menuId');
    this.currentUserSubject.next(undefined);
    this.router.navigateByUrl('login');
  }
}

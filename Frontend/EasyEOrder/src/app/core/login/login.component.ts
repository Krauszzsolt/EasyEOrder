import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginDto } from 'src/app/shared/client/clients';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  constructor(private authService: AuthService, private router: Router) {}

  loginDto: LoginDto = new LoginDto({ username: '', password: '' });

  errorMessage: string = undefined;

  ngOnInit() {}

  login() {
    this.authService.login(this.loginDto).subscribe(
      (resp) => {
        this.router.navigateByUrl('/restaurant');
      },
      (error) => {
        console.log(error);
        this.errorMessage = error.error.message;
      }
    );
  }
}

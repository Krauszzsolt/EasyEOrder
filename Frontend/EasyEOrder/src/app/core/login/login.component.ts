import { Component, OnInit } from '@angular/core';
import { AuthenticateRequestDto } from 'src/app/shared/client/clients';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private authService: AuthService) { }

  ngOnInit() {
    this.authService.login(new AuthenticateRequestDto({username: 'test@test.test', password:'123456'})).subscribe()
  }

}

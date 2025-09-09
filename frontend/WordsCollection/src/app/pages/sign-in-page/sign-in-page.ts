import { Component, Input } from '@angular/core';
import { TopBar } from '../../components/top-bar/top-bar';
import { UserAuthForm } from '../../components/user-auth-form/user-auth-form';

@Component({
  selector: 'app-sign-in-page',
  imports: [TopBar, UserAuthForm],
  templateUrl: './sign-in-page.html',
  styleUrl: './sign-in-page.css'
})
export class SignInPage {
  @Input()
  isSignUp: boolean = false;

  @Input()
  linkText: string = '';

  constructor() {  

  }
}

import { Component, Input } from '@angular/core';
import { TopBar } from "../../components/top-bar/top-bar";
import { UserAuthForm } from "../../components/user-auth-form/user-auth-form";

@Component({
  selector: 'app-sign-up-page',
  imports: [TopBar, UserAuthForm],
  templateUrl: './sign-up-page.html',
  styleUrl: './sign-up-page.css'
})
export class SignUpPage {
  @Input()
  isSignUp: boolean = true;

  @Input()
  linkText: string = '';
}

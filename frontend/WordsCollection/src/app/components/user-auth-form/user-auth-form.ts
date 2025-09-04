import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-user-auth-form',
  imports: [FormsModule, CommonModule, RouterLink],
  templateUrl: './user-auth-form.html',
  styleUrl: './user-auth-form.css'
})
export class UserAuthForm {
  
  @Input()
  isSignUp: boolean = true;

  @Input()
  email: string = '';

  @Input()
  password: any;

  @Input()
  linkText: string = '';

  public UserAuthForm() {
    
  }

  public onSubmit() {

  }
}

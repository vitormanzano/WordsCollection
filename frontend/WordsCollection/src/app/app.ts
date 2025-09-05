import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SignUpPage } from './pages/sign-up-page/sign-up-page';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('WordsCollection');
}

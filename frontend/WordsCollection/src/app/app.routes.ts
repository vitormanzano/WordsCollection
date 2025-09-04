import { Routes } from '@angular/router';
import { SignUpPage } from './pages/sign-up-page/sign-up-page';
import { SignInPage } from './pages/sign-in-page/sign-in-page';

export const routes: Routes = [
    {
        path: '',
        component: SignUpPage,
        pathMatch: 'full'
    },
    {
        path: 'sign-in',
        component: SignInPage,
        pathMatch: 'full'
    }
];

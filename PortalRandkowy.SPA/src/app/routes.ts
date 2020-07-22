import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsersListComponent } from './users/usersList/usersList.component';
import { LikesComponent } from './likes/likes.component';
import { MessegesComponent } from './messeges/messeges.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'uzytkownicy', component: UsersListComponent, canActivate: [AuthGuard] },
    { path: 'polubienia', component: LikesComponent, canActivate: [AuthGuard] },
    { path: 'wiadomosci', component: MessegesComponent, canActivate: [AuthGuard] },
    { path: '**', redirectTo: 'home', pathMatch: 'full' },
];
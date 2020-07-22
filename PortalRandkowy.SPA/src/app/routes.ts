import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsersListComponent } from './users/usersList/usersList.component';
import { LikesComponent } from './likes/likes.component';
import { MessegesComponent } from './messeges/messeges.component';

export const appRoutes: Routes = [
    { path: ' home', component: HomeComponent },
    { path: ' użytkownicy ', component: UsersListComponent },
    { path: ' polubienia', component: LikesComponent },
    { path: ' wiadomości', component: MessegesComponent },
    { path: ' **', redirectTo: ' home ', pathMatch: 'full' }
];
import { Routes } from '@angular/router';
import { CharacterDetailPage } from './pages/character-detail-page/character-detail-page';
import { CharactersListPage } from './pages/characters-list-page/characters-list-page';


export const routes: Routes = [

  // redirect iniziale
  {
    path: '',
    redirectTo: 'characters',
    pathMatch: 'full'
  },

  // lista personaggi
  {
    path: 'characters',
    component: CharactersListPage
  },

  // dettaglio personaggio
  {
    path: 'characters/:id',
    component: CharacterDetailPage
  },

  // fallback
  {
    path: '**',
    redirectTo: 'characters'
  }
];
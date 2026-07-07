import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { Character } from '../models/character.model';

@Injectable({
  providedIn: 'root'
})
export class CharacterService {

  // URL backend
  private apiUrl = 'https://special-goggles-9g6wppqg465299q4-5068.app.github.dev/characters';

  constructor(private http: HttpClient) {}

  /**
   * Recupera tutti i personaggi
   */
  getAllCharacters(): Observable<Character[]> {
    return this.http.get<Character[]>(this.apiUrl);
  }

  getCharacterById(id:string): Observable<Character[]> {
    return this.http.get<Character[]>(this.apiUrl + '/' + id);
  }
}
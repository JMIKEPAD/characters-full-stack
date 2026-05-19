import { Component, Input } from '@angular/core';
import { Character } from '../../../../models/character.model';

@Component({
  selector: 'app-character-sidebar',
  imports: [],
  templateUrl: './character-sidebar.html',
  styleUrl: './character-sidebar.css',
})
export class CharacterSidebar {
  @Input() character!: Character;

}

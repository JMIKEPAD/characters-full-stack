import {  ChangeDetectorRef,Component, OnInit } from '@angular/core';
import { Character } from '../../models/character.model';
import { CommonModule } from '@angular/common';
import { CharacterService } from '../../services/character.service';
import { Router, RouterModule, RouterOutlet } from '@angular/router';
import { ChangeDetectionStrategy } from '@angular/compiler';

@Component({
  selector: 'app-characters-list-page',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './characters-list-page.html',
  styleUrl: './characters-list-page.css',
})
export class CharactersListPage implements OnInit {


  public characters: Character[] = [];

  constructor(private characterService: CharacterService, private cd: ChangeDetectorRef, private route:Router) { }

  ngOnInit(): void {
    this.characterService.getAllCharacters().subscribe((res) => {
      this.characters = res;
      this.cd.detectChanges();
    });
  }

  public navigateToSelectedChar(id:number){
    this.route.navigate(['/characters/' + id]);
  }

  public getRarityClass(rarity: string): string {
    return rarity.toLowerCase();
  }
}

import { ChangeDetectorRef, Component } from '@angular/core';
import { ActivatedRoute, RouterLink, RouterOutlet } from '@angular/router';
import { CharacterService } from '../../services/character.service';
import { Character } from '../../models/character.model';
import { Weapon } from '../../models/weapon.model';
import { CharacterSidebar } from './components/character-sidebar/character-sidebar';
import { WeaponSkills } from './components/weapon-skills/weapon-skills';
import { WeaponSelector } from './components/weapon-selector/weapon-selector';

@Component({
  selector: 'app-character-detail-page',
  standalone: true,
  imports: [RouterLink, RouterOutlet, CharacterSidebar, WeaponSkills, WeaponSelector],
  templateUrl: './character-detail-page.html',
  styleUrl: './character-detail-page.css',
})
export class CharacterDetailPage {

  public character!: Character
  public selectedWeapon!: Weapon;
  constructor(
    private cd: ChangeDetectorRef,
    private route: ActivatedRoute,
    private characterService: CharacterService
  ) { }

  ngOnInit(): void {

    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.characterService.getCharacterById(id)
        .subscribe((data: any) => {
          this.character = data;
          console.log(this.character.weapons);
          
          this.selectedWeapon = this.character.weapons[0];
          this.cd.detectChanges();
        });
    }
  }

  onWeaponSelected(weapon: Weapon): void {
    this.selectedWeapon = weapon;
  }
}

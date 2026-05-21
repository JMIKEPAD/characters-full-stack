import { Component, Input } from '@angular/core';
import { Character } from '../../../../models/character.model';
import { Weapon } from '../../../../models/weapon.model';
import { SkillPanel } from '../skill-panel/skill-panel';

@Component({
  selector: 'app-weapon-skills',
  imports: [SkillPanel],
  templateUrl: './weapon-skills.html',
  styleUrl: './weapon-skills.css',
})
export class WeaponSkills {
  @Input() character!: Character;
  @Input() weapon!: Weapon;

  openedPanel = 'passive';

togglePanel(panel: string): void {

  if (this.openedPanel === panel) {
    return;
  }

  this.openedPanel = panel;

}
}

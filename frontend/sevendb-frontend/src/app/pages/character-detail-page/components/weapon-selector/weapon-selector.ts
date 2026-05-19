import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Weapon } from '../../../../models/weapon.model';

@Component({
  selector: 'app-weapon-selector',
  imports: [],
  templateUrl: './weapon-selector.html',
  styleUrl: './weapon-selector.css',
})
export class WeaponSelector {
  @Input() weapons!: Weapon[];
  @Input() selectedWeapon!: Weapon;

  @Output() weaponSelected = new EventEmitter<Weapon>();

  public selectWeapon(weapon: Weapon): void {
    this.weaponSelected.emit(weapon);
  }
}

import { Weapon } from './weapon.model';

export interface Character {
  id: number;

  rarity: string;

  linkPortrait: string;

  name: string;

  adventureSkillName: string;
  adventureSkillDescription: string;

  weapons: Weapon[];
}
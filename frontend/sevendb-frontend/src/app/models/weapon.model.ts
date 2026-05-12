import { SkillSet } from './skill-set.model';

export interface Weapon {
  name: string;
  element: string;
  skills: SkillSet;
}
export interface SkillSet {
  passiveName: string;
  passiveDescription: string;
  passiveStatusDescription: string;

  attackName: string;
  attackDescription: string;

  countdownSpecial: number;
  specialName: string;
  specialDescription: string;
  specialStatusDescription: string;

  countdownNormal: number;
  normalName: string;
  normalDescription: string;

  tagName: string;
  tagDescription: string;
  tagStatusDescription: string;

  countdownUltimate: number;
  usageMagicUltimate: number;
  ultimateName: string;
  ultimateDescription: string;
  ultimateStatusDescription: string;
}
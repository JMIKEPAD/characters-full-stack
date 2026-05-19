import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeaponSkills } from './weapon-skills';

describe('WeaponSkills', () => {
  let component: WeaponSkills;
  let fixture: ComponentFixture<WeaponSkills>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [WeaponSkills],
    }).compileComponents();

    fixture = TestBed.createComponent(WeaponSkills);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

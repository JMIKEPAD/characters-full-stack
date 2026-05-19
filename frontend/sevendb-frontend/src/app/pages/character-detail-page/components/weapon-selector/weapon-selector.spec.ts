import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeaponSelector } from './weapon-selector';

describe('WeaponSelector', () => {
  let component: WeaponSelector;
  let fixture: ComponentFixture<WeaponSelector>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [WeaponSelector],
    }).compileComponents();

    fixture = TestBed.createComponent(WeaponSelector);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

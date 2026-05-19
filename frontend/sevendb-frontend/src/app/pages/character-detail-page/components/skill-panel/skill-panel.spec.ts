import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillPanel } from './skill-panel';

describe('SkillPanel', () => {
  let component: SkillPanel;
  let fixture: ComponentFixture<SkillPanel>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SkillPanel],
    }).compileComponents();

    fixture = TestBed.createComponent(SkillPanel);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

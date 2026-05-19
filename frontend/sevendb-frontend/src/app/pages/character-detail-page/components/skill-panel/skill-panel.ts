import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-skill-panel',
  imports: [],
  templateUrl: './skill-panel.html',
  styleUrl: './skill-panel.css',
})
export class SkillPanel {
  @Input() title!: string;

  @Input() name!: string;

  @Input() description!: string;

  @Input() extraDescription?: string;

  isOpen = false;

  toggle(): void {
    this.isOpen = !this.isOpen;
  }

}

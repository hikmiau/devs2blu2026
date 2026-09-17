import { Component, input, computed } from '@angular/core';

@Component({
  selector: 'app-estrelas-card',
  templateUrl: './estrelas-card.html',
  styleUrl: './estrelas-card.css',
})
export class EstrelasCardComponent {
  readonly nota = input<number>(0);
  readonly maxEstrelas = 5;

  readonly notaValidada = computed(() => {
    const n = this.nota();
    return Math.max(0, Math.min(5, n));
  });

  obterEstrelas(): { cheia: boolean }[] {
    return Array.from({ length: this.maxEstrelas }, (_, i) => ({
      cheia: i < this.notaValidada(),
    }));
  }
}

import { Component, signal, computed } from '@angular/core';

@Component({
  selector: 'app-exercicio-2-contador',
  templateUrl: './exercicio-2-contador.html',
  styleUrl: './exercicio-2-contador.css',
})
export class Exercicio2ContadorComponent {
  readonly cliques = signal(0);

  readonly deveFicarVermelho = computed(() => this.cliques() >= 10);

  somar(): void {
    this.cliques.update(c => c + 1);
  }

  zerar(): void {
    this.cliques.set(0);
  }
}

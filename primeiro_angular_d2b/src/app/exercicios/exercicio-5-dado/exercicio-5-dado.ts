import { Component, signal, computed } from '@angular/core';

@Component({
  selector: 'app-exercicio-5-dado',
  templateUrl: './exercicio-5-dado.html',
  styleUrl: './exercicio-5-dado.css',
})
export class Exercicio5DadoComponent {
  readonly resultado = signal<number | null>(null);
  readonly totalRolagens = signal(0);
  readonly somaResultados = signal(0);

  readonly media = computed(() => {
    if (this.totalRolagens() === 0) return 0;
    return this.somaResultados() / this.totalRolagens();
  });

  rolar(): void {
    const numero = Math.floor(Math.random() * 6) + 1;
    this.resultado.set(numero);
    this.totalRolagens.update(t => t + 1);
    this.somaResultados.update(s => s + numero);
  }

  obterTextoResultado(): string {
    return this.resultado() === null ? '—' : this.resultado()!.toString();
  }
}

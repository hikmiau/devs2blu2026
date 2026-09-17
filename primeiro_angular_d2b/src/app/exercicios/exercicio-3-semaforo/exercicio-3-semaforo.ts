import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-3-semaforo',
  templateUrl: './exercicio-3-semaforo.html',
  styleUrl: './exercicio-3-semaforo.css',
})
export class Exercicio3SemaforoComponent {
  readonly cores = ['vermelho', 'amarelo', 'verde'];
  readonly indiceAtual = signal(0);

  proximaCor(): void {
    this.indiceAtual.update(i => (i + 1) % this.cores.length);
  }

  obterCor(): string {
    const coresMapa: { [key: string]: string } = {
      vermelho: '#dc3545',
      amarelo: '#ffc107',
      verde: '#28a745',
    };
    return coresMapa[this.cores[this.indiceAtual()]] || '#dc3545';
  }
}

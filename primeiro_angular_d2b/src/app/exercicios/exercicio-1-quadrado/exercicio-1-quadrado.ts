import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-1-quadrado',
  templateUrl: './exercicio-1-quadrado.html',
  styleUrl: './exercicio-1-quadrado.css',
})
export class Exercicio1QuadradoComponent {
  readonly tamanho = signal(100);

  aumentar(): void {
    this.tamanho.update(t => t + 10);
  }

  diminuir(): void {
    this.tamanho.update(t => t - 10);
  }

  resetar(): void {
    this.tamanho.set(100);
  }
}

import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-6-nome',
  templateUrl: './exercicio-6-nome.html',
  styleUrl: './exercicio-6-nome.css',
})
export class Exercicio6NomeComponent {
  readonly nome = signal('');

  aoDigitar(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.nome.set(input.value);
  }

  obterSaudacao(): string {
    return this.nome().trim() === '' ? 'Olá, visitante!' : `Olá, ${this.nome()}!`;
  }
}

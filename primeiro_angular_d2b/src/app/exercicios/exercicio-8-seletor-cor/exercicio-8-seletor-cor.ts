import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-8-seletor-cor',
  templateUrl: './exercicio-8-seletor-cor.html',
  styleUrl: './exercicio-8-seletor-cor.css',
})
export class Exercicio8SeletorCorComponent {
  readonly corSelecionada = signal('#007bff');

  aoMudarCor(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.corSelecionada.set(input.value);
  }
}

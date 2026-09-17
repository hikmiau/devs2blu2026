import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-7-barra-letra',
  templateUrl: './exercicio-7-barra-letra.html',
  styleUrl: './exercicio-7-barra-letra.css',
})
export class Exercicio7BarraLetraComponent {
  readonly tamanhoFonte = signal(16);

  aoMudarBarra(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.tamanhoFonte.set(Number(input.value));
  }
}

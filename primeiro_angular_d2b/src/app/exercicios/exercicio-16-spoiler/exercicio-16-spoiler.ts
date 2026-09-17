import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-16-spoiler',
  templateUrl: './exercicio-16-spoiler.html',
  styleUrl: './exercicio-16-spoiler.css',
})
export class Exercicio16SpoilerComponent {
  readonly mostrarResposta = signal(false);

  alternarResposta(): void {
    this.mostrarResposta.update(m => !m);
  }

  obterTextoBotao(): string {
    return this.mostrarResposta() ? 'Esconder' : 'Mostrar Resposta';
  }
}

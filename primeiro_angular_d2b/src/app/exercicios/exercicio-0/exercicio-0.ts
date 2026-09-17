import { Component, signal } from '@angular/core';
import { SeletorTemaComponent } from '../seletor-tema/seletor-tema';

@Component({
  selector: 'app-exercicio-0',
  templateUrl: './exercicio-0.html',
  styleUrl: './exercicio-0.css',
  imports: [SeletorTemaComponent],
})
export class Exercicio0Component {
  readonly temaSelecionado = signal<string>('claro');

  aoTemaEscolhido(tema: string): void {
    this.temaSelecionado.set(tema);
  }

  obterCorFundo(): string {
    const temas: { [key: string]: string } = {
      claro: '#ffffff',
      escuro: '#333333',
      azul: '#e3f2fd',
    };
    return temas[this.temaSelecionado()] || '#ffffff';
  }

  obterCorTexto(): string {
    return this.temaSelecionado() === 'claro' ? '#000000' : '#ffffff';
  }
}

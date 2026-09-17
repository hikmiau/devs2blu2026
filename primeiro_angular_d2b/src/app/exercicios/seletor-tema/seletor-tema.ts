import { Component, output } from '@angular/core';

@Component({
  selector: 'app-seletor-tema',
  templateUrl: './seletor-tema.html',
  styleUrl: './seletor-tema.css',
})
export class SeletorTemaComponent {
  readonly temaEscolhido = output<string>();

  escolherTema(tema: string): void {
    this.temaEscolhido.emit(tema);
  }
}

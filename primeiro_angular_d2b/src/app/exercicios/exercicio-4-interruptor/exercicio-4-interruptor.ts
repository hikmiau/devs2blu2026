import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-4-interruptor',
  templateUrl: './exercicio-4-interruptor.html',
  styleUrl: './exercicio-4-interruptor.css',
})
export class Exercicio4InterruptorComponent {
  readonly luzAcesa = signal(true);

  alternarLuz(): void {
    this.luzAcesa.update(l => !l);
  }

  obterTexto(): string {
    return this.luzAcesa() ? 'Apagar' : 'Acender';
  }
}

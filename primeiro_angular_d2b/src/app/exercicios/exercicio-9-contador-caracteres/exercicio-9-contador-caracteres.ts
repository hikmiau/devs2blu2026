import { Component, signal, computed } from '@angular/core';

@Component({
  selector: 'app-exercicio-9-contador-caracteres',
  templateUrl: './exercicio-9-contador-caracteres.html',
  styleUrl: './exercicio-9-contador-caracteres.css',
})
export class Exercicio9ContadorCaracteresComponent {
  readonly limite = 140;
  readonly texto = signal('');

  readonly caracteresRestantes = computed(
    () => this.limite - this.texto().length
  );

  readonly ultrapassouLimite = computed(() => this.texto().length > this.limite);

  aoDigitar(evento: Event): void {
    const input = evento.target as HTMLTextAreaElement;
    this.texto.set(input.value);
  }
}

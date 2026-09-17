import { Component, signal, computed } from '@angular/core';

@Component({
  selector: 'app-exercicio-10-espelho',
  templateUrl: './exercicio-10-espelho.html',
  styleUrl: './exercicio-10-espelho.css',
})
export class Exercicio10EspelhoComponent {
  readonly texto = signal('');

  readonly maiusculas = computed(() => this.texto().toUpperCase());

  readonly invertido = computed(() => 
    this.texto().split('').reverse().join('')
  );

  readonly numeroPalavras = computed(() => {
    const trimado = this.texto().trim();
    return trimado === '' ? 0 : trimado.split(/\s+/).length;
  });

  readonly numeroCaracteres = computed(() => 
    this.texto().replace(/\s/g, '').length
  );

  aoDigitar(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.texto.set(input.value);
  }
}

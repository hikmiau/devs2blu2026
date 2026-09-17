import { Component, signal, computed } from '@angular/core';

@Component({
  selector: 'app-exercicio-12-gorjeta',
  templateUrl: './exercicio-12-gorjeta.html',
  styleUrl: './exercicio-12-gorjeta.css',
})
export class Exercicio12GorjetaComponent {
  readonly valorConta = signal(0);
  readonly numeroPessoas = signal(1);
  readonly porcentagemGorjeta = signal(15);

  readonly valorGorjeta = computed(() => 
    this.valorConta() * (this.porcentagemGorjeta() / 100)
  );

  readonly totalComGorjeta = computed(() => 
    this.valorConta() + this.valorGorjeta()
  );

  readonly porPessoa = computed(() => {
    const pessoas = Math.max(1, this.numeroPessoas());
    return this.totalComGorjeta() / pessoas;
  });

  aoMudarConta(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.valorConta.set(Number(input.value));
  }

  aoMudarPessoas(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.numeroPessoas.set(Number(input.value));
  }

  aoMudarGorjeta(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.porcentagemGorjeta.set(Number(input.value));
  }
}

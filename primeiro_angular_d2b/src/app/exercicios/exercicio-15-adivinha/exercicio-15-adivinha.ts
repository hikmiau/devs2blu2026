import { Component, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-exercicio-15-adivinha',
  templateUrl: './exercicio-15-adivinha.html',
  styleUrl: './exercicio-15-adivinha.css',
})
export class Exercicio15AdinhaComponent implements OnInit {
  readonly numeroSecreto = signal(0);
  readonly chute = signal('');
  readonly mensagem = signal('');
  readonly tentativas = signal(0);
  readonly acertou = signal(false);
  readonly desistiu = signal(false);

  ngOnInit(): void {
    this.iniciarJogo();
  }

  iniciarJogo(): void {
    this.numeroSecreto.set(Math.floor(Math.random() * 100) + 1);
    this.chute.set('');
    this.mensagem.set('');
    this.tentativas.set(0);
    this.acertou.set(false);
    this.desistiu.set(false);
  }

  aoDigitar(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.chute.set(input.value);
  }

  chutar(): void {
    const valor = Number(this.chute());
    
    if (isNaN(valor)) {
      this.mensagem.set('Digite um número válido!');
      return;
    }

    this.tentativas.update(t => t + 1);

    if (valor === this.numeroSecreto()) {
      this.mensagem.set('🎉 Você acertou! Parabéns!');
      this.acertou.set(true);
    } else if (valor < this.numeroSecreto()) {
      this.mensagem.set('📈 O número é maior!');
    } else {
      this.mensagem.set('📉 O número é menor!');
    }
  }

  desistir(): void {
    this.desistiu.set(true);
    this.mensagem.set(`O número era ${this.numeroSecreto()}.`);
  }

  jogarNovamente(): void {
    this.iniciarJogo();
  }
}

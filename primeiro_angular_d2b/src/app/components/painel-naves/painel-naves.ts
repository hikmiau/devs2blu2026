import { Component, computed, OnInit, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CardNave } from '../nave/nave';

type Nave = {
  nome: string;
  combustivel: number;
  tripulacao: number;
};

@Component({
  imports: [FormsModule, CardNave],
  selector: 'app-painel-naves',
  styleUrl: './painel-naves.css',
  templateUrl: './painel-naves.html',
})
export class PainelNaves implements OnInit {
  naves = signal<Nave[]>([]);
  nomeNovo = signal('');
  combustivelNovo = signal(100);
  tripulacaoNova = signal(0);

  total = computed(() => this.naves().length);
  tripulacaoTotal = computed(() =>
    this.naves().reduce((total, nave) => total + nave.tripulacao, 0)
  );
  alerta = computed(() =>
    this.naves().some(nave => nave.combustivel < 20)
  );
  podeAtracar = computed(() =>
    this.nomeNovo().trim().length >= 3 &&
    this.combustivelNovo() >= 0 &&
    this.combustivelNovo() <= 100
  );

  ngOnInit(): void {
    this.naves.set([
      { nome: 'Aurora', combustivel: 85, tripulacao: 5 },
      { nome: 'Horizonte', combustivel: 45, tripulacao: 3 },
      { nome: 'Cometa', combustivel: 15, tripulacao: 0 },
    ]);
  }

  atracar(): void {
    if (!this.podeAtracar()) {
      return;
    }

    this.naves.update(naves => [
      ...naves,
      {
        nome: this.nomeNovo().trim(),
        combustivel: this.combustivelNovo(),
        tripulacao: this.tripulacaoNova(),
      },
    ]);
    this.nomeNovo.set('');
    this.combustivelNovo.set(100);
    this.tripulacaoNova.set(0);
  }
}

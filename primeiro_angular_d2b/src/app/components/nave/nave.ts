import { Component, computed, input } from '@angular/core';

@Component({
  selector: 'app-card-nave',
  styleUrl: './nave.css',
  templateUrl: './nave.html',
})
export class CardNave {
  nome = input.required<string>();
  combustivel = input(100);
  tripulacao = input(0);
  status = computed(() => {
    if (this.combustivel() > 60) {
      return 'pronta';
    }

    if (this.combustivel() >= 20) {
      return 'reabastecer';
    }

    return 'em terra';
  });

  corBarra = computed(() => {
    if (this.combustivel() > 60) {
      return 'green';
    }

    if (this.combustivel() >= 20) {
      return 'orange';
    }

    return 'red';
  });
}

import {Component, input} from '@angular/core';

@Component({
  imports: [],
  selector: 'app-nave',
  styleUrl: './nave.css',
  templateUrl: './nave.html',
})
export class Nave {
  nome = input.required<string>();
  combustivel = input(100);
  tripulacao = input(0);
}

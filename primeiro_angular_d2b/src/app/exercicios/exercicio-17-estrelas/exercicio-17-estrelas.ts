import { Component, signal } from '@angular/core';
import { EstrelasCardComponent } from '../estrelas-card/estrelas-card';

type Filme = {
  id: number;
  titulo: string;
  nota: number;
};

@Component({
  selector: 'app-exercicio-17-estrelas',
  templateUrl: './exercicio-17-estrelas.html',
  styleUrl: './exercicio-17-estrelas.css',
  imports: [EstrelasCardComponent],
})
export class Exercicio17EstrelasComponent {
  readonly filmes = signal<Filme[]>([
    { id: 1, titulo: 'Filme A', nota: 5 },
    { id: 2, titulo: 'Filme B', nota: 4 },
    { id: 3, titulo: 'Filme C', nota: 3 },
    { id: 4, titulo: 'Filme D', nota: 2 },
    { id: 5, titulo: 'Filme E', nota: 1 },
    { id: 6, titulo: 'Filme F', nota: 0 },
  ]);
}

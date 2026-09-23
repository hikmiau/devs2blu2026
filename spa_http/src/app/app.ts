import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListProduto } from './components/list-produto/list-produto';

@Component({
  imports: [RouterOutlet, ListProduto],
  selector: 'app-root',
  styleUrl: './app.css',
  templateUrl: './app.html',
})
export class App {
  protected readonly title = signal('spa_http');
}

import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Container } from './components/container/container';
import { Card } from './components/card/card';

@Component({
  imports: [RouterOutlet, Container, Card],
  selector: 'app-root',
  styleUrl: './app.css',
  templateUrl: './app.html',
})
export class App {
  protected readonly title = signal('projeto01');
  nome = "Seu zé"
  imagem = "https://images.unsplash.com/photo-1682685794700-1e7f5c3d8b6e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
  pessoas = [
    { nome: "João", idade: 25, pais: "Brasil" },
    { nome: "Maria", idade: 30, pais: "Portugal" },
    { nome: "El Pedro", idade: 28, pais: "Espanha" }
  ]

  mostrar(){
    this.imagem = "123"
  }
  oi(){
    return "Oiii"
  }
  
}

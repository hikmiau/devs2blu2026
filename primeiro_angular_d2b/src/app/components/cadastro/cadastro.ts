import { Component, Input, input, computed, signal, OnInit } from '@angular/core';
import { Pessoa } from '../../models/pessoa.model';
import { Card } from '../card/card';



@Component({
  imports: [Card],
  selector: 'app-cadastro',
  styleUrl: './cadastro.css',
  templateUrl: './cadastro.html',
})
export class Cadastro implements OnInit {

  nome = signal('');
  email = signal('');
  idade = signal(0);
  ativo = signal(true);

  

  pessoas = signal<Pessoa[]>([]);

  ngOnInit() {{
    this.pessoas.set([
        { nome: 'Ranny', email: 'ranny@example.com', idade: 25, ativo: true },
        { nome: 'Maria', email: 'maria@example.com', idade: 30, ativo: false },
        { nome: 'João', email: 'joao@example.com', idade: 35, ativo: true },
        { nome: 'Ana', email: 'ana@example.com', idade: 28, ativo: true }
      ]);
    }
  }

  total = computed(() => this.pessoas().length);

  podeCadastrar = computed(() => this.nome().length > 2 && this.email().includes('@') && this.idade() > 16);

  cadastrar(){
    this.pessoas.update(p => [
      ...p, 
      { 
        nome: this.nome(), 
        email: this.email(), 
        idade: this.idade(), 
        ativo: this.ativo() 
      }
    ]);
    this.limpar();
  }
  limpar(){
    this.nome.set('');
    this.email.set('');
    this.idade.set(0);
    this.ativo.set(true);
  }

}
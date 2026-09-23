import { Component, inject, OnInit, signal } from '@angular/core';
import { ProdutoService } from '../../services/produtoservice';
import { Produto } from '../../../models/produto.model';
@Component({
  imports: [],
  selector: 'app-list-produto',
  styleUrl: './list-produto.css',
  templateUrl: './list-produto.html',
})
export class ListProduto  implements OnInit{
  private service = inject(ProdutoService)
  produtos = signal<Produto[]>([])
  carregando = signal(true)
  erro = signal('')

  ngOnInit(): void {
    console.log(this.service.listar())

    this.service.listar().subscribe({
      next:(dados) =>{
          this.produtos.set(dados)
          this.carregando.set(false)
      },
      error:(err) =>{
          this.erro.set('NAO FOI POSSIVEL'+err.message)
          this.carregando.set(false)
      }
    });

    console.log(this.produtos().length)
  }

}

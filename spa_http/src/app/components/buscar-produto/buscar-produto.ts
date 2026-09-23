import {Component, inject, signal} from '@angular/core';
import {ProdutoService} from "../../services/produtoservice";
import {Produto} from "../../../models/produto.model";

@Component({
  imports: [],
  selector: 'app-buscar-produto',
  styleUrl: './buscar-produto.css',
  templateUrl: './buscar-produto.html',
})
export class BuscarProduto {
  private service = inject(ProdutoService)
  id = signal('1')
  produto = signal<Produto | undefined>(undefined)
  erro = signal('')
  carregando = signal(false)
  
  buscarPorId(){
    const numero = Numer(this.id())
    
    if(!this.id().trim()){
      this.erro.set('Digite um ID')
      this.produto.set(undefined)
      return
    }
    if(isNaN(numero) || numero <= 0){
      this.erro.set('O id precisa ser um numero positivo')
      this.produto.set(undefined)
      return
    }
    this.erro.set('')
    this.produto.set(undefined)
    this.carregando.set(true)
    
    this.service.buscarPorId(numero).subscribe({
      next: (p) => {
        if (!p) this.erro.set('Produto não encontrado')
        else this.produto.set(p)
        this.carregando.set(false)
      },
      error: (err) => {
        this.erro.set('Erro ao buscar produto: ' + err.message)
        this.carregando.set(false)
      }
    })
  }
}
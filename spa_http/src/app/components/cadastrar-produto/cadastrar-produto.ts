import {Component, inject, signal} from "@angular/core";
import {Produto} from "../../../models/produto.model";
import {ProdutoService} from "../../services/produtoservice";

type NovoProduto = Omit<Produto, 'id'>

function produtoVazio(): NovoProduto {
  return {
    title: '',
    price: 0,
    description: '',
    category: '',
    image: '',
    rating:{
      rate:0,
      count:0
    }
  }
}

@Component({
  imports: [],
  selector: "app-cadastrar-produto",
  styleUrl: "./cadastrar-produto.css",
  templateUrl: "./cadastrar-produto.html",
})
export class CadastrarProduto {
  private service = inject(ProdutoService)
  
  dados = signal<NovoProduto>(produtoVazio())
  salvando = signal(false)
  erro = signal('')
  sucesso = signal<number | undefined>(undefined)
  
  podeSalvar(){
    return this.dados().title.trim().length > 2 && this.dados().price > 0
  }
  alterar<K extends keyof NovoProduto>(campo: K, valor: NovoProduto[K]) {
    this.dados.update(d => ({ ...d, [campo]: valor }))
  }
  salvar() {
    if (!this.podeSalvar()) {
      return;
    }

    this.salvando.set(true);
    this.erro.set('');
    this.sucesso.set(undefined);

    this.service.criar(this.dados()).subscribe({
      next: (id) => {
        this.salvando.set(false);
        this.sucesso.set(id);
      },
      error: (err) => {
        this.salvando.set(false);
        this.erro.set(err.message);
      }
    });
  }
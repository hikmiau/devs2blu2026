import { HttpClient } from '@angular/common/http';
import { inject, Service } from '@angular/core';
import { Produto } from '../../models/produto.model';
import { Observable } from 'rxjs';

@Service()
export class ProdutoService {
    private http = inject(HttpClient)
    private url = 'https://fakestoreapi.com/products'

    listar(){
        return this.http.get<Produto[]>(this.url)
    }
    buscarPorId(id:number){
        return this.http.get<Produto>(`${this.url}/${id}`)
    }
    criar(produto: Omit<Produto, 'id'>){
        return this.http.post<Produto>(this.url, produto)
    }
}

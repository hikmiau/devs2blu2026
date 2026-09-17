import { Component, signal } from '@angular/core';
import { ItemTarefa } from '../item-tarefa/item-tarefa';

@Component({
  imports: [ItemTarefa],
  selector: 'app-lista-tarefas',
  styleUrl: './lista-tarefas.css',
  templateUrl: './lista-tarefas.html',
})
export class ListaTarefas {
  readonly tarefas = signal([
    { id: 1, titulo: 'Dormir bem hoje' },
    { id: 2, titulo: 'Lavar a louça hoje' },
    { id: 3, titulo: 'Fazer o almoço hoje' },
  ]);

  readonly ultimaConcluida = signal<string>('');

  aoConcluirTarefa(idRecebido: number): void {
    const tarefaConcluida = this.tarefas()
      .find(tarefa => tarefa.id === idRecebido);

    if (tarefaConcluida) {

      this.ultimaConcluida.set(tarefaConcluida.titulo);

      this.tarefas.update(tarefas =>
        tarefas.filter(tarefa => tarefa.id !== idRecebido));
    }

  }
}

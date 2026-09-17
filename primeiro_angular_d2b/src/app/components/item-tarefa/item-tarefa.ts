import { Component, input, output } from '@angular/core';
import { Tarefa } from '../../models/tarefa.model';

@Component({
  imports: [],
  selector: 'app-item-tarefa',
  styleUrl: './item-tarefa.css',
  templateUrl: './item-tarefa.html',
})
export class ItemTarefa {
    readonly tarefa = input.required<Tarefa>();

    readonly tarefaConcluida = output<number>();

    concluir():void{
      this.tarefaConcluida.emit(this.tarefa().id);
    }
}

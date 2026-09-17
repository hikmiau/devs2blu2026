import { Component, EventEmitter, Input, Output } from "@angular/core";
import { Pessoa } from "../../models/pessoa.model";


@Component({
    selector: 'app-card',
    templateUrl: './card.html',
    styleUrls: ['./card.css']
})
export class Card {
    @Input() pessoa!: Pessoa;
    @Output() onDelete: any;

  
}
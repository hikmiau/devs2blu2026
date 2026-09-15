import { Component, Input } from "@angular/core";

@Component({
    selector: 'app-card',
    templateUrl: './card.html',
    styleUrls: ['./card.css']
})
export class Card{
    @Input() nome: string = "";
    @Input() idade!: number;
    @Input() pais: string = "";
}
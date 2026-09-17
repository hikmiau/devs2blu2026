import { Component, signal, computed } from '@angular/core';

@Component({
  selector: 'app-exercicio-11-temperatura',
  templateUrl: './exercicio-11-temperatura.html',
  styleUrl: './exercicio-11-temperatura.css',
})
export class Exercicio11TemperaturaComponent {
  readonly celsius = signal(0);

  readonly fahrenheit = computed(() => 
    (this.celsius() * 9/5) + 32
  );

  readonly kelvin = computed(() => 
    this.celsius() + 273.15
  );

  readonly descricao = computed(() => {
    const temp = this.celsius();
    if (temp < 0) return 'Congelando';
    if (temp < 15) return 'Frio';
    if (temp < 25) return 'Agradável';
    return 'Quente';
  });

  aoMudarTemperatura(evento: Event): void {
    const input = evento.target as HTMLInputElement;
    this.celsius.set(Number(input.value));
  }
}

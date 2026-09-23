import { ComponentFixture, TestBed } from '@angular/core/testing';
import { BuscarProduto } from './buscar-produto';

describe('BuscarProduto', () => {
  let component: BuscarProduto;
  let fixture: ComponentFixture<BuscarProduto>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BuscarProduto]
    })
      .compileComponents();

    fixture = TestBed.createComponent(BuscarProduto);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ListProduto } from './list-produto';

describe('ListProduto', () => {
  let component: ListProduto;
  let fixture: ComponentFixture<ListProduto>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListProduto],
    }).compileComponents();

    fixture = TestBed.createComponent(ListProduto);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

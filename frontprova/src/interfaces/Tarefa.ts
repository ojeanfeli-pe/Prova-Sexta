import { Categoria } from './Categoria';
export interface Tarefa {
    Tarefaid?: string;
    Titulo: string;
    Descricao: string;
    criadoEm?: string;
    categoria?: string;
    CategoriaId?: string;
    Status: string;
  }
  
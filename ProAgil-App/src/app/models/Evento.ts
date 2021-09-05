import { Lote } from './Lote';
import { RedeSocial } from './RedeSocial';
import { Palestrante } from './Palestrante';

export interface Evento {
  eventoId: number;
  local: string;
  dataEvento: Date;
  tema: string;
  qtdPessoas: number;
  imagemURL: string;
  telefone: string;
  email: string;
  //lotes: Lote[];
  lote: string;
  redesSociais: RedeSocial[];
  palestrantesEventos: Palestrante[];
}

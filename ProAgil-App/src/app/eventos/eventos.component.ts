import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any;
  /** = [
    {
      EventoId: 1,
      Tema: 'Angular',
      Local: 'Belo Horizonte',
      QtdPessoas: 333,
      Lote: '1º lote'
    },
    {
      EventoId: 2,
      Tema: '.NET Core',
      Local: 'São Paulo',
      QtdPessoas: 222,
      Lote: '2º lote'
    },
    {
      EventoId: 3,
      Tema: 'React',
      Local: 'Rio de Janeiro',
      QtdPessoas: 111,
      Lote: '3º lote'
    }
  ]; */

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

  getEventos() {
    this.http.get('http://localhost:5000/api/Evento').subscribe(response => {
      this.eventos = response;
    }, error => {
      console.log(error);
    });
  }

}

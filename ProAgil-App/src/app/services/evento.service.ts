import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EventoService {

  baseUrl = 'http://localhost:5000/api/Evento';

  constructor(private http: HttpClient) { }

  getEventos() {
    return this.http.get(this.baseUrl);
  }

}

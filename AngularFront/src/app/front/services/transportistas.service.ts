import { Observable } from 'rxjs'
import { Injectable } from '@angular/core';
import { HttpBackend, HttpClient, HttpClientJsonpModule, HttpClientModule } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/Shipper';

@Injectable({
  providedIn: 'root'
})
export class TransportistasService {

  endpoint: string = 'Shipper';

  constructor(private hhtp: HttpClient) { }

  public obtenerTransportista(id: String): Observable<Shipper> {
    let url = environment.apiShippers + this.endpoint + "/" + id;
    return this.hhtp.get<Shipper>(url);
  }

  public obtenerTransportistas(): Observable<Array<Shipper>> {
    let url = environment.apiShippers + this.endpoint;
    return this.hhtp.get<Array<Shipper>>(url);
  }

  public agregarTransportista(s: Shipper): Observable<any> {
    let url = environment.apiShippers + this.endpoint;
    return this.hhtp.post(url, s);
  }

  public borrarTransportista(id: String): Observable<any> {
    let url = environment.apiShippers + this.endpoint + "/" + id;
    return this.hhtp.delete(url);
  }

  public actualizarTransportista(id: String, s:Shipper): Observable<any> {
    let url = environment.apiShippers + this.endpoint + "/" + id; 
    return this.hhtp.put(url,s);
  }
}

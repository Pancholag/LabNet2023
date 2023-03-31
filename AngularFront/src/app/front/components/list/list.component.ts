import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute } from '@angular/router';
import { Observer } from 'rxjs';
import { Shipper } from '../../models/Shipper';
import { TransportistasService } from '../../services/transportistas.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css'],
})
export class ListComponent implements OnInit {

  public listaTransportista: Array<Shipper> = [];

  constructor(private transportistaService : TransportistasService, private snack: MatSnackBar, private rutaActiva: ActivatedRoute) { }

  ngOnInit(): void {
    this.obtenerTransportistas();
    let msg = this.rutaActiva.snapshot.params['message']
    if(msg != ''){
      this.ejecutarSnack(msg);
    }
  }

  obtenerTransportistas() {
    this.transportistaService.obtenerTransportistas().subscribe(res => {
      this.listaTransportista = res;
    },
    err => {
      this.ejecutarSnack(err.error.Message)
    })
  }

  ejecutarSnack(message: String){
    
    this.snack.open(message.toString(),"OK",{
      horizontalPosition:'right',
      panelClass: ['mat-toolbar', 'mat-primary']
    });
  }

}

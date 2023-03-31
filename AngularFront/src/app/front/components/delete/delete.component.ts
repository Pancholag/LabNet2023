import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Shipper } from '../../models/Shipper';
import { TransportistasService } from '../../services/transportistas.service';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {

  public s: Shipper = new Shipper();
  public str: string = '';

  constructor(private transportistaService : TransportistasService, private rutaActiva: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.obtenerTransportista(this.rutaActiva.snapshot.params['id'])
  }

  obtenerTransportista (id: string) {
    this.transportistaService.obtenerTransportista(id).subscribe(res =>{
      this.s = res;
      this.str = res.ShipperID.toString();
    },
    err => {this.router.navigate(['list/'+err.error.Message.toString()])})
  }
  borrarTransportista(id: string){
    this.transportistaService.borrarTransportista(id).subscribe(
      res => {this.router.navigate(["list/Transportista borrado con exito"])},
      err => {this.router.navigate(['list/'+err.error.Message.toString()])}
    )
  }
}

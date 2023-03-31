import { Component, OnInit } from '@angular/core';
import { Shipper } from '../../models/Shipper';
import { TransportistasService } from '../../services/transportistas.service';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Observer } from 'rxjs/internal/types';

@Component({
  selector: 'app-get',
  templateUrl: './get.component.html',
  styleUrls: ['./get.component.css']
})
export class GetComponent implements OnInit {

  public s: Shipper = new Shipper();
  private aux: string = "";

  obs: Observer<Shipper> = {
    next: x =>{
      this.s = x;
    },
    error: err =>{
      this.aux= err.error.Message
      this.router.navigate(['list/'+this.aux.toString()])
    },
    complete: () =>{}
  }

  constructor(private transportistaService : TransportistasService, private rutaActiva: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.obtenerTransportista(this.rutaActiva.snapshot.params['id'])
  }

  obtenerTransportista (id: string) {
    this.transportistaService.obtenerTransportista(id).subscribe(this.obs)
  }
}

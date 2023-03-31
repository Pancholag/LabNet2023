import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Shipper } from '../../models/Shipper';
import { TransportistasService } from '../../services/transportistas.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  public formTransportista!: FormGroup
  public s: Shipper = new Shipper();
  public str: string = '';

  constructor(private transportistaService : TransportistasService, private rutaActiva: ActivatedRoute, private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {
    this.obtenerTransportista(this.rutaActiva.snapshot.params['id'])
    this.formTransportista = this.fb.group({
      CompanyName: [this.s.CompanyName, Validators.required],
      Phone: [this.s.Phone]
  })
  }

  obtenerTransportista (id: string) {
    this.transportistaService.obtenerTransportista(id).subscribe(res =>{
      this.s = res;
      this.str = res.ShipperID.toString();
    },
    err => {this.router.navigate(['list/'+err.error.Message.toString()])})
  }

  actualizarTransportista(id: string){
    var aux = new Shipper();
    let companyName = this.formTransportista.get("CompanyName")?.value
    let phone = this.formTransportista.get("Phone")?.value

    aux.CompanyName = companyName != null ? companyName : this.s.CompanyName
   
    aux.Phone = phone != null ? phone : this.s.Phone

    this.transportistaService.actualizarTransportista(id,aux).subscribe({
      next: x =>{
        this.router.navigate(["list/Transportista actualizado con exito"])
      },
      error: err =>{
        this.router.navigate(['list/'+err.error.Message.toString()])
      },
      complete: () =>{}
    }
    )
  }

  get CompanyName(){
    return this.formTransportista.get('CompanyName')
  }
}

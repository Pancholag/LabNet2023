import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Shipper } from '../../models/Shipper';
import { TransportistasService } from '../../services/transportistas.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {

  public formTransportista!: FormGroup

  constructor(private formBuild: FormBuilder, private transportistaServicio: TransportistasService, private router: Router) { }

  ngOnInit(): void {
    this.initForm()
  }
  initForm(){
    this.formTransportista = this.formBuild.group({
      CompanyName: ['', Validators.required],
      Phone: ''
    })
  }

  agregarTransportista(){
    var s = new Shipper();
    s.CompanyName = this.formTransportista.get("CompanyName")?.value;
    s.Phone = this.formTransportista.get("Phone")?.value;
    console.log(s);
    this.transportistaServicio.agregarTransportista(s).subscribe(
      res =>{this.router.navigate(["list/Transportista agregado con exito"])},
      err => {this.router.navigate(['list/'+err.error.Message.toString()])});
  }

  get CompanyName(){
    return this.formTransportista.get('CompanyName')
  }
}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './components/list/list.component';
import { GetComponent } from './components/get/get.component';
import { AddComponent } from './components/add/add.component';
import { UpdateComponent } from './components/update/update.component';
import { DeleteComponent } from './components/delete/delete.component';
import { MatSlideToggleModule  } from '@angular/material/slide-toggle'
import { HttpClientModule } from '@angular/common/http';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ListComponent,
    GetComponent,
    AddComponent,
    UpdateComponent,
    DeleteComponent,
  ],
  imports: [
    CommonModule,
    MatSlideToggleModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatSnackBarModule,
  ]
})

export class FrontModule { }
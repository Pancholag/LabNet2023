import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './front/components/add/add.component';
import { DeleteComponent } from './front/components/delete/delete.component';
import { GetComponent } from './front/components/get/get.component';

import { ListComponent } from './front/components/list/list.component';
import { UpdateComponent } from './front/components/update/update.component';


const routes: Routes = [
  {
    path: '',
    component: ListComponent
  },
  {
  path: 'list/:message',
  component: ListComponent
 },
 {
  path: 'add',
  component: AddComponent
 },
 {
  path: 'get/:id',
  component: GetComponent
 },
 {
  path: 'delete/:id',
  component: DeleteComponent
 },
 {
  path: 'update/:id',
  component: UpdateComponent
 }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

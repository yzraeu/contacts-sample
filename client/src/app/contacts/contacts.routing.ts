import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { ListComponent } from './list/list.component';
import { DetailComponent } from './detail/detail.component';
import { FormComponent } from './form/form.component';

const contactsRoutes: Routes = [
  { path: '', component: ListComponent },
  { path: 'new', component: FormComponent },
  { path: ':id', component: DetailComponent },
  { path: ':id/edit', component: FormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(contactsRoutes)],
  exports: [RouterModule]
})
export class ContactsRoutingModule {}

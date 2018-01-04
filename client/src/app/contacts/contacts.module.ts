import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactsService } from './contacts.service';

import { ListComponent } from './list/list.component';
import { FormComponent } from './form/form.component';
import { DetailComponent } from './detail/detail.component';

import { ContactsRoutingModule } from './contacts.routing';

@NgModule({
  imports: [CommonModule, ContactsRoutingModule],
  declarations: [ListComponent, FormComponent, DetailComponent],
  providers: [ContactsService]
})
export class ContactsModule {}

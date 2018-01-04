import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactsService } from './contacts.service';

import { ListComponent } from './list/list.component';
import { FormComponent } from './form/form.component';

@NgModule({
  imports: [CommonModule],
  declarations: [ListComponent, FormComponent],
  providers: [ContactsService]
})
export class ContactsModule {}

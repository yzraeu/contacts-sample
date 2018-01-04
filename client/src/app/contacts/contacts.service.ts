import { Injectable } from '@angular/core';
import { Contact } from './contact';

@Injectable()
export class ContactsService {
  contacts: Contact[];

  constructor() {}

  getAll(): Contact[] {
    return this.contacts;
  }

  get(id: number) {}

  add(contact: Contact) {}

  update(id: number, contact: Contact) {}

  remove(id: number) {}
}

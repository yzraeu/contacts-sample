import { Component, OnInit } from '@angular/core';

import { Contact } from '../contact';
import { ContactsService } from '../contacts.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  contacts: Contact[];

  constructor(private contactsService: ContactsService) {}

  ngOnInit() {
    this.loadContacts();
  }

  loadContacts() {
    this.contactsService.getAll().subscribe(c => {
      this.contacts = c;
      console.log(c);
    });
  }

  removeContact(id: number) {
    console.log('remove: ' + id);
  }
}

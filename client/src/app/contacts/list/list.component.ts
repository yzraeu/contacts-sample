import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Contact } from '../contact';
import { ContactsService } from '../contacts.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  contacts: Contact[];

  constructor(
    private contactsService: ContactsService,
    private route: Router
  ) {}

  ngOnInit() {
    this.loadContacts();
  }

  loadContacts() {
    this.contactsService.getAll().subscribe(c => {
      this.contacts = c;
    });
  }

  removeContact(id: number) {
    this.contactsService.remove(id).subscribe(c => {
      this.loadContacts();
    });
  }
}

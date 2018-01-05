import { Component, OnInit } from '@angular/core';
import { Contact } from '../contact';
import { ContactsService } from '../contacts.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit {
  contact: Contact;

  constructor(
    private contactsService: ContactsService,
    private activatedRoute: ActivatedRoute,
    private route: Router
  ) {}

  ngOnInit() {
    this.loadContact();
  }

  loadContact() {
    this.contact = new Contact();
    const contactId = this.activatedRoute.snapshot.params.id;

    this.contactsService.get(contactId).subscribe(c => (this.contact = c));
  }

  removeContact(id: number) {
    this.contactsService
      .remove(id)
      .subscribe(c => this.route.navigate(['contacts']));
  }
}

import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { ContactsService } from '../contacts.service';
import { Contact } from '../contact';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  form: FormGroup;

  constructor(
    private contactsService: ContactsService,
    private formBuilder: FormBuilder,
    private route: Router
  ) {}

  ngOnInit() {
    this.form = this.formBuilder.group({
      firstName: [null, [Validators.required, Validators.minLength(2)]],
      lastName: [null, [Validators.required, Validators.minLength(2)]],
      dateOfBirth: [null, Validators.required]
    });
  }

  applyErrorClass(controlName) {
    return {
      'is-invalid':
        !this.form.get(controlName).valid && this.form.get(controlName).touched
    };
  }

  onSubmit() {
    if (!this.form.valid) {
      return;
    }

    const values = this.form.value;
    const contact = new Contact();
    contact.FirstName = values.firstName;
    contact.LastName = values.lastName;
    contact.DateOfBirth = values.dateOfBirth;

    this.contactsService.add(contact).subscribe(
      c => {
        this.form.reset();
        this.route.navigate(['contacts']);
      },
      (error: any) => {
        console.error(error);
        alert('Error persisting data. Please try again');
      }
    );
  }
}

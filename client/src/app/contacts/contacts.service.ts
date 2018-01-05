import { Injectable } from '@angular/core';
import { Contact } from './contact';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

@Injectable()
export class ContactsService {
  private _apiUrl = 'http://localhost:64770/api/contacts/';

  constructor(private http: Http) {}

  getAll(): Observable<Contact[]> {
    return this.http
      .get(this._apiUrl)
      .map(d => <Contact[]>d.json())
      .catch(this.handleError);
  }

  get(id: number): Observable<Contact> {
    return this.http
      .get(this._apiUrl + id)
      .map(d => <Contact>d.json())
      .catch(this.handleError);
  }

  add(contact: Contact) {}

  update(id: number, contact: Contact) {}

  remove(id: number): Observable<Response> {
    return this.http
      .delete(this._apiUrl + id)
      .catch(this.handleError);
  }

  handleError(error: Response) {
    console.error(error);
    return Observable.throw(error.json().error || 'Server error');
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class FieldService {
  constructor(private http: HttpClient) {}

  getField() {
    return this.http.get('server/api/fields', { responseType: 'json' });
  }
}

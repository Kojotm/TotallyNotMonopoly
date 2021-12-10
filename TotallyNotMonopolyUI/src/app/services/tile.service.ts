import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TileService {

  isActive: boolean = false;

  constructor(private http: HttpClient) {}

  getDetails(id: number) {
    return this.http.get('server/api/fields/details/' + id, { responseType: 'json' });
  }

  setIsActive(bool: boolean) {
    this.isActive = bool;
  }

  getIsActive() {
    return this.isActive;
  }
}

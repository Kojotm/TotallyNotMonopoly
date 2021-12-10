import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CardService {
  constructor(private http: HttpClient) {}

  getFortuneCard() {
    return this.http.get('server/api/cards/fortune', { responseType: 'json' });
  }

  getChanceCard() {
    return this.http.get('server/api/cards/chance', { responseType: 'json' });
  }
}

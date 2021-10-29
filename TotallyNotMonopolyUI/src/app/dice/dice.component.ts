import { Component, OnInit } from '@angular/core';
import { Subject, timer } from 'rxjs';

import {
  trigger,
  state,
  style,
  animate,
  transition
} from '@angular/animations';

import { filter, map, switchMap, tap, take } from 'rxjs/operators'

@Component({
  selector: 'app-dice',
  templateUrl: './dice.component.html',
  styleUrls: ['./dice.component.scss']
})
export class DiceComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  rolling = false;
  selectedRollCount = 1;
  selectedType = 4;
  start$ = new Subject();

  roller$ = this.start$
    .pipe(
      switchMap(max => {
        return timer(0, 50).pipe(take(10), map(_ => {
          let total = 0;
          for(let i = 0; i < this.selectedRollCount; i++){
            total += this.calcRoll(6);
          }
          return total
        }))
      })
    )

  calcRoll(max: number){
    const min = 1;
    return Number((Math.random() * (max - min) + min).toFixed(0));
  }

  start(max: number){
    this.selectedType = max;
    this.start$.next(max);
  }

}

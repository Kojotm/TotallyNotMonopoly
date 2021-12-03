import { Component, OnInit } from '@angular/core';
import { Subject, timer } from 'rxjs';

import {
  trigger,
  state,
  style,
  animate,
  transition,
} from '@angular/animations';

import { filter, map, switchMap, tap, take } from 'rxjs/operators';
import { GameTableComponent } from '../game-table/game-table.component';
import { async } from '@angular/core/testing';

@Component({
  selector: 'app-dice',
  templateUrl: './dice.component.html',
  styleUrls: ['./dice.component.scss'],
})
export class DiceComponent implements OnInit {
  public roll: number[];
  constructor(private gameTableComponent: GameTableComponent) {
    this.roll = [];
  }

  ngOnInit(): void {
    this.rolled = false;
  }

  rolled = false;
  selectedRollCount = 1;
  selectedType = 2;
  start$ = new Subject();

  roller$ = this.start$.pipe(
    switchMap((max) => {
      this.rolled = true;
      let rolls = timer(0, 50).pipe(
        take(10),
        map(() => {
          let dice1 = this.calcRoll(this.selectedType);
          let dice2 = this.calcRoll(this.selectedType);
          this.roll.push(dice1);
          this.roll.push(dice2);
          this.movePlayer();
          return [dice1, dice2];
        })
      );
      return rolls;
    })
  );

  calcRoll(max: number): number {
    const min = 1;
    let number = Number((Math.random() * (max - min) + min).toFixed(0));
    return number;
  }

  start(max: number) {
    this.roll = [];
    this.selectedType = max;
    this.start$.next(max);
  }
  movePlayer() {
    if (this.roll.length === 20)
      this.gameTableComponent.movePlayer(this.roll.slice(18));
  }
}

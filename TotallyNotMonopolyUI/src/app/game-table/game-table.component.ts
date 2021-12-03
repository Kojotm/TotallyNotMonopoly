import { Component, Inject, OnInit } from '@angular/core';
import { FieldService } from '../services/field.service';

export interface Tile {
  name: string;
  color: string;
  img: string;
  cols: number;
  rows: number;
  text: string;
}
export interface Player {
  number: number;
  money: number;
  position: number;
  properties: string[];
}
export interface Property {
  name: string;
  price: number[];
  level: number;
}

@Component({
  selector: 'app-game-table',
  templateUrl: './game-table.component.html',
  styleUrls: ['./game-table.component.scss'],
})
export class GameTableComponent implements OnInit {
  public activeTurn: boolean;
  public activePlayer: Player;
  public activePlayerIndex: number;
  public rolled: boolean;
  tiles: Tile[] = [];

  players: Player[] = [
    {
      number: 1,
      money: 505000,
      position: 0,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
    {
      number: 2,
      money: 5000000,
      position: 0,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
    {
      number: 3,
      money: 500000,
      position: 0,
      properties: ['Property 2', 'Property 3'],
    },
    {
      number: 4,
      money: 5000000,
      position: 0,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
  ];
  private leftcolTiles: Tile[] = [];
  private topRowTiles: Tile[] = [];
  private rightColTiles: Tile[] = [];
  private bottomRowTiles: Tile[] = [];

  constructor(private fieldService: FieldService) {
    this.getTilesFromBE();
    this.fillTableWithTiles();
    this.activePlayerIndex = 0;
    this.activePlayer = this.players[this.activePlayerIndex];
    this.activeTurn = true;
    this.rolled = false;
  }

  ngOnInit(): void {
    this.fieldService.getField().subscribe((response) => {
      console.log(response);
    });
  }

  openUpgradesMenu(number: number) {
    console.log('Player ' + number + "'s upgrade menu");
    let player: Player = this.players[number - 1];
  }

  getTilesFromBE() {
    //Here will be the request.toPromise, but for now just filled manually.
    this.leftcolTiles = [];
    this.topRowTiles = [];
    this.rightColTiles = [];
    this.bottomRowTiles = [];
    for (let i = 0; i < 9; i++) {
      this.leftcolTiles.push({
        name: 'left col tile',
        color: 'grey',
        img: '',
        cols: 2,
        rows: 1,
        text: 'This is a left-col tile.',
      });
      this.topRowTiles.push({
        name: 'top row tile',
        color: 'grey',
        img: '',
        cols: 1,
        rows: 2,
        text: 'This is a top-row tile.',
      });
      this.rightColTiles.push({
        name: 'right col tile',
        color: 'grey',
        img: '',
        cols: 2,
        rows: 1,
        text: 'This is a right-col tile.',
      });
      this.bottomRowTiles.push({
        name: 'bottom row tile',
        color: 'grey',
        img: '',
        cols: 1,
        rows: 2,
        text: 'This is a bottom-row tile.',
      });
    }
  }
  fillTableWithTiles() {
    this.tiles.push({
      name: 'top-left',
      color: 'rgb(82, 80, 80)',
      img: "url('../../assets/jail-tile.png')",
      cols: 2,
      rows: 2,
      text: '',
    });
    this.topRowTiles.forEach((tile) => this.tiles.push(tile));
    this.tiles.push({
      name: 'top-right',
      color: 'rgb(82, 80, 80)',
      img: "url('../../assets/parking-tile.png')",
      cols: 2,
      rows: 2,
      text: '',
    });
    for (let i = 0; i < 9; i++) {
      this.tiles.push(this.leftcolTiles[i]);
      for (let j = 0; j < 9; j++) {
        this.tiles.push({
          name: 'filler',
          color: 'white',
          img: '',
          cols: 1,
          rows: 1,
          text: '',
        });
      }
      this.tiles.push(this.rightColTiles[i]);
    }
    this.tiles.push({
      name: 'bottom-left',
      color: 'rgb(82, 80, 80)',
      img: "url('../../assets/start-tile.png')",
      cols: 2,
      rows: 2,
      text: '',
    });
    this.bottomRowTiles.forEach((tile) => this.tiles.push(tile));
    this.tiles.push({
      name: 'bottom-right',
      color: 'rgb(82, 80, 80)',
      img: "url('../../assets/go-to-jail-tile.png')",
      cols: 2,
      rows: 2,
      text: '',
    });
  }
  public upgradeBtn(index: number) {
    console.log('Upgrade: ' + this.activePlayer.properties[index]);
  }
  public nextPlayer() {
    this.activePlayerIndex =
      this.activePlayerIndex + 1 === 4 ? 0 : this.activePlayerIndex + 1;
    this.activePlayer = this.players[this.activePlayerIndex];
    this.rolled = false;
    this.activeTurn = false;
  }
  public rollDice() {
    let dice_one = Math.floor(Math.random() * 6 + 1);
    let dice_two = Math.floor(Math.random() * 6 + 1);
    console.log('Rolled: ', dice_one, '+', dice_two, '=', dice_one + dice_two);
    this.rolled = true;
  }
  movePlayer(roll: any[]) {
    let totalRoll = ((roll[0] as number) + roll[1]) as number;
    this.activePlayer.position =
      this.activePlayer.position + totalRoll >= 40
        ? this.activePlayer.position + totalRoll - 40
        : this.activePlayer.position + totalRoll;
    console.log(this.activePlayer.position);
  }
}

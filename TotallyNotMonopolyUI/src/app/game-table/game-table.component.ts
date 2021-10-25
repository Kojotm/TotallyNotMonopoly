import { ArrayType } from '@angular/compiler';
import { Component, Inject, OnInit } from '@angular/core';
import {
  MatDialog,
  MatDialogRef,
  MAT_DIALOG_DATA,
} from '@angular/material/dialog';

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
  tiles: Tile[] = [];

  players: Player[] = [
    {
      number: 1,
      money: 505000,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
    {
      number: 2,
      money: 5000000,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
    { number: 3, money: 500000, properties: ['Property 2', 'Property 3'] },
    {
      number: 4,
      money: 5000000,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
  ];
  private leftcolTiles: Tile[] = [];
  private topRowTiles: Tile[] = [];
  private rightColTiles: Tile[] = [];
  private bottomRowTiles: Tile[] = [];

  constructor(public dialog: MatDialog) {
    this.getTilesFromBE();
    this.fillTableWithTiles();
  }

  ngOnInit(): void {}

  openUpgradesMenu(number: number) {
    console.log('Player ' + number + "'s upgrade menu");
    let player: Player = this.players[number - 1];
    console.log(player);
    const dialogRef = this.dialog.open(UpgradeMenuDialog, {
      width: '40%',
      data: player,
    });
    // this.dialog.open(UpgradeMenuDialog, player);
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed.');
      console.log(result);
    });
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
    console.log(
      this.leftcolTiles.length,
      this.topRowTiles.length,
      this.rightColTiles.length,
      this.bottomRowTiles.length
    );
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
}

@Component({
  selector: 'upgrade-menu-dialog',
  templateUrl: 'upgrade-menu.html',
})
export class UpgradeMenuDialog {
  constructor(
    public dialogRef: MatDialogRef<UpgradeMenuDialog>,
    @Inject(MAT_DIALOG_DATA) public player: Player
  ) {}
}

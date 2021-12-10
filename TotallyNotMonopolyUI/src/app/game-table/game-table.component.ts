import { Component, Inject, OnInit } from '@angular/core';
import { FieldService } from '../services/field.service';
import { TileComponent } from '../tile/tile.component';

export interface Tile {
  id: number;
  name: string;
  color: any;
  image: string;
  col: number;
  row: number;
  description: string;
  rent: number[];
  level: number;
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
  public activeTile!: Tile;
  public rolled: boolean;
  public tiles: Tile[] = [];
  public start!: Tile;
  public jail!: Tile;
  public parking!: Tile;
  public goToJail!: Tile;

  players: Player[] = [
    {
      number: 1,
      money: 505000,
      position: 1,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
    {
      number: 2,
      money: 5000000,
      position: 1,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
    {
      number: 3,
      money: 500000,
      position: 1,
      properties: ['Property 2', 'Property 3'],
    },
    {
      number: 4,
      money: 5000000,
      position: 1,
      properties: ['Property 1', 'Property 2', 'Property 3'],
    },
  ];
  private leftcolTiles: Tile[] = [];
  private topRowTiles: Tile[] = [];
  private rightColTiles: Tile[] = [];
  private bottomRowTiles: Tile[] = [];

  constructor(
    private fieldService: FieldService,
    private tileComponent: TileComponent
  ) {
    this.getTilesFromBE();
    this.activePlayerIndex = 0;
    this.activePlayer = this.players[this.activePlayerIndex];
    this.activeTurn = false;
    this.rolled = false;
  }

  ngOnInit(): void {}

  async getTilesFromBE() {
    await this.fieldService
      .getField()
      .toPromise()
      .then((resp) => {
        let tiles: Tile[] = resp as Tile[];
        this.start = tiles[0];
        this.leftcolTiles = tiles.slice(1, 10).reverse();

        this.jail = tiles[10];
        this.topRowTiles = tiles.slice(11, 20);

        this.parking = tiles[20];
        this.rightColTiles = tiles.slice(21, 30);
        this.goToJail = tiles[30];
        this.bottomRowTiles = tiles.slice(31, 40).reverse();
        this.fillTableWithTiles();
      })
      .catch((err) => console.error(err));
  }
  fillTableWithTiles() {
    this.tiles = [];
    this.tiles.push(this.jail);
    this.topRowTiles.forEach((tile) => this.tiles.push(tile));
    this.tiles.push(this.parking);
    for (let i = 0; i < 9; i++) {
      this.tiles.push(this.leftcolTiles[i]);
      for (let j = 0; j < 9; j++) {
        this.tiles.push({
          id: 0,
          name: '',
          color: 8,
          image: '',
          col: 1,
          row: 1,
          description: '',
          rent: [],
          level: 0,
        });
      }
      this.tiles.push(this.rightColTiles[i]);
    }
    this.tiles.push(this.start);
    this.bottomRowTiles.forEach((tile) => this.tiles.push(tile));
    this.tiles.push(this.goToJail);
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
  movePlayer(roll: any[]) {
    this.rolled = true;
    let totalRoll = ((roll[0] as number) + roll[1]) as number;
    this.activePlayer.position =
      this.activePlayer.position + totalRoll > 40
        ? this.activePlayer.position + totalRoll - 40
        : this.activePlayer.position + totalRoll;
  }
  getColor(tile: Tile) {
    switch (tile.color) {
      case 0:
        return 'brown';
      case 1:
        return 'lightblue';
      case 2:
        return 'magenta';
      case 3:
        return 'orange';
      case 4:
        return 'red';
      case 5:
        return 'yellow';
      case 6:
        return 'green';
      case 7:
        return 'blue';
      default:
        return '#E9E6DB';
    }
  }
  getClass(player: Player) {
    return 'player-' + player.number + '-info-card';
  }
  getStyle(tile: Tile) {
    let style: any;
    if (tile.name !== '') {
      style = {
        border: '1px solid black',
        'background-image': tile.image,
        'background-size': 'cover',
        'background-color': this.getColor(tile),
      };
    }
    return style;
  }
  openTileMenu(id: number) {
    this.tileComponent.setTile(this.findTile(id));
  }
  findTile(id: number): any {
    for (let tile of this.tiles) {
      if (tile.id === id) return tile;
    }
  }
}

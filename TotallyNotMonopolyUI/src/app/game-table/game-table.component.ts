import { Component, Inject, OnInit } from '@angular/core';
import { FieldService } from '../services/field.service';

export interface Tile {
  col: number;
  color: any;
  description: string;
  id: number;
  image: string;
  level: number;
  name: string;
  rent: any;
  row: number;
  owner: number;
  upgradeCost: number;
  value: number;
  type: any;
}
export interface Player {
  number: number;
  money: number;
  position: number;
  properties: Tile[];
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
  public tileMenu: boolean = false;
  public rolled: boolean;
  public tiles: Tile[] = [];
  public start!: Tile;
  public jail!: Tile;
  public parking!: Tile;
  public goToJail!: Tile;

  players: Player[] = [
    {
      number: 1,
      money: 5000,
      position: 1,
      properties: [],
    },
    {
      number: 2,
      money: 5000,
      position: 1,
      properties: [],
    },
    {
      number: 3,
      money: 5000,
      position: 1,
      properties: [],
    },
    {
      number: 4,
      money: 5000,
      position: 1,
      properties: [],
    },
  ];
  private leftcolTiles: Tile[] = [];
  private topRowTiles: Tile[] = [];
  private rightColTiles: Tile[] = [];
  private bottomRowTiles: Tile[] = [];

  constructor(private fieldService: FieldService) {
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
  rentsToArray() {
    for (let tile of this.tiles) {
      if (tile.rent.length > 0) {
        let rent = tile.rent as string;
        tile.rent = rent.split(',');
      }
    }
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
          owner: 0,
          value: 0,
          upgradeCost: 0,
          type: '',
        });
      }
      this.tiles.push(this.rightColTiles[i]);
    }
    this.tiles.push(this.start);
    this.bottomRowTiles.forEach((tile) => this.tiles.push(tile));
    this.tiles.push(this.goToJail);
    this.rentsToArray();
  }

  public upgradeBtn(property: Tile) {
    this.activePlayer.money -= property.upgradeCost;
    property.level += 1;
  }

  public nextPlayer() {
    this.activePlayerIndex =
      this.activePlayerIndex + 1 === 4 ? 0 : this.activePlayerIndex + 1;

    this.activePlayer = this.players[this.activePlayerIndex];
    if (this.activePlayer.money > 0) {
      this.rolled = false;
      this.activeTurn = false;
    } else {
      this.deletePlayer();
      this.nextPlayer();
    }
  }
  deletePlayer() {
    for (let property of this.activePlayer.properties) {
      property.owner = 0;
      property.level = 0;
    }
    this.activePlayer.position = 50;
  }

  movePlayer(roll: any[]) {
    this.rolled = true;

    console.log(roll[0], roll[1]);
    let totalRoll = ((roll[0] as number) + roll[1]) as number;

    let newPosition = totalRoll + this.activePlayer.position;
    this.activePlayer.position =
      newPosition > 40 ? newPosition - 40 : newPosition;
    // this.checkActiveTile();
    setTimeout(() => {
      this.activeTurn = false;
    }, 1000);
  }
  checkActiveTile() {
    let currentTile = this.findFirstTile(this.activePlayer.position) as Tile;
    if (
      (currentTile.owner !== null || currentTile.owner !== 0) &&
      currentTile.owner !== this.activePlayer.number
    ) {
      let owner: Player = this.players[currentTile.owner - 1];
      let rent: number = currentTile.rent[currentTile.level];
      this.activePlayer.money = +this.activePlayer.money - rent;
      owner.money = Number(owner.money) + Number(rent);
    }
  }

  findFirstTile(id: number) {
    for (let tile of this.tiles) {
      if (tile.id === id) {
        return tile;
      }
    }
    return;
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
    if (id === 0) return;
    this.activeTile = this.findTile(id);
    console.log(this.activeTile);
    this.tileMenu = true;
  }

  closeTileMenu() {
    this.tileMenu = false;
  }

  findTile(id: number): any {
    for (let tile of this.tiles) {
      if (tile.id === id) return tile;
    }
  }
  buyProperty() {
    this.activePlayer.money -= this.activeTile.value;
    this.activeTile.owner = this.activePlayer.number;
    this.activePlayer.properties.push(this.activeTile);
  }
}

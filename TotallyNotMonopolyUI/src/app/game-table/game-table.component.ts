import { Component, Inject, OnInit } from '@angular/core';
import { CardService } from '../services/card.service';
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
export interface Card {
  id: number;
  description: string;
  type: string;
  amount: string;
}
export interface Player {
  number: number;
  money: number;
  position: number;
  properties: Tile[];
  hasGetOutOfJail: boolean;
  isJailed: boolean;
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
  public isCardDrawn: boolean;
  public drawnCard!: Card;
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
      money: Number(1000),
      position: 33,
      properties: [],
      hasGetOutOfJail: false,
      isJailed: false,
    },
    {
      number: 2,
      money: Number(1000),
      position: 1,
      properties: [],
      hasGetOutOfJail: false,
      isJailed: false,
    },
    {
      number: 3,
      money: Number(1000),
      position: 1,
      properties: [],
      hasGetOutOfJail: false,
      isJailed: false,
    },
    {
      number: 4,
      money: Number(1000),
      position: 1,
      properties: [],
      hasGetOutOfJail: false,
      isJailed: false,
    },
  ];

  private leftcolTiles: Tile[] = [];
  private topRowTiles: Tile[] = [];
  private rightColTiles: Tile[] = [];
  private bottomRowTiles: Tile[] = [];

  constructor(
    private fieldService: FieldService,
    private cardService: CardService
  ) {
    this.getTilesFromBE();
    this.activePlayerIndex = 0;
    this.activePlayer = this.players[this.activePlayerIndex];
    this.activeTurn = false;
    this.rolled = false;
    this.isCardDrawn = false;
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

  rentsToArray() {
    for (let tile of this.tiles) {
      if (tile.rent.length > 0) {
        let rent = tile.rent as string;
        tile.rent = rent.split(',');
      }
    }
  }

  upgradeBtn(property: Tile) {
    this.activePlayer.money -= property.upgradeCost;
    property.level += 1;
  }

  nextPlayer() {
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
    let totalRoll = ((roll[0] as number) + roll[1]) as number;
    totalRoll = 1;
    if (this.activePlayer.isJailed && roll[0] !== roll[1]) {
      this.activePlayer.money = Number(this.activePlayer.money) - 50;
      this.activePlayer.isJailed = false;
    }
    let newPosition = totalRoll + this.activePlayer.position;
    if (newPosition > 40)
      this.activePlayer.money = Number(this.activePlayer.money) + 200;
    this.activePlayer.position =
      newPosition > 40 ? newPosition - 40 : newPosition;
    this.checkActiveTile(totalRoll);
  }

  async checkActiveTile(roll: number) {
    let currentTile = this.findTile(this.activePlayer.position) as Tile;

    if (currentTile.type === 0) {
      await this.cardService
        .getFortuneCard()
        .toPromise()
        .then((resp) => (this.drawnCard = resp as Card))
        .catch((err) => console.error(err));
      console.log(this.drawnCard);
      let action = this.getActionFromCard(this.drawnCard);
      console.log(this.players);
      console.log(this.activePlayer);
      if (action !== null) currentTile = action as Tile;
      else return;
    }
    if (currentTile.type === 1) {
      await this.cardService
        .getChanceCard()
        .toPromise()
        .then((resp) => (this.drawnCard = resp as Card))
        .catch((err) => console.error(err));
      console.log(this.drawnCard);
      let action = this.getActionFromCard(this.drawnCard);
      if (action !== null) currentTile = action as Tile;
      else return;
    }
    if (currentTile.id === 31) {
      this.activePlayer.position = 11;
      if (this.activePlayer.hasGetOutOfJail)
        this.activePlayer.hasGetOutOfJail = false;
      else this.activePlayer.isJailed = true;
      return;
    }
    if (currentTile.type === 4) {
      this.activePlayer.money = this.activePlayer.money - currentTile.rent[0];
      return;
    }
    console.log('otherwise');
    let hasOwner =
      currentTile.owner !== null || currentTile.owner !== 0
        ? currentTile.owner
        : null;
    console.log(hasOwner);
    if (hasOwner === null || hasOwner === this.activePlayer.number) return;

    let rent: number =
      currentTile.type === 6
        ? roll * currentTile.rent[currentTile.level]
        : currentTile.rent[currentTile.level];
    console.log(rent);
    let owner: Player = this.players[currentTile.owner - 1];
    console.log(owner);
    this.activePlayer.money = +this.activePlayer.money - rent;
    owner.money = Number(owner.money) + Number(rent);
  }

  getActionFromCard(card: Card) {
    this.isCardDrawn = true;
    switch (card.type) {
      case 'advance':
        let property = this.findTileByName(card.amount) as Tile;
        if (this.activePlayer.position > property.id) {
          this.activePlayer.money = Number(this.activePlayer.money) + 200;
        }
        this.activePlayer.position = property.id;
        console.log(this.activePlayer.position);
        console.log(property);
        return property;
      case 'earn':
        this.activePlayer.money =
          Number(this.activePlayer.money) + Number(card.amount);
        return null;
      case 'spend':
        this.activePlayer.money =
          Number(this.activePlayer.money) - Number(card.amount);
        return null;
      case 'jail-card':
        this.activePlayer.hasGetOutOfJail = true;
        return null;
      case 'jail':
        property = this.findTile(11);
        this.activePlayer.position = property.id;
        this.activePlayer.isJailed = true;
        return property;
      case 'earn-each-player':
        for (let player of this.players) {
          player.money = Number(player.money) - Number(card.amount);
          this.activePlayer.money =
            Number(this.activePlayer.money) + Number(card.amount);
        }
        return null;
      case 'spend-each-player':
        for (let player of this.players) {
          player.money = Number(player.money) + Number(card.amount);
          this.activePlayer.money =
            Number(this.activePlayer.money) - Number(card.amount);
        }
        return null;
      case 'repairs':
        for (let property of this.activePlayer.properties) {
          this.activePlayer.money =
            Number(this.activePlayer.money) -
            Number(Number(property.level) * 25);
        }
        return null;
      case 'back':
        let newPosition = this.activePlayer.position - Number(card.amount);
        if (newPosition <= 0) newPosition = newPosition + 40;
        this.activePlayer.position = newPosition;
        return this.findTile(newPosition);
    }
  }

  findTileByName(info: string) {
    if (info === 'Tram') {
      let i = this.activePlayer.position;
      for (i; i < 40; i++) {
        let property: Tile = this.findTile(i);
        if (property.type === 2) return property;
      }
      for (i = 0; i < this.tiles.length; i++) {
        let property: Tile = this.findTile(i);
        if (property.type === 2) return property;
      }
    }
    if (info === 'Utility') {
      let i = this.activePlayer.position;
      for (i; i < 40; i++) {
        let property: Tile = this.findTile(i);
        if (property.type === 6) return property;
      }
      for (i = 0; i < this.tiles.length; i++) {
        let property: Tile = this.findTile(i);
        if (property.type === 6) return property;
      }
    }
    for (let property of this.tiles) {
      if (property.name === info) return property;
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
    if (this.activeTile.type === 2) {
      let tramLevel = this.getTramLevel();
      for (let property of this.activePlayer.properties) {
        if (property.type === 2) property.level = tramLevel;
      }
    }
    if (this.activeTile.type === 6) {
      let utilityLevel = this.getUtilityLevel();
      for (let property of this.activePlayer.properties) {
        if (property.type === 6) property.level = utilityLevel;
      }
    }
  }

  getTramLevel() {
    let level = -1;
    for (let property of this.activePlayer.properties) {
      if (property.type === 2) level++;
    }
    return level;
  }

  getUtilityLevel() {
    let level = -1;
    for (let property of this.activePlayer.properties) {
      if (property.type === 6) level++;
    }
    return level;
  }
}

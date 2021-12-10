import { Component, OnInit } from '@angular/core';
import { Tile } from '../game-table/game-table.component';

@Component({
  selector: 'app-tile',
  templateUrl: './tile.component.html',
  styleUrls: ['./tile.component.scss'],
})
export class TileComponent implements OnInit {
  public tile!: Tile;
  public isActive: boolean = false;

  constructor() {}

  ngOnInit(): void {}

  setTile(tile: Tile) {
    console.log(this.isActive);
    this.isActive = true;
    console.log(this.isActive);

    this.tile = tile;
    console.log(this.tile);
  }
}

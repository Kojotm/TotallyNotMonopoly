import { Component, OnInit } from '@angular/core';
import { Tile } from '../game-table/game-table.component';
import { TileService } from '../services/tile.service';

@Component({
  selector: 'app-tile',
  templateUrl: './tile.component.html',
  styleUrls: ['./tile.component.scss'],
})
export class TileComponent implements OnInit {
  public tile!: Tile;
  isActive: boolean;

  constructor(public tileService: TileService) {
    this.isActive = this.tileService.getIsActive();
  }

  ngOnInit(): void {}

  setTile(tile: Tile) {
    console.log(this.isActive);
    this.tileService.setIsActive(true);
    this.isActive = this.tileService.getIsActive();
    console.log(this.isActive);

    this.tile = tile;
    console.log(this.tile);
  }
}

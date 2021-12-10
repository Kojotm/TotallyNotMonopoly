import { Component, Input, OnInit } from '@angular/core';
import { Tile } from '../game-table/game-table.component';

@Component({
  selector: 'app-tile',
  templateUrl: './tile.component.html',
  styleUrls: ['./tile.component.scss'],
})
export class TileComponent implements OnInit {
  @Input() tile!: Tile;
  @Input() isActive!: boolean;

  constructor() {}

  ngOnInit(): void {}
}

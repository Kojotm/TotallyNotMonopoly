import { ArrayType } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

export interface Tile {
  name: string;
  color: string;
  cols: number;
  rows: number;
  text: string;
}
export interface Player {
  number: number;
  money: number;
  properties: string[];
}

@Component({
  selector: 'app-game-table',
  templateUrl: './game-table.component.html',
  styleUrls: ['./game-table.component.scss']
})
export class GameTableComponent implements OnInit {
  tiles: Tile[] = [
    { name:"top-left", color:"rgb(82, 80, 80)", cols:2, rows:2, text:"top left corner tile"},
    { name:"top-row", color:"grey", cols:9, rows:2, text:"top row tiles" },
    { name:"top-right", color:"rgb(82, 80, 80)", cols:2, rows:2, text:"top right corner tile"},
    { name:"left-col", color:"grey", cols:2, rows:9, text:"left col tiles"},
    { name:"filler", color:"white", cols:9, rows:9, text:"Totally not monopoly board"},
    { name:"right-col", color:"grey", cols:2, rows:9, text:"right col tiles"},
    { name:"bottom-left", color:"rgb(82, 80, 80)", cols:2, rows:2, text:"bottom left corner tile"},
    { name:"bottom-row", color:"grey", cols:9, rows:2,text:"bottom row tiles"},
    { name:"bottom-right", color:"rgb(82, 80, 80)", cols:2, rows:2, text:"bottom right corner tile"},
  ];
  players: Player[] = [
    {number:1, money:505000,properties:["Property 1","Property 2", "Property 3"]},
    {number:2, money:5000,properties:["Property 1","Property 2", "Property 3"]},
    {number:3, money:5000,properties:["Property 1","Property 2", "Property 3"]},
    {number:4, money:5000,properties:["Property 1","Property 2", "Property 3"]},
  ];
  
  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

}

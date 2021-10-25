import { ArrayType } from '@angular/compiler';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

export interface Tile {
  name: string;
  color: string;
  img: string
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
  styleUrls: ['./game-table.component.scss']
})
export class GameTableComponent implements OnInit {
  tiles: Tile[] = [
    { name:"top-left", color:"rgb(82, 80, 80)", img:"url('../../assets/jail-tile.png')", cols:2, rows:2, text:""},
    { name:"top-row", color:"grey", img:"", cols:9, rows:2, text:"top row tiles" },
    { name:"top-right", color:"rgb(82, 80, 80)", img:"url('../../assets/parking-tile.png')", cols:2, rows:2, text:""},
    { name:"left-col", color:"grey", img:"", cols:2, rows:9, text:"left col tiles"},
    { name:"filler", color:"white", img:"", cols:9, rows:9, text:"Totally not monopoly board"},
    { name:"right-col", color:"grey", img:"", cols:2, rows:9, text:"right col tiles"},
    
    { name:"bottom-left", color:"rgb(82, 80, 80)", img:"url('../../assets/start-tile.png')", cols:2, rows:2, text:""}, //Start tile
    
    
    { name:"bottom-row", color:"grey", img:"", cols:9, rows:2, text:"bottom row tiles"},
    { name:"bottom-right", color:"rgb(82, 80, 80)", img:"url('../../assets/go-to-jail-tile.png')", cols:2, rows:2, text:""},
  ];
  
  topRowProperties: Property[] = [
    {name:"testProperty",price:[100,200,300,400,500],level:1},
  ];

  players: Player[] = [
    {number:1, money:505000,properties:["Property 1","Property 2", "Property 3"]},
    {number:2, money:5000000,properties:["Property 1","Property 2", "Property 3"]},
    {number:3, money:500000,properties:["Property 2", "Property 3"]},
    {number:4, money:5000000,properties:["Property 1","Property 2", "Property 3"]},
  ];
  
  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }


  openUpgradesMenu(number: number) {
    console.log("Player "+number+"'s upgrade menu");
    let player: Player = this.players[number-1];
    console.log(player)
    const dialogRef = this.dialog.open(UpgradeMenuDialog, {
      width: '40%',
      data: player
    });
    // this.dialog.open(UpgradeMenuDialog, player);
    dialogRef.afterClosed().subscribe(result => {
      console.log("The dialog was closed.");
      console.log(result);
    });
  }
}

@Component({
  selector: 'upgrade-menu-dialog',
  templateUrl: 'upgrade-menu.html'
})
export class UpgradeMenuDialog {
  constructor(
    public dialogRef: MatDialogRef<UpgradeMenuDialog>,
    @Inject(MAT_DIALOG_DATA) public player: Player) {}
}

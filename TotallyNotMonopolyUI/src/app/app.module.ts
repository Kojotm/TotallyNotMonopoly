import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GameTableComponent } from './game-table/game-table.component';

import { MatGridListModule } from '@angular/material/grid-list';


const MaterialComponents = [
  MatGridListModule
]


@NgModule({
  declarations: [
    AppComponent,
    GameTableComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialComponents
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

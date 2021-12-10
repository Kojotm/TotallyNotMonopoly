import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GameTableComponent } from './game-table/game-table.component';

import { MatGridListModule } from '@angular/material/grid-list';
import { MatCardModule } from '@angular/material/card';
import { MatDividerModule } from '@angular/material/divider';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { DiceComponent } from './dice/dice.component';
import { FieldService } from './services/field.service';
import { HttpClientModule } from '@angular/common/http';

const MaterialComponents = [
  MatGridListModule,
  MatCardModule,
  MatDividerModule,
  MatButtonModule,
  MatDialogModule,
];

@NgModule({
  declarations: [AppComponent, GameTableComponent, DiceComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MaterialComponents,
  ],
  providers: [FieldService],
  bootstrap: [AppComponent],
})
export class AppModule {}

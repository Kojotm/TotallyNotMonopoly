import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GameTableComponent } from './game-table/game-table.component';

const routes: Routes = [
  { path: '', component: GameTableComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

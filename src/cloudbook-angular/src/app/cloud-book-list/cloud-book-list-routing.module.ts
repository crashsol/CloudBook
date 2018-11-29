import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookComponent } from './books/book.component';

const routes: Routes = [
  { path: 'book', component: BookComponent, data: { permission: 'Pages.Book' } },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CloudBookListRoutingModule { }

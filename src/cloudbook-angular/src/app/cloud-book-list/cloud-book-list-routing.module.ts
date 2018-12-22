import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookComponent } from './books/book.component';
import { BookTagComponent } from './book-tag/book-tag.component';

const routes: Routes = [
  { path: 'book', component: BookComponent, data: { permission: 'Pages.Book' } },
  { path: 'book-tag', component: BookTagComponent, data: { permission: 'Pages.BookTag' } },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CloudBookListRoutingModule { }

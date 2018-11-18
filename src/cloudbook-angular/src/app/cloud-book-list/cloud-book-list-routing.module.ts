import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookListComponent } from './books/book-list/book-list.component';

const routes: Routes = [
  {
    path: 'book-list',
    component: BookListComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CloudBookListRoutingModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { BookListComponent } from './books/book-list/book-list.component';

@NgModule({
  imports: [
    CommonModule,
    CloudBookListRoutingModule
  ],
  declarations: [BookListComponent]
})
export class CloudBookListModule { }

import { TitleService } from '@yoyo/theme';
import { AbpModule, LocalizationService } from '@yoyo/abp';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { BookListComponent } from './books/book-list/book-list.component';
import { SharedModule } from '@shared/shared.module';
import { CreateOrEditBookComponent } from './books/create-or-edit-book/create-or-edit-book.component';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    SharedModule,
    AbpModule,
    CloudBookListRoutingModule
  ],
  declarations: [BookListComponent, CreateOrEditBookComponent],
  providers: [LocalizationService, TitleService],
  // 需要编译的Component
  entryComponents: [BookListComponent]


})
export class CloudBookListModule { }

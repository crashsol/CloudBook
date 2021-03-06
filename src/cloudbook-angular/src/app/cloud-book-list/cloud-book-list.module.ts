import { TitleService } from '@yoyo/theme';
import { AbpModule, LocalizationService } from '@yoyo/abp';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { SharedModule } from '@shared/shared.module';
import { CreateOrEditBookComponent } from './books/create-or-edit-book/create-or-edit-book.component';
import { BookComponent } from './books/book.component';
import { BookTagComponent } from './book-tag/book-tag.component';
import { CreateOrEditBookTagComponent } from './book-tag/create-or-edit-book-tag/create-or-edit-book-tag.component';


@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    SharedModule,
    AbpModule,
    CloudBookListRoutingModule
  ],
  declarations: [BookComponent, CreateOrEditBookComponent,
    BookTagComponent,
    CreateOrEditBookTagComponent],
  providers: [LocalizationService, TitleService],
  // 需要编译的Component
  entryComponents: [BookComponent, CreateOrEditBookComponent, CreateOrEditBookTagComponent]


})
export class CloudBookListModule { }

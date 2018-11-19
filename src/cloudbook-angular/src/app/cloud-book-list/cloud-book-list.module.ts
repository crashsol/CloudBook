import { TitleService } from '@yoyo/theme';
import { AbpModule, LocalizationService } from '@yoyo/abp';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { BookListComponent } from './books/book-list/book-list.component';
import { SharedModule } from '@shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    SharedModule,
    AbpModule,
    CloudBookListRoutingModule
  ],
  declarations: [BookListComponent],
  providers: [LocalizationService, TitleService],
  // 需要编译的Component
  entryComponents: [BookListComponent]


})
export class CloudBookListModule { }
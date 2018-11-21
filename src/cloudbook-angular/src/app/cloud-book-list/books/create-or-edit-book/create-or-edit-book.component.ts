import { BooksServiceProxy, CreateOrUpdateBookInput } from './../../../../shared/service-proxies/service-proxies';
import { Component, OnInit, Injector } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base';
import { BookEditDto } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-create-or-edit-book',
  templateUrl: './create-or-edit-book.component.html',
  styles: []
})
export class CreateOrEditBookComponent extends ModalComponentBase implements OnInit {


  id: number;
  entity = new BookEditDto();
  constructor(injector: Injector, private _booksService: BooksServiceProxy) {
    super(injector);
  }

  ngOnInit() {
    this.init();
  }
  /*  */
  init() {
    // 编辑
    if (this.id) {
      this._booksService.getBookForEditOutputAsync(this.id)
        .subscribe((result) => {
          this.entity = result.book;
        });
    }
  }

  submitForm(): void {
    const input = new CreateOrUpdateBookInput();
    input.book = this.entity;
    this.saving = true;
    this._booksService.createOrUpdateBookAsync(input)
      .pipe(finalize(() => {
        this.saving = false;
      })).subscribe(() => {
        this.notify.success('信息保存成功');
        this.success(true);
      });
  }

}

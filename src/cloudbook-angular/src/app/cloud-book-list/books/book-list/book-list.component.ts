import { CreateOrEditBookComponent } from './../create-or-edit-book/create-or-edit-book.component';
import { BooksServiceProxy } from './../../../../shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/component-base/paged-listing-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { Component, OnInit, Injector } from '@angular/core';
import { BookListDto } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.less'],
  // 引入动画模块
  animations: [appModuleAnimation()]
})
export class BookListComponent extends PagedListingComponentBase<BookListDto> implements OnInit {

  constructor(injector: Injector, private _bookService: BooksServiceProxy) {
    super(injector);
  }


  /**
   * 默认获取后端数据列表方法
   * @param request 请求Dto
   * @param pageNumber 当前的页面
   * @param finishedCallback 完成请求后的回调信息
   */

  protected fetchDataList(
    request: PagedRequestDto,
    pageNumber: number,
    finishedCallback: Function):
    void {
    this._bookService.getPagedBooksAsync(
      this.filterText,
      request.sorting,
      request.skipCount,
      request.maxResultCount)
      .pipe(finalize(() => {
        finishedCallback();
      })
      ).subscribe(result => {
        // 获取返回结果
        this.dataList = result.items;
        this.showPaging(result);

      });
  }


  /**
   * 批量删除
   *
   * @memberof BookListComponent
   */
  batchDelete(): void {
    if (this.selectedDataItems.length <= 0) {
      this.message.warn('请选择你要删除的数据');
    }
    this.message.confirm('确定要批量删除这些数据，删除后不可恢复', () => {
      const ids = this.selectedDataItems.map(item => item.id);
      this._bookService.batchDeleteAsync(ids).subscribe(() => {
        this.refresh();
        this.notify.success('批量数据成功');
      });
    });
  }

  /**
   *  单条删除
   * @param {number} id
   * @memberof BookListComponent
   */
  delete(id: number): void {
    this._bookService.deleteBookAsync(id)
      .subscribe(() => {
        this.refreshGoFirstPage();
        this.notify.success('信息删除成功');
      });
  }


  /**
   *  添加或则编辑Book
   *
   * @param {number} [id]
   * @memberof BookListComponent
   */
  createOrEdit(id?: number): void {
    this.modalHelper.static(CreateOrEditBookComponent, { id })
      .subscribe(result => {
        if (result) {
          this.refresh();
        }
      });

  }


}

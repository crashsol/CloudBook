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

}

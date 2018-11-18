## 创建一个cloud-book-list 模块
 - 1、添加一个模块并放置app下 参数 --dryrun -d 可以进行先预览生存的文件和要修改的文件
  ```
  ng g m cloud-book-list --routing -m=app --dryrun -d
  ```
 - 2、添加一个组件，并附加
  ```
  ng g c cloud-book-list/books/book-list -m=cloud-book-list 
  ```
## 修改AppMenus.cs 添加模块先关的路由信息
   ```    // 添加cloud-book-list 模块
    new MenuItem(
      'CloudBookList',
      '',
      'anticon  anticon-book',
      '',
      [
        new MenuItem(
          'Books',
          '',
          'anticon anticon-info-circle-o',
          '/app/cloud-book-list/book-list'
        )
      ]
    ),
   ```
## 在app路由模块中添加cloud-book-list的路由
   ``` 
   // 懒加载
     {
        path: 'cloud-book-list',
        loadChildren: './cloud-book-list/cloud-book-list.module#CloudBookListModule'
      },

   ```


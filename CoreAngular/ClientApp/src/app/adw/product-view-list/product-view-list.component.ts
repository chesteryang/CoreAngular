import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { IProductViewModel } from '../redux/common';
@Component({
  selector: 'app-product-view-list',
  templateUrl: './product-view-list.component.html',
  styleUrls: ['./product-view-list.component.css']
})
export class ProductViewListComponent implements OnInit {

  @select(['adventureworksState', 'productViewState']) readonly productList$: Observable<IProductViewModel[]>;

  constructor() { }

  ngOnInit() {
  }

}

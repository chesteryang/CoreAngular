import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { ICustomerViewModel } from '../redux/common';

@Component({
  selector: 'app-customer-view-list',
  templateUrl: './customer-view-list.component.html',
  styleUrls: ['./customer-view-list.component.css']
})
export class CustomerViewListComponent implements OnInit {

  @select(['adventureworksState', 'customerViewState']) readonly customerList$: Observable<ICustomerViewModel[]>;

  constructor() { }

  ngOnInit() { }
}

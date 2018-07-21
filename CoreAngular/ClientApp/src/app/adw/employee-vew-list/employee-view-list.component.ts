import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { IEmployeeViewModel } from '../redux/common';

@Component({
  selector: 'app-employee-view-list',
  templateUrl: './employee-view-list.component.html',
  styleUrls: ['./employee-view-list.component.css']
})
export class EmployeeViewListComponent implements OnInit {

  @select(['adventureworksState', 'employeeViewState']) readonly employeeList$: Observable<IEmployeeViewModel[]>;

  constructor() { }

  ngOnInit() { }
}

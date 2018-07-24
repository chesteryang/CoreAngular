import { Reducer, combineReducers } from 'redux';
import { IEmployeeViewModel,
  IPerson,
  IAdventureworksState,
  ICustomerViewModel,
  IEmployeeState} from '../common';
import { EmployeeViewModelActions,
  PersonActions,
  CustomerViewModelActions,
  EmployeeActions} from '../actions';

export const initEmployeeViewModelState: IEmployeeViewModel[] = [];

export const employeeViewModelReducer: Reducer<IEmployeeViewModel[]> =
  (state = initEmployeeViewModelState, action: {type: string, payload: IEmployeeViewModel[]}) => {
    switch (action.type) {
      case EmployeeViewModelActions.MODEL_LOADED:
        return action.payload;
      default:
        return state;
    }
};

export const initPersonState: IPerson = {businessEntityId: 0} as IPerson;

export const personReducer: Reducer<IPerson> =
  (state = initPersonState, action: { type: string, payload: IPerson}) => {
    switch (action.type) {
      case PersonActions.PERSON_LOADED:
        return action.payload;
      default:
        return state;
    }
};

export const initCustomerViewModelState: ICustomerViewModel[] = [];

export const customerViewModelReducer: Reducer<ICustomerViewModel[]> =
  (state = initCustomerViewModelState, action: {type: string, payload: ICustomerViewModel[]}) => {
    switch (action.type) {
      case CustomerViewModelActions.MODEL_LOADED:
        return action.payload;
      default:
        return state;
    }
};

export const initEmployeeState: IEmployeeState
  = {loggedIn: false,
    validating: false,
    vadidatedMessage: '',
    person: {businessEntityId: 0} as IPerson} as IEmployeeState;

export const employeeReducer: Reducer<IEmployeeState> =
  (state = initEmployeeState, action: {type: string, payload: IPerson | string }) => {
    switch (action.type) {
      case EmployeeActions.LOGGED_OUT:
        return initEmployeeState;
      case EmployeeActions.LOGGED_IN:
        return {loggedIn: true, validating: false, vadidatedMessage: '', person: action.payload as IPerson};
      case EmployeeActions.VALIDATING_STARTING:
        return Object.assign({}, state, {loggedIn: false, validating: true});
      case EmployeeActions.VALIDATING_FAILED:
        return Object.assign({}, initEmployeeState, {vadidatedMessage: action.payload});
      default:
        return state;
    }
  };

export const adventureworksReducers = combineReducers<IAdventureworksState>({
  employeeViewState: employeeViewModelReducer,
  employeeState: employeeReducer,
  customerViewState: customerViewModelReducer
});

export const initAdventureworksState = {
  employeeViewState: initEmployeeViewModelState,
  employeeState: initEmployeeState,
  customerViewState: initCustomerViewModelState
};

export interface IEmployeeViewModel {
  businessEntityId:	number
  loginId:	string
  emailAddress:	string
  firstName:	string
  lastName:	string
}

export interface ICustomerViewModel {
  businessEntityId: number
  emailAddress: string
  title: string
  firstName: string
  lastName: string
}

export interface IPerson {
  businessEntityId:	number
  personType:	string
  nameStyle:	string
  title:	string
  firstName:	string
  middleName:	string
  lastName:	string
  suffix:	string
  emailPromotion:	number
  additionalContactInfo:	string
  employee: IEmployee
  emailAddress: IEmailAddress[]
}

export interface IEmployee {
  businessEntityId:	number
  nationalIdnumber:	string
  loginId:	string
  organizationNode:	string
  jobTitle:	string
  birthDate:	string
  maritalStatus:	string
  gender:	string
  hireDate:	string
  salariedFlag:	string
  vacationHours:	number
  sickLeaveHours:	number
  currentFlag:	string
}

export interface IEmailAddress {
  businessEntityId:	number
  emailAddressId:	number
  emailAddress1:	string
  businessEntity: IPerson | null
}

export interface IEmployeeState {
  loggedIn: boolean
  validating: boolean
  validatedMessage: string
  person: IPerson
}

export interface IUser {
  loginId: string
  password: string
}

export interface IAdventureworksState {
  employeeViewState: IEmployeeViewModel[]
  employeeState: IEmployeeState
  customerViewState: ICustomerViewModel[]
}

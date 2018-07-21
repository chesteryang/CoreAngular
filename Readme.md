1. dotnet new angular -n CoreAngular
2. Using VS code to open and run debug
3. Using VS 2017 to open and run debug.
4. enable xml doc and disable xml doc requirement.
5. update angular - https://update.angular.io/
6. install @angular/cli. npm i -D @angular/cli
7. generate component must be in app folder 
8. update bootstrap to version 4. npm uninstall/install
9. use external bootstrap js.
10. Add redux
11. Add AdventureWorks database project and its xUnit test project
12. Install Ms Sql Server 2017 Developer version.
13. Restore AdventureWorks sample database 
	https://github.com/Microsoft/sql-server-samples/releases	
	https://github.com/Microsoft/sql-server-samples/releases/download/adventureworks/AdventureWorks2017.bak
14. scaffolding models: 
dotnet ef dbcontext scaffold "Server=YourPcName\yourSqlInstance;Database=AdventureWorks2017;Trusted_Connection=True;" 
Microsoft.EntityFrameworkCore.SqlServer -o model -p CoreAngular.AdventureWorks.csproj
15. Connection string: Server={0};Database=AdventureWorks2017;Trusted_Connection=True; 
	where {0} is an environment var called DbInstance.
16. Add news component. Angular’s cross-site scripting security model is tough to grasp
    At last, make this work: [style.background-image]='getUrl(article)'
17. move news data to redux store.
18. work out ng test. when there is an error of "[object ErrorEvent] thrown", use
	ng test --sourceMap=false can get details.
19. Reset Person.Password table's hashed password column as failed to find how the password was generated.
20. scaffold models.
    dotnet ef dbcontext scaffold "Data Source=data/adventureworks2017.db3" Microsoft.EntityFrameworkCore.Sqlite -o SqliteModel -p 
	CoreAngular.AdventureWorks.csproj

	In order to scaffold, the following packages are required in csproj.
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite.Core" Version="2.1.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite.Design" Version="1.1.5" />
    <PackageReference Include="SQLitePCLRaw.bundle_green" Version="1.1.11" />

21. Use the tool (https://github.com/ErikEJ/SqlCeToolbox) to generate schema and data scripts for sqlite database and add sqlite database.
	sqlite3 db_name.sqlt < your_sql.sql
22. Use git lfs tool to store the database into github as it is too large - 120MB
23. Add Sqlite DBContext and EmployeesController
24. Remove MS SQL model of AdventureWorks built in No.14.
25. Add some actions, the generated model contains looping references, remember to cut them.
26. a component must be registered on a module or it is not visible to component's html template
27. a component can only be registered on one module. In order to share the component, it can be registered into a shared module, the shared module exports it. Another module can import the shared module and then use the component. 
28. generate c# classes for Additional Info xml parsing.
	xsd /c /namespace:CoreAngular.AdventureWorks.SqliteModel AdditionalContactInfo.xsd ContactTypes.xsd ContactRecord.xsd
29. Update git repo author info
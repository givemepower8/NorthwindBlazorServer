# NorthwindBlazorServer

playground for Blazer server app

## Northwind Context 

Install nuget packages:

* Microsoft.EntityworkCore
* Microsoft.EntityworkCore.SqlServer
* Microsoft.EntityworkCore.Tools
* Microsoft.EntityworkCore.Design

Run the Scaffold-DbContext command in Package Manager Console
`Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models`

```cs
builder.Services.AddDbContextFactory<NorthwindContext>(options =>
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Northwind;Trusted_Connection=True;"));
```

in the pazor, `@inject IDbContextFactory<NorthwindContext> DbFactory`

```cs
using var context = DbFactory.CreateDbContext();
```

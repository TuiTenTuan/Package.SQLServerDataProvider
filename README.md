# SQLServerDataProvider

# SQL Server Data Provider

Very simple to execute SQL query for SQL Server

# Author
Tui Tên Tuấn - Professtional developer C#

Base on [KTeam](https://howkteam.vn/about)

Visit me at [TuiTenTuan.com](http://tuitentuan.com)

# Install
`NuGet\Install-Package SQLServerDataProvider -Version 1.4.1`

# Github
[Package.SQLServerDataProvider](https://github.com/TuiTenTuan/Package.SQLServerDataProvider)

# Usage

## Construction
### Normal
``` C#
string _connection = "Server=;Database=;User=;Password=;";
DataProvider dp = new DataProvider(_connection);
```
### DI (in .Net core and .Net 6 or lasted)
.Net core 3.1 add this to ConfigureServices of Startup.cs file
```
string _connection = "Server=;Database=;User=;Password=;"; //Can get in appsettings.json

services.AddTransient<IDataProvider>(new DataProvider(_connection));
```

.Net 6 add this to the file Program.cs
``` C#
string _connection = "Server=;Database=;User=;Password=;"; //Can get in appsettings.json

builder.Services.AddTransient<IDataProvider>(new DataProvider(_connection));
```

## Use
### Normal
``` C#
# Excute Query to return DataTable
string query = "Select * from TempTable where id = @abc , name = @name";
object[] parameter = new object[] {"1", "abc"};
DataTable result = dp.ExcuteQuery(query, parameter);

# Excute non-Query to return the total row affected
string query = "Select * from TempTable where id = @abc , name = @name";
object[] parameter = new object[] {"1", "abc"};
int rowAffected = dp.ExcuteNonQuery(query, parameter);

# Excute Scalar query returns the value of the first column and first row as an object
string query = "Select * from TempTable where id = @abc , name = @name";
object[] parameter = new object[] {"1", "abc"};
int rowEffected = dp.ExcuteNonQuery(query, parameter);
```

## DI (.Net core and .Net 6 or lasted)

Construction in class
``` C#
public class TestClass
{
    private readonly IdataProvider _dp;

    public TestClass(IDataProvider dataProvider)
    {
        _dp = dataProvider;
    }
}
```

Use in class
``` C#
# Excute Query to return DataTable
string query = "Select * from TempTable where id = @abc , name = @name";
object[] parameter = new object[] {"1", "abc"};
DataTable result = _dp.ExcuteQuery(query, parameter);

# Excute non-Query to return the total row affected
string query = "Select * from TempTable where id = @abc , name = @name";
object[] parameter = new object[] {"1", "abc"};
int rowAffected = _dp.ExcuteNonQuery(query, parameter);

# Excute Scalar query returns the value of the first column and first row as an object
string query = "Select * from TempTable where id = @abc , name = @name";
object[] parameter = new object[] {"1", "abc"};
int rowEffected = _dp.ExcuteNonQuery(query, parameter);
```
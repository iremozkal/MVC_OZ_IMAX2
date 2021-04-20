## MVC_OZ_IMAX2

Creating Cinema Database with Entity Framework Code First using Mappings.  

OnModelCreating method is a virtual method that is triggered when the database is created for the first time. It is located in DbContext. We will use it by overriding in our Context class that we inherited from DbContext in Code First structure. 
 
In the Code First approach, there is a set of rules that come into play during the generation of the database side. These rules, which are called Convention, are actually expressed with the help of some types under the System.Data.Entity.ModelConfiguration.Conventions namespace. In cases such as using Data Annotations or Fluent Api, it is possible to crush the relevant convention rule sets.

By creating a mapping class for each entity, we determine how we want each entity to be created in the database and how they relate to each other. Separate mapping classes were created in this project for relations written in OnModelCreating method in the previous OZ_IMAX project. After that, they are added as configurations for our OnModelCreating method in the context class.

### Technologies  

+ Asp.Net Web Application with .Net Framework 4.5 
+ Entity Framework 6.4.4
+ Visual Studio 2012

### Usage

on DAL Layer,

```python
PM> enable-migrations	# creates the Configuration.cs file for migrations.
PM> update-database 	# updates the database when code changes.
```

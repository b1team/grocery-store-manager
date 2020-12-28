# grocery-store-manager

## Database Config
In `./GroceryStoreManager/App.config`, change `DatabaseString` to your connection string(SQL SERVER)  

## Database Migration
In `Package Manager Console` of Visual Studio  
1. If you changed db models, run `Add-Migration "your change log"` to create migation script  
2. Run `Update-Database` to update database to latest version.  

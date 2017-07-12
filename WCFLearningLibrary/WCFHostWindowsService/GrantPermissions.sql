CREATE LOGIN [WindowsServiceUser] WITH PASSWORD = 'password';
CREATE USER [WindowsServiceUser] FOR LOGIN [WindowsServiceUser];
exec sp_addrolemember 'db_owner', 'WindowsServiceUser'
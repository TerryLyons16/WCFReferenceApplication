

You don't need to install Entity Framework in your Console application, you just need to add a reference to the assembly EntityFramework.SqlServer.dll. 
You can copy this assembly from the Class Library project that uses Entity Framework to a LIB folder and add a reference to it.

In summary:

    Class Library application:
        Install Entity Framework
        Write your data layer code
        app.config file has all the configuration related to Entity Framework except for the connection string.
    Create a Console, web or desktop application:
        Add a reference to the first project.
        Add a reference to EntityFramework.SqlServer.dll.
        app.config/web.config has the connection string (remember that the name of the configuration entry has to be the same as the name of the DbContext class.

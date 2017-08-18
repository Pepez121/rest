using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConsole
{
    class EF
    {
        /*
        Entity Framework
            Es un framework de ORM(Object Relational Mapping), QUE permite trabajar con datos relacionales pero con objetos.
            En vez de usar SELECT, JOIN, etc, se usa el mapeo de las tablas a clases
            De esa forma se elimina la necesidad de los usuarios para escribir queries de SQL
            Nos da servicios en los que podemos identificar si ha habido cambios en datos


        Model First
            The DB is created first using an ORM designer, VS includes a DB designer
            Once the model is finisehd, we can translate those models into entities
            We have a schema, we can start either to create the database or the entities, its kind of in the middle from the other 2

        Database First
            We have the DB table turned into Context and Entity Classes, via entity framework
            DB should exist before we start working with the entity

        Code First
            The developer can focus on the domain design and start creating classes
            Devs need to know the global domain of the problem in order to start creating all the entities (opuesto a DB First ?)

        CODE FIRST CONVENTIONS

        Primary key
            Property name is ID or <class name> ID
            Por convención Id y 'NombreClase'Id genera automaticamente la primary key

	            public class Standard {
		            public Standard() {}
		            public int StdId { get; set; }
		            public string StandardName { get; set; }

        Navigation Properties
            Para relacionar unas clases se usa Navigation Property (es como crear FK ?), que es crear un objeto del tipo de la otra clase
            Hay dos tipos: Simple navigation, and collections
            Navegar hacia las linked tables

        Foreign Key
            Debemos crear una variable de mismo tipo y nombre de la otra clase, como StandardID. Se especifican en la NavProp


        DbContext
            Es la clase principal, la que dice que estamso usando EF. Es responsable de la interacción entre todos los objetos
	
	            Entity Set - Listado de todas las entidades - DbSet<TEntity>
	            Si en DBcontext agregamos un DBset de una entidad, esto lo convierte en una tabla
	            Querying - Queries usando LINQ
	            Change Tracking - Identifica si ha habido cambios en los objetos de la base de datos
	            Persisting Data - Permite INSERT, UPDATE y DELETE, dependiendo del estado de las entidades (depende del change tracking)
	            Caching - 
	            Manage Relationship
	            Object Materialization - Convierte tablas en objetos
            Debe heredar de la clase DbContext

        Migraciones
            Enable-Migrations - Le dice al EF que nos permita ir haciendo casos en nuestra BD
            Add-Migration
            Método seed para poner info en nuestra BD desde el inicio
            Schema
            Down es cuando nosotros hacemos rollback a una migración. Tenemos Up() y Down() en las migraciones

        MigrationHistory
            Guarda el Modelo de BD de forma cifrada. Se crea esta tabla al correr update-database

        Todas las migraciones deben tener un nombre referente al cambio que se está haciendo
            1.- enable-migration
            2.- add-migration "Nombre" (parecido al commit)
            3.- update-database -verbose

        Rollback: update-database -TargetMigration "Migración anterior"
        No se puede hacer una migración si se tiene una anterior (VS) que no esté en la DB (MSSQL)

        Tipos de Loading
            Eager: Obtiene toda la información al mismo tiempo desde la base de datos desde el principio

            Lazy Loading: Primero se usa la información que proveé la entidad, y hasta que se necesita información de las entidades relacionadas,
            va a la base de datos a recuperarlas. Sólo va por la información que necesita

        Explicit: Usamos include para 

        DataAnnotations
            Atributos para especificar el tipo de datos de los campos en nuestra base de datos.
            Un ejemplo es [key], etc

         you have the ability to add configurations to your classes to provide EF with the information it needs.
        Code first gives you two ways to add these configurations to your classes. 
        One is using simple attributes called DataAnnotations and the other is using code first’s Fluent API, 
        which provides you with a way to describe configurations imperatively, in code.

        Fluent API
            Es otra forma de configurar el dominio de clases. Provee más funcionalidad para configuración que DataAnnotations
            Ventajas: Se pueden hacer relacioens más complicadas

        Se declara en DbContext en el método OnModelCreating

        ModelBuilder
            Se encarga de crear el modelo

        SE USA VIRTUAL PARA QUE LAZY LOADING LO PUEDA LEER

        db es nuestro source, que tiene objetos de tipo DbSet, que nos apunta a diferentes entidades
        var student = db.Course.Where(c => c.Id == 1)
		              .Student.Select(Id); //Usamos NAV Properties

        ENTIDADES SON EN SINGULAR, TABLAS SON EN PLURAL

        Se recomienda agregar en el Db Context Dbset todas las entidades de relaciones 1 a muchos, pues al momento de usar LINQ
        el source puede acceder a ellas CHECAR


        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////


        SQL - Structured Query Language

            su propósito es manipular DB relacionales
            lenguaje declarativo
            contiene sintaxix de definición de datos y sinstaxis de manipulación de datos

        DataBase

            Contiene información y nos ayuda a tenerla organizada
            Query the data, Update the data, Insert new data, Delete old data
            Hay varios tipos: Relacional: usa tablas, relaciones entre tablas
		    Object-oriented: es un mix entre relacional, pero usa objetos en vez de
		    Document-based: usa documentos JSON, como MongoDB, CosmosDB

        Filas - registros. Son consultadas a través de los Querys
        Columnas - campos. Cada columna puede ser requerida o no requerida. Tiene restricción de tamaño y categoría de datos

        Keys - Cada tabla debe tener al menos una llave única para identificar una fila (Primary Key)
        Foreign key - Nos permite hacer el enlace entre una foreign key de una tabla y la primary key de otra

        Queries
            Al hacer query verificar que el nombre del servidor, DB y usuario sean correctos

        SELECT - SELECT * FROM Customers; 
        El resultado de un select se le conoce como un result-set

        DISTINCT - SELECT DISTINCT Country FROM Customers; 
        Muestra valores distintos, no repite

        WHERE - SELECT * FROM Customers WHERE Country = 'Mexico';
        Se usa para filtrar registros, puede usar operadores =, <> not equal, BETWEEN entre un rango, LIKE %alo%, IN ('Mex', 'Spain')

        AS - SELECT count(Country) AS 'Total Customers' FROM Customers WHERE Country = 'UK';
        Se usa para crear etiquetas en columnas

        INSERT - INSERT INTO Customers(Columna1, columna2) VALUES (valor1, valor2) || INSERT INTO Customers VALUES (valroes para todas las columnas)
        Agrega valores a una tabla

        UPTADE - UPDATE Customers SET columna1=value1, column2=value2 WHERE condicion;
        Actualiza los campos

        DELETE - DELETE FROM Customers WHERE condicion
        Elimina filas de información

        substring CHECAR
        INSERT INTO Employees(LastName, FirstName) SELECT CompanyName, ContactName FROM Customers WHERE CustomerID = 'ACC';

        CREATE DATABASE nombreDB;

        CREATE TABLE Persons(
           ID int NOT NULL
           LastName varchar(255) NOT NULL,
           FirstName varchar(255),
           Age int,
           CONSTRAINT PK_Person PRIMARY KEY (ID,LastName)
        );

        CREATE VIEW [Current Product List] AS
        SELECT ProductID, ProdcutName
        FROM Products
        WHERE DIscontinued = No;

        Modificar DB:
        ALTER TABLE table 1 ALTER COLUMN column1 varchar(55)
        ALTER TABLE Enrollment WITH CHECK ADD CONSTRAINT CourseID FOREIGN KEY (CourseID) REFERENCES Courses(CourseID);
        ALTER TABLE Enrollment ADD FOREIGN KEY (StudentID) REFERENCES Students(StudentID);

        JOIN - Sirven para combinar resultados de más de una tabla, considerando que éstas deben de estar relacionadas entre ellas

        INNER JOIN
        SELECT columnNames
        FROM table1
        INNER JOIN tabl2 ON table1.column_name = table2.column_name;
			        FK tabla 1	    PK tabla 2

        SELECT e.EmployeeID, (e.FirstName + ' ' +  e.LastName) AS Name, o.OrderID, o.OrderDate, c.CompanyName, c.Country 
	        FROM Employees e 
	        INNER JOIN Orders o ON o.EmployeeID = e.EmployeeID 
	        INNER JOIN Customers c ON c.CustomerID = o.CustomerID 
	        ORDER BY c.Country;

        LEFT JOIN
        SELECT c.CompanyName, o.OrderID FROM Customers c LEFT JOIN Orders o ON o.CustomerID = c.CustomerID ORDER BY c.CompanyName; 
        Muestra a C# Academy a pesar de no haber hecho alguna orden

        GROUP BY & ORDER BY
	        SELECT COUNT(CustomerID) AS 'Customers by country', Country, City
	        FROM Customers
	        GROUP BY Country, City
	        ORDER BY COUNT(CustomerID) DESC, Country, City;






        */


    }
}

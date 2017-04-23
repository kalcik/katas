# Ticket Portal API Kata

## Mission

This Kata helps you:
* Exercise [TDD](https://en.wikipedia.org/wiki/Test-driven_development) or [Unit Tests](https://en.wikipedia.org/wiki/Unit_testing).
* Exercise [Integration Tests](https://www.youtube.com/watch?v=vqAaMVoKz1c).
* Exercise [Repository Pattern](https://www.google.at/search?q=repository+pattern).

## Description

Create REST Ticket Portal API to buy the tickets. Write Unit- and Integration tests.

To allow you be focused on the solution, there is already some implementation in the place. ```public async Task<IHttpActionResult> Post([FromBody] Ticket ticket)``` in [```TicketController.cs```][path-to-ticket-controller] is the entry point for the client to use Ticket Portal API. [```Ticket```](TicketPortalApi/Models/Ticket.cs) model used by this method can be used down to the all classes, which is not usual but the focus of this Kata is on different topic. Classes like [```TicketService.cs```](TicketPortalApi/Services/TicketService.cs) and [```TicketRepository.cs```](TicketPortalApi/Repositories/TicketRepository.cs) can be also helpful as they represent important part of repository pattern and mimic the business and data access layer. Database access is implemented in [```TicketPortalDb.cs```](TicketPortalApi/Repositories/TicketPortalDb.cs).

This Kata is using: 

* Some useful NuGet packages

    * [Autofac](https://autofac.org/)
    * Autofac.WebApi2
    * [Fluent Assertions](http://fluentassertions.com/)
    * [Moq](https://github.com/moq)
    * [RestSharp](http://restsharp.org/)

* EntityFramework to access the database

* ASP.Net Web Api 2

* [SQL Server LocalDB](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql) which is usually installed with Visual Studio installation. If not, you can use [standalone installer](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express). If necessary you can change the connection string in the [```ConnectionStrings.config```](ConnectionStrings.config).

## Exercise(s)

1. Choose if you use Top-Down, Bottom-Up, Sandwitch or Bing-Bang integration testing.
2. Implement method ```public async Task<IHttpActionResult> Post([FromBody] Ticket ticket)``` in [```TicketController.cs```][path-to-ticket-controller] so that this can be used by http client.

    The result is a persisted ticket in the database. Implement Integration tests which simulate the purchase of the ticket and Unit Tests for all methods.

[path-to-ticket-controller]: TicketPortalApi/Controllers/TicketController.cs
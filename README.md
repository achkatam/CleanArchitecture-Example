# Clean Architecture

### Software design pattern that emphasizes separation of concerns and the independence of various components of a software system. It provides a set of principles and guidelines for structuring and organizing software code that is easy to maintain, extend, and test.

## Domain
- The domain layer contains all of the entities, value objects, enums, interfaces and logic that is specific to the domain. It does not depend on any other layer in the system.

## Application
- The application layer is responsible for orchestrating all of the application logic and the necessary use-cases. It depends on the domain layer, but has no dependencies on any other layer. This layer defines additional interfaces that are required for supporting the application logic, that are implemented by outside layers. For example, the IDbContext interface is defined in this layer but implemented by the Persistence layer.

- This layer utilizes the CQRS pattern for structuring the application logic into commands and queries, using the MediatR library.

## Infrastucture
- The infrastructure layer contains classes tasked with accessing external resources. These classes are based on the interfaces defined within the application layer. In the current system, this layer is possibly oversimplified and redundant as it contains only the MachineDateTime class for getting the current UTC date and time.

## Persistence
- The persistence layer is responsible for implementing database related concerns. It contains EF Core Configurations for entities, implements the application database context and wires up some persistence related dependencies.

## Api
- The Api layer represents the last layer in the onion, and is responsible for glueing the entire system together. The only function of this layer is to accept HTTP requests, package them up into commands or queries, and send them somewhere else in the system to be processed and then return the result of that processing in the response. The controllers are designed to be as thin as possible.

<p align="center"><h1 align="center">Vertical Slice Architecture example in .NET 8</h1></p>
<p align="center">
	<!-- Shields.io badges disabled, using skill icons. --></p>
<p align="center">Built with the tools and technologies:</p>
<p align="center">
	<a href="https://skillicons.dev">
		<img src="https://skillicons.dev/icons?i=,cs,dotnet,redis,sqlite,rabbitmq&theme=light">
	</a></p>
<br>

- **Architecture:** Built on a microservices architecture for modularity, scalability, and reliability.
- **Core Modules:**
  - **Catalog, Basket, Discount, and Ordering** microservices.
  - Optimized with NoSQL (DocumentDB, Redis) and relational databases (PostgreSQL, SQL Server).
- **Communication:**
  - **RabbitMQ** for event-driven messaging.
  - **gRPC** for high-speed synchronous interactions.
- **Best Practices:**
  - Implements **CQRS, DDD, and Clean Architecture** for maintainability.
  - Uses **MediatR, FluentValidation, and MassTransit** for efficient request handling.
- **API Gateway:**
  - Managed with **YARP Reverse Proxy** for centralized traffic control and security.
- **Containerization:**
  - **Docker Compose** ensures seamless deployment.
  - Isolated environments for all services and databases.


## 🔗 Table of Contents

- [📍 Overview](#-overview)
- [👾 Features](#-features)
- [📁 Project Structure](#-project-structure)
  - [📂 Project Index](#-project-index)
- [🚀 Getting Started](#-getting-started)
  - [☑️ Prerequisites](#-prerequisites)
  - [⚙️ Installation](#-installation)
  - [🤖 Usage](#🤖-usage)
  - [🧪 Testing](#🧪-testing)
- [✍️ Authors](#✍️-authors)
- [🙌 Acknowledgments](#🙌-acknowledgments)

---

## 📍 Overview

eshopmicroservice is an open-source solution for building scalable and resilient e-commerce applications. It leverages microservices architecture, Docker containers, and message queues to provide a robust platform for managing catalogs, orders, and user interactions. Ideal for developers and businesses seeking a flexible and maintainable e-commerce infrastructure.

---

## 👾 Features

|      | Feature         | Summary       |
| :--- | :---:           | :---          |
| ⚙️  | **Architecture**  | <ul><li>Microservices architecture based on the provided dependencies and containerization with Docker.</li><li>Potential use of gRPC for communication between microservices, indicated by 'discount.proto' dependency.</li><li>Likely utilizes a message queue or event bus for asynchronous communication, inferred from 'BuildingBlocks/BuildingBlocks.Messaging/BuildingBlocks.Messaging.csproj'.</li></ul> |
| 🔩 | **Code Quality**  | <ul><li>Difficult to assess without code review. </li><li>Project structure and file naming conventions suggest potential adherence to coding standards.</li><li>Presence of 'dotnet-tools.json' suggests use of .NET tooling for code analysis and quality checks.</li></ul> |
| 📄 | **Documentation** | <ul><li>Primary language is C# based on the provided information.</li><li>Variety of file types including '.yml', '.dcproj', '.csproj', '.json', and '.cs' indicate a mix of configuration, project files, and source code.</li><li>Limited documentation details available for a comprehensive analysis.</li></ul> |
| 🔌 | **Integrations**  | <ul><li>Integration with Docker for containerization and deployment.</li><li>Potential integration with other microservices based on the 'discount.proto' dependency and communication patterns.</li><li>'basket.api.http' and 'ordering.api.http' suggest REST API integrations.</li></ul> |
| 🧩 | **Modularity**    | <ul><li>Microservice architecture inherently promotes modularity with distinct services responsible for specific functionalities.</li><li>Project structure with multiple '.csproj' files suggests individual projects or modules within the e_shop ecosystem.</li></ul> |
| 🧪 | **Testing**       | <ul><li>Difficult to assess testing practices without reviewing test code and coverage reports.</li><li>Presence of 'dotnet-tools.json' might indicate integration with .NET testing frameworks.</li></ul> |
| ⚡️  | **Performance**   | <ul><li>Performance characteristics are unknown without benchmarking data or performance analysis.</li><li>Containerization with Docker can potentially improve performance through resource optimization and scaling.</li></ul> |
| 🛡️ | **Security**      | <ul><li>Security measures are not explicitly mentioned in the provided details.</li><li>Best practices for secure coding, authentication, and authorization should be implemented based on industry standards.</li></ul> |
| 📦 | **Dependencies**  | <ul><li>Utilizes NuGet package manager for .NET dependencies.</li><li>Docker dependency for containerization and deployment.</li><li>Specific dependencies like 'discount.proto' suggest use of gRPC for communication.</li></ul> |

---

## 📁 Project Structure

```sh
└── VerticalSliceCommerceMicroservice/
    ├── README.md
    └── src
        ├── .DS_Store
        ├── .dockerignore
        ├── .idea
        │   └── .idea.shop-microservice
        │       └── .idea
        ├── ApiGateways
        │   └── YarpApiGateway
        │       ├── Program.cs
        │       ├── Properties
        │       ├── YarpApiGateway.csproj
        │       ├── appsettings.Development.json
        │       └── appsettings.json
        ├── BuildingBlocks
        │   ├── BuildingBlocks
        │   │   ├── Behaviors
        │   │   ├── BuildingBlocks.csproj
        │   │   ├── CQRS
        │   │   ├── Exceptions
        │   │   └── Pagination
        │   └── BuildingBlocks.Messaging
        │       ├── BuildingBlocks.Messaging.csproj
        │       ├── Events
        │       └── MassTransit
        ├── Services
        │   ├── .DS_Store
        │   ├── Basket
        │   │   ├── .DS_Store
        │   │   └── Basket.API
        │   ├── Catalog
        │   │   └── Catalog.API
        │   ├── Discount
        │   │   └── Discount.Grpc
        │   └── Ordering
        │       ├── Ordering.API
        │       ├── Ordering.Application
        │       ├── Ordering.Domain
        │       └── Ordering.Infrastructure
        ├── docker-compose.dcproj
        ├── docker-compose.override.yml
        ├── docker-compose.yml
        └── shop-microservice.sln
```


### 📂 Project Index
<details open>
	<summary><b><code>VerticalSliceCommerceMicroservice/</code></b></summary>
	<details> <!-- src Submodule -->
		<summary><b>src</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/shop-microservice.sln'>shop-microservice.sln</a></b></td>
				<td>- This file is a Visual Studio Solution (.sln) file that defines a multi-project solution<br>- It includes various projects with different configurations and settings, such as Debug and Release modes<br>- The solution also specifies dependencies between projects and provides a framework for building and deploying the entire application.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/docker-compose.override.yml'>docker-compose.override.yml</a></b></td>
				<td>- Defines the containerized environment for a multi-tiered e-commerce application<br>- It orchestrates the deployment of databases like CatalogDb, BasketDb, and OrderDb alongside essential services such as a distributed cache and a message broker<br>- This configuration ensures seamless communication and data management across different application components.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/docker-compose.yml'>docker-compose.yml</a></b></td>
				<td>- Defines the multi-container architecture for the e-shop application<br>- It specifies services like a catalog database, basket database, distributed cache, order database, and message broker, each running in its own Docker container<br>- The file also defines volumes to persist data across container restarts, ensuring data integrity and availability.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/docker-compose.dcproj'>docker-compose.dcproj</a></b></td>
				<td>- This project defines a Docker Compose configuration for the ordering API service<br>- It specifies the container images, ports, and dependencies required to run the API within a development environment<br>- The configuration allows for easy deployment and scaling of the application using Docker orchestration tools.</td>
			</tr>
			</table>
			<details>
				<summary><b>ApiGateways</b></summary>
				<blockquote>
					<details>
						<summary><b>YarpApiGateway</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/ApiGateways/YarpApiGateway/YarpApiGateway.csproj'>YarpApiGateway.csproj</a></b></td>
								<td>- Defines the YarpApiGateway project, a crucial component within the overall architecture<br>- This project leverages the Yarp reverse proxy library to manage and route incoming API requests to appropriate backend services<br>- It serves as an intermediary between clients and the application's core functionalities, ensuring efficient and secure communication.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/ApiGateways/YarpApiGateway/appsettings.Development.json'>appsettings.Development.json</a></b></td>
								<td>- Configures the Yarp API Gateway's behavior during development<br>- It defines routing rules that map incoming requests to specific microservices based on their paths, including rate limiting policies and URL transformations<br>- Additionally, it specifies the endpoints of each microservice cluster, allowing the gateway to connect and forward traffic appropriately.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/ApiGateways/YarpApiGateway/appsettings.json'>appsettings.json</a></b></td>
								<td>- The `appsettings.json` file configures the YarpApiGateway's runtime behavior<br>- It defines logging levels for different categories, ensuring appropriate verbosity for debugging and operational purposes<br>- Additionally, it specifies allowed hosts, controlling which domains can access the API gateway's services.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/ApiGateways/YarpApiGateway/Program.cs'>Program.cs</a></b></td>
								<td>- This program sets up a reverse proxy API gateway within the application's architecture<br>- It configures rate limiting policies to control incoming requests and utilizes a configuration file to define how traffic is routed to backend services<br>- The gateway acts as an intermediary, handling incoming requests and forwarding them to appropriate endpoints while enforcing rate limits for security and stability.</td>
							</tr>
							</table>
							<details>
								<summary><b>Properties</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/ApiGateways/YarpApiGateway/Properties/launchSettings.json'>launchSettings.json</a></b></td>
										<td>- Defines the configuration settings for launching and deploying the YarpApiGateway within different environments<br>- It specifies application URLs, debugging options, and authentication protocols for both local development and IIS Express deployments<br>- These configurations ensure proper setup and functionality of the API gateway within the overall project architecture.</td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
				</blockquote>
			</details>
			<details>
				<summary><b>BuildingBlocks</b></summary>
				<blockquote>
					<details>
						<summary><b>BuildingBlocks.Messaging</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks.Messaging/BuildingBlocks.Messaging.csproj'>BuildingBlocks.Messaging.csproj</a></b></td>
								<td>- Defines the Building Blocks Messaging project within the larger application architecture<br>- This project leverages MassTransit to facilitate communication between various components using RabbitMQ as the message broker, enabling asynchronous and reliable data exchange throughout the system.</td>
							</tr>
							</table>
							<details>
								<summary><b>Events</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks.Messaging/Events/BasketCheckoutEvent.cs'>BasketCheckoutEvent.cs</a></b></td>
										<td>- Defines the BasketCheckoutEvent, a record representing the details of a completed basket checkout process within the application's event-driven architecture<br>- It encapsulates customer information, order summary, shipping and billing addresses, and payment method details, facilitating communication and processing across different system components.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks.Messaging/Events/IntegrationEvent.cs'>IntegrationEvent.cs</a></b></td>
										<td>- Defines the base structure for integration events within the application's messaging system<br>- This `IntegrationEvent` class provides a common template for all event types, ensuring consistency in data representation and facilitating communication between different microservices.</td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>MassTransit</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks.Messaging/MassTransit/Extentions.cs'>Extentions.cs</a></b></td>
										<td>- This file defines an extension method that simplifies the integration of MassTransit messaging into a .NET application<br>- It allows developers to configure RabbitMQ as the message broker, define consumers based on provided assemblies, and set up endpoints for communication within the system.</td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>BuildingBlocks</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/BuildingBlocks.csproj'>BuildingBlocks.csproj</a></b></td>
								<td>- Defines the building blocks of the application by specifying dependencies required for core functionalities<br>- It leverages libraries like Mapster for object mapping, MediatR for dependency injection and command handling, FluentValidation for data validation, and Microsoft.FeatureManagement.AspNetCore for feature toggling.</td>
							</tr>
							</table>
							<details>
								<summary><b>CQRS</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/CQRS/IQuery.cs'>IQuery.cs</a></b></td>
										<td>- Defines the interface `IQuery` which serves as a blueprint for all read operations within the application's CQRS (Command Query Responsibility Segregation) pattern<br>- It ensures that queries, which retrieve data without modifying it, adhere to a standardized structure and return a specific response type.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/CQRS/IQueryHandler.cs'>IQueryHandler.cs</a></b></td>
										<td>- Defines the interface `IQueryHandler` which serves as a contract for handling queries within the application's CQRS (Command Query Responsibility Segregation) pattern<br>- It specifies how to process incoming queries and return corresponding responses, ensuring a clear separation of concerns between read and write operations.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/CQRS/ICommand.cs'>ICommand.cs</a></b></td>
										<td>- Defines the interface for commands within the CQRS (Command Query Responsibility Segregation) pattern<br>- These interfaces establish a contract for actions that modify the state of the application, ensuring they adhere to the defined structure and expectations<br>- This contributes to a clear separation of concerns and promotes testability within the codebase.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/CQRS/ICommandHandler.cs'>ICommandHandler.cs</a></b></td>
										<td>- Defines the interface for handling commands within the application's CQRS architecture<br>- It establishes a contract for classes responsible for processing incoming commands and producing corresponding responses, ensuring consistent interaction between command dispatchers and handlers.</td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Behaviors</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Behaviors/LoggingBehavior.cs'>LoggingBehavior.cs</a></b></td>
										<td>- The `LoggingBehavior` class enhances request handling within the application by recording detailed information about each executed request<br>- It logs the start and end of requests, including the type of request and response, along with the time taken to process it<br>- Additionally, it issues warnings if a request exceeds a specified threshold (3 seconds) for performance monitoring.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Behaviors/ValidationBehavior.cs'>ValidationBehavior.cs</a></b></td>
										<td>- The `ValidationBehavior` class ensures data integrity within the application by validating incoming requests before they reach their handlers<br>- It leverages FluentValidation to perform asynchronous validation against a set of defined rules, throwing a `ValidationException` if any failures occur<br>- This safeguards the system by preventing invalid data from being processed further.</td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Exceptions</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Exceptions/BadRequestException.cs'>BadRequestException.cs</a></b></td>
										<td>- Defines a custom exception type, BadRequestException, within the BuildingBlocks module<br>- This exception is specifically designed to signal invalid input or requests to the application, providing additional context through a "Details" property for more informative error handling.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Exceptions/InternalServerException.cs'>InternalServerException.cs</a></b></td>
										<td>- Defines an `InternalServerException` class within the BuildingBlocks library<br>- This exception type provides a structured way to handle and communicate server-side errors, including additional details about the error context<br>- It ensures consistent error reporting across the application, aiding in debugging and monitoring.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Exceptions/NotFoundException.cs'>NotFoundException.cs</a></b></td>
										<td>- Defines a custom exception type, `NotFoundException`,  specifically designed to signal when a requested entity is absent within the application's data store<br>- This exception provides a structured way to handle scenarios where resources are not located, improving error handling and clarity throughout the codebase.</td>
									</tr>
									</table>
									<details>
										<summary><b>Handler</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Exceptions/Handler/CustomExceptionHandler.cs'>CustomExceptionHandler.cs</a></b></td>
												<td>- CustomExceptionHandler gracefully handles exceptions within the application by categorizing them and returning appropriate HTTP status codes and error messages<br>- It logs errors, constructs detailed problem descriptions, and sends informative responses to clients, ensuring a robust and user-friendly experience even in the face of unexpected issues.</td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
							<details>
								<summary><b>Pagination</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Pagination/PaginationResult.cs'>PaginationResult.cs</a></b></td>
										<td>- The `PaginationResult` class encapsulates the results of a paginated query within the application's architecture<br>- It provides a structured representation of the current page index, page size, total record count, and the actual data retrieved for that specific page<br>- This facilitates efficient handling and display of large datasets across multiple pages.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/BuildingBlocks/BuildingBlocks/Pagination/PaginationRequest.cs'>PaginationRequest.cs</a></b></td>
										<td>- Defines a data structure for handling pagination requests within the application<br>- The `PaginationRequest` record encapsulates the required information to determine which portion of data should be retrieved, specifying both the page index and the desired page size<br>- This facilitates efficient data retrieval and display across various parts of the application that require paginated results.</td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
				</blockquote>
			</details>
			<details>
				<summary><b>Services</b></summary>
				<blockquote>
					<details>
						<summary><b>Basket</b></summary>
						<blockquote>
							<details>
								<summary><b>Basket.API</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/GlobalUsing.cs'>GlobalUsing.cs</a></b></td>
										<td>- GlobalUsing.cs establishes a shared namespace within the Basket API project<br>- It imports essential libraries and frameworks like Carter, MediatR, Mapster, FluentValidation, and Marten, enabling core functionalities such as routing, handling requests and events, data mapping, validation, and database interactions<br>- This file streamlines code organization and promotes reusability across the Basket API's components.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket.API.http'>Basket.API.http</a></b></td>
										<td>- Defines the API endpoint for retrieving a user's shopping basket<br>- This configuration specifies the host address and URL path used to access the basket service within the overall application architecture<br>- It also indicates the expected data format (application/json) for requests and responses.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket.API.csproj'>Basket.API.csproj</a></b></td>
										<td>- Defines the Basket API, a microservice responsible for managing shopping baskets within the system<br>- It leverages technologies like Marten for persistence, Carter for routing, and gRPC for communication with other services, particularly the Discount service<br>- The API exposes endpoints for creating, updating, and retrieving baskets, ensuring seamless integration with the broader application architecture.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/appsettings.Development.json'>appsettings.Development.json</a></b></td>
										<td>- Configures the development environment for the Basket API by defining connection strings for the database and Redis cache<br>- It also specifies settings for message broker communication, logging levels, and the gRPC endpoint for the Discount service<br>- These configurations are essential for the application to function correctly during development.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/appsettings.json'>appsettings.json</a></b></td>
										<td>- Configures the application's environment settings<br>- It defines connection strings for the database and Redis cache, specifies details for message broker communication, sets logging levels, and outlines the address of the Discount gRPC service<br>- These configurations are essential for the Basket API to function correctly within the larger project architecture.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Program.cs'>Program.cs</a></b></td>
										<td>- The `Program.cs` file bootstraps the Basket API application, configuring services and middleware necessary for its operation<br>- It sets up APIs, database connections, message brokers, health checks, and CORS policies to enable communication with other parts of the system and external clients.</td>
									</tr>
									</table>
									<details>
										<summary><b>Models</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Models/ShoppingCart.cs'>ShoppingCart.cs</a></b></td>
												<td>- The `ShoppingCart` class represents a user's shopping cart within the e-commerce application<br>- It stores a list of items along with their quantities and prices, allowing calculation of the total price<br>- This class facilitates the management of individual shopping carts for each user interacting with the system.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Models/ShoppingCartItem.cs'>ShoppingCartItem.cs</a></b></td>
												<td>- The `ShoppingCartItem` class defines the structure of individual items within a shopping cart<br>- It encapsulates essential information about each product, including quantity, color, price, unique identifier, and name<br>- This data is crucial for managing and processing shopping carts within the e-commerce application.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Properties</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Properties/launchSettings.json'>launchSettings.json</a></b></td>
												<td>- Defines the configuration settings for launching and debugging the Basket API application within different environments<br>- It specifies URLs, ports, authentication methods, and environment variables to ensure proper execution and integration with tools like IIS Express.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Data</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Data/CachedBasketRepository.cs'>CachedBasketRepository.cs</a></b></td>
												<td>- CachedBasketRepository provides a layer of caching on top of the core Basket repository<br>- It retrieves and stores shopping cart data from both the underlying database and an in-memory cache, improving performance by serving frequently accessed carts directly from the cache.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Data/BasketRepository.cs'>BasketRepository.cs</a></b></td>
												<td>- The `BasketRepository` class manages the persistence of shopping carts within the application's data store<br>- It provides methods to retrieve, store, and delete shopping cart data associated with a given user name<br>- This repository interacts with the database to ensure that shopping cart information is reliably saved and accessible.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Data/IBasketRepository.cs'>IBasketRepository.cs</a></b></td>
												<td>- The `IBasketRepository` interface defines the methods for interacting with shopping cart data within the application<br>- It enables retrieval, storage, and deletion of shopping carts associated with specific user names, ensuring a robust and scalable mechanism for managing user shopping experiences.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Exceptions</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Exceptions/BasketNotFoundException.cs'>BasketNotFoundException.cs</a></b></td>
												<td>- Defines a custom exception, BasketNotFoundException, within the Basket API service<br>- This exception is thrown when a user's shopping basket cannot be found, providing a specific error message that includes the user's name<br>- This helps in handling and reporting errors related to missing baskets gracefully within the application.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Dtos</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Dtos/BasketCheckoutDto.cs'>BasketCheckoutDto.cs</a></b></td>
												<td>- BasketCheckoutDto defines the structure of data required to process a checkout request within the e-commerce system<br>- It encapsulates customer information, shipping and billing addresses, payment details, and the total price of the order<br>- This DTO facilitates communication between different services involved in the checkout process.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Basket</b></summary>
										<blockquote>
											<details>
												<summary><b>DeleteBasket</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/DeleteBasket/DeleteBasketEndpoints.cs'>DeleteBasketEndpoints.cs</a></b></td>
														<td>- Defines endpoints for deleting a user's shopping basket within the application<br>- It handles incoming DELETE requests to the "/basket/{userName}" path, processes the request using a command pattern, and returns an appropriate response indicating success or failure<br>- The endpoint integrates with other components like message sending and result adaptation to manage the deletion process.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/DeleteBasket/DeleteBasketHandler.cs'>DeleteBasketHandler.cs</a></b></td>
														<td>- Manages the deletion of a user's shopping basket<br>- It receives a command containing the user's name and interacts with a repository to remove the associated basket data<br>- Upon successful deletion, it returns a confirmation result indicating success<br>- This functionality contributes to the overall e-commerce platform by allowing users to clear their shopping carts.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>CheckoutBasket</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/CheckoutBasket/CheckoutBasketHandler.cs'>CheckoutBasketHandler.cs</a></b></td>
														<td>- The `CheckoutBasketHandler` orchestrates the checkout process for a user's shopping basket<br>- It retrieves the basket, calculates its total price, publishes a checkout event to a message queue, and then deletes the basket from storage<br>- This ensures that the order is processed and recorded for fulfillment.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/CheckoutBasket/CheckoutBasketEndpoints.cs'>CheckoutBasketEndpoints.cs</a></b></td>
														<td>- Defines the API endpoint responsible for handling basket checkout requests within the application<br>- It receives a request containing basket details, processes it as a command, and returns a success or failure response to the client<br>- This endpoint integrates with the messaging system to send the checkout command for processing.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>StoreBasket</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/StoreBasket/StoreBasketEndpoints.cs'>StoreBasketEndpoints.cs</a></b></td>
														<td>- Defines an API endpoint responsible for storing a user's shopping basket<br>- It accepts a shopping cart as input, processes the request using a command pattern, and returns a confirmation with the user's name upon successful storage<br>- This endpoint integrates with other components within the application to manage user baskets and their associated data.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/StoreBasket/StoreBasketHandler.cs'>StoreBasketHandler.cs</a></b></td>
														<td>- The `StoreBasketCommandHandler` orchestrates the process of storing a shopping cart within the system<br>- It validates the incoming cart data, applies discounts to each item using a gRPC service, and persists the final cart to the repository<br>- Upon successful completion, it returns a confirmation message containing the user's name.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetBasket</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/GetBasket/GetBasketEndpoints.cs'>GetBasketEndpoints.cs</a></b></td>
														<td>- Defines endpoints for retrieving a user's shopping basket<br>- It maps a GET request to a specific URL path with the user name as a parameter, processes the request using an internal query handler, and returns the retrieved shopping cart data as a JSON response<br>- This functionality contributes to the overall e-commerce application by enabling users to access their shopping baskets.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Basket/Basket.API/Basket/GetBasket/GetBasketHandler.cs'>GetBasketHandler.cs</a></b></td>
														<td>- Handles retrieving a shopping basket associated with a given user name<br>- It defines a query to request the basket and a handler that retrieves it from the repository, returning the shopping cart data<br>- This functionality is essential for managing individual user shopping experiences within the e-commerce application.</td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Ordering</b></summary>
						<blockquote>
							<details>
								<summary><b>Ordering.Domain</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Ordering.Domain.csproj'>Ordering.Domain.csproj</a></b></td>
										<td>- Defines the domain logic for order processing within the application<br>- It leverages the MediatR library to handle command and query operations related to orders, ensuring a clear separation of concerns between business rules and infrastructure<br>- Let me know if you need further clarification on any aspect of this summary or the project structure!</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/GlobalUsing.cs'>GlobalUsing.cs</a></b></td>
										<td>- This file establishes global namespaces within the Ordering domain of the application<br>- It ensures that classes and types defined across various modules like abstractions, models, value objects, enums, exceptions, and events are readily accessible throughout the Ordering service's codebase.</td>
									</tr>
									</table>
									<details>
										<summary><b>Models</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Models/OrderItem.cs'>OrderItem.cs</a></b></td>
												<td>- Defines the OrderItem model within the Ordering domain<br>- It represents a single item included in an order, encapsulating details like the order ID, product ID, quantity, and price<br>- This model contributes to the overall structure of managing and processing orders within the application.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Models/Customer.cs'>Customer.cs</a></b></td>
												<td>- Defines the Customer entity within the Ordering domain<br>- It encapsulates customer information like name and email, ensuring data integrity through validation during creation<br>- This model serves as a blueprint for representing individual customers in the ordering system.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Models/Product.cs'>Product.cs</a></b></td>
												<td>- Defines the Product model within the Ordering domain<br>- It encapsulates product attributes like name and price, ensuring data integrity through validation during creation<br>- This model serves as the foundation for representing individual products in the ordering system.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Models/Order.cs'>Order.cs</a></b></td>
												<td>- The `Order` class defines the structure and behavior of an order within the application's domain model<br>- It encapsulates details like customer information, shipping and billing addresses, payment method, order items, and status<br>- This class enables the creation, modification, and management of orders throughout their lifecycle.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Enums</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Enums/OrderStatus.cs'>OrderStatus.cs</a></b></td>
												<td>- Defines the possible states an order can be in within the ordering service<br>- This enumeration, `OrderStatus`, provides a structured way to represent the lifecycle of an order, from its initial creation as a "Draft" to its eventual completion or cancellation.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Events</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Events/OrderCreatedEvent.cs'>OrderCreatedEvent.cs</a></b></td>
												<td>- Defines the `OrderCreatedEvent`, a record representing an order creation event within the Ordering domain<br>- This event adheres to the `IDomainEvent` interface, signaling a significant change in the ordering process and allowing for downstream actions or notifications based on this event.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Events/OrderUpdatedEvent.cs'>OrderUpdatedEvent.cs</a></b></td>
												<td>- Defines an event that signals a change has occurred within the ordering domain<br>- The `OrderUpdatedEvent` records the updated order information, allowing other components of the application to react to and process these changes within the larger system architecture.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Abstractions</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Abstractions/Entity.cs'>Entity.cs</a></b></td>
												<td>- Defines the base structure for entities within the Ordering domain<br>- This abstraction establishes common properties like an identifier, creation and modification timestamps, and associated user information<br>- It ensures consistency across all entity types used in managing order-related data.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Abstractions/IDomainEvent.cs'>IDomainEvent.cs</a></b></td>
												<td>- Defines the blueprint for domain events within the Ordering service<br>- This interface ensures all domain events adhere to a consistent structure, including a unique identifier, timestamp of occurrence, and type information<br>- This standardization facilitates event handling and communication across various components of the application.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Abstractions/IEntity.cs'>IEntity.cs</a></b></td>
												<td>- Defines the common properties and behaviors expected of all entities within the Ordering domain<br>- The `IEntity` interface establishes conventions for tracking creation and modification timestamps, along with associated user identifiers<br>- The `IEntity<T>` interface builds upon this foundation by requiring a unique identifier (`Id`) specific to each entity type.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Abstractions/IAggregate.cs'>IAggregate.cs</a></b></td>
												<td>- Defines the core interface for aggregates within the Ordering domain<br>- Aggregates represent a cluster of related entities and encapsulate business logic<br>- This interface establishes common behaviors like managing domain events, ensuring consistency across aggregate implementations.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Abstractions/Aggregate.cs'>Aggregate.cs</a></b></td>
												<td>- Defines the base structure for aggregates within the Ordering domain<br>- It provides a mechanism for tracking and managing domain events associated with each aggregate, enabling features like event sourcing and asynchronous processing of business logic changes<br>- This abstraction ensures consistency and maintainability across various ordering-related entities.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>ValueObjects</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/OrderItemId.cs'>OrderItemId.cs</a></b></td>
												<td>- Defines a value object representing a unique identifier for an order item within the Ordering domain<br>- It ensures that each OrderItemId is non-empty and utilizes a GUID to guarantee uniqueness<br>- This class contributes to data integrity and consistency by enforcing these constraints during order item creation and management.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/OrderName.cs'>OrderName.cs</a></b></td>
												<td>- Defines the `OrderName` value object within the Ordering domain<br>- It encapsulates a string representing an order name and ensures its validity through input validation<br>- This value object contributes to maintaining data integrity and consistency across the ordering service.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/Address.cs'>Address.cs</a></b></td>
												<td>- Defines an immutable `Address` value object that encapsulates customer shipping information<br>- This object ensures data integrity and consistency within the ordering domain by enforcing validation rules and providing a structured representation of address details.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/Payment.cs'>Payment.cs</a></b></td>
												<td>- Defines the Payment value object within the Ordering domain<br>- It encapsulates payment card details like name, number, expiration date, CVV, and payment method<br>- The `Of` method constructs a valid `Payment` instance, ensuring data integrity through validation checks<br>- This object represents a crucial component for processing orders securely and accurately.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/OrderId.cs'>OrderId.cs</a></b></td>
												<td>- Defines the OrderId value object within the Ordering domain<br>- It encapsulates a unique identifier for each order, ensuring it's not empty and adheres to the required Guid format<br>- This class contributes to maintaining data integrity and consistency across the ordering system.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/ProductId.cs'>ProductId.cs</a></b></td>
												<td>- Defines a value object representing a unique product identifier within the ordering domain<br>- It ensures that each product ID is a non-empty GUID and provides a factory method to create valid instances, enforcing data integrity and consistency across the application.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/ValueObjects/CustomerId.cs'>CustomerId.cs</a></b></td>
												<td>- Defines a value object representing a unique customer identifier within the ordering domain<br>- It encapsulates a GUID and provides methods to ensure valid customer IDs are created, preventing empty or invalid values from being used in the system.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Exceptions</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Domain/Exceptions/DomainException.cs'>DomainException.cs</a></b></td>
												<td>- Defines a custom exception type, `DomainException`, within the Ordering domain layer<br>- This exception is specifically designed to be thrown when errors occur during business logic operations within the domain, providing a clear indication of the source of the issue.</td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
							<details>
								<summary><b>Ordering.Infrastructure</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/GlobalUsing.cs'>GlobalUsing.cs</a></b></td>
										<td>- GlobalUsing.cs defines a set of global namespaces used throughout the Ordering service's infrastructure layer<br>- It ensures consistent access to domain models, value objects, enumerations, abstractions, data access components, and Entity Framework Core functionalities, streamlining development and promoting code reusability within the project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Ordering.Infrastructure.csproj'>Ordering.Infrastructure.csproj</a></b></td>
										<td>- Defines the infrastructure layer for the Ordering service<br>- It establishes a connection to a SQL Server database using Entity Framework Core and references the Ordering Application project, enabling data persistence and interaction within the ordering system.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/DependencyInjection.cs'>DependencyInjection.cs</a></b></td>
										<td>- This file configures the infrastructure layer of the Ordering service by registering dependencies within the application's service container<br>- It establishes connections to the database, sets up interceptors for auditing and event dispatching, and registers concrete implementations of interfaces defined in the application layer.</td>
									</tr>
									</table>
									<details>
										<summary><b>Data</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/ApplicationDbContext.cs'>ApplicationDbContext.cs</a></b></td>
												<td>- Manages the database schema and interactions for the Ordering service<br>- It defines DbSet properties to represent entities like Customers, Products, Orders, and OrderItems, allowing data persistence and retrieval<br>- The context also utilizes Entity Framework Core conventions and configuration mappings defined within the assembly.</td>
											</tr>
											</table>
											<details>
												<summary><b>Migrations</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Migrations/20241115122435_InitialCreate.Designer.cs'>20241115122435_InitialCreate.Designer.cs</a></b></td>
														<td>- This code defines a database schema using Entity Framework Core<br>- It creates entities for Customers, Orders, OrderItems, and Products, establishing relationships between them<br>- Each entity has properties representing attributes like name, price, quantity, and timestamps for creation and modification.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Migrations/20241115122435_InitialCreate.cs'>20241115122435_InitialCreate.cs</a></b></td>
														<td>- This C# code defines a database migration script using Entity Framework Core<br>- The script creates tables for Customers, Products, Orders, and OrderItems, establishing relationships between them<br>- It also defines indexes to improve query performance<br>- The Down method provides the reverse operations to delete these tables.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Migrations/ApplicationDbContextModelSnapshot.cs'>ApplicationDbContextModelSnapshot.cs</a></b></td>
														<td>- This code defines a database schema using Entity Framework Core<br>- It establishes relationships between entities like Customers, Orders, OrderItems, and Products<br>- The schema includes properties for each entity and specifies primary keys, foreign keys, and data types<br>- This structure is essential for managing and querying relational data within an application.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>Interceptors</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Interceptors/AuditableEntityInterceptor.cs'>AuditableEntityInterceptor.cs</a></b></td>
														<td>- AuditableEntityInterceptor manages the creation and modification timestamps for entities within the Ordering service's database<br>- It automatically sets the "CreatedBy", "CreatedAt", "LastModifiedBy", and "LastModified" properties on each entity based on its state (Added, Modified) ensuring a consistent audit trail of data changes.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Interceptors/DispatchDomainEventsInterceptor.cs'>DispatchDomainEventsInterceptor.cs</a></b></td>
														<td>- This interceptor manages the publication of domain events within the Ordering service's database context<br>- It intercepts database saving operations and dispatches any accumulated domain events to the MediatR bus for further processing<br>- This ensures that domain events are published consistently after changes are made to the database.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>Extensions</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Extensions/DatabaseExtensions.cs'>DatabaseExtensions.cs</a></b></td>
														<td>- DatabaseExtensions initializes and populates the application database<br>- It ensures that essential data such as customers, products, and orders are present when the application starts<br>- This initialization process includes migrating the database schema and seeding it with initial data sets defined in the InitialData class.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Extensions/InitialData.cs'>InitialData.cs</a></b></td>
														<td>- InitialData provides sample data for the Ordering system, initializing customers, products, and orders with items<br>- This ensures a populated database for testing and development purposes within the larger application architecture.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>Configurations</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Configurations/OrderItemConfiguration.cs'>OrderItemConfiguration.cs</a></b></td>
														<td>- Defines the structure and relationships of OrderItem entities within the database schema<br>- It establishes a primary key for each order item, maps the product association, and enforces required fields for quantity and price<br>- This configuration ensures data integrity and consistency for order items in the Ordering service.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Configurations/ProductConfiguration.cs'>ProductConfiguration.cs</a></b></td>
														<td>- ProductConfiguration defines the structure and behavior of the Product entity within the Ordering service's database schema<br>- It establishes the primary key, ensures a specific data type conversion for the product ID, and sets constraints on the product name field<br>- This configuration directly impacts how product data is stored and retrieved, ensuring data integrity and consistency within the ordering system.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Configurations/CustomerConfiguration.cs'>CustomerConfiguration.cs</a></b></td>
														<td>- Defines the structure and properties of the 'Customer' entity within the Ordering service's database schema<br>- It specifies a unique identifier for each customer, enforces data validation rules for name and email, and ensures that email addresses are unique across all customers<br>- This configuration contributes to the overall data integrity and consistency of the ordering system.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Infrastructure/Data/Configurations/OrderConfiguration.cs'>OrderConfiguration.cs</a></b></td>
														<td>- OrderConfiguration defines the structure and relationships of Order entities within the database schema<br>- It specifies data types, constraints, and foreign keys to ensure accurate representation and efficient retrieval of order information, including customer details, order items, shipping and billing addresses, payment methods, status, and total price.</td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
								</blockquote>
							</details>
							<details>
								<summary><b>Ordering.Application</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Ordering.Application.csproj'>Ordering.Application.csproj</a></b></td>
										<td>- Defines the Ordering.Application project, a core component responsible for orchestrating business logic within the ordering domain<br>- It leverages the BuildingBlocks library for messaging and foundational services, interacts with the Ordering Domain for data access, and utilizes Entity Framework Core for database interactions.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/GlobalUsing.cs'>GlobalUsing.cs</a></b></td>
										<td>- GlobalUsing.cs establishes a shared namespace within the Ordering Application project<br>- It ensures that various components like domain models, value objects, CQRS implementations, data access layers, DTOs, exceptions, and event handling mechanisms are readily accessible across different parts of the application codebase.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/DependencyInjection.cs'>DependencyInjection.cs</a></b></td>
										<td>- The `DependencyInjection` class within the Ordering Application module configures and registers essential services required by the ordering application<br>- It sets up dependency injection for MediatR, enabling command and query handling, integrates feature management capabilities, and connects the application to the message broker for asynchronous communication.</td>
									</tr>
									</table>
									<details>
										<summary><b>Data</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Data/IApplicationDbContext.cs'>IApplicationDbContext.cs</a></b></td>
												<td>- Defines the interface for interacting with the application's database context<br>- It specifies the available DbSet properties for Orders, Customers, Products, and OrderItems, enabling data access and manipulation within the Ordering application<br>- The interface also includes a SaveChangesAsync method for persisting changes to the database.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Extentions</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Extentions/OrderExtensions.cs'>OrderExtensions.cs</a></b></td>
												<td>- The `OrderExtensions` class facilitates the transformation of Order objects into their corresponding DTO (Data Transfer Object) representations<br>- This conversion is crucial for transferring order data between different layers of the application, enabling seamless communication and data exchange within the ordering service's architecture.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Exceptions</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Exceptions/OrderNotFoundException.cs'>OrderNotFoundException.cs</a></b></td>
												<td>- Defines a custom exception, OrderNotFoundException, within the Ordering application's exception handling layer<br>- This exception is specifically raised when an order with a given ID cannot be found in the system, providing a clear indication of this failure scenario to calling code and facilitating appropriate error handling.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Dtos</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Dtos/OrderItemDto.cs'>OrderItemDto.cs</a></b></td>
												<td>- Defines the `OrderItemDto` data transfer object within the Ordering application<br>- This structure represents a single item within an order, encapsulating its OrderId, ProductId, Quantity, and Price<br>- It facilitates communication between different layers of the application, ensuring consistent data representation when handling order items.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Dtos/AddressDto.cs'>AddressDto.cs</a></b></td>
												<td>- Defines the structure for representing an address within the ordering application<br>- This data transfer object (DTO) encapsulates essential address information like name, email, and location details, facilitating communication between different layers of the application.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Dtos/OrderDto.cs'>OrderDto.cs</a></b></td>
												<td>- The `OrderDto` class defines a data transfer object representing an order within the application layer<br>- It encapsulates essential order information such as customer details, shipping and billing addresses, payment information, status, and a list of associated order items<br>- This structure facilitates seamless communication between different components of the ordering service.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Dtos/PaymentDto.cs'>PaymentDto.cs</a></b></td>
												<td>- Defines the PaymentDto, a data transfer object used within the Ordering application to represent payment information<br>- This DTO encapsulates details like card name, number, expiration date, CVV, and payment method, facilitating secure and structured communication between different components of the ordering system.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Orders</b></summary>
										<blockquote>
											<details>
												<summary><b>Commands</b></summary>
												<blockquote>
													<details>
														<summary><b>DeleteOrder</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Commands/DeleteOrder/DeleteOrderCommandHandler.cs'>DeleteOrderCommandHandler.cs</a></b></td>
																<td>- Handles the deletion of an order within the application<br>- It retrieves the order from the database based on the provided order ID and removes it if found<br>- The command handler then saves the changes to the database and returns a confirmation result indicating successful deletion.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Commands/DeleteOrder/DeleteOrderCommand.cs'>DeleteOrderCommand.cs</a></b></td>
																<td>- Defines the structure and validation rules for deleting an order within the ordering service<br>- The `DeleteOrderCommand` encapsulates the order ID required for deletion, while the `DeleteOrderResult` indicates the success or failure of the operation<br>- This command follows a pattern common in CQRS architectures, separating commands from queries for a more structured application design.</td>
															</tr>
															</table>
														</blockquote>
													</details>
													<details>
														<summary><b>UpdateOrder</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Commands/UpdateOrder/UpdateOrderCommandHandler.cs'>UpdateOrderCommandHandler.cs</a></b></td>
																<td>- This command handler processes requests to update existing orders within the system<br>- It retrieves the order from the database, updates its details based on provided data, and saves the changes<br>- The handler ensures that the order exists before proceeding with the update and handles potential exceptions if the order is not found.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Commands/UpdateOrder/UpdateOrderCommand.cs'>UpdateOrderCommand.cs</a></b></td>
																<td>- Defines the `UpdateOrderCommand` used to modify existing orders within the Ordering service<br>- It encapsulates order details as a DTO and leverages FluentValidation to ensure data integrity before processing the update request<br>- The command's successful execution is indicated by an `UpdateOrderResult`.</td>
															</tr>
															</table>
														</blockquote>
													</details>
													<details>
														<summary><b>CreateOrder</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Commands/CreateOrder/CreateOrderCommandHandler.cs'>CreateOrderCommandHandler.cs</a></b></td>
																<td>- This command handler processes incoming create order requests<br>- It constructs a new order object based on the provided order details, including customer information, shipping and billing addresses, payment method, and order items<br>- The newly created order is then persisted to the database.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Commands/CreateOrder/CreateOrderCommand.cs'>CreateOrderCommand.cs</a></b></td>
																<td>- Defines the structure and validation rules for creating new orders within the application<br>- It specifies the required data fields for an order, including its name, customer ID, and list of items<br>- This command ensures data integrity and consistency when processing new order requests.</td>
															</tr>
															</table>
														</blockquote>
													</details>
												</blockquote>
											</details>
											<details>
												<summary><b>Queries</b></summary>
												<blockquote>
													<details>
														<summary><b>GetOrders</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Queries/GetOrders/GetOrdersQueryHandler.cs'>GetOrdersQueryHandler.cs</a></b></td>
																<td>- Retrieves orders from the database based on pagination parameters provided by a GetOrdersQuery<br>- The handler fetches a specified number of orders, ordered alphabetically by order name, and calculates the total count of orders available<br>- It then constructs a PaginatedResult containing the retrieved orders and relevant metadata for display or further processing within the application.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Queries/GetOrders/GetOrdersQuery.cs'>GetOrdersQuery.cs</a></b></td>
																<td>- Defines the `GetOrdersQuery` used to retrieve orders within the Ordering application<br>- This query accepts a pagination request and returns a result containing paginated orders represented as `OrderDto` objects<br>- This functionality supports retrieving orders in a controlled manner, allowing for efficient data retrieval based on user needs.</td>
															</tr>
															</table>
														</blockquote>
													</details>
													<details>
														<summary><b>GetOrdersByName</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Queries/GetOrdersByName/GetOrdersByNameQueryHandler.cs'>GetOrdersByNameQueryHandler.cs</a></b></td>
																<td>- The `GetOrdersByNameQueryHandler` retrieves orders from the database based on a provided name<br>- It queries the `Orders` table, including related order items, and filters results to match the specified name<br>- The handler then returns a list of orders in a formatted DTO (Data Transfer Object) suitable for presentation or further processing within the application.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Queries/GetOrdersByName/GetOrdersByNameQuery.cs'>GetOrdersByNameQuery.cs</a></b></td>
																<td>- Defines a query to retrieve orders based on a given name within the Ordering application<br>- It encapsulates the criteria for the search (a customer's name) and specifies the expected result structure, which includes a collection of order details<br>- This query contributes to the overall functionality of retrieving and managing order information within the system.</td>
															</tr>
															</table>
														</blockquote>
													</details>
													<details>
														<summary><b>GetOrdersByCustomer</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Queries/GetOrdersByCustomer/GetOrdersByCustomerQueryHandler.cs'>GetOrdersByCustomerQueryHandler.cs</a></b></td>
																<td>- This handler retrieves orders associated with a specific customer from the database<br>- It fetches order details, including order items, and sorts them alphabetically by order name<br>- The retrieved data is then transformed into a format suitable for presentation to the user within the application's ordering service.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/Queries/GetOrdersByCustomer/GetOrdersByCustomerQuery.cs'>GetOrdersByCustomerQuery.cs</a></b></td>
																<td>- Defines a query to retrieve orders associated with a specific customer within the ordering service<br>- It encapsulates the request parameters and the expected result structure, facilitating communication between application layers and data access components<br>- This aligns with the project's goal of providing a modular and well-defined architecture for managing order information.</td>
															</tr>
															</table>
														</blockquote>
													</details>
												</blockquote>
											</details>
											<details>
												<summary><b>EventHandlers</b></summary>
												<blockquote>
													<details>
														<summary><b>Domain</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/EventHandlers/Domain/OrderCreatedEventHandler.cs'>OrderCreatedEventHandler.cs</a></b></td>
																<td>- This event handler processes the "OrderCreatedEvent" within the Ordering service's application layer<br>- It logs the event and, if the "OrderFullfilment" feature is enabled, publishes an integration event representing the created order to a message bus<br>- This enables downstream services to be notified about new orders.</td>
															</tr>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/EventHandlers/Domain/OrderUpdatedEventHandler.cs'>OrderUpdatedEventHandler.cs</a></b></td>
																<td>- Handles the OrderUpdatedEvent within the Ordering application's domain layer<br>- When an OrderUpdatedEvent is raised, this event handler logs a message indicating the event type was handled<br>- This ensures proper logging and tracking of domain events within the ordering system's architecture.</td>
															</tr>
															</table>
														</blockquote>
													</details>
													<details>
														<summary><b>Integration</b></summary>
														<blockquote>
															<table>
															<tr>
																<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.Application/Orders/EventHandlers/Integration/BasketCheckoutEventHandler.cs'>BasketCheckoutEventHandler.cs</a></b></td>
																<td>- This event handler processes the "BasketCheckoutEvent", signifying a customer's checkout action<br>- It maps the event data into a "CreateOrderCommand" which is then sent to initiate the order creation process within the Ordering service<br>- This integration ensures a seamless transition from the shopping cart to the order management system.</td>
															</tr>
															</table>
														</blockquote>
													</details>
												</blockquote>
											</details>
										</blockquote>
									</details>
								</blockquote>
							</details>
							<details>
								<summary><b>Ordering.API</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/GlobalUsing.cs'>GlobalUsing.cs</a></b></td>
										<td>- GlobalUsing.cs establishes a foundational framework within the Ordering API by globally importing essential libraries and namespaces<br>- This file ensures seamless integration of Carter for web API development, Mapster for object mapping, MediatR for handling asynchronous requests, and custom DTOs defined in the Ordering.Application project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Ordering.API.http'>Ordering.API.http</a></b></td>
										<td>- Defines the base address for the Ordering API within the application's architecture<br>- This configuration ensures proper communication between different services and components, facilitating seamless order processing across the system.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/DependencyInjection.cs'>DependencyInjection.cs</a></b></td>
										<td>- Configures the Ordering API's dependencies and services<br>- It sets up Carter as the web framework, integrates Swagger for documentation,  implements health checks using SQL Server, and configures exception handling<br>- The file also enables development features like Swagger UI and HTTPS redirection.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Dockerfile'>Dockerfile</a></b></td>
										<td>- This Dockerfile defines the build and deployment process for the Ordering API service within the larger application architecture<br>- It leverages multi-stage builds to efficiently compile, publish, and containerize the application, ensuring a streamlined and optimized deployment process.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Ordering.API.csproj'>Ordering.API.csproj</a></b></td>
										<td>- Defines the Ordering API project, a web application built using ASP.NET Core that exposes endpoints for managing orders<br>- It leverages dependency injection to integrate with the Ordering Application and Infrastructure projects, providing a robust and scalable solution for order processing<br>- The API utilizes Swagger documentation and health checks for monitoring and developer convenience.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/appsettings.Development.json'>appsettings.Development.json</a></b></td>
										<td>- Configures the development environment for the Ordering API service<br>- It defines connection strings for the database and message broker, sets feature flags for order fulfillment, and specifies logging levels for different components within the application.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/appsettings.json'>appsettings.json</a></b></td>
										<td>- Configures the application's environment settings<br>- It defines connection strings for accessing the database and message broker, sets logging levels, and specifies allowed hosts for secure communication<br>- These configurations are essential for the Ordering API to function correctly within the overall project architecture.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Program.cs'>Program.cs</a></b></td>
										<td>- The `Program.cs` file bootstraps the Ordering API application<br>- It configures services such as application logic, infrastructure components, and API endpoints<br>- Furthermore, it initializes the database during development and sets up the request pipeline to handle incoming HTTP requests.</td>
									</tr>
									</table>
									<details>
										<summary><b>Properties</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Properties/launchSettings.json'>launchSettings.json</a></b></td>
												<td>- Configures the development environment for the Ordering API within the project<br>- It defines launch settings for different profiles like HTTP, HTTPS, and IIS Express, specifying URLs, ports, authentication methods, and environment variables<br>- These settings enable seamless local development and debugging of the Ordering API.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Endpoints</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Endpoints/DeleteOrder.cs'>DeleteOrder.cs</a></b></td>
												<td>- The `DeleteOrder` class defines an endpoint within the Ordering API responsible for deleting an order by its unique identifier<br>- It sends a `DeleteOrderCommand` to the application layer, processes the result, and returns an appropriate HTTP response indicating success or failure.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Endpoints/UpdateOrder.cs'>UpdateOrder.cs</a></b></td>
												<td>- Defines an API endpoint for updating existing orders within the Ordering system<br>- It accepts a request containing updated order details, processes the update using an internal command handler, and returns a success/failure response to the client<br>- This endpoint integrates with the broader application architecture by utilizing message sending mechanisms for asynchronous processing of updates.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Endpoints/GetOrders.cs'>GetOrders.cs</a></b></td>
												<td>- Defines an endpoint within the Ordering API responsible for retrieving orders<br>- It accepts pagination parameters and utilizes a query handler to fetch orders from the application layer<br>- The retrieved orders are then presented as a paginated response, adhering to standard HTTP status codes and documentation conventions.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Endpoints/GetOrdersByCustomer.cs'>GetOrdersByCustomer.cs</a></b></td>
												<td>- Defines an API endpoint for retrieving customer orders<br>- It accepts a customer ID as input and utilizes the `GetOrdersByCustomerQuery` to fetch relevant order data from the application layer<br>- The retrieved orders are then formatted into a response object and returned to the client with a successful status code.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Endpoints/GetOrdersByName.cs'>GetOrdersByName.cs</a></b></td>
												<td>- Defines an API endpoint for retrieving orders based on a provided name<br>- This endpoint leverages the `GetOrdersByNameQuery` from the application layer to fetch relevant order data and returns the results as a `GetOrdersByNameResponse` object<br>- The endpoint is documented with clear summaries and descriptions, adhering to best practices for API design within the Ordering service.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Ordering/Ordering.API/Endpoints/CreateOrder.cs'>CreateOrder.cs</a></b></td>
												<td>- Defines an endpoint within the Ordering API responsible for creating new orders<br>- It accepts a CreateOrderRequest containing order details, processes the request using a command handler, and returns a Created response with the newly generated order ID<br>- This endpoint integrates seamlessly with the application's ordering service to manage order creation.</td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Discount</b></summary>
						<blockquote>
							<details>
								<summary><b>Discount.Grpc</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/discountdb'>discountdb</a></b></td>
										<td>- Please provide me with the code file and the "PROJECT STRUCTURE" context details so I can generate a succinct summary for you<br>- Once you give me that information, I'll be able to:

* **Analyze the code:** Understand its functionality within the larger project.
* **Relate it to the architecture:** Explain how this file contributes to the overall design and goals of the project.
* **Write a clear summary:**  Provide a concise explanation of what the code achieves, avoiding technical jargon and focusing on the "big picture." 


Let's work together to make your open-source project even better!</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Dockerfile'>Dockerfile</a></b></td>
										<td>- This Dockerfile defines the build and deployment process for a gRPC service responsible for handling discount calculations within the application<br>- It leverages multi-stage builds to optimize image size, ensuring a lean and efficient runtime environment for the service.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Discount.Grpc.csproj'>Discount.Grpc.csproj</a></b></td>
										<td>- Defines the gRPC service for managing discounts within the application's architecture<br>- It leverages gRPC for communication, Mapster for object mapping, and Entity Framework Core for data persistence using a SQLite database<br>- The service exposes functionalities related to discount creation, retrieval, and modification through well-defined API endpoints.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/appsettings.Development.json'>appsettings.Development.json</a></b></td>
										<td>- Configures the Discount gRPC service's environment settings during development<br>- It specifies the connection string to access the discount database and sets the logging level for information messages<br>- These configurations are essential for the service to function correctly within the larger project architecture, enabling it to interact with the database and log relevant events.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/appsettings.json'>appsettings.json</a></b></td>
										<td>- Configures the Discount gRPC service by defining connection strings to the database, logging levels, allowed hosts, and Kestrel endpoint protocols<br>- These settings are crucial for the service to function correctly within the larger application architecture, enabling communication with the database, managing logs, and establishing secure network connections.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Program.cs'>Program.cs</a></b></td>
										<td>- This program bootstraps a gRPC service responsible for managing discount information within the application<br>- It configures a database connection using SQLite and registers the DiscountService to handle incoming gRPC requests related to discounts<br>- The program also sets up database migrations to ensure data schema consistency.</td>
									</tr>
									</table>
									<details>
										<summary><b>Protos</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Protos/discount.proto'>discount.proto</a></b></td>
												<td>- Defines the gRPC service interface for managing discount coupons within the application<br>- It specifies methods for retrieving, creating, updating, and deleting discounts based on product names<br>- The service utilizes a `CouponModel` data structure to represent discount information.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>.config</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/.config/dotnet-tools.json'>dotnet-tools.json</a></b></td>
												<td>- The `dotnet-tools.json` file configures tools used within the Discount service's gRPC implementation<br>- It specifies the version of Entity Framework Core and its associated commands, enabling database operations essential for managing discount data within the broader application architecture.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Models</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Models/Coupon.cs'>Coupon.cs</a></b></td>
												<td>- Defines the structure of a coupon within the Discount service's gRPC API<br>- This model represents a single discount offer, including its unique identifier, product name, description, and monetary value<br>- It enables seamless communication between clients and the Discount service for retrieving and applying coupons during checkout processes.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Migrations</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Migrations/DiscountContextModelSnapshot.cs'>DiscountContextModelSnapshot.cs</a></b></td>
												<td>- Defines the structure of the `DiscountContext` database within the application<br>- It specifies the schema for the `Coupons` table, outlining columns like `Id`, `Amount`, `Description`, and `ProductName`<br>- This file also includes initial sample data for two coupons: one for an "IPhone X" and another for a "Samsung 10".</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Migrations/20241111105053_InitialCreate.cs'>20241111105053_InitialCreate.cs</a></b></td>
												<td>- This migration script establishes the initial database structure for the Discount service<br>- It creates a "Coupons" table to store information about available discounts, including product name, description, and discount amount<br>- The script also populates this table with two initial coupon entries.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Migrations/20241111105053_InitialCreate.Designer.cs'>20241111105053_InitialCreate.Designer.cs</a></b></td>
												<td>- This file defines the initial database schema for the Discount Service within the larger application architecture<br>- It specifies the structure of the "Coupons" table, including columns for ID, Amount, Description, and ProductName, along with initial sample data.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Properties</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Properties/launchSettings.json'>launchSettings.json</a></b></td>
												<td>- Defines the launch settings for the Discount gRPC service within the larger project architecture<br>- It specifies how the service runs, including the port number and environment variables used during development<br>- This configuration allows developers to easily start and debug the gRPC service as part of the overall application.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Services</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Services/DiscountService.cs'>DiscountService.cs</a></b></td>
												<td>- DiscountService handles all interactions related to coupons within the application<br>- It retrieves existing coupons based on product name, creates new coupons, updates existing ones, and deletes coupons as requested by clients<br>- This service acts as a central point of access for managing coupon data within the system.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Data</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Data/DiscountContext.cs'>DiscountContext.cs</a></b></td>
												<td>- DiscountContext establishes the data access layer for managing coupon information within the Discount gRPC service<br>- It defines a database context using Entity Framework Core, enabling interactions with a DbSet of Coupon entities to store, retrieve, and manipulate discount data.</td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Discount/Discount.Grpc/Data/Extentions.cs'>Extentions.cs</a></b></td>
												<td>- The `Extentions` class within the Discount gRPC service's data layer provides a mechanism to apply database migrations during application startup<br>- It leverages dependency injection to access the `DiscountContext` and ensures that the database schema is updated to reflect any changes defined in the migration scripts.</td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Catalog</b></summary>
						<blockquote>
							<details>
								<summary><b>Catalog.API</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/GlobalUsing.cs'>GlobalUsing.cs</a></b></td>
										<td>- GlobalUsing.cs establishes a shared namespace within the Catalog API project<br>- It imports essential libraries and frameworks used throughout the application, including Carter for web requests, Mapster for object mapping, MediatR for handling asynchronous requests, Marten for document database interactions, and FluentValidation for data validation.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Dockerfile'>Dockerfile</a></b></td>
										<td>- This Dockerfile defines the build process for a .NET API application named Catalog.API<br>- It utilizes multiple stages to efficiently build, publish, and containerize the application<br>- The final stage creates a runnable image that exposes ports 8080 and 8081, allowing the API to be accessible within a Docker environment.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/global.json'>global.json</a></b></td>
										<td>- Defines the SDK version and roll forward strategy used within the Catalog API service<br>- This configuration ensures compatibility with the latest features of the .NET SDK, enabling the development team to leverage the most up-to-date tools and functionalities<br>- Let me know if you have any other questions about this project or need further assistance!</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Catalog.API.csproj'>Catalog.API.csproj</a></b></td>
										<td>- Defines the Catalog API project within a larger microservices architecture<br>- It leverages ASP.NET Core and integrates with external services like Marten for data persistence and Swashbuckle for API documentation<br>- The project also incorporates health checks and utilizes the BuildingBlocks library for shared functionality across the application.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/appsettings.Development.json'>appsettings.Development.json</a></b></td>
										<td>- Configures the development environment settings for the Catalog API service<br>- It defines the connection string to access the CatalogDb database and sets the logging level for different categories within the application<br>- These configurations are crucial for the API to function correctly during development.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/appsettings.json'>appsettings.json</a></b></td>
										<td>- The appsettings.json file configures the application's runtime environment within the Catalog API service<br>- It defines connection details for the database, sets logging levels for different areas of the application, and specifies allowed hostnames for accessing the API.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Program.cs'>Program.cs</a></b></td>
										<td>- Configures the Catalog API application by defining services, middleware, and endpoints<br>- It sets up dependency injection, integrates with Swagger for documentation, enables CORS for cross-origin requests, and registers health checks for monitoring application status<br>- The file also initializes Marten database interactions and configures exception handling.</td>
									</tr>
									</table>
									<details>
										<summary><b>Models</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Models/Product.cs'>Product.cs</a></b></td>
												<td>- Defines the structure of a product within the e-commerce catalog<br>- This model specifies attributes such as the product's ID, name, category, description, image file path, and price<br>- It serves as the blueprint for representing individual products in the API and database.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Properties</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Properties/launchSettings.json'>launchSettings.json</a></b></td>
												<td>- Defines the configuration settings for launching and debugging the Catalog API within various environments<br>- It specifies URLs, ports, authentication methods, and environment variables used during development, testing, and deployment to IIS Express or Docker containers.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Data</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Data/CatalogInitialData.cs'>CatalogInitialData.cs</a></b></td>
												<td>- CatalogInitialData populates the product catalog with sample data when the application starts<br>- It utilizes a Faker library to generate realistic product information, including names, prices, descriptions, and categories<br>- This ensures a populated database for initial testing and development purposes within the larger e-commerce application.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Exceptions</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Exceptions/ProductNotFoundException.cs'>ProductNotFoundException.cs</a></b></td>
												<td>- Defines a custom exception type, ProductNotFoundException, within the Catalog API service<br>- This exception is specifically raised when a requested product cannot be found based on its provided identifier (Guid)<br>- It extends the built-in NotFoundException, providing a more specific error message indicating the missing resource.</td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Products</b></summary>
										<blockquote>
											<details>
												<summary><b>DeleteProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/DeleteProduct/DeleteProductEndPoint.cs'>DeleteProductEndPoint.cs</a></b></td>
														<td>- Defines an endpoint within the API responsible for deleting a product by its ID<br>- This endpoint receives a product ID as input and sends a command to the application's core logic to delete the corresponding product record<br>- The endpoint returns a success or failure indication to the caller.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/DeleteProduct/DeleteProductHandler.cs'>DeleteProductHandler.cs</a></b></td>
														<td>- Manages the deletion of a product from the catalog service<br>- It receives a product ID as input and orchestrates the retrieval, removal, and saving of changes to the database<br>- If the product is not found, it throws an appropriate exception.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>UpdateProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/UpdateProduct/UpdateProductEndPoint.cs'>UpdateProductEndPoint.cs</a></b></td>
														<td>- The  `UpdateProductEndPoint` class defines an API endpoint responsible for updating product information within the system<br>- It accepts a request containing updated product details and sends a command to the application's core logic for processing<br>- The endpoint returns a success or failure response indicating the outcome of the update operation.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/UpdateProduct/UpdateProductHandler.cs'>UpdateProductHandler.cs</a></b></td>
														<td>- This file defines the logic for updating a product within the application's catalog service<br>- It handles incoming update requests, validates the provided data, retrieves the existing product from storage, modifies its attributes based on the request, and saves the changes<br>- Successful updates return an indication of success.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetProductById</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/GetProductById/GetProductByIdHandler.cs'>GetProductByIdHandler.cs</a></b></td>
														<td>- This file defines the logic for retrieving a specific product from the catalog based on its unique identifier<br>- It utilizes a query handler to interact with the database, ensuring that a valid product ID is provided and handling the scenario where a product is not found<br>- The retrieved product information is then returned as a result object.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/GetProductById/GetProductByIdEndPoint.cs'>GetProductByIdEndPoint.cs</a></b></td>
														<td>- Defines an endpoint within the API that retrieves a product by its unique identifier<br>- This endpoint accepts a product ID as input and returns a corresponding product object upon successful retrieval<br>- It leverages message sending to interact with other parts of the application, ensuring a robust and scalable architecture.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>CreateProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/CreateProduct/CreateProductHandler.cs'>CreateProductHandler.cs</a></b></td>
														<td>- This file defines the logic for creating new products within the application<br>- It handles incoming product creation requests, validates their data against predefined rules, and persists the validated product information to the database<br>- Upon successful creation, it returns a unique identifier for the newly created product.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/CreateProduct/CreateProductEndPoint.cs'>CreateProductEndPoint.cs</a></b></td>
														<td>- Defines an endpoint within the Catalog API responsible for creating new products<br>- It accepts a product creation request, processes it as a command, and returns a successful response with the newly created product's ID upon completion<br>- This endpoint integrates with other parts of the system to handle database interactions and generate appropriate responses based on success or failure.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetProducts</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/GetProducts/GetProductsHandler.cs'>GetProductsHandler.cs</a></b></td>
														<td>- Handles retrieving paginated product data from the database<br>- It processes a query specifying page number and size, then fetches products using Marten's pagination capabilities<br>- The retrieved products are returned as a result object, enabling seamless integration with the application's presentation layer.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/GetProducts/GetProductsEndPoint.cs'>GetProductsEndPoint.cs</a></b></td>
														<td>- Defines an endpoint within the Catalog API responsible for retrieving product information<br>- It accepts a request containing pagination parameters and returns a list of products as a response<br>- This endpoint leverages dependency injection to interact with the application's query handling logic, ensuring efficient data retrieval and presentation.</td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetProductByCategory</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/GetProductByCategory/GetProductByCategoryHandler.cs'>GetProductByCategoryHandler.cs</a></b></td>
														<td>- This file defines a handler responsible for retrieving products based on a given category within the application's catalog service<br>- It processes queries to fetch products whose categories match the specified search term and returns a result containing the matching products<br>- This functionality contributes to the overall goal of providing users with a searchable and browsable catalog of products.</td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/hakanereenn/VerticalSliceCommerceMicroservice/blob/master/src/Services/Catalog/Catalog.API/Products/GetProductByCategory/GetProductByCategoryEndPoint.cs'>GetProductByCategoryEndPoint.cs</a></b></td>
														<td>- Defines an API endpoint that retrieves a list of products based on a given category<br>- It utilizes the `ISender` interface to send a query to retrieve products and returns a response containing the retrieved products as a collection<br>- This endpoint contributes to the overall functionality of the e-commerce platform by enabling users to filter products by category.</td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
				</blockquote>
			</details>
		</blockquote>
	</details>
</details>

---
## 🚀 Getting Started

### ☑️ Prerequisites

Before getting started with VerticalSliceCommerceMicroservice, ensure your runtime environment meets the following requirements:

- **Programming Language:** CSharp
- **Package Manager:** Nuget
- **Container Runtime:** Docker


### ⚙️ Installation

Install VerticalSliceCommerceMicroservice using one of the following methods:

**Build from source:**

1. Clone the VerticalSliceCommerceMicroservice repository:
```sh
❯ git clone https://github.com/hakanereenn/VerticalSliceCommerceMicroservice
```

2. Navigate to the project directory:
```sh
❯ cd VerticalSliceCommerceMicroservice
```

3. Install the project dependencies:


**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet restore
```


**Using `docker`** &nbsp; [<img align="center" src="https://img.shields.io/badge/Docker-2CA5E0.svg?style={badge_style}&logo=docker&logoColor=white" />](https://www.docker.com/)

```sh
❯ docker build -t hakanereenn/VerticalSliceCommerceMicroservice .
```




### 🤖 Usage
Run VerticalSliceCommerceMicroservice using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet run
```


**Using `docker`** &nbsp; [<img align="center" src="https://img.shields.io/badge/Docker-2CA5E0.svg?style={badge_style}&logo=docker&logoColor=white" />](https://www.docker.com/)

```sh
❯ docker run -it {image_name}
```


### 🧪 Testing
Run the test suite using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet test
```
---

## ✍️ Authors

- [Hakan Eren](https://github.com/hakanereenn)



## 🙌 Acknowledgments

- Inspired by [Mehmet Özkaya](https://github.com/mehmetozkaya)

---

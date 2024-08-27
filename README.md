# 📓 Online Diary Web Application

Welcome to the **Online Diary Web Application** project! This application is a microservices-based system built using .NET 7, Docker, and Docker Compose. It's designed to be a scalable and extensible platform where users can securely manage their personal diary entries.

## 🌟 Features

- **User Management**: Register, login, and manage user profiles.
- **Diary Management**: Create, update, delete, and view diary entries.
- **Notifications**: Receive reminders and notifications.
- **API Gateway**: Centralized access point for routing and load balancing.
- **Microservices Architecture**: Each service is independently deployable and scalable.

## 🏗️ Architecture Overview

This project follows a microservices architecture inspired by Microsoft's eShopOnContainers. The services include:

- **API Gateway**: Routes requests to appropriate microservices.
- **User Service**: Manages user-related operations (registration, authentication).
- **Diary Service**: Handles CRUD operations for diary entries.
- **Notification Service**: Sends notifications to users.

Each service is containerized using Docker and managed by Docker Compose.

![Architecture Diagram](https://user-images.githubusercontent.com/123456789/architecture-diagram.png) *(Insert your actual architecture diagram image URL here)*

## 🚀 Getting Started

### Prerequisites

Ensure you have the following installed:

- [Docker](https://www.docker.com/products/docker-desktop)
- [Docker Compose](https://docs.docker.com/compose/install/)
- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

### Clone the Repository

```bash
git clone https://github.com/yourusername/online-diary-app.git
cd online-diary-app
```

### Build and Run the Application
To build and start all the services, simply run:
```bash
docker-compose up --build
```
### Inter-service Communication
RESTful APIs: Services communicate via HTTP using REST APIs.
Asynchronous Messaging: Consider using RabbitMQ or Azure Service Bus for event-driven communication.

## 🔒 Security

The application uses **Identity Server 4** for authentication and authorization, providing secure access to the microservices. The Identity Server handles OAuth 2.0 and OpenID Connect protocols, issuing tokens that are validated by each microservice.

### Identity Server Configuration

- **Identity Resources**: OpenID, Profile
- **API Scopes**: `diaryApi`
- **Clients**: Configured for client credentials flow

### Protecting Microservices

Each microservice validates tokens issued by Identity Server, ensuring only authorized users can access the services.

### API Gateway Security

The API Gateway (Ocelot) is configured to enforce authentication and authorization, routing requests only when valid tokens are presented.

For more detailed setup instructions, see the [Identity Server Documentation](https://identityserver.io/).

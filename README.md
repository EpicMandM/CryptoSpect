# CryptoSpect

## Overview

CryptoSpect is a cryptocurrency monitoring ASP.NET web application. It is designed to provide real-time updates on cryptocurrency prices, trends, and other relevant data.

## Features

- Real-time cryptocurrency price tracking
- Microservice architecture
- RESTful API backend
- Frontend built with React, TypeScript, and SCSS
- Utilizes modern utilities and frameworks like Entity Framework, Redis Cache, RabbitMQ, and MongoDB

## Project Structure

- **CryptoSpect**: Main ASP.NET Core project for handling HTTP requests and responses.
- **CryptoSpect.Core**: Business logic and models.
- **CryptoSpect.DA**: Database interactions and repositories.
- **CryptoSpect.Service**: Business services for specific use-cases.
- **CryptoSpect.Utility**: Common utilities and helpers.
- **CryptoSpect.Test**: Unit and integration tests.

## Prerequisites

- .NET 7.0.400
- Node.js and npm (for frontend)
- MongoDB
- Redis

## Setup

1. Clone the repository:

```shell
git clone https://github.com/yourusername/CryptoSpect.git
```

2. Navigate to the project directory and install backend dependencies:

```shell
cd CryptoSpect
dotnet restore
```

3. Navigate to the frontend directory and install frontend dependencies:

```shell
cd CryptoSpect/ClientApp
npm install
```

4. Run the application:

```shell
dotnet run
```

## Contributing

If you'd like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## License

MIT License

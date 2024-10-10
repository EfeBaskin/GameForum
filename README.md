# Game Forum

## Description

The **Game Forum** is a web application designed to manage and interact with video game content, user reviews, and scores. This project allows users to browse games, submit reviews, rate them and bookmark their favorite games for easy accessa. Built using ASP.NET MVC and Entity Framework, this application provides a user-friendly interface for game enthusiasts.

![ASP.NET MVC]()
![ASP.NET MVC]()
![ASP.NET MVC]()
![ASP.NET MVC]()


## Features

- **Game Management**: View and manage a list of games with detailed information.
- **User Reviews**: Users can submit reviews for games, helping others to make informed decisions.
- **Bookmarking**: Users can bookmark games they are interested in, allowing for easy access later.
- **User Management**: Create and manage user accounts for personalized experiences.
- **Responsive Design**: Optimized for various devices to ensure accessibility.

## Technology Stack

- **Frontend**: HTML, CSS, JavaScript (using ASP.NET MVC for views)
- **Backend**: ASP.NET MVC
- **Database**: SQL Server (using Entity Framework, ADO.NET for database interactions)

## MVC Model

![ASP.NET MVC](https://github.com/EfeBaskin/GameForum/blob/main/img/asp.net%20mvc%20image.png?raw=true)

### Overview of ASP.NET MVC

ASP.NET MVC is a framework for building scalable, high-performance web applications using a Model-View-Controller (MVC) architecture. It provides a clean separation of concerns, allowing developers to organize their code in a way that is maintainable and testable. 

### Key Features

- **Separation of Concerns**: The MVC pattern divides the application into three main components: 
  - **Model**: Represents the application's data and business logic.
  - **View**: Responsible for rendering the user interface.
  - **Controller**: Handles user input and interacts with the model to update the view.

- **Routing**: ASP.NET MVC uses a powerful routing mechanism that allows you to create SEO-friendly URLs and map requests to the appropriate controller actions.

- **Testability**: The separation of concerns makes it easier to unit test the application components individually.

- **Extensibility**: The framework is designed to be extensible, allowing developers to create custom components and replace default behaviors.

- **Support for Multiple View Engines**: ASP.NET MVC supports various view engines, including Razor, which allows for concise and expressive views.

### Getting Started

To create a new ASP.NET MVC application, you can use Visual Studio or the .NET CLI. You can find detailed documentation and tutorials on the [official ASP.NET website](https://dotnet.microsoft.com/apps/aspnet/mvc).


## Models

### Game

- **Id**: Unique identifier for each game.
- **GameName**: Name of the game.
- **ImageURL**: URL for the game cover image.
- **Score**: Average score given by users.
- **Company**: Name of the game development company.
- **Platform**: Platforms on which the game is available.

### Review

- **Id**: Unique identifier for each review.
- **GameId**: Reference to the associated game.
- **UserId**: Reference to the user who submitted the review.
- **ReviewContent**: Text of the user's review.

### User

- **Id**: Unique identifier for each user.
- **Username**: User's chosen name.
- **Email**: User's email address.
- **Country**: User's country.
- **City**: User's city

### Bookmark

- **Id**: Unique identifier for each bookmark.
- **UserId**: Reference to the user who created the bookmark.
- **GameId**: Reference to the game being bookmarked.
- **Bookmarked Date**: Bookmarked date of the game.

## Usage

- Visit the home page to view a list of available games seperated by platforms.
- Click on a game to read reviews and leave your own.
- Use the bookmark feature to save games you want to revisit later.
- You can rate games by add score button.

## Contributing

Contributions are welcome! If you have suggestions for improvements or features, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix:
   ```bash
   git checkout -b feature-name
   git commit -m "Add a new feature or fix a bug"
   git commit -m "Add a new feature or fix a bug"
3. Open a pull request describing your changes


## Installation

1. Clone the repository:
   ```bash
   git clone <repository_url>

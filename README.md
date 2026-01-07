# TechEvent.WebApp

A single-page Blazor Web App that displays the schedule for a one-day technical event.

## Description

This project is a simple, yet functional, Blazor Web App built with .NET 8. It showcases a single-page schedule view for a fictional tech event. The application is designed to be interactive, allowing users to filter the event's talks by category in real-time.

## Features

- **Single-Page Schedule View**: Displays all talks for the one-day event in a clean, chronological layout.
- **Category Filtering**: A search bar allows users to filter the schedule by talk category (e.g., ".NET", "Blazor", "AI"). The filtering logic is implemented purely in C#.
- **Component-Based Architecture**: The UI is built using reusable Blazor components (`TalkCard`, `Schedule`).
- **Responsive Design**: The UI is styled with Bootstrap and custom CSS for a clean look on various screen sizes.

## Tech Stack

- **Framework**: Blazor Web App
- **Language**: C#
- **Platform**: .NET 8
- **Styling**: Bootstrap & Standard CSS
- **Render Mode**: Interactive Server

## Setup and Run

To run this project locally, follow these steps:

1.  **Clone the repository** (if you haven't already):
    ```bash
    git clone <your-repository-url>
    ```
2.  **Navigate to the project directory**:
    ```bash
    cd TechEvent.WebApp
    ```
3.  **Run the application**:
    ```bash
    dotnet run
    ```
4.  **Open your browser** and navigate to the URL provided in the terminal (e.g., `http://localhost:5164`).

## Project Structure

The project follows a standard Blazor Web App structure:

-   `TechEvent.WebApp/`
    -   `Components/`: Contains the Blazor components, including pages, layouts, and reusable UI elements like `TalkCard.razor`.
    -   `Models/`: Contains the C# data models, such as `Talk.cs`.
    -   `Services/`: Contains the application's services, like `ScheduleService.cs`, which handles business logic.
    -   `wwwroot/`: Contains static assets like CSS and images.
    -   `Program.cs`: The application's entry point, where services are configured.
    -   `TechEvent.WebApp.csproj`: The project file, defining dependencies and project settings.

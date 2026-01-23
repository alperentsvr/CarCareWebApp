# Car Care Panel

Car Care Panel is a modern, web-based management system for car detailing, service, and maintenance businesses. It allows specific tracking of vehicles, customers, services, personnel, and accounting.

## Features

- **Dashboard**: Real-time overview of active jobs, completed orders, and revenue.
- **Order Management**: Track vehicle services from reception to delivery.
- **Kanban Board**: Drag-and-drop workflow for order status (Pending, In Progress, Completed).
- **Customer Management**: Database of customers and their vehicles.
- **Personnel & Accounting**: Basic staff tracking and income/expense management.
- **Responsive Design**: Works on desktop and mobile devices.

## Tech Stack

- **Frontend**: React (Vite), Tailwind CSS, Lucide Icons
- **Backend**: .NET 8 Web API, Entity Framework Core
- **Database**: PostgreSQL
- **Containerization**: Docker & Docker Compose

## Getting Started

### Prerequisites

- [Docker Desktop](https://www.docker.com/products/docker-desktop) installed and running.

### Installation & Run

1.  Clone the repository:
    ```bash
    git clone https://github.com/yourusername/car-care-panel.git
    cd car-care-panel
    ```

2.  Start the application using Docker Compose:
    ```bash
    docker-compose up --build
    ```

3.  Access the application:
    - **Frontend**: [http://localhost:3000](http://localhost:3000)
    - **Backend API (Swagger)**: [http://localhost:5000/swagger](http://localhost:5000/swagger)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

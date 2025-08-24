# 🚀 TraversalCoreProject - Tourism Management System

## 📋 Project Overview

**TraversalCoreProject** is a comprehensive tourism management system built with modern web technologies. This project is developed using .NET Core 8.0 architecture and follows layered architecture principles to provide a robust, scalable, and maintainable solution for tourism businesses.

## 🏗️ Architecture Overview

### 📦 Layered Architecture Structure

```
TraversalCoreProject/
├── 📦 EntityLayer/          # Database entities and domain models
├── 📦 DataAccessLayer/      # Data access layer with repositories
├── 📦 BusinessLayer/        # Business logic and validation
├── 📦 DTOLayer/            # Data Transfer Objects
├── 🌐 TraversalCoreProject/ # Main web application (MVC)
├── 📡 SignalRApi/          # SignalR API (PostgreSQL)
├── 📡 SignalRApiForSql/    # SignalR API (SQL Server)
└── 🖥️ SignalRConsume/      # SignalR client application
```

## 🛠️ Technology Stack

### 🔧 Backend Technologies
- **.NET Core 8.0** - Primary framework
- **Entity Framework Core 8.0** - ORM for database operations
- **SQL Server** - Primary database
- **PostgreSQL** - Secondary database for SignalR
- **ASP.NET Core Identity** - Authentication and authorization
- **AutoMapper 12.0** - Object mapping
- **FluentValidation 11.0** - Data validation
- **MediatR 11.0** - CQRS pattern implementation
- **Serilog 8.0** - Advanced logging
- **MailKit 4.12** - Email functionality
- **EPPlus 6.0** - Excel operations
- **iTextSharp** - PDF generation
- **ClosedXML** - Excel file operations

### 🌐 Frontend Technologies
- **ASP.NET Core MVC 8.0** - Web framework
- **Razor Pages** - View engine
- **Bootstrap 5** - CSS framework
- **jQuery** - JavaScript library
- **SignalR** - Real-time communication

### 🗄️ Database
- **SQL Server** - Primary database (DbTraversal)
- **PostgreSQL** - SignalR visitor tracking

## 🏛️ Project Structure Details

### 📦 EntityLayer
Contains all database entities and domain models:

**Core Entities:**
- `About`, `About2` - Company information
- `Destination` - Tourist destinations
- `Guide` - Tour guides
- `Comment` - User reviews and comments
- `Reservation` - Booking system
- `Announcement` - System announcements
- `Contact`, `ContactUs` - Contact information
- `AppUser`, `AppRole` - User and role management
- `Feature`, `Feature2` - Website features
- `Newsletter` - Newsletter subscriptions
- `SubAbout` - Additional about sections
- `Testimonial` - Customer testimonials
- `Account` - Financial accounts

### 📦 DataAccessLayer
Implements data access patterns:

- **Generic Repository Pattern** - Common CRUD operations
- **Unit of Work Pattern** - Transaction management
- **Entity Framework Core** - Database operations
- **Repository Interfaces** - Abstraction layer

### 📦 BusinessLayer
Contains business logic and validation rules:

- **Service Pattern** - Business logic implementation
- **Validation Rules** - Data validation with FluentValidation
- **Dependency Injection** - Service registration
- **Custom Validators** - Business-specific validation

### 📦 DTOLayer
Data Transfer Objects for API communication:

- **AnnouncementDTOs** - Announcement data transfer
- **AppUserDTOs** - User registration and login
- **ContactDTOs** - Contact form data
- **DestinationDTOs** - Destination information
- **EmailDTOs** - Email request data

### 🌐 TraversalCoreProject (Main Web Application)

#### CQRS Pattern Implementation
- **Commands** - Write operations (Create, Update, Delete)
- **Queries** - Read operations
- **Handlers** - Business logic execution
- **MediatR** - Command/Query mediation

#### View Components
- **Default Components** - Homepage sections
- **Admin Components** - Dashboard widgets
- **Member Components** - User dashboard
- **Layout Components** - Reusable UI parts

#### Areas Structure
- **Admin Area** - Administrative panel with full CRUD operations
- **Member Area** - User dashboard and profile management

### 📡 SignalR Integration

#### SignalR API (PostgreSQL)
- **VisitorHub** - Real-time visitor tracking
- **VisitorService** - Visitor data management
- **Real-time Updates** - Live dashboard updates

#### SignalR Consumer
- **Client Application** - SignalR connection management
- **Real-time Communication** - Live data synchronization

## 🔐 Security and Authentication

### Identity Framework Integration
- Custom password validation
- Role-based authorization
- Token-based authentication
- Custom identity error messages
- User profile management

## 🌍 Multi-Language Support

### Localization Features
- Supported languages: Turkish, English, French, Spanish, German, Greek
- Resource-based translation management
- Culture-specific formatting
- Dynamic language switching

## 🚀 Installation and Setup

### Prerequisites
- .NET Core 8.0 SDK
- SQL Server (for main database)
- PostgreSQL (for SignalR)
- Visual Studio 2022 or VS Code

### Installation Steps

1. **Clone the repository:**
```bash
git clone [repository-url]
cd TraversalCoreProject
```

2. **Configure database connections:**
   - Update SQL Server connection string in `DataAccessLayer/Concrete/Context.cs`
   - Update PostgreSQL connection string in `SignalRApi/appsettings.json`

3. **Run database migrations:**
```bash
# Main application
dotnet ef database update --project DataAccessLayer --startup-project TraversalCoreProject

# SignalR API
dotnet ef database update --project SignalRApi
```

4. **Install dependencies:**
```bash
dotnet restore
```

5. **Run the applications:**
```bash
# Main web application
dotnet run --project TraversalCoreProject

# SignalR API
dotnet run --project SignalRApi

# SignalR Consumer
dotnet run --project SignalRConsume
```

## 📊 Database Schema

### Main Entities Relationship
- **Destination** ↔ **Guide** (Many-to-One)
- **Destination** ↔ **Comment** (One-to-Many)
- **Destination** ↔ **Reservation** (One-to-Many)
- **AppUser** ↔ **Reservation** (One-to-Many)
- **AppUser** ↔ **Comment** (One-to-Many)

## 🔧 Configuration

### App Settings
- Database connection strings
- Email configuration
- Logging settings
- Localization settings
- SignalR hub configuration

### Environment Variables
- Development/Production environment settings
- Database connection strings
- API endpoints

## 📈 Performance Optimizations

- Entity Framework query optimization
- Caching strategies
- Image compression and optimization
- Database indexing
- Lazy loading implementation

## 📸 Screenshots

<img width="1920" height="5081" alt="screencapture-localhost-44321-Default-Index-2025-08-24-00_54_29" src="https://github.com/user-attachments/assets/463ba6af-be0d-4d7e-b037-0846f2ee8467" />
<img width="1902" height="978" alt="Screenshot 2025-08-24 005313" src="https://github.com/user-attachments/assets/87ae515b-150c-4274-bb5f-c7fa09e9fb1b" />
<img width="1920" height="5106" alt="screencapture-localhost-44321-Destination-DestinationDetails-1-2025-08-24-00_53_33" src="https://github.com/user-attachments/assets/60382537-708f-4ad5-91e0-89e096ea716c" />
<img width="1920" height="1426" alt="screencapture-localhost-44321-Guide-Index-2025-08-24-00_53_53" src="https://github.com/user-attachments/assets/c85f7822-4008-4e9f-9146-ee1454394330" />
<img width="1920" height="1908" alt="screencapture-localhost-44321-Contact-Index-2025-08-24-00_54_08" src="https://github.com/user-attachments/assets/74ac73c1-db59-4453-914f-8fde9038043b" />

### 👑 Admin Panel
<img width="1920" height="1286" alt="screencapture-localhost-44321-Admin-Dashboard-Index-2025-08-24-00_55_08" src="https://github.com/user-attachments/assets/7b2ec946-ef82-451c-a4e7-e4d904450fa8" />
<img width="1920" height="945" alt="screencapture-localhost-44321-Admin-Destination-Index-2025-08-24-00_55_24" src="https://github.com/user-attachments/assets/302a8c50-173a-483d-8b66-b241d4e1b9f8" />
<img width="1920" height="945" alt="screencapture-localhost-44321-Admin-Role-Index-2025-08-24-00_56_54" src="https://github.com/user-attachments/assets/38207bf8-892f-4113-9f7f-2050a02cbd27" />

### 👥 Member Panel
<img width="1365" height="2322" alt="screencapture-localhost-44321-Member-Dashboard-MemberDashboard-2025-08-24-00_58_10" src="https://github.com/user-attachments/assets/0418ca7c-3875-4ff8-975b-2c10905bab0c" />
<img width="1920" height="1048" alt="screencapture-localhost-44321-Member-LastDestinations-Index-2025-08-24-00_58_32" src="https://github.com/user-attachments/assets/1bc5c433-07a3-454c-8615-aec67798e9b5" />
<img width="259" height="804" alt="Screenshot 2025-08-24 005934" src="https://github.com/user-attachments/assets/64d78931-5650-4ae5-93fc-2c0cbd48fe9b" />
<img width="255" height="777" alt="Screenshot 2025-08-24 005946" src="https://github.com/user-attachments/assets/39b4f1b6-cb16-4dfa-aaed-625386159a01" />

### 📊 SignalR
<img width="1919" height="1079" alt="Screenshot 2025-08-24 011543" src="https://github.com/user-attachments/assets/76ef9c5b-3ec8-478b-945c-8bbae60beafd" />

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

⭐ If you find this project helpful, please give it a star!

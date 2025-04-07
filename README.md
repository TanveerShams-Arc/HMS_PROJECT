# HMS Project

A hospital management system (HMS) built with **.NET**, consisting of various components for management, authentication, authorization and validation.

## Project Structure

### 1. **HMS_API**
A **Web API** built with **.NET**, handling core backend functionalities.

- Implements **JWT authentication**, **authorization**, **role-based policies**, and **user claims**.
- Contains:
  - **Controllers**, **DTOs**, **Enums**, **Middleware**, **Repositories**, **Models**, **QuryObjects**, **DatabaseSeeder**, **Utilities & Extensions**.
  - **JWT Token**, **Identity Users**, **Roles, Claims, Policies** For User Management and Auth Functionalities.
  - **AppDbContext** for database management.
  - **Key Entities**: **Appointment**, **Doctor**, **Patient**, **Prescription**, **Receptionist**, and more.

### 2. **HMS_UI**
A **WinForms** application that interfaces with the **HMS_API** via **HTTPS** calls.

- Contains:
  - **Custom Controls**: Custom UI components such as Left and Right Arrow buttons.
  - **Forms**: WinForms for each API entity, providing user interfaces for data interaction.
  - **Helper Functions**:
    - **DI Container** for dependency injection.
    - **Data Formatters** for formatting model data in DataGrids.
    - **Regex and Utilities** for common operations.
  - **Repositories** and **Services** for API data interaction.

### 3. **PasswordValidationFunction**
An **Azure Function** that validates passwords during user registration.

- **HTTPTrigger** function that receives passwords, validates them, and returns success or error responses.

### 4. **AppointmentStatusChanger**
An **Azure Function** with a **TimerTrigger** that runs every minute.

- It fetches appointments from the API where:
  - Status is not **complete** or **cancelled**.
  - Date is before the current datetime.
- Changes the status of the fetched appointments to **complete**.

## Authentication & Authorization

- **HMS_API** uses **JWT tokens**, **Policies Based On Roles & Claims** for authentication and authorization.
- The **UI** sends the **Auth header** in each HTTPS request to authenticate users.

## Technology Stack

- **Backend**: 
  - **.NET**, **Entity Framework Core**, **Azure Functions** (TimerTrigger, HTTPTrigger)
- **Frontend**: 
  - **WinForms** (.NET 9)
- **Authentication**: 
  - **JWT**, **Role-based authorization**, **Claims**
- **Database**: 
  - **SQL Database** with **AppDbContext** for entity management
- **Azure Functions**: 
  - **TimerTrigger** (for background tasks) and **HTTPTrigger** (for password validation)
  
### Clone the repository
```bash
git clone https://github.com/mts-wtag/HMS_PROJECT.git
```

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


### 5. **Unit Testing**
A comprehensive set of unit tests covering core logic and controller-level actions.

- Written using **xUnit** with **Moq** for mocking dependencies.
- Tests include:
  - **Controller Logic**: Verifying correct responses (e.g., `Ok`, `BadRequest`, `NotFound`) for various scenarios.
  - **Service Behavior**: Ensuring services return expected results from mocked repositories.
  - **Model Validations**: Confirming business logic rules (e.g., invalid input, null checks).
  - **Edge Case Handling**: Testing boundary values, invalid states, and unexpected user inputs.
  - **Policy Authorization Simulation**: Mocking user roles and claims to validate access control paths.

### 6. **Integration Testing**
Integration tests validate the end-to-end functionality of the API by running against an in-memory database.

- Built using **xUnit**, **TestServer**, and **HttpClient** for simulating real HTTP requests.
- Covers:
  - **Realistic API Scenarios**: From controller to database interaction, ensuring complete pipeline works.
  - **JWT Auth Testing**: Tests involving authentication headers and secured endpoints.
  - **Request/Response Flow**: Verifying serialization/deserialization, status codes, and content.
  - **Database Interaction**: Uses **InMemoryDb** to test EF Core behavior with real data queries.


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
- **Testing**: 
  - **xUnit** for unit and integration testing.
  - **Moq** for mocking dependencies in unit tests.
  - **TestServer** and **HttpClient** for simulating real HTTP requests in integration tests.
  - **InMemoryDb** for testing Entity Framework Core interactions in the repository layer.
  
### Clone the repository
```bash
git clone https://github.com/mts-wtag/HMS_PROJECT.git
```

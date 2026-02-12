# Inventory Management System

A Windows Forms application for managing inventory, users, and orders, built with C# and MySQL. The system supports role-based dashboards for Admin, Manager, and User, and provides a complete workflow for inventory and order management.

---

## Features

- **User Authentication:** Secure login and registration for users, managers, and admins.
- **Role-Based Dashboards:** Different interfaces and permissions for Admin, Manager, and User.
- **Inventory Management:** Add, update, delete, and view spare parts.
- **Order Management:** Create, view, and update paid/unpaid/cancelled orders.
- **User Management:** Admin can manage users and managers.
- **PDF Export:** Export inventory and order lists to PDF.
- **Database Integration:** Uses MySQL for persistent data storage.

---

## Project Structure

```
InventorySystem.sln
Assests/
    01 LOGIN DETAILS & PROJECT INFO.txt
    (Images and icons)
DATABASE FILE/
    (Database scripts and info)
InventorySystem/
    Admin_home.cs
    Confirm.cs
    Home.cs
    Login.cs
    Manager_home.cs
    MyOrders.cs
    Program.cs
    SignUp.cs
    User_list.cs
    userdetail.cs
    UserControl1.cs
    Properties/
    ...
```

---

## Getting Started

### Prerequisites

- Visual Studio 2017 or later
- .NET Framework 4.6.1 or later
- MySQL Server (database name: `inventorymgcsharp`)
- [MySql.Data](https://www.nuget.org/packages/MySql.Data/) NuGet package

### Setup

1. **Clone the repository:**
    ```sh
    git clone https://github.com/yourusername/InventoryManagementSystem.git
    ```
2. **Open the solution:**  
   Open `InventorySystem.sln` in Visual Studio.

3. **Restore NuGet packages:**  
   Visual Studio should restore packages automatically. If not, right-click the solution and select "Restore NuGet Packages".

4. **Configure the database:**  
   - Create a MySQL database named `inventorymgcsharp`.
   - Import the provided SQL scripts from the `DATABASE FILE/` directory.
   - Update the connection string in the code if your MySQL credentials differ.

5. **Build and run:**  
   Press `F5` or click "Start" in Visual Studio.

---

## Default Login Credentials

See `Assests/01 LOGIN DETAILS & PROJECT INFO.txt` for more info.

- **Admin**
  - Username: `admin`
  - Password: `password123`
- **Manager**
  - Username: `manager`
  - Password: `manager123`

---

## Main Components

- `Admin_home.cs`: Admin dashboard and user management
- `Manager_home.cs`: Inventory and order management for managers
- `Home.cs`: User dashboard and order placement
- `Login.cs`: Login logic and authentication
- `SignUp.cs`: User registration
- `User_list.cs`: List and manage users
- `MyOrders.cs`: User order history

---

## License

This project is for educational purposes.  
Developed by Sudesh Fernandez.  
See `Assests/01 LOGIN DETAILS & PROJECT INFO.txt` for credits.

---

**Note:**  
This project is intended for learning and demonstration purposes. Do not use in production without proper security review.

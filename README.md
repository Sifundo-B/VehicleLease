# WebApplication1
🔧 Features
🔗 Supplier Tracking – Record where each vehicle was procured.

🏢 Branch Assignment – Allocate vehicles to regional branches.

🧑‍💼 Client Leasing – Associate clients (corporate) with leased vehicles.

👨‍✈️ Driver Mapping – Track which drivers operate specific vehicles.

📊 Dynamic Reporting – See how many vehicles each supplier, branch, or client has by manufacturer.

⚙️ Code First Migrations – Full EF schema management and data seeding.

🛠️ Technologies
Layer	Stack
Language	C#, Razor
Framework	ASP.NET MVC (.NET Framework)
ORM	Entity Framework 6 (Code First)
Database	Microsoft SQL Server
UI	Razor Views + Bootstrap
Seeding	DbMigrationsConfiguration.Seed()
## 🛠 Prerequisites

- Visual Studio 2019 or newer  
- .NET Framework 4.7.2+  
- SQL Server Express / LocalDB / full SQL Server  
- Git (for source control)  

---

## 🚀 Getting Started

### 1. Clone the Repository
This guide covers two ways to get your environment up and running:

- **Option A:** Restore the database from a provided `.bak` file for a quick setup  
- **Option B:** Use Entity Framework Migrations to build and seed the database from scratch

---

### Option A: Restore Database from Backup (.bak) File

1. **Download the database backup**

   Download the `.bak` file here:  
   [Database Backup (Google Drive)](https://drive.google.com/file/d/1zyy0AT2uDSugpdJJml63d7B9-8zzbDQv/view?usp=drive_link)

2. **Restore the database using SQL Server Management Studio (SSMS)**

   - Open SSMS and connect to your SQL Server instance.
   - Right-click `Databases` > `Restore Database...`
   - Choose **Device** and browse to select the downloaded `.bak` file.
   - Enter a database name, e.g., `WebApplication1`.
   - Review the **Files** tab to ensure paths are valid.
   - Click **OK** to start the restore.
   - Wait for confirmation that the restore succeeded.

3. **Update connection string**

   - In the `Web.config` file of the project, update the connection string to point to your restored database, for example:
 Application Navigation
Page	URL	Description
Home	/	Landing page or dashboard
Vehicles	/Vehicles	Manage vehicle records (create, update, delete)
Suppliers	/Suppliers	Manage suppliers who procure vehicles
Branches	/Branches	Manage branches where vehicles are allocated
Clients	/Clients	Manage companies leasing vehicles
Drivers	/Drivers	Manage drivers assigned to vehicles
Reports	/Reports	View summarized vehicle counts by supplier, branch, client, and manufacturer

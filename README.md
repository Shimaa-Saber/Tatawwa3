
# Basma Platform 🎓

Basma is a scalable and modular **volunteering platform** developed as an ITI graduation project. It empowers organizations to manage volunteer opportunities, track attendance, issue certificates, and communicate via real-time notifications.

## 🚀 Features

- 🧠 Clean Architecture with CQRS & MediatR  
- 👥 Role-Based Access (Admin - Volunteer - Organization)  
- 🔔 Real-time Notifications using SignalR  
- 📜 Volunteer Certificates (Issue / Download PDF)  
- 📅 Attendance Tracking  
- 🔐 OTP Verification + Password Reset  
- 📧 Email Services Integration  
- 🔎 Advanced Filtering (by name, status, date, etc.)  


## 🧰 Technologies

- **Backend:** ASP.NET Core 8, C#  
- **Architecture:** Clean Architecture, CQRS, MediatR, Generic Repository  
- **Security:** ASP.NET Core Identity, JWT  
- **Database:** SQL Server  
- **Tools:** AutoMapper, SignalR, Serilog, Hangfire, Postman  

## 📂 Project Structure
Tatawwa3/
│
├── Tatawwa3.API/ # Web API project (controllers, middlewares, etc.)
├── Tatawwa3.Application/ # CQRS handlers, Dtos, interfaces
├── Tatawwa3.Domain/ # Entities, enums, shared models
├── Tatawwa3.Infrastructure/ # DBContext, repositories, email, notification, Hangfire


## ⚙️ Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/Shimaa-Saber/Tatawwa3.git
   cd Tatawwa3
   
👩‍💻 Team
This project was developed as part of the ITI 9-Month Diploma – .NET Track.

Backend Team:

Shimaa Saber

Christina Ayman

Sondos Abdelraziq


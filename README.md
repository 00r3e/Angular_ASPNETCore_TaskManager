📌 Task Manager – Angular & ASP.NET Core

A full-stack Task Management application built with Angular (frontend) and ASP.NET Core Web API (backend). This project allows users to create, manage, filter, and track tasks with real-time statistics and productivity insights.

🚀 Features:

✅ User authentication & authorization (JWT + Refresh Tokens)
✅ User-specific tasks (each user sees only their own data)
✅ Create, update, and delete tasks
📊 Real-time task statistics (total, completed, pending, overdue)
📈 Productivity score and completion rate tracking
🔍 Advanced filtering by:

Status
Category
Priority
⏰ Overdue task detection
✔️ Toggle task completion
🔄 Automatic JWT refresh using refresh tokens
🧠 Clean separation of concerns using services (Angular & .NET)

🛠️ Tech Stack

Frontend

Angular (Standalone Components)
TypeScript
HTML / CSS
Angular Forms (ngModel)

Backend

ASP.NET Core Web API
C#
RESTful API architecture
JWT Authentication + Refresh Tokens

🧩 Architecture:

Angular Services

TasksService → Handles API communication
FilterService → Manages UI filters
StatisticsService → Calculates metrics
AccountService → Handles authentication & token management

Backend

Controller-based API (/api/tasks, /api/account)
Service layer for business logic
JWT-based authentication system

📡 API Endpoints:

Tasks

GET /api/tasks → Get user tasks
POST /api/tasks → Create a task
PUT /api/tasks/{id} → Update a task
DELETE /api/tasks/{id} → Delete a task

Auth

POST /api/account → Register
POST /api/account/login → Login
POST /api/account/generate-new-jwt-token → Refresh token
GET /api/account/logout → Logout

💡 Purpose:

This project was built to practice:

Full-stack development
Angular state management & UI logic
REST API design with ASP.NET Core
JWT authentication & security
Clean architecture and service-based design

📷 Future Improvements:

✏️ Edit task UI
📅 Better date handling
🎨 UI/UX improvements

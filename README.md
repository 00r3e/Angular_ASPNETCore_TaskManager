📌 Task Manager – Angular & ASP.NET Core

A full-stack Task Management application built with Angular (frontend) and ASP.NET Core Web API (backend). 
This project allows users to create, manage, filter, and track tasks with real-time statistics and productivity insights.

🚀 Features:

✅ Create, update, and delete tasks
📊 Real-time task statistics (total, completed, pending, overdue)
📈 Productivity score and completion rate tracking
🔍 Advanced filtering by:
Status
Category
Priority
⏰ Overdue task detection
✔️ Toggle task completion
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

🧩 Architecture:

Angular Services
TasksService → Handles API communication
FilterService → Manages UI filters
StatisticsService → Calculates metrics

Backend
Controller-based API (/api/tasks)
Service layer for business logic

📡 API Endpoints:

GET /api/tasks → Get all tasks

POST /api/tasks → Create a task

PUT /api/tasks/{id} → Update a task

DELETE /api/tasks/{id} → Delete a task


💡 Purpose:

This project was built to practice:
Full-stack development
Angular state management & UI logic
REST API design with ASP.NET Core
Clean architecture and service-based design

📷 Future Improvements:

✏️ Edit task UI
🔐 Authentication & user accounts
📅 Better date handling
🎨 UI/UX improvements

# SevenDB - Seven Deadly Sins: Origin Character Wiki

A full-stack web application that serves as a character wiki for **Seven Deadly Sins: Origin**.

The goal of this project is to provide an easy way to browse all playable characters, inspect their details, explore their available weapons, and view the corresponding skill sets for each weapon.

> **Project Status:** 🚧 Work in Progress

---

## ✨ Features

* Browse all available characters
* View detailed information for every character
* Display all available weapons for each character
* Dynamically switch the skill set based on the selected weapon
* REST API built with .NET 10
* Frontend built with Angular 21
* SQLite database integration planned

---

## 🛠️ Tech Stack

| Technology | Version                |
| ---------- | ---------------------- |
| Angular    | 21                     |
| .NET       | 10                     |
| Node.js    | Latest LTS Recommended |
| SQLite     | Planned                |

---

## 📁 Project Structure

```text
.
├── backend
│   └── CharactersApi
│       ├── Data
│       │   └── CharactersData.cs
│       ├── Controllers
│       ├── Models
│       └── ...
│
├── frontend
│   └── sevendb-frontend
│       ├── src
│       └── ...
│
└── README.md
```

---

## 📚 Current Data Source

At the moment, all character data is hardcoded inside:

```text
backend/CharactersApi/Data/CharactersData.cs
```

This file contains the complete list of available characters used by the API.

The long-term goal is to migrate all data to a **SQLite** database, allowing easier maintenance, scalability, and future features.

---

## 🖥️ Application Pages

### Character List

The home page displays all available characters currently included in the project.

Clicking on a character opens its dedicated detail page.

---

### Character Details

The detail page contains:

* Character information
* Available weapons
* Weapon selector
* Dynamic skill list

Changing the selected weapon automatically updates the displayed skills.

---

## 🚀 Getting Started

### Requirements

Before running the project, make sure you have installed:

* .NET 10 SDK
* Node.js (Latest LTS recommended)
* npm

---

## ▶️ Running the Backend

Open a terminal from the project root and run:

```bash
cd backend/CharactersApi/
dotnet watch run
```

The API will start in development mode and automatically reload whenever changes are detected.

---

## 🌐 Running the Frontend

Open a second terminal and run:

```bash
cd frontend/sevendb-frontend/
npm i
npm start
```

Angular will compile the project and start the development server.

---

## ☁️ Running in GitHub Codespaces

Once the repository is opened in GitHub Codespaces:

### Backend

```bash
cd backend/CharactersApi/
dotnet watch run
```

### Frontend

```bash
cd frontend/sevendb-frontend/
npm i
npm start
```

After both services are running, open the forwarded frontend port from the **Ports** tab inside GitHub Codespaces.

---

## 🗺️ Roadmap

* [x] Character list
* [x] Character details
* [x] Weapon selection
* [x] Dynamic weapon skills
* [ ] SQLite database
* [ ] Search bar
* [ ] Character filters
* [ ] Character statistics
* [ ] Favorites
* [ ] Responsive mobile layout
* [ ] Admin panel
* [ ] Image optimization
* [ ] Performance improvements

---

## 💡 Future Improvements

Planned features include:

* SQLite integration
* Automatic database initialization
* Search functionality
* Filtering by attribute, race, rarity, and role
* Additional game information
* Character builds and recommendations
* Improved UI and animations
* Better mobile experience

---

## 📌 Notes

This project is currently under active development.

The current version uses hardcoded data for rapid development while the backend architecture is being prepared for SQLite integration.

---

## ⚠️ Disclaimer

This is a fan-made project created for educational and personal learning purposes.

**Seven Deadly Sins: Origin**, its characters, artwork, names, and all related intellectual property belong to their respective owners.

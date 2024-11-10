# Japanese Learning Platform: Project Details

## Project Overview
The goal is to create a full-stack web application to help users learn Japanese, focusing on vocabulary, kanji, grammar, and real-world comprehension. The platform prioritizes understanding written Japanese over speaking skills, with a gamified approach to learning. The project will use **ASP.NET Core** for the backend and **Vue.js** for the frontend.

## Requirements

### Must-have Features
- **User Authentication**: Secure login and registration, using JWT tokens.
- **Hiragana and Katakana Learning Module**: Core lessons for users to learn these foundational character sets.
- **Flashcards with Spaced Repetition (SRS)**: Flashcards for vocabulary, kanji, and grammar, using SRS to optimize review intervals.
- **Vocabulary, Kanji, and Grammar Lessons**: Structured lessons with progress tracking.
- **Note System**: Users can add notes to vocabulary, kanji, or grammar items.
- **Real-World Examples**: Practical phrases/scenarios to help users understand real-world Japanese.
- **Backend API**: A RESTful API to support frontend functionality.
- **Database**: A PostgreSQL database for persistent data storage (user profiles, learning progress, etc.).

### Should-have Features
- **Progress Tracking**: Users can track their learning journey.
- **Quiz Mode**: Quizzes to test knowledge on vocabulary, kanji, and grammar.
- **Rating/Favorites**: Users can rate or favorite items to personalize learning recommendations.

### Could-have Features
- **User Forum**: A place for user discussion and questions.
- **Dark Mode**: Improves user experience by offering an alternate color scheme.
- **Leaderboards**: Adds competition to motivate users.
- **Video and Music Transcription**: Users can practice transcription with Japanese audio/video.

## Development Stack
- **Backend**: ASP.NET Core (C#)
- **Frontend**: Vue.js
- **Database**: PostgreSQL
- **Authentication**: JWT-based token authentication
- **Deployment**: Options include Azure, AWS, or DigitalOcean, depending on budget.

---

# Implementation Details

## Core Backend Components

### 1. User Authentication and Profile Management
- JWT-based login and registration with hashed password storage.
- User profiles, including settings for favorites, dark mode, and progress.

### 2. Hiragana and Katakana Learning Module
- Endpoints to retrieve character data and log user progress.
- Gamified exercises, such as memory matching games, for character recognition.

### 3. Flashcard System with Spaced Repetition
- SRS algorithm to manage flashcard review intervals.
- Endpoints for creating, updating, and reviewing flashcards.

### 4. Vocabulary, Kanji, and Grammar Lessons
- Endpoints to serve lessons and update user progress.
- User-specific data to track completion and difficulty levels.

### 5. Real-World Examples and Notes
- Storage and retrieval for practical Japanese phrases (station signs, menus).
- Note-taking feature for personalized learning references.

### 6. Gamification and Quiz Features
- Quizzes and memory games for vocabulary and grammar.
- Endpoint to record quiz scores and user achievements.

---

## Supporting Backend Infrastructure

- **Error Handling**: Centralized error logging with Serilog for issue tracking.
- **Rate Limiting**: Protects against excessive API calls.
- **Caching**: Redis for faster access to frequently requested data.

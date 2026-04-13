# CyberSecurityChatbot

## Project Overview
This project is a C# console application that simulates a Cybersecurity Chatbot. It is designed to educate users about common cyber threats such as phishing, password safety, and safe browsing.

The chatbot interacts with users in a conversational manner and provides educational responses to improve cybersecurity awareness.

---

## Features
- Personalized user greeting
- ASCII art interface for visual presentation
- Basic cybersecurity Q&A system
- Topics include:
  - Password safety
  - Phishing awareness
  - Safe browsing practices
- Input validation for empty or invalid responses
- Voice greeting (WAV file support)
- Colored console UI for better readability

---

## Concepts Used
- C# Classes and Objects
- Methods and Properties
- String manipulation
- Input validation
- Console UI formatting
- File handling (audio file integration)
- GitHub version control
- GitHub Actions CI pipeline

---

## Voice Feature
A WAV audio file is played at startup to greet the user:
> "Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online and avoid cyber threats."

---

## CI/CD Pipeline
GitHub Actions is used to automatically build and test the project on every push.

Status: Successfully configured

---

## Project Structure
- Program.cs
- ChatBot.cs
- CyberSecurityChatbot.csproj
- CyberSecurityChatbot.sln
- greeting.wav
- .github/workflows/dotnet.yml

---

## How to Run
1. Open solution in Visual Studio
2. Build the project
3. Run the application

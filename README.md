# 📘 English Learning Management System

**English Learning Management System** is a desktop application built using **C# WinForms (.NET Framework 4.8.1)**. The project helps users **learn, manage, and practice English vocabulary** with Arabic translations and example sentences.

The latest version integrates **AI-powered automatic example generation**, providing **English example sentences** and **Arabic translations** for selected words.

---

## 🚀 Project Overview :

The application starts with a **splash screen** showing progress and initialization, then opens the main interface where users can manage vocabulary and access the learning presentation mode.

The project emphasizes:

* Clean architecture.
* Shared logic.
* Reusable components.

This reduces code duplication and simplifies long-term maintenance.

---

## ✨ Features :

### 🗄️ Storage System

* **File system–based storage** persists English words and their Arabic translations locally.

### 📌 Core Features :

1. Splash screen with progress bar and initialization message.

2. Add English words.

3. Each word supports **up to 4 Arabic translations**.

4. English pronunciation with configurable voice.

5. System sound control via **TrackBar**.

6. **Enhanced ListView with Context Menu (right mouse click):**

   * Change view mode.
   * Edit word.
   * Delete single word.
   * Delete multiple selected words.
   * Delete all words.
   * Check selected words.
   * Uncheck selected words.

7. **Responsive layout behavior across core UI components**, enabling dynamic resizing and proportional control adjustments to maintain layout consistency and usability across standard desktop resolutions.

> 🔄 The current version supports structured responsive behavior. Advanced responsiveness and enhanced multi-DPI optimization will be further improved in upcoming versions.

### ✅ Word Check System :

* Words can be checked directly inside the **ListView**.
* When a word is saved (checked), its background color becomes **green** in the ListView.
* Users can uncheck selected items from the **Context Menu** opened by right-clicking the ListView.

### 🤖 AI Integration Feature :

To use AI, place your API key as a string in `clsWord`; the API is free with daily usage limits.

When you click the **"Speak Selected Words"** button, the AI integration:

* Automatically generates **English example sentences** for the selected words.
* Generates **Arabic translations** of those examples strictly using the word’s provided translations.
* Ensures examples are clear, relevant, and suitable for vocabulary practice.

---

## 🎓 Learning / Presentation Mode :

The application includes **one presentation mode in desktop size**.

1. Select **1–4 words**.
2. Generate English example sentences using AI, and the user can also add them manually.
3. Generate Arabic translations for each example using AI, and the user can also add them manually.
4. Automatic presentation includes:

   * Word pronunciation.
   * Translation display.
   * Example sentence display.

---

## 🎨 Custom UI Controls :

This application is built using **custom-designed controls** to enhance UI/UX and provide a modern appearance.

Enhanced custom controls include:

* Custom Button.
* Custom Panel.
* Custom Label.
* Custom TextBox.
* Borderless Form.
* Circular Progress Bar.
* Progress Indicator.

---

## 🧠 Architecture & Code Quality :

* Centralized reusable methods.
* No duplicated business logic.
* Designed for maintainability and scalability.

---

## 🛠️ Technologies :

* **C#**.
* **WinForms**.
* **.NET Framework 4.8.1**.
* **Visual Studio 2026**.

---

## ▶️ How to Run :

⚠️ Requires **Visual Studio 2026**.

1. Clone or download the repository.
2. For proper UI display, it is **recommended** to set your Windows **Display Scale to 100%**. Other scaling values may affect layout alignment in the current version.
3. Open the solution in **Visual Studio 2026**.
4. Ensure **.NET Framework 4.8.1** is installed.
5. Set your **Google AI API key** in class `clsWord`.

---

## 🔮 Future Enhancements :

1. Migrate storage from file system to **relational database**.
2. Further improve and fully enhance UI responsiveness to support multiple screen resolutions, different aspect ratios, and advanced DPI scaling.
3. Implement learning progress tracking and analytics.
4. Optimize layout behavior for high-resolution and multi-monitor environments.

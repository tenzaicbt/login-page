# C# Login System

## Overview

This **C# Login System** is designed to provide a secure and user-friendly authentication experience. The system includes a straightforward user login interface, followed by an additional entry form and two sub-forms for extended functionality. This project can be easily integrated into larger applications or used as a standalone login system.

## Features

https://media.discordapp.net/attachments/1047765816378134550/1275396337642373161/Screenshot_2024-08-20_153916.png?ex=66c5bce6&is=66c46b66&hm=3b191ab25d502aab5d2551fec36d783161b21e6e6de60c1f77541b7f20df442e&=&format=webp&quality=lossless&width=458&height=325

1. **User Login Interface:**
   - A clean and intuitive user login form.
   - Input fields for **Username** and **Password** with built-in validation.
   - Error handling to alert users of invalid credentials or missing inputs.

2. **Additional Entry Form:**
   - Accessible after successful login.
   - This form collects or displays additional user-specific information.
   - Can be customized to suit different application requirements, such as profile setup, preferences, or further data entry.

3. **Two Sub-Forms:**
   - **Sub-Form 1:** Designed for secondary tasks post-login, such as dashboard access or specific module interaction.
   - **Sub-Form 2:** Another customizable form that can handle additional user tasks or provide access to different sections of the application.

## How to Run This Project in Visual Studio Code

To run this project, follow these steps:

![Alt text](login-page\assest\login.png)


1. **Clone the Repository:**
   - Use Git to clone the repository to your local machine:
     ```sh
     git clone https://github.com/your-repo-name/csharp-login-system.git
     ```
   
2. **Open in Visual Studio Code:**
   - Launch **Visual Studio Code**.
   - Navigate to `File > Open Folder` and select the cloned repository's folder.

3. **Build the Project:**
   - Ensure you have the necessary C# extensions installed in VS Code (e.g., C# for Visual Studio Code).
   - Open the integrated terminal (`Ctrl + `` `) and navigate to the project directory.
   - Run the build command:
     ```sh
     dotnet build
     ```
   - Ensure there are no build errors before proceeding.

4. **Run the Project:**
   - Use the following command to run the application:
     ```sh
     dotnet run
     ```
   - The login form should appear, allowing you to test the login system.

5. **Explore and Customize:**
   - After logging in, explore the additional entry form and sub-forms.
   - You can customize the forms by modifying the code and UI elements in VS Code.

## Future Enhancements

- **Encryption:** Implement encryption for storing and retrieving user credentials to enhance security.
- **Role-Based Access Control:** Add features to handle different user roles, such as admins, users, and guests, with varying levels of access.
- **Database Integration:** Expand the system by integrating a database for persistent user data storage and management.
- **Session Management:** Implement session handling to manage user sessions effectively.

## Contributing

Contributions are welcome! Please feel free to submit pull requests or report any issues you encounter.


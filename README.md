##Recipe App

Created to allow users to input a single recipe into the program and display it, change and adjust quantities of ingredients as well as clear recipe and re-enter a new one.

##Application usage

The application is coded in the C# language, on Visual Studio 2022.
If the app is not downloaded on your computer then you will need to download it to run this app. 
Once downloaded, or if you already have the application, open the application on the app and click on the button at the top with the green arrow and it will run the app.

##Code functionality

The app persists the data entered only while active, meaning the recipe does not get stored in memory when the application is deactivated.
The application prompts users for input on the number of ingredients and steps as well as the name, quantity and unit of measurement of the ingredients.
The user input goes through exception handling and input validation until it is deemed valid.
Once valid, the input gets stored in various arrays.
Once the steps and ingredients have been stored, the application displays the full recipe and displays a menu.
The user can select the option they want.
The application will complete the task that was selected and the menu will loop, repeating until the user selects to end the program.

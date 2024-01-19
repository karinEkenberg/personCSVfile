# personCSVfile

# Readme

## Introduction
This C# console application demonstrates the creation of a CSV file containing information about people. Users can input details such as name, age, and city for a person,
and this data is then added to a list of `Person` objects. The program writes the information from the list to a CSV file named `people.csv`. 
The CSV file includes a header row with the column names: Name, Age, and City.

## Usage
1. Run the application in Visual Studio Code or your preferred C# development environment.
2. Follow the prompts to submit information for a person (name, age, and city).
3. The program will create a `Person` object for the submitted information.
4. The program will also create `Person` objects for three predefined individuals.
5. The information for all four people will be added to a list of `Person` objects.
6. The program will write the contents of the list to a CSV file named `people.csv`.
7. Check the console for a message indicating that the file has been saved to the specified location (`C:people.csv`).

## Code Explanation
### Person Class
- Represents a person with properties for Name, Age, and City.
- Includes a constructor to initialize the object with values.
- Provides a `ToCSVString` method that converts the person's information to a CSV-formatted string.

### Main Method
- Collects information for a new person from user input.
- Creates `Person` objects for three predefined individuals and the newly input person.
- Adds all `Person` objects to a list called `people`.
- Specifies the file path for the CSV file (`C:people.csv`).
- Writes the header row and the information from each person to the CSV file using a `StreamWriter`.
- Prints a message to the console indicating the successful creation of the CSV file.

### Note
- Make sure to input valid data when submitting information for a person.
- The program creates or overwrites the `people.csv` file each time it is run.
- You can customize the file path and name by modifying the `csvFilePath` variable in the code.

Hello,
This is a Multi-Form Application that is developed by me using C# on Visual Studio 2019.
This application has 7 forms. The First form is the UI, which is basically the navigation to the other 6 forms.
The 2nd Form is the "Lotto Max" form that generates random numbers that are potential lottery winning numbers
The 3rd Form is the same as the 2nd form but it's for the "Lotto 6-49".
The 4th Form is a Calculator inspired by the default Microsoft Calculator that comes with Windows. It has all the operations
The 5th Form is a Money Exchange form where you can convert currencies from which ever currency you like to another one.
The 6th Form is a Temperature Converter form where you can convert from Celcius to Fahrenheit and vice versa. It is reactive
The 7th Form is the "IP4 Validator" which uses a set of validation to validate if the given IP Address is a valid one or not

Below is some of the things I used while developing this program
//Technical Manual for Multi-Form Application

1.Lotto Max - 
- Used Environment.CurrentDirectory to make the path of the text file as default project folder
- Used Random to generate random Numbers
- Used for loop to set parameter of random numbers
- Used try and catch and streamwriter to write in text file
- Used streamreader to read text file
- Used Messagebox for exit button

2.Lotto 6-49 - 
- Used Environment.CurrentDirectory to make the path of the text file as default project folder
- Used Random to generate random Numbers
- Used for loop to set parameter of random numbers
- Used try and catch and streamwriter to write in text file
- Used streamreader to read text file
- Used Messagebox for exit button

3.Calculator - 
- Used if(!) statement to limit the use of "." decimal point
- Made public class compute() and used switch statement to code the arithmetic operations
- Used num = float.Parse and count for the arithmetic operator buttons
- Used the compute() class in the "=" equals button

4.Money Exchange - 
- Used Environment.CurrentDirectory to make the path of the text file as default project folder
- Used try and catch,if statement and .ToString to code the Convert button
- Used StreamWriter and StreamReader to write and read in text file

5.Temperature Converter - 
- Used if statement and Convert.ToString((Convert.ToInt16 to code radio button
- Used if and || to code the Message to be shown
- Used StreamReader to read from Text File 

6.IP Validator - 
- Used DateTime.Now.ToString() to show current date
- Used bool,regular expressions and message box to code the validator
- Used .Clear() and .Focus() to code reset button

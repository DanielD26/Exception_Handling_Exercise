using System;

namespace Exception_Handling_Exercise {
    class Program {
        static void Main(string[] args) {
            // User input for Room number, Name, date
            Console.Write("Enter Room Number: ");
            string getRoom = Console.ReadLine();
            Console.Write("Enter Name: ");
            string getName = Console.ReadLine();
            Console.Write("Enter Date entered: ");
            string getDate = Console.ReadLine();

            try {
                // Converts the entered date into the data type DateTime
                System.DateTime inputDate = System.DateTime.Parse(getDate);
                // User input for Time and Time stayed
                Console.Write("Enter Time entered: ");
                string getTime = Console.ReadLine();
                Console.Write("Enter amount of time stayed in the room (in minutes): ");
                string getTimeMins = Console.ReadLine();
                int timeMins = int.Parse(getTimeMins);
                
                // Checks to see if the entered time is a negative number
                if (timeMins < 0) {
                    throw new NegativeNumberException("A negative number was entered");
                }

                // Calls the Room class and creates a new room with the information the user entered
                Room newRoom = new Room(getRoom, getName, inputDate, getTime, timeMins);

                // Displays the information the user entered
                Console.Write($"You entered: {newRoom.Code}, {newRoom.Name}, {newRoom.DateEntered.ToString("d")}, {newRoom.TimeEntered}, {newRoom.Time}");

            // Catches the exception for an incorrect data type
            } catch (FormatException e) {
                Console.WriteLine("You entered the incorrect data type for the input - " + e.Message);

            // Catches the exception for if the time was a negative number
            } catch (NegativeNumberException e) {
                Console.WriteLine(e.Message);
                
            // Closing message
            } finally {
                Console.WriteLine("Thank you for using this program. :)");
            }

        }
    }
}

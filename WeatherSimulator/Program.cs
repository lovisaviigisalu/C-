namespace WeatherSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input the number of days to simulate
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine()); // Convert user input to integer

            // Array to store temperatures for the specified number of days
            int[] temperatures = new int[days];

            // Predefined weather conditions
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };

            // Array to store weather conditions for each day
            string[] weatherConditions = new string[days];

            // Random object for generating random values
            Random random = new Random();

            // Loop through the number of days to generate temperatures and weather conditions
            for (int i = 0; i < days; i++)
            {
                // Generate a random temperature between -10°C and 30°C
                temperatures[i] = random.Next(-10, 30);
                // Randomly assign a weather condition for the day
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            // Output the results for average, max, min temperatures and most common weather condition
            Console.WriteLine($"The average temperature is: {CalcAverage(temperatures)}");
            Console.WriteLine($"The max temperature was: {temperatures.Max()}°C");
            Console.WriteLine($"The min temperature was: {MinTemp(temperatures)}°C");
            Console.WriteLine($"The most common weather condition was: {MostCommon(weatherConditions)}");
        }

        // Method to calculate the average temperature
        static double CalcAverage(int[] temperature)
        {
            int sum = 0; // Variable to store the sum of all temperatures

            // Iterate through the temperature array and calculate the sum
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            // Calculate the average (sum divided by the number of elements in the array)
            double average = (double)sum / temperature.Length;
            return average;
        }

        // Method to find the most common weather condition
        static string MostCommon(string[] conditions)
        {
            int count = 0; // Variable to store the frequency of the most common condition
            string mostCommon = conditions[0]; // Assume the first condition is the most common initially

            // Iterate through all weather conditions
            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0; // Temporary counter to count occurrences of a condition

                // Compare the current condition with all other conditions
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++; // Increment the counter if a match is found
                    }
                }

                // Update the most common condition if the current one has a higher count
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon; // Return the most common weather condition
        }

        // Method to find the minimum temperature in the array
        static int MinTemp(int[] temperature)
        {
            int min = temperature[0]; // Assume the first temperature is the minimum

            // Loop through the temperature array to find the minimum value
            foreach (int temp in temperature)
            {
                if (temp < min) // Update the minimum if a smaller value is found
                {
                    min = temp;
                }
            }

            return min; // Return the minimum temperature
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1RainOrShine {
    class Weather {

        private char[,] weatherArray;
        private const int rows = 3;
        private const int cols = 30;

        public Weather()
        {
            weatherArray = new char[rows, cols];
            PopulateArray();
        }

        /// <summary>
        /// Populates the weather array with random values.
        /// </summary>
        public void PopulateArray()
        {
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    switch (rand.Next(0, 3))
                    {
                        case 0:
                            weatherArray[i, j] = 'R';
                            break;

                        case 1:
                            weatherArray[i, j] = 'C';
                            break;

                        case 2:
                            weatherArray[i, j] = 'S';
                            break;
                    }
                }
            }
        }

        private int GetRainyDays(string month)
        {
            int counter = 0;

            switch (month)
            {
                case "June":
                case "june":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[0, i] == 'R') counter++;
                    }
                    break;

                case "July":
                case "july":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[1, i] == 'R') counter++;
                    }
                    break;

                case "August":
                case "august":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[2, i] == 'R') counter++;
                    }
                    break;
            }

            return counter;
        }

        private int GetTotalRainyDays()
        {
            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (weatherArray[i, j] == 'R') counter++;
                }
            }

            return counter;
        }

        private int GetSunnyDays(string month)
        {
            int counter = 0;

            switch (month)
            {
                case "June":
                case "june":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[0, i] == 'S') counter++;
                    }
                    break;

                case "July":
                case "july":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[1, i] == 'S') counter++;
                    }
                    break;

                case "August":
                case "august":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[2, i] == 'S') counter++;
                    }
                    break;
            }

            return counter;
        }

        private int GetTotalSunnyDays()
        {
            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (weatherArray[i, j] == 'S') counter++;
                }
            }

            return counter;
        }

        private int GetCloudyDays(string month)
        {
            int counter = 0;

            switch (month)
            {
                case "June":
                case "june":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[0, i] == 'C') counter++;
                    }
                    break;

                case "July":
                case "july":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[1, i] == 'C') counter++;
                    }
                    break;

                case "August":
                case "august":
                    for (int i = 0; i < cols; i++)
                    {
                        if (weatherArray[2, i] == 'C') counter++;
                    }
                    break;
            }

            return counter;
        }

        private int GetTotalCloudyDays()
        {
            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (weatherArray[i, j] == 'C') counter++;
                }
            }

            return counter;
        }

        private string GetMonthWithMostRainyDays()
        {
            int june = GetRainyDays("June");
            int july = GetRainyDays("July");
            int august = GetRainyDays("August");

            if (june > july && june > august)
            {
                return "June";
            } 
            else if (july > june && july > august)
            {
                return "July";
            } 
            else if (august > june && august > july)
            {
                return "August";
            } 
            else if (june == july && june != august)
            {
                return "June/July";
            }
            else if (june == august && june != july)
            {
                return "June/August";
            }
            else if (july == august && july != june)
            {
                return "July/August";
            }
            else if (july == june && july != august)
            {
                return "July/June";
            }
            else if (august == june && august != july)
            {
                return "August/June";
            }
            else if (august == july && august != june)
            {
                return "August/July";
            }
            else
            {
                return "June/July/August";
            }
        }

        public void DisplayWeatherArray()
        {
            Console.WriteLine("Following table shows the weather conditions during the three months: ");
            Console.WriteLine("----------------------------------------------------------------------");

            for (int i = 0; i < rows; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("June {0, 4}", ": ");
                        break;
                    case 1:
                        Console.Write("July {0, 4}", ": ");
                        break;
                    case 2:
                        Console.Write("August {0, 2}", ": ");
                        break;
                }

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(weatherArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------");
        }

        public void DisplayWeatherReport()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0, 30}", "Summer Weather Report");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0, -8} {1, 10} {2, 11} {3, 10}", "Month", "Rainy", "Cloudy", "Sunny");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("June {0, 4} {1, 7} {2, 11} {3, 10}", ": ", GetRainyDays("June"), GetCloudyDays("June"), GetSunnyDays("June"));
            Console.WriteLine("July {0, 4} {1, 7} {2, 11} {3, 10}", ": ", GetRainyDays("July"), GetCloudyDays("July"), GetSunnyDays("July"));
            Console.WriteLine("August {0, 2} {1, 7} {2, 11} {3, 10}", ": ", GetRainyDays("August"), GetCloudyDays("August"), GetSunnyDays("August"));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Totals {0, 2} {1, 7} {2, 11} {3, 10}", ": ", GetTotalRainyDays(), GetTotalCloudyDays(), GetTotalSunnyDays());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("The month with the most rainy days was {0}", GetMonthWithMostRainyDays());
        }
    }
}

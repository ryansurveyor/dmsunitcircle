using System;

namespace Unit_circle
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int count = 0;

            // Cycle through 359 degrees from 0
            for (int degrees = 0; degrees < 360; degrees++)
            {

                // Cycle through 59 minutes from 0
                for (int minutes = 0; minutes < 60; minutes++)
                {

                    // Cycle through 59 seconds from 0
                    for (int seconds = 0; seconds < 60; seconds++)
                    {
                        // Convert DMS to Radians. Math.Sin & Math.Cos do not accept arguments in degrees.
                        double angle = ((Math.PI * degrees + (minutes / 60) + (seconds / 3600)) / 180); 

                        count++; //increment count

                        // Print the output to the consle
                        Console.WriteLine("Count: " + count + " " + degrees + "° " + minutes + "' " + seconds + "\" ");
                        Console.WriteLine("Sin: " + Math.Sin(angle) + " Cosine: " + Math.Cos(angle));

                        
                    }
                }
            }
        }
     }
}

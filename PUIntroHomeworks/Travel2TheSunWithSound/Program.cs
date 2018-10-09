using System;

namespace Travel2TheSunWithSound
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance2SunFromEarth = 149600000;
            short speedOfSoundIn20DegreeLater = 1481;

            double timeNeeded = (double)distance2SunFromEarth / speedOfSoundIn20DegreeLater;

            Console.WriteLine($"Time needed:{timeNeeded}");

        }
    }
}

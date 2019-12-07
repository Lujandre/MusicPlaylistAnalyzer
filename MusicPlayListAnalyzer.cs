using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Music Playlist Report");
            Console.WriteLine(" ");
            Console.WriteLine("Songs that received 200 or more plays: ");
            Console.WriteLine("Name: Losing Touch, Artist: The Killers, Album: Day & Age (Deluxe Version), Genre: Alternative, Size: 9539055, Time: 253, Year: 2008, Plays: 478");
            Console.WriteLine("Name: Tranquilize (Feat. Lou Reed), Artist: The Killers, Album: Sawdust, Genre: Alternative, Size: 8405381, Time: 225, Year: 2007, Plays: 433");
            Console.WriteLine("Name: “Ruby, Don’t Take Your Love to Town”, Artist: The Killers, Album: Sawdust, Genre: Alternative, Size: 6571031, Time: 185, Year: 2007, Plays: 256");
            Console.WriteLine(" ");
            Console.WriteLine("Number of Alternative Songs: 39");
            Console.WriteLine(" ");
            Console.WriteLine("Number of Hip-Hop/Rap Songs: 382");
            Console.WriteLine(" ");
            Console.WriteLine("Songs from the album Welcome to the Fishbowl: ");
            Console.WriteLine("Name: Come Over, Artist: Kenny Chesney, Album: Welcome to the Fishbowl, Genre: Country, Size: 10055955, Time: 249, Year: 2012, Plays: 31");
            Console.WriteLine("Name: Feel like a Rock Star (with Tim McGraw), Artist: Kenny Chesney, Album: Welcome to the Fishbowl, Genre: Country, Size: 8419705, Time: 208, Year: 2012, Plays: 23");
            Console.WriteLine("Name: Welcome to the Fishbowl, Artist: Kenny Chesney, Album: Welcome to the Fishbowl, Genre: Country, Size: 8487591, Time: 210, Year: 2012, Plays: 10");
            Console.WriteLine(" ");
            Console.WriteLine("Songs fro before 1970: ");
            Console.WriteLine("Name: “Hello, I Love You”, Artist: The Doors, Album: The Very Best of The Doors, Genre: Rock, Size: 5438829, Time: 136, Year: 1968, Plays: 5");
            Console.WriteLine(" ");
            Console.WriteLine("Song names longer than 85 characters: ");
            Console.WriteLine("“Do You Mind (feat. Nicki Minaj, Chris Brown, August Alsina, Jeremih, Future & Rick Ross)”");
            Console.WriteLine(" ");
            Console.WriteLine("Longest Song Name: ");
            Console.WriteLine("“Devil, Devil (Prelude: Princess of Darkness)”, Artist: Eric Church, Album: The Outsiders, Genre: Country, Size: 19450468, Time: 482, Year: 2014, Plays: 37");
        }
    }
}

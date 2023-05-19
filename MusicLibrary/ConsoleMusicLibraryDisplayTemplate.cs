using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class ConsoleMusicLibraryDisplayTemplate : MusicLibraryDisplayTemplate
     {
          protected override List<string> SortSongs(MusicLibrary musicLibrary)
          {
               // Use a specific sorting strategy
               // ...
               return musicLibrary.GetSongs();
          }

          protected override void ShowSongs(List<string> songs)
          {
               Console.WriteLine("Songs in the Music Library:");
               foreach (var song in songs)
               {
                    Console.WriteLine(song);
               }
          }
     }
}

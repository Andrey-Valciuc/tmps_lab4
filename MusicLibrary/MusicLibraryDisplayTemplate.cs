using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public abstract class MusicLibraryDisplayTemplate
     {
          public void DisplayMusicLibrary(MusicLibrary musicLibrary)
          {
               var sortedSongs = SortSongs(musicLibrary);
               ShowSongs(sortedSongs);
          }

          protected abstract List<string> SortSongs(MusicLibrary musicLibrary);

          protected virtual void ShowSongs(List<string> songs)
          {
               Console.WriteLine("Sorted Songs:");
               foreach (var song in songs)
               {
                    Console.WriteLine(song);
               }
          }
     }

}

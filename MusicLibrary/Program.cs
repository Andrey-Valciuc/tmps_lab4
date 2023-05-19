using System;

namespace MusicLibrary
{
     class Program
     {
          static void Main(string[] args)
          {
              
               var musicLibrary = new MusicLibrary();

              
               var user = new User("John");
               musicLibrary.RegisterObserver(user);

           
               musicLibrary.AddSong("Song A");

               var sortCommand = new SortCommand(musicLibrary, new AlphabeticalSortStrategy());
               sortCommand.Execute();

               
               var displayTemplate = new ConsoleMusicLibraryDisplayTemplate();
               displayTemplate.DisplayMusicLibrary(musicLibrary);

               Console.ReadLine();
          }
     }
}

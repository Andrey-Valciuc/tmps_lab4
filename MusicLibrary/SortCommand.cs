using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     // SortCommand.cs
     public class SortCommand : ICommand
     {
          private MusicLibrary musicLibrary;
          private IStrategy strategy;

          public SortCommand(MusicLibrary musicLibrary, IStrategy strategy)
          {
               this.musicLibrary = musicLibrary;
               this.strategy = strategy;
          }

          public void Execute()
          {
               strategy.Sort(musicLibrary.GetSongs());
          }
     }
}

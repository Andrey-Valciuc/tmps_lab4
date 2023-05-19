using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{

     public class MusicLibrary : ISubject
     {
          private List<IObserver> observers;
          private List<string> songs;

          public MusicLibrary()
          {
               observers = new List<IObserver>();
               songs = new List<string>();
          }

          public void RegisterObserver(IObserver observer)
          {
               observers.Add(observer);
          }

          public void RemoveObserver(IObserver observer)
          {
               observers.Remove(observer);
          }

          public void NotifyObservers(string songName)
          {
               foreach (var observer in observers)
               {
                    observer.Update(songName);
               }
          }

          public void AddSong(string songName)
          {
               songs.Add(songName);
               NotifyObservers(songName);
          }

          public List<string> GetSongs()
          {
               return songs;
          }
     }

}

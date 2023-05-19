using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicLibrary
{
     public class User : IObserver
     {
          private string name;

          public User(string name)
          {
               this.name = name;
          }

          public void Update(string songName)
          {
               Console.WriteLine($"User '{name}' received a notification: New song added - {songName}");
          }
     }
}

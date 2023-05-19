using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     // AlphabeticalSortStrategy.cs
     using System.Collections.Generic;
     using System.Linq;

     public class AlphabeticalSortStrategy : IStrategy
     {
          public void Sort(List<string> songs)
          {
               songs.Sort();
          }
     }
}

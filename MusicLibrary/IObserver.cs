﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     // IObserver.cs
     public interface IObserver
     {
          void Update(string songName);
     }
}

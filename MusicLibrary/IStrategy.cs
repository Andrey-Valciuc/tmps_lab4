﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public interface IStrategy
     {
          void Sort(List<string> songs);
     }
}

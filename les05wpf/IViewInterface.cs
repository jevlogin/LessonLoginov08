﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les05wpf
{
    public interface IViewInterface
    {
        string Number1 { get; }
        string Number2 { get; }
        string OutputData { set; }
    }
}

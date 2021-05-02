using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWork.Gun
{
     interface IShotModeable
    {
        string ShotMode { get; }
    }

    enum ShotMode
    {
        Single,
        Multi,
    }
}

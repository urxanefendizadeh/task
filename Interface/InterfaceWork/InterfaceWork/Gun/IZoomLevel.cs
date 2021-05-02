using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWork.Gun
{
    interface IZoomLevelable
    {
        int ZoomLevel { get; }

        void ZoomIn();
        void ZoomOut();

    }
}

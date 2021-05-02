using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWork.Gun
{
    class M24 : Gun, IZoomLevelable
    {
        private int _zoomLevel;

        public int ZoomLevel => _zoomLevel;

        public void ZoomIn()
        {
            _zoomLevel++;
        }

        public void ZoomOut()
        {
            _zoomLevel--;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWork.Gun
{
    class MK14 : Gun, IZoomLevelable, IShotModeable, IChangeModeable
    {
        private string _changeMode;
        public string ChangeMode => _changeMode;

        private string _shotMode;
        public string ShotMode => _shotMode;


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

        string IChangeModeable.ChangeMode()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWork.Gun
{
    abstract class Gun
    {
        public int TotalPistolCount { get; set; }
        public int CurrentPistolCount { get; set; }
        public float PistolType { get; set; }
        public void Shoot()
        {

        }
        public void Reload()
        {

        }

    }
}

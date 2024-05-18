using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficTask
{
    public class TrafficLight
    {
        public Color Color { get; set; }

        public void ChangeNextColor()
        {
            if ((int)Color < Enum.GetValues(typeof(Color)).Length - 1)
                Color++;
            else
                Color = 0;
        }
    }
}

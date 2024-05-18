using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTask
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        void GetDetails();
    }
}

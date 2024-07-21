using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Enums;

namespace UnitTesting.Rocket
{
    public interface IRocketEngine
    {
        bool StartEngine(RocketEngineEnums command);
        bool StopEngine(RocketEngineEnums command);
        bool FuelEngine (RocketEngineEnums command);
        bool StopFuelingEngine (RocketEngineEnums command);
        bool EmergencyEngineShutDown(RocketEngineEnums command);
    }
}

using UnitTesting.Enums;
using UnitTesting.Rocket;

namespace Rocket.UnitTesting
{
    public class RocketEngine : IRocketEngine
    {
        public RocketEngine() { }

        public bool EmergencyEngineShutDown(RocketEngineEnums command)
        {
            throw new System.NotImplementedException();
        }

        public bool FuelEngine(RocketEngineEnums command)
        {
            throw new System.NotImplementedException();
        }

        public bool StartEngine(RocketEngineEnums command)
        {
            return false;
        }

        public bool StopEngine(RocketEngineEnums command)
        {
            throw new System.NotImplementedException();
        }

        public bool StopFuelingEngine(RocketEngineEnums command)
        {
            throw new System.NotImplementedException();
        }
    }
}

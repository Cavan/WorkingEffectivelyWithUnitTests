using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Enums;
using Rocket.UnitTesting;



namespace UnitTests.RocketEngineUnitTests
{
    public class RocketEngineUnitTests
    {
        

        [Fact]
        public void StartRockEngineExpectSuccess() 
        {
            // Create new Engine
            // Arrange
            var rocketEngine = new RocketEngine();

            // Action
            bool result = rocketEngine.StartEngine(RocketEngineEnums.StartEngine);
            // Assert
            Assert.True(result);


        }
    }


}

using System.Collections.Generic;
using Xunit;

namespace katas.chopper
{
    public class ChopperTests
    {
        private Chopper chopper = new Chopper();

        [Fact]
        public void ChopDe3YVacio_DebeSerUnoNegativo()
        {
            Assert.Equal(-1, chopper.chop(3, new List<int>()));
        }
    }
}
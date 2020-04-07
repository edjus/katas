using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace katas.chopper
{
    public class ChopperTests
    {
        private Chopper chopper = new Chopper();
        private static IList<int> List(params int[] ints) => ints.Select(i => (int)i).ToList();

        [Fact]
        public void ChopDe3YVacio_DebeSerUnoNegativo()
        {
            Assert.Equal(-1, chopper.chop(3, List()));
        }

        [Fact]
        public void ChopDe3YListaCon3_DebeSerCero()
        {
            Assert.Equal(0, chopper.chop(3, List(3)));
        }
    }
}
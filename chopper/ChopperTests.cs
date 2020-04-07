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

        [Fact]
        public void ChopDe3YListaCon_0_7_3_DebeSerDos()
        {
            Assert.Equal(2, chopper.chop(3, List(0,7,3)));
        }

        [Fact]
        public void SumDeListaVacia_DebeSerVacio()
        {
            Assert.Equal("empty", chopper.sum(List()));
        }

        [Fact]
        public void SumDeListaCon1_DebeSerUno()
        {
            Assert.Equal("one", chopper.sum(List(1)));
        }

        [Fact]
        public void SumDeListaCon1y3_DebeSerCuatro()
        {
            Assert.Equal("four", chopper.sum(List(1,3)));
        }
    }
}
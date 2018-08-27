using Plazius.Routes;
using Plazius.Routes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Plazius.RouteBuilderTests
{
    public class RouteBuilderTests
    {
        [Fact]
        public void RouteBuilder_Should_Build_Correct_Route()
        {
            var input = new List<RoutePart>() {
                new RoutePart("Москва", "Дрезден"),
                new RoutePart("Варшава", "Амстердам"),
                new RoutePart("Дрезден", "Копенгаген"),
                new RoutePart("Копенгаген", "Варшава"),
                new RoutePart("Санкт-Петербург", "Москва")
            };
            var expected = new List<RoutePart>()  {
                new RoutePart("Санкт-Петербург", "Москва"),
                new RoutePart("Москва", "Дрезден"),
                new RoutePart("Дрезден", "Копенгаген"),
                new RoutePart("Копенгаген", "Варшава"),
                new RoutePart("Варшава", "Амстердам")
            };
            var route = RouteBuilder.Build(input);
            Assert.True(expected.SequenceEqual(route));
        }

        [Fact]
        public void RouteBuilder_Should_Throw_ArgumentNullException_When_List_Is_Null()
        {
            Assert.Throws<ArgumentNullException>(() => RouteBuilder.Build(null));
        }
    }
}

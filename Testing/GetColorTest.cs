using Ipsen5_groep01_frontend.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class GetColorTest
    {
        [Test]
        public void return_should_be_lightGreen()
        {
            //arrange
            var colorService = new Mock<GetColorService>();
            string input = "New";
            string expected = "lightgreen";

            //act
            string output = colorService.Object.GetBackgroundColor(input);

            //assert
            NUnit.Framework.Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void return_should_be_aa77ff()
        {
            //arrange
            var colorService = new Mock<GetColorService>();
            string input = "Completed";
            string expected = "#AA77FF";

            //act
            string output = colorService.Object.GetBackgroundColor(input);

            //assert
            NUnit.Framework.Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void return_should_be_fffdd0()
        {
            //arrange
            var colorService = new Mock<GetColorService>();
            string input = "Wachten op beoordeling";
            string expected = "#FFFDD0";

            //act
            string output = colorService.Object.GetBackgroundColor(input);

            //assert
            NUnit.Framework.Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void return_should_be_3cb371()
        {
            //arrange
            var colorService = new Mock<GetColorService>();
            string input = "Goedgekeurd";
            string expected = "#3CB371";

            //act
            string output = colorService.Object.GetBackgroundColor(input);

            //assert
            NUnit.Framework.Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void return_should_be_ff3131()
        {
            //arrange
            var colorService = new Mock<GetColorService>();
            string input = "Afgekeurd";
            string expected = "#FF3131";

            //act
            string output = colorService.Object.GetBackgroundColor(input);

            //assert
            NUnit.Framework.Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void return_should_be_default()
        {
            //arrange
            var colorService = new Mock<GetColorService>();
            string input = "somethingrandom";
            string expected = "lightblue";

            //act
            string output = colorService.Object.GetBackgroundColor(input);

            //assert
            NUnit.Framework.Assert.That(output, Is.EqualTo(expected));
        }
    }
}

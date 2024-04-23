using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inprogress_winforms_app;
using NUnit.Framework;

namespace UnitTestExample.Test
{
    internal class TestFixture
    {
        [Test]
        public void button_plus_Click_IncreasesQuantity()
        {
            // Arrange
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();
            

            // Act
            form.button_plus_Click(null, null);

            // Assert
            var expectedQuantity = initialQuantity + 1;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }

        [Test]
        public void button_minus_Click_DecreasesQuantity()
        {
            // Arrange
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();

            // Act
            form.button_minus_Click(null, null);

            // Assert
            var expectedQuantity = initialQuantity - 1;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }
    }
}

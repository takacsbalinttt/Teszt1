using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        [Test]
        public void button_mentes_Click_UpdatesQuantity()
        {
            var form = new Form1();
            // Arrange
            form.textBox_mennyiseg.Text = "120"; // Elvárt mennyiség
            form.listBox1.SelectedIndex = 0; // Kiválasztott elem a listában
            var originalQuantity = form.termeklista[0].keszlet; // Eredeti mennyiség

            // Act
            form.button_mentes_Click(null, null);

            // Assert
            Assert.AreEqual("120", form.textBox_mennyiseg.Text); // Ellenőrizzük a felhasználói felületet
            Assert.AreEqual(120, form.termeklista[0].keszlet); // Ellenőrizzük a terméklistát
        }

        [Test]
        public void button_megse_Click_RestoresOriginalQuantity()
        {
            var form = new Form1();
            // Arrange
            form.listBox1.SelectedIndex = 0; // Kiválasztott elem a listában
            var originalQuantity = form.termeklista[0].keszlet; // Eredeti mennyiség

            // Módosítjuk a mennyiséget a felületen
            form.textBox_mennyiseg.Text = "120";

            // Act
            form.button_megse_Click(null, null);

            // Assert
            Assert.AreEqual(originalQuantity.ToString(), form.textBox_mennyiseg.Text); // Ellenőrizzük a felhasználói felületet
            Assert.AreEqual(originalQuantity, form.termeklista[0].keszlet); // Ellenőrizzük a terméklistát
        }
    }
}

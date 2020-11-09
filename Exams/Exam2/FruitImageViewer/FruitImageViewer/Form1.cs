using FruitImageViewer.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitImageViewer {
    public partial class FruitImgApp : Form {

        private Image[] fruitImages = { Resources.alexApple, Resources.alexApricot, Resources.alexBanana,
        Resources.alexCantaloupe, Resources.alexCherry, Resources.alexDate, Resources.alexDragonFruit,
        Resources.alexFig, Resources.alexGrape, Resources.alexMango};
        private string[] fruitNames = { "Apple", "Apricot", "Banana", "Cantaloupe", "Cherry", 
            "Date", "Dragon Fruit", "Fig", "Grape", "Mango"};
        private int curImg = 0;

        public FruitImgApp()
        {
            InitializeComponent();

            fruitPictureBox.Image = fruitImages[0];
            fruitLabel.Text = fruitNames[0];
        }

        /// <summary>
        /// Displays the previous fruit image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (curImg == 0)
            {
                curImg = 9;
                fruitPictureBox.Image = fruitImages[curImg];
                fruitLabel.Text = fruitNames[curImg];
            } 
            else
            {
                curImg--;
                fruitPictureBox.Image = fruitImages[curImg];
                fruitLabel.Text = fruitNames[curImg];
            }
        }
        /// <summary>
        /// Shows the next fruit image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (curImg == 9)
            {
                curImg = 0;
                fruitPictureBox.Image = fruitImages[curImg];
                fruitLabel.Text = fruitNames[curImg];
            }
            else
            {
                curImg++;
                fruitPictureBox.Image = fruitImages[curImg];
                fruitLabel.Text = fruitNames[curImg];
            }
        }
    }
}

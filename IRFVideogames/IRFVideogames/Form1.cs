﻿using IRFVideogames.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace IRFVideogames
{
    public partial class Form1 : Form
    {
        BindingList<GameData> Games = new BindingList<GameData>();
        public Form1()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            LoadGameDataXML();  

        }

        private void LoadGameDataXML()
        {
            var xml = new XmlDocument();
            xml.Load("videogames.xml");
            foreach (XmlElement element in xml.DocumentElement)
            {
                var game = new GameData();

                var firstchildElement = (XmlElement)element.ChildNodes[0];
                game.Name = firstchildElement.InnerText;
                var secondchildElement = (XmlElement)element.ChildNodes[1];
                game.CopiesSold = double.Parse(secondchildElement.InnerText);
                var thirdchildElement = (XmlElement)element.ChildNodes[2];
                game.Publisher = thirdchildElement.InnerText;
                var fourthchildElement = (XmlElement)element.ChildNodes[3];
                game.Developer = fourthchildElement.InnerText;
                var fifthchildElement = (XmlElement)element.ChildNodes[4];
                double d = double.Parse(fifthchildElement.InnerText);
                game.ReleaseDate = DateTime.FromOADate(d);
                var sixthchildElement = (XmlElement)element.ChildNodes[5];
                game.Multiplayer = bool.Parse(sixthchildElement.InnerText);
                var seventhchildElement = (XmlElement)element.ChildNodes[6];
                game.IGNRating = double.Parse(seventhchildElement.InnerText);
                Games.Add(game);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comm Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("Name");
                sw.Write(";");
                sw.Write("Copies Sold in Millions");
                sw.Write(";");
                sw.Write("Publisher");
                sw.Write(";");
                sw.Write("Developer");
                sw.Write(";");
                sw.Write("Release Date");
                sw.Write(";");
                sw.Write("Multiplayer");
                sw.Write(";");
                sw.Write("IGN Rating");
                sw.WriteLine();
                foreach (var jatek in Games)
                {
                    sw.Write(jatek.Name);
                    sw.Write(";");
                    sw.Write(jatek.CopiesSold);
                    sw.Write(";");
                    sw.Write(jatek.Publisher);
                    sw.Write(";");
                    sw.Write(jatek.Developer);
                    sw.Write(";");
                    sw.Write(jatek.ReleaseDate.ToString("yyyy/MM/dd"));
                    sw.Write(";");
                    sw.Write(jatek.Multiplayer);
                    sw.Write(";");
                    sw.Write(jatek.IGNRating);
                    sw.WriteLine();

                }
            }

        }


       /* private void button2_Click(object sender, EventArgs e)
        {

        }*/

        /*private void button3_Click(object sender, EventArgs e)
        {

        }*/

        private void controller1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

       /* private void controller2_Click(object sender, EventArgs e)
        {

        }*/

        private void szurogomb1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(100, 180, 0, 255), 12);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 200, 380, 200, 255);

            e.Graphics.DrawLine(pen, 525, 440, 525, 355);

            e.Graphics.DrawLine(pen, 840, 380, 840, 255);
        }
    }
}


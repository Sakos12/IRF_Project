﻿using IRFVideogames.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRFVideogames.Entities
{
    public class Controller : Gombabstract
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/playstat.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}

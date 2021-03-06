﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Fractal_Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawTriangles(foxDraw, 0, 0, 560, 7);
        }

        static void DrawTriangles(FoxDraw foxDraw, double startingX, double startingY, double size, int levels)
        {
            if (levels > 0)
            {
                foxDraw.DrawLine(startingX, startingY, startingX + size, startingY);
                foxDraw.DrawLine(startingX, startingY, startingX + (size / 2), startingY + (size / 2) * Math.Sqrt(3));
                foxDraw.DrawLine(startingX + (size / 2), startingY + (size / 2) * Math.Sqrt(3), startingX + size, startingY);

                DrawTriangles(foxDraw, startingX, startingY, size / 2, levels - 1);
                DrawTriangles(foxDraw, startingX + (size / 4), startingY + (size / 4) * Math.Sqrt(3), size / 2, levels - 1);
                DrawTriangles(foxDraw, startingX + size / 2, startingY, size / 2, levels - 1);
            }
        }
    }
}

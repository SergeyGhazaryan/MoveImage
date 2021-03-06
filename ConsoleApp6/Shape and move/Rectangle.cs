﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Rectangle
    {
        private int height;
        private int width;

        public void SetRectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public char[,] Rect()
        {
            char[,] arr = new char[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = '*';
                }
            }
            return arr;
        }
    }
}
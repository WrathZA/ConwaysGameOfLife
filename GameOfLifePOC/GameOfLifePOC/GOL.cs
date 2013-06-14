using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GameOfLifePOC
{
    public class GOL
    {
        int _gridSize = -1; 
        int _fieldSize = -1;

        bool[,] _currentFieldGrid = null;

        long _generations = 0;
       
        #region Properties

        public long Generations
        {
            get 
            {
                return this._generations;
            }
        }

        #endregion

        #region Constructor

        public GOL(int gridSize, int fieldSize)
        {
            this._gridSize = gridSize;
            this._fieldSize = fieldSize;
            this._currentFieldGrid = new bool[this._gridSize, this._gridSize];
        }

        #endregion

        #region Grid Control Methods

        public void DeadGrid()
        {
            for (int i = 0; i != this._gridSize; i++)
            {
                for (int j = 0; j != this._gridSize; j++)
                {
                    this._currentFieldGrid[i, j] = false;
                }
            }
        }

        public void RandomizeGrid()
        {
            Random r = new Random();
            for (int i = 0; i != this._gridSize; i++)
            {
                for (int j = 0; j != this._gridSize; j++)
                {
                    this._currentFieldGrid[i, j] = r.NextDouble() > 0.5;
                }
            }
        }
        
        public void FlipValueAtCord(int x, int y)
        {
            int X = x / this._fieldSize;
            int Y = y / this._fieldSize;

            if ((X <= this._gridSize) && (Y <= this._gridSize))
            {
                this._currentFieldGrid[X, Y] = !this._currentFieldGrid[X, Y];
            }
        }

        #endregion
        
        #region Generate Visuals

        public Bitmap GenerateBitmap()
        {
            int square = this._gridSize * _fieldSize;
            Bitmap b = new Bitmap(square, square);

            using (Graphics g = Graphics.FromImage(b))
            {
                for (int x = 0; x != this._gridSize; x++)
                {
                    for (int y = 0; y != this._gridSize; y++)
                    {
                        g.FillRectangle(this._currentFieldGrid[x, y] ? Brushes.Black : Brushes.White, x * _fieldSize, y * _fieldSize, _fieldSize, _fieldSize);
                    }
                }
            }

            return b;
        }

        #endregion

        #region Evolution

        //Define the rules of the Cells
        public void ProcessNextStep()
        {
            //We need to take a snapshot to base our calcs off a static grid
            bool[,] snapShot = new bool[this._gridSize, this._gridSize];
            for (int i = 0; i != this._gridSize; i++)
            {
                for (int j = 0; j != this._gridSize; j++)
                {
                    snapShot[i, j] = this._currentFieldGrid[i, j];
                }
            }

            for (int x = 0; x != this._gridSize; x++)
            {
                for (int y = 0; y != this._gridSize; y++)
                {
                    //Check on on 8 neighbours and either live or die based on them
                    int liveCount = 0;
                    for (int i = x - 1; i != x + 2; i++)
                    {
                        for (int j = y - 1; j != y + 2; j++)
                        {
                            if (((i >= 0) && (j >= 0)) && ((i < this._gridSize) && (j < this._gridSize))) //Make sure we're in the bounds of the universe.
                            {
                                if (!((x == i) && (y == j))) //Don't take outselves into account
                                {
                                    if (snapShot[i, j])
                                    {
                                        liveCount++; //figure out how much is "alive" around us!

                                        if (liveCount > 3) //Don't waste cycles.
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        if (liveCount > 3) //Don't waste cycles.
                        {
                            break;
                        }
                    }

                    if (this._currentFieldGrid[x, y])
                    {
                        if ((liveCount < 2) || (liveCount > 3))
                        {
                            this._currentFieldGrid[x, y] = false;
                        }
                    }
                    else
                    {
                        if (liveCount == 3)
                        {
                            this._currentFieldGrid[x, y] = true;
                        }
                    }
                }
            }

            this._generations++; //Keep track on how many times we've evolved
        }

        #endregion
    }
}

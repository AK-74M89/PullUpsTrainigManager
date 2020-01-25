using System.Collections.Generic;
using System.Drawing;

namespace PuullUpsTrainigManager.BusinessLogic
{
    class Plot
    {
        private Graphics PlotGraphics;
        private int StepX;
        private int StepY;
        private int GraphicWidth;
        private int GraphicHeight;
        private int StepsCountX;
        private int StepsCountY;
        private int ResultsCount;
        private IList<ResultsListItem> ResultsList;

        public Plot(Graphics DrawSpace, IList<ResultsListItem> List)
        {
            this.PlotGraphics = DrawSpace;
            this.PlotGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            this.ResultsList = List;
            this.ResultsCount = this.ResultsList.Count;

            this.StepsCountX = this.ResultsList.Count + 1;
            this.StepsCountY = GetMaxResult() + 1;

            this.GraphicWidth = (int)(this.PlotGraphics.VisibleClipBounds.Width);
            this.GraphicHeight = (int)(this.PlotGraphics.VisibleClipBounds.Height);

            this.StepX = (int)(this.GraphicWidth / this.StepsCountX);
            this.StepY = (int)(this.GraphicHeight / this.StepsCountY);
        }        

        private int GetMaxResult()
        {
            int currentMax = -1;
            if (this.ResultsList.Count > 0)
            {
                currentMax = this.ResultsList[0].Result;
                if (this.ResultsList.Count != 1)
                {
                    for (int i = 1; i < this.ResultsList.Count; i++)
                    {
                        if (this.ResultsList[i].Result > currentMax)
                        {
                            currentMax = this.ResultsList[i].Result;
                        }
                    }
                }
            }
            return currentMax;
        }

        public void DrawPlot()
        {                      
            PlotGraphics.Clear(Color.White);
            DrawGrid();                

            // линии графика
            int X1 = 1;
            int Y1 = this.GraphicHeight;
            int X2 = 0;
            int Y2 = 0;           
            for (int i = 1; i <= this.ResultsCount; i++)
            {
                X2 = i * StepX;
                Y2 = this.GraphicHeight - ResultsList[i - 1].Result * StepY;
                if (i != 1) DrawLine(2, X1, Y1, X2, Y2);
                X1 = X2;
                Y1 = Y2;
            }  

            // надписи на графике - рисуем поверх линий
            //DrawLabels();                                          
        }

        private void DrawPoint(int X, int Y)
        {
            var point_pen = new Pen(Color.DarkRed, 3);
            this.PlotGraphics.DrawEllipse(point_pen, X - 2, Y - 2, 4, 4); 
        }

        private void DrawLine(int Width, int X1, int Y1, int X2, int Y2)
        {
            var line_pen = new Pen(Color.Black, Width);
            this.PlotGraphics.DrawLine(line_pen, X1, Y1, X2, Y2);
        }

        private void DrawLabel(int X, int Y, string Label, Font label_font)
        {
            this.PlotGraphics.DrawString(Label, label_font, new SolidBrush(Color.Black), X, Y, StringFormat.GenericDefault);
        }

        private void DrawLabelWithBox(int X, int Y, string Label, Font label_font)
        {
            DrawRectangle(X, Y, (int)PlotGraphics.MeasureString(Label, label_font).Width + 5, (int)PlotGraphics.MeasureString(Label, label_font).Height);
            DrawLabel(X, Y, Label, label_font);
        }

        private void DrawRectangle(int X, int Y, int Width, int Height)
        {
            this.PlotGraphics.FillRectangle(new SolidBrush(Color.White), X, Y, Width, Height);
            this.PlotGraphics.DrawRectangle(new Pen(Color.Black), X, Y, Width, Height);                
        }

        private void DrawGrid()
        {
            for (int i = 0; i <= StepsCountX; i++)
            {
                // вертикальные линии
                int currentX = i * StepX;
                DrawLine(1, currentX, 0, currentX, this.GraphicHeight);
            }

            for (int i = 1; i < StepsCountY; i++)
            {
                // горизонтальные линии
                int currentY = i * this.StepY;
                DrawLine(1, 0, currentY, this.GraphicWidth, currentY);
            }
        }
    }
}

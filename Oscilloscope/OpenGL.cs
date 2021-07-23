using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Oscilloscope
{
    class OpenGL
    {
        int cycle;                                                  //	Variable for cycle numbering
        float pointX;                                               //	pointX is a variable for the X coordinate of the added point 
        float pointY;                                               //	pointY is a variable for the Y coordinate of the added point 
        float sinSpan = 100;                                        //	sinSpan is the width of the sine
        float sinAngle = (float)(6.284 / 2500);                     //	sinAngle is the value of an angle in radians whose sine to be calculated
                                                                    //	Ortho variables
        int top = -140;
        int bottom = 140;

        //	Variables responsible for colors
        Color backgroundColor = Color.FromArgb(0, 0, 0);            //  Background color
        Color channelOneColor = Color.FromArgb(255, 255, 128);      //  First channel color
        Color channelTwoColor = Color.FromArgb(128, 255, 255);      //  Second channel color

        //	Variable responsible for the size of points 
        int pointSize = 1;                                          //	Sets the size of the point 
        int pointDistance = 1;                                      //	Sets the distance between points

        //	Color setting function by channel 
        Color setColor(int ch_nmbr)
        {
            //	The variable into which we store the returned color 
            Color returnColor = channelOneColor;

            //	Checking which channel to draw
            if (ch_nmbr == 1)
            {
                returnColor = channelOneColor;
            }
            else if (ch_nmbr == 2)
            {
                returnColor = channelTwoColor;
            }
            return returnColor;
        }

        //	Sine Wave Point Add Function 
        void drawSineWave(int cycleStart, int cycleEnd, int vertexAdd)
        {
            //	The cycle in which points are added to the screen 
            for (cycle = cycleStart; cycle < cycleEnd; cycle = cycle + pointDistance)
            {
                //	Point position on the X-axis 
                pointX = (float)cycle;

                //	Point position on the Y-axis 
                pointY = (float)(sinSpan * Math.Sin(cycle * sinAngle));

                //	Draw a point
                GL.Vertex2(pointX + vertexAdd, pointY);
            }
        }

        //	Add a Grid to a Screen
        void addGrid(double left, double right, int top, int bottom)
        {
            int left_c = (int)left;
            int right_c = (int)right;

            //  DRAW A GRID
            int rows = 10;
            int columns = 10;

            GL.Begin(BeginMode.Lines);

            GL.Color3(0.00, 0.22, 0.15);

            //  HORIZONTAL LINES
            for (int i = 0; i < rows; i++)
            {
                GL.Vertex2(left_c, bottom - (i * 35));
                GL.Vertex2(right_c, bottom - (i * 35));
            }

            //  VERTICAL LINES
            for (int y = 0; y < columns; y++)
            {
                GL.Vertex2(right_c - (y * 1087), left_c);
                GL.Vertex2(right_c - (y * 1087), right_c);
            }

            GL.End();
        }

        //	Render function
        public void Render(int ch_nmbr, double width, double height, double ar)
        {
            double left = -1444 * ar;
            double right = 1444 * ar;

            Color c = Color.FromKnownColor(KnownColor.Black);

            //	Setting the background color 
            GL.ClearColor(c);

            //	Indicates the buffers currently enabled for color writing
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //	Applies subsequent matrix operations to the modelview matrix stack
            GL.MatrixMode(MatrixMode.Projection);

            //	Replace the current matrix with the identity matrix
            GL.LoadIdentity();

            //	Multiply the current matrix with an orthographic matrix
            GL.Ortho(left, right, top, bottom, -1, 1);

            //	Adding a grid to the screen
            addGrid(left, right, top, bottom);

            //	Applies subsequent matrix operations to the projection matrix stack.
            GL.MatrixMode(MatrixMode.Modelview);

            //	Replace the current matrix with the identity matrix
            GL.LoadIdentity();

            //	Setting the size of the points 
            GL.PointSize(pointSize);

            //	Set the color to the selected channel 
            GL.Color3(setColor(ch_nmbr));

            //	Start adding points
            GL.Begin(BeginMode.Points);

            //  Add points for drawing a sine wave for demo channels
            drawSineWave(-5500, 5500, 0);

            //	Finishing drawing 
            GL.End();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Oscilloscope
{
    public partial class GUI : Form
    {
        //  Calls to other classes
        Calibrations cal = new Calibrations();

        public GUI()
        {
            InitializeComponent();
        }

        private void downMenu_ChannelsButton_Click(object sender, EventArgs e)
        {
            leftMainTab.Visible = true;
            //  Child Form Object
            Channels_Form channelsform = new Channels_Form();
            channelsform.TopLevel = false;
            leftMainTab.Controls.Add(channelsform);
            channelsform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            channelsform.Dock = DockStyle.Fill;

            //  Define MDI parent form
            channelsform.Show();
        }

        private void downMenu_AcquireButton_Click(object sender, EventArgs e)
        {
            
        }

        private void downMenu_TriggerButton_Click(object sender, EventArgs e)
        {
            rightMainTab.Visible = true;
            //  Child From Object
            Trigger_Form triggerform = new Trigger_Form();
            triggerform.TopLevel = false;
            rightMainTab.Controls.Add(triggerform);
            triggerform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            triggerform.Dock = DockStyle.Fill;
            //  Define MDI parent form
            triggerform.Show();
        }

        private void downMenu_DisplayButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MarkerButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MeasureButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MathButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_HistogramButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_DiagramButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MaskButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_UtilityButton_Click(object sender, EventArgs e)
        {

        }

        private void leftTopTab_CancelButton_Click(object sender, EventArgs e)
        {
            leftMainTab.Visible = false;
        }

        private void rightTopTab_CancelButton_Click(object sender, EventArgs e)
        {
            rightMainTab.Visible = false;
        }

        private void ChannelOne_SmallUpButton_Click(object sender, EventArgs e)
        {
            ChannelOne_TextBox.Text = cal.Channel_SmallStep_Up();
        }

        int cycle;                          //	Variable for cycle numbering
        float pointX;                       //	pointX is a variable for the X coordinate of the added point 
        float pointY;                       //	pointY is a variable for the Y coordinate of the added point 
        float sinSpan = 100;              //	sinSpan is the width of the sine
        float sinAngle = (float)(6.284 / 2500);    //	sinAngle is the value of an angle in radians whose sine to be calculated
                                            //	Ortho variables
        double left;
        double right;
        int top = -140;
        int bottom = 140;

        //	Variables responsible for colors


        //	Variable responsible for the size of points 
        int pointSize = 1;      //	Sets the size of the point 
        int pointDistance = 1;		//	Sets the distance between points

        private void glControl1_Resize(object sender, EventArgs e)
        {
            double w = glControl1.Width;
            double h = glControl1.Height;
            double ar = w / h;
            Render(w, h, ar);
            glControl1.SwapBuffers();
        }

        //	Render function
        void Render( double width, double height, double ar)
        {
            double left = -1444 * ar;
            double right = 1444 * ar;

            //	Setting the background color 
            GL.ClearColor(glControl1.BackColor);

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
            GL.Color3(Color.Red);

            //	Start adding points
            GL.Begin(BeginMode.Points);

            drawSineWave(-5500, 5500, 0);

            //	Finishing drawing 
            GL.End();
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

        private void ChannelOne_BigDownButton_Click(object sender, EventArgs e)
        {
            double w = glControl1.Width;
            double h = glControl1.Height;
            double ar = w / h;
            Render(w, h, ar);
            glControl1.SwapBuffers();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayerMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                                                           
            this.Width = 1280;//Width  of the Windows_Form.
            this.Height = 720;//Height of the Windows_Form.                                              
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            int w = 1;//Width  Value of each Rectangle.
            int h = 1;//Heigth Value of each Rectangle.

            int x = 0;//Inicial Value of the X Coordinate.
            int y = 0;//Inicial Value of the Y Coordinate.

            int cols = 640;//Amount of Columns wanted.
            int rows = 360;//Amount of Rows    wanted.

            for (int i = 0; i < rows; i++)//Loop for the Rows.
            {
                x = 0;//initializes x value at 0.
                for (int j = 0; j < cols; j++)//Loop for the Columns.
                {
                    SolidBrush r  = new SolidBrush( Color.Red        );//Creates Brush "r"  with Color "Red".
                    SolidBrush g0 = new SolidBrush( Color.Green      );//Creates Brush "g0" with Color "Green".
                    SolidBrush g1 = new SolidBrush( Color.LightGreen );//Creates Brush "g1" with Color "LightGreen".
                    SolidBrush b  = new SolidBrush( Color.Blue       );//Creates Brush "b"  with Color "Blue".

                    Rectangle recR  = new Rectangle( x    , y    , w, h );//Draws Rectangle "cR"  in position "x =  0;  y =  0;" "Width = 60; Height = 60;" .
                    Rectangle recG0 = new Rectangle( x + w, y    , w, h );//Draws Rectangle "cG0" in position "x = 60;  y =  0;" "Width = 60; Height = 60;".
                    Rectangle recG1 = new Rectangle( x    , y + h, w, h );//Draws Rectangle "cG1" in position "x =  0;  y = 60;" "Width = 60; Height = 60;".
                    Rectangle recB  = new Rectangle( x + w, y + h, w, h );//Draws Rectangle "cR"  in position "x = 60;  y = 60;" "Width = 60; Height = 60;".

                    Region frR  = new Region( recR  );//Creates Fill Region "frR"  at Rect "recR"  Coordinates and Size.
                    Region frG0 = new Region( recG0 );//Creates Fill Region "frG0" at Rect "recG0" Coordinates and Size.
                    Region frG1 = new Region( recG1 );//Creates Fill Region "frG1" at Rect "recG1" Coordinates and Size.
                    Region frB  = new Region( recB  );//Creates Fill Region "frB"  at Rect "recB"  Coordinates and Size.

                    e.Graphics.FillRegion(  r,  frR );//Uses Graphics() to fill Region "frR"  with Color  "r".
                    e.Graphics.FillRegion( g0, frG0 );//Uses Graphics() to fill Region "frG0" with Color "g0".
                    e.Graphics.FillRegion( g1, frG1 );//Uses Graphics() to fill Region "frG1" with Color "g1".
                    e.Graphics.FillRegion(  b,  frB );//Uses Graphics() to fill Region "frB"  with Color  "b".

                    x += w * 2;//Multiplies by 2 the Width  needed for the drawing of the next Column.
                }
                y += h*2;//Multiplies by 2 the Height needed for the drawing of the next Row.
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drow
{
    public partial class Form1 : Form
    {
        private Color NeedColor;

        private Graphics g;

        private int selectedFigure;
        

        private List<AbstrFigure> allFigureOnPanel = new List<AbstrFigure>();
        public Form1()
        {
            InitializeComponent();
            g = panel.CreateGraphics();
            selectedFigure = -1;
            NeedColor = Color.DeepPink;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbCircle.Checked)
            {
                allFigureOnPanel.Add(new Circle(Int32.Parse(txBox.Text), 50, 50, NeedColor));
                allFigureOnPanel.Last().drow(g);
                return;

            }           
            if (rbRectangel.Checked)
            {
                allFigureOnPanel.Add(new Rectangle(Int32.Parse(txbWidth.Text), Int32.Parse(txbHeght.Text), 50, 50, NeedColor));
                allFigureOnPanel.Last().drow(g);
                return;
            }
            if (rbTriangle.Checked)
            {
                allFigureOnPanel.Add(new Triangle(Int32.Parse(txbEdge.Text), 50, 50, NeedColor));
                allFigureOnPanel.Last().drow(g);
                return;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColDialog = new ColorDialog();
            if (ColDialog.ShowDialog() == DialogResult.OK)
            {
                NeedColor = ColDialog.Color;
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            for(int i=allFigureOnPanel.Count-1; i >= 0; i--)
            {
                if (allFigureOnPanel[i].selected(e.X, e.Y))
                {
                    selectedFigure = i;
                    break;
                }
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {

            if (selectedFigure != -1 )
            {
                allFigureOnPanel[selectedFigure].clear(g, panel.BackColor);
                allFigureOnPanel[selectedFigure].changePosition(e.X, e.Y);         
                foreach(AbstrFigure fig in allFigureOnPanel) // чтобы одна фигура не закрашивала другую
                {
                    fig.drow(g);
                }
                /*for (int i = allFigureOnPanel.Count - 1; i >= 0; i--)
                {
                    allFigureOnPanel[i].drow(g);
                }*/
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            selectedFigure = -1;
        }
        

        private void helpKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void txBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpKeyPress(sender, e);
        }

        private void txbEdge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEdge_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpKeyPress(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpKeyPress(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpKeyPress(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(AbstrFigure fig in allFigureOnPanel)
            {
                fig.clear(g, panel.BackColor);
            }
            allFigureOnPanel.Clear(); // удаление фигур из списка
        }
    }
}

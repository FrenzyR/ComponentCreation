using System;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.Load += Form1_Load;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTextBox1.KeyPress += labelTextBox1_KeyPress;
        }

        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.labelTextBox1.TextTxt = "Letra: " + e.KeyChar;
        }
        static void Final(bool e)
        {
            Console.WriteLine(e ? "Position 1" : "Position 1");
        }
        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox.LabelTextBox.EPosicion.DERECHA)
            {
                labelTextBox1.Posicion = LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA;
            }
            else if(labelTextBox1.Posicion == LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA)
            {
                labelTextBox1.Posicion = LabelTextBox.LabelTextBox.EPosicion.DERECHA;

            }
            
            
            
        }

        private void onPositionChanged(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox.LabelTextBox.EPosicion.DERECHA)
            {
                this.Text = "DERECHA";
            }
            else if (labelTextBox1.Posicion == LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA)
            {
                this.Text = "IZQUIERDA";

            }
            
        }

        

        
        
    }
}

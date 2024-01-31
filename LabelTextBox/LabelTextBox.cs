using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabelTextBox.LabelTextBox;

namespace LabelTextBox
{
    [
    DefaultProperty("TextLbl"),
    DefaultEvent("Load")
    ]

    public partial class LabelTextBox: UserControl
    {
        public delegate void PositionChanger(bool e);
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        public enum EPosicion
        {
            IZQUIERDA, DERECHA
        }

        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    recolocar();
                    OnPosicionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }
        private int separacion = 0;
        [Category("Mis Propiedades")] 
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Mis Propiedades")] 
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        private void recolocar() { 
        
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    
                    txt.Location = new Point(lbl.Width + Separacion, 0);

                    txt.Width = this.Width - lbl.Width - Separacion;

                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;

                case EPosicion.DERECHA:                   
                    txt.Location = new Point(0, 0);
                    
                    txt.Width = this.Width - lbl.Width - Separacion;
                    
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

    }
}

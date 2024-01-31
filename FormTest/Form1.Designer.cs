namespace FormTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTextBox1 = new LabelTextBox.LabelTextBox();
            this.btnPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(231, 32);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(310, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(335, 137);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(75, 23);
            this.btnPosition.TabIndex = 1;
            this.btnPosition.Text = "Position button";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBox.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btnPosition;
    }
}


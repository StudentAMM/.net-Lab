namespace drow
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
            this.grBox = new System.Windows.Forms.GroupBox();
            this.txbEdge = new System.Windows.Forms.TextBox();
            this.lbEdge = new System.Windows.Forms.Label();
            this.lbRad = new System.Windows.Forms.Label();
            this.txBox = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbRectangel = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.lbWidth = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.txbHeght = new System.Windows.Forms.TextBox();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBox
            // 
            this.grBox.AutoSize = true;
            this.grBox.Controls.Add(this.txbHeght);
            this.grBox.Controls.Add(this.lbHeight);
            this.grBox.Controls.Add(this.txbWidth);
            this.grBox.Controls.Add(this.lbWidth);
            this.grBox.Controls.Add(this.txbEdge);
            this.grBox.Controls.Add(this.lbEdge);
            this.grBox.Controls.Add(this.lbRad);
            this.grBox.Controls.Add(this.txBox);
            this.grBox.Controls.Add(this.btnColor);
            this.grBox.Controls.Add(this.btnClear);
            this.grBox.Controls.Add(this.btnAdd);
            this.grBox.Controls.Add(this.rbRectangel);
            this.grBox.Controls.Add(this.rbTriangle);
            this.grBox.Controls.Add(this.rbCircle);
            this.grBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(87, 387);
            this.grBox.TabIndex = 0;
            this.grBox.TabStop = false;
            this.grBox.Text = "Figure";
            // 
            // txbEdge
            // 
            this.txbEdge.Location = new System.Drawing.Point(6, 117);
            this.txbEdge.Name = "txbEdge";
            this.txbEdge.Size = new System.Drawing.Size(75, 20);
            this.txbEdge.TabIndex = 9;
            this.txbEdge.Text = "30";
            this.txbEdge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEdge_KeyPress);
            // 
            // lbEdge
            // 
            this.lbEdge.AutoSize = true;
            this.lbEdge.Location = new System.Drawing.Point(3, 101);
            this.lbEdge.Name = "lbEdge";
            this.lbEdge.Size = new System.Drawing.Size(32, 13);
            this.lbEdge.TabIndex = 8;
            this.lbEdge.Text = "Edge";
            // 
            // lbRad
            // 
            this.lbRad.AutoSize = true;
            this.lbRad.Location = new System.Drawing.Point(3, 39);
            this.lbRad.Name = "lbRad";
            this.lbRad.Size = new System.Drawing.Size(40, 13);
            this.lbRad.TabIndex = 7;
            this.lbRad.Text = "Radius";
            // 
            // txBox
            // 
            this.txBox.Location = new System.Drawing.Point(6, 55);
            this.txBox.Name = "txBox";
            this.txBox.Size = new System.Drawing.Size(75, 20);
            this.txBox.TabIndex = 6;
            this.txBox.Text = "20";
            this.txBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBox_KeyPress);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(6, 277);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbRectangel
            // 
            this.rbRectangel.AutoSize = true;
            this.rbRectangel.Location = new System.Drawing.Point(6, 143);
            this.rbRectangel.Name = "rbRectangel";
            this.rbRectangel.Size = new System.Drawing.Size(74, 17);
            this.rbRectangel.TabIndex = 2;
            this.rbRectangel.Text = "Rectangel";
            this.rbRectangel.UseVisualStyleBackColor = true;
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(6, 81);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(63, 17);
            this.rbTriangle.TabIndex = 1;
            this.rbTriangle.Text = "Triangel";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Checked = true;
            this.rbCircle.Location = new System.Drawing.Point(6, 19);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(87, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 387);
            this.panel.TabIndex = 1;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(3, 163);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(35, 13);
            this.lbWidth.TabIndex = 10;
            this.lbWidth.Text = "Width";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(6, 181);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(75, 20);
            this.txbWidth.TabIndex = 11;
            this.txbWidth.Text = "30";
            this.txbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(6, 204);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(36, 13);
            this.lbHeight.TabIndex = 12;
            this.lbHeight.Text = "Heght";
            // 
            // txbHeght
            // 
            this.txbHeght.Location = new System.Drawing.Point(6, 220);
            this.txbHeght.Name = "txbHeght";
            this.txbHeght.Size = new System.Drawing.Size(75, 20);
            this.txbHeght.TabIndex = 13;
            this.txbHeght.Text = "15";
            this.txbHeght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(796, 387);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.grBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbRectangel;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lbRad;
        private System.Windows.Forms.TextBox txBox;
        private System.Windows.Forms.TextBox txbEdge;
        private System.Windows.Forms.Label lbEdge;
        private System.Windows.Forms.TextBox txbHeght;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label lbWidth;
    }
}


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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBox
            // 
            this.grBox.AutoSize = true;
            this.grBox.Controls.Add(this.btnRun);
            this.grBox.Controls.Add(this.btnClear);
            this.grBox.Controls.Add(this.btnAdd);
            this.grBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(87, 387);
            this.grBox.TabIndex = 0;
            this.grBox.TabStop = false;
            this.grBox.Text = "Figure";
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
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(6, 48);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 24);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Start Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnRun;
    }
}


namespace kwadratowafunkcja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.ukryty = new System.Windows.Forms.Label();
            this.Podaj = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.TextBox();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.Delta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(607, 289);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(27, 20);
            this.x2.TabIndex = 1;
            this.x2.Text = "x2:";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(607, 250);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(27, 20);
            this.x1.TabIndex = 2;
            this.x1.Text = "x1:";
            // 
            // ukryty
            // 
            this.ukryty.AutoSize = true;
            this.ukryty.Location = new System.Drawing.Point(83, 51);
            this.ukryty.Name = "ukryty";
            this.ukryty.Size = new System.Drawing.Size(0, 20);
            this.ukryty.TabIndex = 3;
            // 
            // Podaj
            // 
            this.Podaj.AutoSize = true;
            this.Podaj.Location = new System.Drawing.Point(287, 250);
            this.Podaj.Name = "Podaj";
            this.Podaj.Size = new System.Drawing.Size(95, 20);
            this.Podaj.TabIndex = 4;
            this.Podaj.Text = "Podaj A, B, C.";
            this.Podaj.Click += new System.EventHandler(this.label4_Click);
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(451, 366);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(125, 27);
            this.box3.TabIndex = 5;
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(83, 366);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(125, 27);
            this.box1.TabIndex = 6;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(272, 366);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(125, 27);
            this.box2.TabIndex = 7;
            // 
            // Delta
            // 
            this.Delta.AutoSize = true;
            this.Delta.Location = new System.Drawing.Point(526, 250);
            this.Delta.Name = "Delta";
            this.Delta.Size = new System.Drawing.Size(45, 20);
            this.Delta.TabIndex = 8;
            this.Delta.Text = "Delta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delta);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.Podaj);
            this.Controls.Add(this.ukryty);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label x2;
        private Label x1;
        private Label ukryty;
        private Label Podaj;
        private TextBox box3;
        private TextBox box1;
        private TextBox box2;
        private Label Delta;
    }
}
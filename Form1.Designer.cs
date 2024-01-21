namespace DinamicForm
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
            this.ItemTypeCb = new System.Windows.Forms.ComboBox();
            this.ItemTypeLbl = new System.Windows.Forms.Label();
            this.TextLbl = new System.Windows.Forms.Label();
            this.TextTxt = new System.Windows.Forms.TextBox();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.WidthNud = new System.Windows.Forms.NumericUpDown();
            this.HeigthNud = new System.Windows.Forms.NumericUpDown();
            this.HeigthLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.yPosNud = new System.Windows.Forms.NumericUpDown();
            this.yPosLbl = new System.Windows.Forms.Label();
            this.xPosNud = new System.Windows.Forms.NumericUpDown();
            this.xPosLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ScreenPnl = new System.Windows.Forms.Panel();
            this.ScreenLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeigthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosNud)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemTypeCb
            // 
            this.ItemTypeCb.FormattingEnabled = true;
            this.ItemTypeCb.Items.AddRange(new object[] {
            "Label",
            "Button",
            "TextBox"});
            this.ItemTypeCb.Location = new System.Drawing.Point(50, 98);
            this.ItemTypeCb.Name = "ItemTypeCb";
            this.ItemTypeCb.Size = new System.Drawing.Size(168, 24);
            this.ItemTypeCb.TabIndex = 0;
            // 
            // ItemTypeLbl
            // 
            this.ItemTypeLbl.AutoSize = true;
            this.ItemTypeLbl.Location = new System.Drawing.Point(47, 70);
            this.ItemTypeLbl.Name = "ItemTypeLbl";
            this.ItemTypeLbl.Size = new System.Drawing.Size(67, 16);
            this.ItemTypeLbl.TabIndex = 1;
            this.ItemTypeLbl.Text = "Item Type";
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(47, 146);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(33, 16);
            this.TextLbl.TabIndex = 2;
            this.TextLbl.Text = "Text";
            // 
            // TextTxt
            // 
            this.TextTxt.Location = new System.Drawing.Point(50, 175);
            this.TextTxt.Name = "TextTxt";
            this.TextTxt.Size = new System.Drawing.Size(100, 22);
            this.TextTxt.TabIndex = 3;
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(47, 295);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(41, 16);
            this.WidthLbl.TabIndex = 4;
            this.WidthLbl.Text = "Width";
            // 
            // WidthNud
            // 
            this.WidthNud.Location = new System.Drawing.Point(50, 325);
            this.WidthNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthNud.Name = "WidthNud";
            this.WidthNud.Size = new System.Drawing.Size(62, 22);
            this.WidthNud.TabIndex = 5;
            // 
            // HeigthNud
            // 
            this.HeigthNud.Location = new System.Drawing.Point(153, 325);
            this.HeigthNud.Name = "HeigthNud";
            this.HeigthNud.Size = new System.Drawing.Size(60, 22);
            this.HeigthNud.TabIndex = 7;
            // 
            // HeigthLbl
            // 
            this.HeigthLbl.AutoSize = true;
            this.HeigthLbl.Location = new System.Drawing.Point(150, 295);
            this.HeigthLbl.Name = "HeigthLbl";
            this.HeigthLbl.Size = new System.Drawing.Size(46, 16);
            this.HeigthLbl.TabIndex = 6;
            this.HeigthLbl.Text = "Heigth";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(50, 240);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 22);
            this.NameTxt.TabIndex = 9;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(47, 211);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name";
            // 
            // yPosNud
            // 
            this.yPosNud.Location = new System.Drawing.Point(153, 412);
            this.yPosNud.Name = "yPosNud";
            this.yPosNud.Size = new System.Drawing.Size(60, 22);
            this.yPosNud.TabIndex = 13;
            // 
            // yPosLbl
            // 
            this.yPosLbl.AutoSize = true;
            this.yPosLbl.Location = new System.Drawing.Point(150, 382);
            this.yPosLbl.Name = "yPosLbl";
            this.yPosLbl.Size = new System.Drawing.Size(43, 16);
            this.yPosLbl.TabIndex = 12;
            this.yPosLbl.Text = "Y Pos";
            // 
            // xPosNud
            // 
            this.xPosNud.Location = new System.Drawing.Point(50, 412);
            this.xPosNud.Name = "xPosNud";
            this.xPosNud.Size = new System.Drawing.Size(62, 22);
            this.xPosNud.TabIndex = 11;
            // 
            // xPosLbl
            // 
            this.xPosLbl.AutoSize = true;
            this.xPosLbl.Location = new System.Drawing.Point(47, 382);
            this.xPosLbl.Name = "xPosLbl";
            this.xPosLbl.Size = new System.Drawing.Size(42, 16);
            this.xPosLbl.TabIndex = 10;
            this.xPosLbl.Text = "X Pos";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(50, 460);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(168, 54);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ScreenPnl
            // 
            this.ScreenPnl.Location = new System.Drawing.Point(310, 70);
            this.ScreenPnl.Name = "ScreenPnl";
            this.ScreenPnl.Size = new System.Drawing.Size(442, 444);
            this.ScreenPnl.TabIndex = 15;
            // 
            // ScreenLbl
            // 
            this.ScreenLbl.AutoSize = true;
            this.ScreenLbl.Location = new System.Drawing.Point(307, 41);
            this.ScreenLbl.Name = "ScreenLbl";
            this.ScreenLbl.Size = new System.Drawing.Size(50, 16);
            this.ScreenLbl.TabIndex = 16;
            this.ScreenLbl.Text = "Screen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.ScreenLbl);
            this.Controls.Add(this.ScreenPnl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.yPosNud);
            this.Controls.Add(this.yPosLbl);
            this.Controls.Add(this.xPosNud);
            this.Controls.Add(this.xPosLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.HeigthNud);
            this.Controls.Add(this.HeigthLbl);
            this.Controls.Add(this.WidthNud);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.TextTxt);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.ItemTypeLbl);
            this.Controls.Add(this.ItemTypeCb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WidthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeigthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemTypeCb;
        private System.Windows.Forms.Label ItemTypeLbl;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.TextBox TextTxt;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.NumericUpDown WidthNud;
        private System.Windows.Forms.NumericUpDown HeigthNud;
        private System.Windows.Forms.Label HeigthLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.NumericUpDown yPosNud;
        private System.Windows.Forms.Label yPosLbl;
        private System.Windows.Forms.NumericUpDown xPosNud;
        private System.Windows.Forms.Label xPosLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel ScreenPnl;
        private System.Windows.Forms.Label ScreenLbl;
    }
}


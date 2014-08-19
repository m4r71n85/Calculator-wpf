namespace Calculator
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
            this.num1 = new controls.cBtn();
            this.num0 = new controls.cBtn();
            this.opEquals = new controls.cBtn();
            this.num2 = new controls.cBtn();
            this.num5 = new controls.cBtn();
            this.num4 = new controls.cBtn();
            this.num6 = new controls.cBtn();
            this.num3 = new controls.cBtn();
            this.num7 = new controls.cBtn();
            this.numDot = new controls.cBtn();
            this.num9 = new controls.cBtn();
            this.num8 = new controls.cBtn();
            this.opMultiply = new controls.cBtn();
            this.opDevide = new controls.cBtn();
            this.opSubstract = new controls.cBtn();
            this.opAdd = new controls.cBtn();
            this.opBackspace = new controls.cBtn();
            this.opC = new controls.cBtn();
            this.display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AlignCenter = false;
            this.num1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num1.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num1.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num1.Label = "1";
            this.num1.LabelColorDisabled = System.Drawing.Color.Black;
            this.num1.LabelColorDown = System.Drawing.Color.Black;
            this.num1.LabelColorUp = System.Drawing.Color.Black;
            this.num1.Location = new System.Drawing.Point(12, 110);
            this.num1.Name = "num1";
            this.num1.PaddingLeft = 5;
            this.num1.PaddingRight = 5;
            this.num1.TabIndex = 0;
            this.num1.Text = "cBtn1";
            this.num1.ToggleButton = false;
            this.num1.Click += new controls.cBtn.ClickEventHandler(this.num1_Click);
            // 
            // num0
            // 
            this.num0.AlignCenter = false;
            this.num0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num0.imgPicDown = global::Calculator.Properties.Resources.wide_active;
            this.num0.imgPicUp = global::Calculator.Properties.Resources.wide;
            this.num0.imgPicUpDisabled = global::Calculator.Properties.Resources.wide;
            this.num0.Label = "0";
            this.num0.LabelColorDisabled = System.Drawing.Color.Black;
            this.num0.LabelColorDown = System.Drawing.Color.Black;
            this.num0.LabelColorUp = System.Drawing.Color.Black;
            this.num0.Location = new System.Drawing.Point(12, 143);
            this.num0.Name = "num0";
            this.num0.PaddingLeft = 5;
            this.num0.PaddingRight = 5;
            this.num0.TabIndex = 1;
            this.num0.Text = "cBtn2";
            this.num0.ToggleButton = false;
            this.num0.Click += new controls.cBtn.ClickEventHandler(this.cBtn2_Click);
            // 
            // opEquals
            // 
            this.opEquals.AlignCenter = false;
            this.opEquals.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opEquals.imgPicDown = global::Calculator.Properties.Resources.tall_active;
            this.opEquals.imgPicUp = global::Calculator.Properties.Resources.tall;
            this.opEquals.imgPicUpDisabled = global::Calculator.Properties.Resources.tall;
            this.opEquals.Label = "=";
            this.opEquals.LabelColorDisabled = System.Drawing.Color.Black;
            this.opEquals.LabelColorDown = System.Drawing.Color.Black;
            this.opEquals.LabelColorUp = System.Drawing.Color.Black;
            this.opEquals.Location = new System.Drawing.Point(172, 111);
            this.opEquals.Name = "opEquals";
            this.opEquals.PaddingLeft = 5;
            this.opEquals.PaddingRight = 5;
            this.opEquals.TabIndex = 2;
            this.opEquals.Text = "cBtn3";
            this.opEquals.ToggleButton = false;
            this.opEquals.Click += new controls.cBtn.ClickEventHandler(this.opEquals_Click);
            // 
            // num2
            // 
            this.num2.AlignCenter = false;
            this.num2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num2.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num2.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num2.Label = "2";
            this.num2.LabelColorDisabled = System.Drawing.Color.Black;
            this.num2.LabelColorDown = System.Drawing.Color.Black;
            this.num2.LabelColorUp = System.Drawing.Color.Black;
            this.num2.Location = new System.Drawing.Point(52, 110);
            this.num2.Name = "num2";
            this.num2.PaddingLeft = 5;
            this.num2.PaddingRight = 5;
            this.num2.TabIndex = 3;
            this.num2.Text = "cBtn4";
            this.num2.ToggleButton = false;
            this.num2.Click += new controls.cBtn.ClickEventHandler(this.num2_Click);
            // 
            // num5
            // 
            this.num5.AlignCenter = false;
            this.num5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num5.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num5.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num5.Label = "5";
            this.num5.LabelColorDisabled = System.Drawing.Color.Black;
            this.num5.LabelColorDown = System.Drawing.Color.Black;
            this.num5.LabelColorUp = System.Drawing.Color.Black;
            this.num5.Location = new System.Drawing.Point(52, 77);
            this.num5.Name = "num5";
            this.num5.PaddingLeft = 5;
            this.num5.PaddingRight = 5;
            this.num5.TabIndex = 5;
            this.num5.Text = "cBtn5";
            this.num5.ToggleButton = false;
            this.num5.Click += new controls.cBtn.ClickEventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.AlignCenter = false;
            this.num4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num4.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num4.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num4.Label = "4";
            this.num4.LabelColorDisabled = System.Drawing.Color.Black;
            this.num4.LabelColorDown = System.Drawing.Color.Black;
            this.num4.LabelColorUp = System.Drawing.Color.Black;
            this.num4.Location = new System.Drawing.Point(12, 77);
            this.num4.Name = "num4";
            this.num4.PaddingLeft = 5;
            this.num4.PaddingRight = 5;
            this.num4.TabIndex = 4;
            this.num4.Text = "cBtn6";
            this.num4.ToggleButton = false;
            this.num4.Click += new controls.cBtn.ClickEventHandler(this.num4_Click);
            // 
            // num6
            // 
            this.num6.AlignCenter = false;
            this.num6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num6.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num6.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num6.Label = "6";
            this.num6.LabelColorDisabled = System.Drawing.Color.Black;
            this.num6.LabelColorDown = System.Drawing.Color.Black;
            this.num6.LabelColorUp = System.Drawing.Color.Black;
            this.num6.Location = new System.Drawing.Point(92, 77);
            this.num6.Name = "num6";
            this.num6.PaddingLeft = 5;
            this.num6.PaddingRight = 5;
            this.num6.TabIndex = 7;
            this.num6.Text = "cBtn7";
            this.num6.ToggleButton = false;
            this.num6.Click += new controls.cBtn.ClickEventHandler(this.num6_Click);
            // 
            // num3
            // 
            this.num3.AlignCenter = false;
            this.num3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num3.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num3.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num3.Label = "3";
            this.num3.LabelColorDisabled = System.Drawing.Color.Black;
            this.num3.LabelColorDown = System.Drawing.Color.Black;
            this.num3.LabelColorUp = System.Drawing.Color.Black;
            this.num3.Location = new System.Drawing.Point(92, 110);
            this.num3.Name = "num3";
            this.num3.PaddingLeft = 5;
            this.num3.PaddingRight = 5;
            this.num3.TabIndex = 6;
            this.num3.Text = "cBtn8";
            this.num3.ToggleButton = false;
            this.num3.Click += new controls.cBtn.ClickEventHandler(this.num3_Click);
            // 
            // num7
            // 
            this.num7.AlignCenter = false;
            this.num7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num7.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num7.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num7.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num7.Label = "7";
            this.num7.LabelColorDisabled = System.Drawing.Color.Black;
            this.num7.LabelColorDown = System.Drawing.Color.Black;
            this.num7.LabelColorUp = System.Drawing.Color.Black;
            this.num7.Location = new System.Drawing.Point(12, 44);
            this.num7.Name = "num7";
            this.num7.PaddingLeft = 5;
            this.num7.PaddingRight = 5;
            this.num7.TabIndex = 9;
            this.num7.Text = "cBtn9";
            this.num7.ToggleButton = false;
            this.num7.Click += new controls.cBtn.ClickEventHandler(this.num7_Click);
            // 
            // numDot
            // 
            this.numDot.AlignCenter = false;
            this.numDot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDot.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.numDot.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.numDot.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.numDot.Label = ".";
            this.numDot.LabelColorDisabled = System.Drawing.Color.Black;
            this.numDot.LabelColorDown = System.Drawing.Color.Black;
            this.numDot.LabelColorUp = System.Drawing.Color.Black;
            this.numDot.Location = new System.Drawing.Point(92, 143);
            this.numDot.Name = "numDot";
            this.numDot.PaddingLeft = 5;
            this.numDot.PaddingRight = 5;
            this.numDot.TabIndex = 8;
            this.numDot.Text = "cBtn10";
            this.numDot.ToggleButton = false;
            this.numDot.Click += new controls.cBtn.ClickEventHandler(this.numDot_Click);
            // 
            // num9
            // 
            this.num9.AlignCenter = false;
            this.num9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num9.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num9.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num9.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num9.Label = "9";
            this.num9.LabelColorDisabled = System.Drawing.Color.Black;
            this.num9.LabelColorDown = System.Drawing.Color.Black;
            this.num9.LabelColorUp = System.Drawing.Color.Black;
            this.num9.Location = new System.Drawing.Point(92, 44);
            this.num9.Name = "num9";
            this.num9.PaddingLeft = 5;
            this.num9.PaddingRight = 5;
            this.num9.TabIndex = 11;
            this.num9.Text = "cBtn11";
            this.num9.ToggleButton = false;
            this.num9.Click += new controls.cBtn.ClickEventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.AlignCenter = false;
            this.num8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.num8.imgPicUp = global::Calculator.Properties.Resources.normal;
            this.num8.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.num8.Label = "8";
            this.num8.LabelColorDisabled = System.Drawing.Color.Black;
            this.num8.LabelColorDown = System.Drawing.Color.Black;
            this.num8.LabelColorUp = System.Drawing.Color.Black;
            this.num8.Location = new System.Drawing.Point(52, 44);
            this.num8.Name = "num8";
            this.num8.PaddingLeft = 5;
            this.num8.PaddingRight = 5;
            this.num8.TabIndex = 10;
            this.num8.Text = "cBtn12";
            this.num8.ToggleButton = false;
            this.num8.Click += new controls.cBtn.ClickEventHandler(this.num8_Click);
            // 
            // opMultiply
            // 
            this.opMultiply.AlignCenter = false;
            this.opMultiply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opMultiply.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.opMultiply.imgPicUp = global::Calculator.Properties.Resources.operations;
            this.opMultiply.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.opMultiply.Label = "*";
            this.opMultiply.LabelColorDisabled = System.Drawing.Color.Black;
            this.opMultiply.LabelColorDown = System.Drawing.Color.Black;
            this.opMultiply.LabelColorUp = System.Drawing.Color.Black;
            this.opMultiply.Location = new System.Drawing.Point(132, 77);
            this.opMultiply.Name = "opMultiply";
            this.opMultiply.PaddingLeft = 5;
            this.opMultiply.PaddingRight = 5;
            this.opMultiply.TabIndex = 12;
            this.opMultiply.Text = "cBtn13";
            this.opMultiply.ToggleButton = false;
            this.opMultiply.Click += new controls.cBtn.ClickEventHandler(this.opMultiply_Click);
            // 
            // opDevide
            // 
            this.opDevide.AlignCenter = false;
            this.opDevide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opDevide.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.opDevide.imgPicUp = global::Calculator.Properties.Resources.operations;
            this.opDevide.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.opDevide.Label = "/";
            this.opDevide.LabelColorDisabled = System.Drawing.Color.Black;
            this.opDevide.LabelColorDown = System.Drawing.Color.Black;
            this.opDevide.LabelColorUp = System.Drawing.Color.Black;
            this.opDevide.Location = new System.Drawing.Point(132, 44);
            this.opDevide.Name = "opDevide";
            this.opDevide.PaddingLeft = 5;
            this.opDevide.PaddingRight = 5;
            this.opDevide.TabIndex = 13;
            this.opDevide.Text = "cBtn14";
            this.opDevide.ToggleButton = false;
            this.opDevide.Click += new controls.cBtn.ClickEventHandler(this.opDevide_Click);
            // 
            // opSubstract
            // 
            this.opSubstract.AlignCenter = false;
            this.opSubstract.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opSubstract.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.opSubstract.imgPicUp = global::Calculator.Properties.Resources.operations;
            this.opSubstract.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.opSubstract.Label = "-";
            this.opSubstract.LabelColorDisabled = System.Drawing.Color.Black;
            this.opSubstract.LabelColorDown = System.Drawing.Color.Black;
            this.opSubstract.LabelColorUp = System.Drawing.Color.Black;
            this.opSubstract.Location = new System.Drawing.Point(132, 111);
            this.opSubstract.Name = "opSubstract";
            this.opSubstract.PaddingLeft = 5;
            this.opSubstract.PaddingRight = 5;
            this.opSubstract.TabIndex = 14;
            this.opSubstract.Text = "cBtn15";
            this.opSubstract.ToggleButton = false;
            this.opSubstract.Click += new controls.cBtn.ClickEventHandler(this.opSubstract_Click);
            // 
            // opAdd
            // 
            this.opAdd.AlignCenter = false;
            this.opAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opAdd.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.opAdd.imgPicUp = global::Calculator.Properties.Resources.operations;
            this.opAdd.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.opAdd.Label = "+";
            this.opAdd.LabelColorDisabled = System.Drawing.Color.Black;
            this.opAdd.LabelColorDown = System.Drawing.Color.Black;
            this.opAdd.LabelColorUp = System.Drawing.Color.Black;
            this.opAdd.Location = new System.Drawing.Point(132, 143);
            this.opAdd.Name = "opAdd";
            this.opAdd.PaddingLeft = 5;
            this.opAdd.PaddingRight = 5;
            this.opAdd.TabIndex = 15;
            this.opAdd.Text = "cBtn16";
            this.opAdd.ToggleButton = false;
            this.opAdd.Click += new controls.cBtn.ClickEventHandler(this.opAdd_Click);
            // 
            // opBackspace
            // 
            this.opBackspace.AlignCenter = false;
            this.opBackspace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opBackspace.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.opBackspace.imgPicUp = global::Calculator.Properties.Resources.operations;
            this.opBackspace.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.opBackspace.Label = "<";
            this.opBackspace.LabelColorDisabled = System.Drawing.Color.Black;
            this.opBackspace.LabelColorDown = System.Drawing.Color.Black;
            this.opBackspace.LabelColorUp = System.Drawing.Color.Black;
            this.opBackspace.Location = new System.Drawing.Point(172, 44);
            this.opBackspace.Name = "opBackspace";
            this.opBackspace.PaddingLeft = 5;
            this.opBackspace.PaddingRight = 5;
            this.opBackspace.TabIndex = 16;
            this.opBackspace.Text = "cBtn17";
            this.opBackspace.ToggleButton = false;
            this.opBackspace.Click += new controls.cBtn.ClickEventHandler(this.opBackspace_Click);
            // 
            // opC
            // 
            this.opC.AlignCenter = false;
            this.opC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opC.imgPicDown = global::Calculator.Properties.Resources.normal_active;
            this.opC.imgPicUp = global::Calculator.Properties.Resources.operations;
            this.opC.imgPicUpDisabled = global::Calculator.Properties.Resources.normal;
            this.opC.Label = "C";
            this.opC.LabelColorDisabled = System.Drawing.Color.Black;
            this.opC.LabelColorDown = System.Drawing.Color.Black;
            this.opC.LabelColorUp = System.Drawing.Color.Black;
            this.opC.Location = new System.Drawing.Point(172, 77);
            this.opC.Name = "opC";
            this.opC.PaddingLeft = 5;
            this.opC.PaddingRight = 5;
            this.opC.TabIndex = 17;
            this.opC.Text = "cBtn18";
            this.opC.ToggleButton = false;
            this.opC.Click += new controls.cBtn.ClickEventHandler(this.opC_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(13, 12);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(189, 26);
            this.display.TabIndex = 18;
            this.display.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 174);
            this.Controls.Add(this.display);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.opEquals);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.numDot);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.opMultiply);
            this.Controls.Add(this.opDevide);
            this.Controls.Add(this.opSubstract);
            this.Controls.Add(this.opAdd);
            this.Controls.Add(this.opBackspace);
            this.Controls.Add(this.opC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.cBtn num1;
        private controls.cBtn num0;
        private controls.cBtn opEquals;
        private controls.cBtn num2;
        private controls.cBtn num5;
        private controls.cBtn num4;
        private controls.cBtn num6;
        private controls.cBtn num3;
        private controls.cBtn num7;
        private controls.cBtn numDot;
        private controls.cBtn num9;
        private controls.cBtn num8;
        private controls.cBtn opMultiply;
        private controls.cBtn opDevide;
        private controls.cBtn opSubstract;
        private controls.cBtn opAdd;
        private controls.cBtn opBackspace;
        private controls.cBtn opC;
        private System.Windows.Forms.TextBox display;
    }


}


namespace SíkidomForm
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
            pictureBox1 = new PictureBox();
            labelA = new Label();
            labelB = new Label();
            label2 = new Label();
            labelC = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            resultBox = new GroupBox();
            labelErr = new Label();
            labelT = new Label();
            labelK = new Label();
            labelCValue = new Label();
            textBoxC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            resultBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.haromszog2_1024x830;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(23, 296);
            labelA.Name = "labelA";
            labelA.Size = new Size(31, 20);
            labelA.TabIndex = 1;
            labelA.Text = "a =";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(23, 333);
            labelB.Name = "labelB";
            labelB.Size = new Size(32, 20);
            labelB.TabIndex = 2;
            labelB.Text = "b =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 236);
            label2.Name = "label2";
            label2.Size = new Size(305, 40);
            label2.TabIndex = 3;
            label2.Text = "Adja meg a háromszög oldalait ami alapján \r\na program kiszámolja a területét, kerületét!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(23, 369);
            labelC.Name = "labelC";
            labelC.Size = new Size(30, 20);
            labelC.TabIndex = 4;
            labelC.Text = "c =";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(72, 289);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(247, 27);
            textBoxA.TabIndex = 5;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(72, 326);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(247, 27);
            textBoxB.TabIndex = 6;
            textBoxB.TextChanged += textBoxB_TextChanged;
            // 
            // resultBox
            // 
            resultBox.Controls.Add(labelErr);
            resultBox.Controls.Add(labelT);
            resultBox.Controls.Add(labelK);
            resultBox.Location = new Point(31, 424);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(292, 138);
            resultBox.TabIndex = 8;
            resultBox.TabStop = false;
            resultBox.Text = "Eredmény";
            // 
            // labelErr
            // 
            labelErr.AutoSize = true;
            labelErr.Location = new Point(6, 115);
            labelErr.Name = "labelErr";
            labelErr.Size = new Size(0, 20);
            labelErr.TabIndex = 2;
            // 
            // labelT
            // 
            labelT.AutoSize = true;
            labelT.Location = new Point(14, 69);
            labelT.Name = "labelT";
            labelT.Size = new Size(28, 20);
            labelT.TabIndex = 1;
            labelT.Text = "t =";
            // 
            // labelK
            // 
            labelK.AutoSize = true;
            labelK.Location = new Point(14, 36);
            labelK.Name = "labelK";
            labelK.Size = new Size(30, 20);
            labelK.TabIndex = 0;
            labelK.Text = "k =";
            // 
            // labelCValue
            // 
            labelCValue.AutoSize = true;
            labelCValue.Location = new Point(75, 369);
            labelCValue.Name = "labelCValue";
            labelCValue.Size = new Size(0, 20);
            labelCValue.TabIndex = 9;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(72, 366);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(247, 27);
            textBoxC.TabIndex = 10;
            textBoxC.TextChanged += textBoxC_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(348, 574);
            Controls.Add(textBoxC);
            Controls.Add(labelCValue);
            Controls.Add(resultBox);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(labelC);
            Controls.Add(label2);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Háromszög területe, kerülete";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            resultBox.ResumeLayout(false);
            resultBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelA;
        private Label labelB;
        private Label label2;
        private Label labelC;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private GroupBox resultBox;
        private Label labelErr;
        private Label labelT;
        private Label labelK;
        private Label labelCValue;
        private TextBox textBoxC;
    }
}

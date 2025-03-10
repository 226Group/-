namespace Переходы_между_формами
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOdd = new System.Windows.Forms.RadioButton();
            this.radioButtonEven = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.listBoxNumbers = new System.Windows.Forms.ListView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов массива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cумма элементов равна:";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(254, 329);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(155, 20);
            this.labelResult.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Controls.Add(this.radioButtonOdd);
            this.groupBox1.Controls.Add(this.radioButtonEven);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(576, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вариант суммы:";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAll.Location = new System.Drawing.Point(7, 66);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(106, 17);
            this.radioButtonAll.TabIndex = 2;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Все значения";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonOdd
            // 
            this.radioButtonOdd.AutoSize = true;
            this.radioButtonOdd.ForeColor = System.Drawing.Color.Black;
            this.radioButtonOdd.Location = new System.Drawing.Point(7, 43);
            this.radioButtonOdd.Name = "radioButtonOdd";
            this.radioButtonOdd.Size = new System.Drawing.Size(83, 17);
            this.radioButtonOdd.TabIndex = 1;
            this.radioButtonOdd.TabStop = true;
            this.radioButtonOdd.Text = "Нечетные";
            this.radioButtonOdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonEven
            // 
            this.radioButtonEven.AutoSize = true;
            this.radioButtonEven.ForeColor = System.Drawing.Color.Black;
            this.radioButtonEven.Location = new System.Drawing.Point(7, 20);
            this.radioButtonEven.Name = "radioButtonEven";
            this.radioButtonEven.Size = new System.Drawing.Size(70, 17);
            this.radioButtonEven.TabIndex = 0;
            this.radioButtonEven.TabStop = true;
            this.radioButtonEven.Text = "Четные";
            this.radioButtonEven.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.HideSelection = false;
            this.listBoxNumbers.Location = new System.Drawing.Point(15, 98);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(243, 211);
            this.listBoxNumbers.TabIndex = 11;
            this.listBoxNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNumbers);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonOdd;
        private System.Windows.Forms.RadioButton radioButtonEven;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ListView listBoxNumbers;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
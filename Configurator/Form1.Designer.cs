namespace Configurator
{
    partial class Configurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurator));
            this.IdSlot = new System.Windows.Forms.NumericUpDown();
            this.XSlot = new System.Windows.Forms.NumericUpDown();
            this.YSlot = new System.Windows.Forms.NumericUpDown();
            this.ZSlot = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ComSlot = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.readValues = new System.Windows.Forms.Label();
            this.radioX = new System.Windows.Forms.RadioButton();
            this.radioY = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdSlot
            // 
            this.IdSlot.Location = new System.Drawing.Point(62, 22);
            this.IdSlot.Name = "IdSlot";
            this.IdSlot.Size = new System.Drawing.Size(120, 20);
            this.IdSlot.TabIndex = 3;
            // 
            // XSlot
            // 
            this.XSlot.Location = new System.Drawing.Point(62, 49);
            this.XSlot.Name = "XSlot";
            this.XSlot.Size = new System.Drawing.Size(120, 20);
            this.XSlot.TabIndex = 4;
            // 
            // YSlot
            // 
            this.YSlot.Location = new System.Drawing.Point(62, 76);
            this.YSlot.Name = "YSlot";
            this.YSlot.Size = new System.Drawing.Size(120, 20);
            this.YSlot.TabIndex = 5;
            // 
            // ZSlot
            // 
            this.ZSlot.Location = new System.Drawing.Point(62, 103);
            this.ZSlot.Name = "ZSlot";
            this.ZSlot.Size = new System.Drawing.Size(120, 20);
            this.ZSlot.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(93, 173);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComSlot
            // 
            this.ComSlot.FormattingEnabled = true;
            this.ComSlot.Location = new System.Drawing.Point(323, 175);
            this.ComSlot.Name = "ComSlot";
            this.ComSlot.Size = new System.Drawing.Size(147, 21);
            this.ComSlot.TabIndex = 13;
            this.ComSlot.SelectedIndexChanged += new System.EventHandler(this.ComSlot_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Via";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(59, 137);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 15;
            this.DateLabel.Text = "Date";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(174, 173);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // readValues
            // 
            this.readValues.AutoSize = true;
            this.readValues.Location = new System.Drawing.Point(337, 27);
            this.readValues.Name = "readValues";
            this.readValues.Size = new System.Drawing.Size(0, 13);
            this.readValues.TabIndex = 17;
            // 
            // radioX
            // 
            this.radioX.AutoSize = true;
            this.radioX.Location = new System.Drawing.Point(195, 81);
            this.radioX.Name = "radioX";
            this.radioX.Size = new System.Drawing.Size(82, 17);
            this.radioX.TabIndex = 18;
            this.radioX.TabStop = true;
            this.radioX.Text = "Increment X";
            this.radioX.UseVisualStyleBackColor = true;
            // 
            // radioY
            // 
            this.radioY.AutoSize = true;
            this.radioY.Location = new System.Drawing.Point(195, 105);
            this.radioY.Name = "radioY";
            this.radioY.Size = new System.Drawing.Size(82, 17);
            this.radioY.TabIndex = 19;
            this.radioY.TabStop = true;
            this.radioY.Text = "Increment Y";
            this.radioY.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 125);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 212);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioY);
            this.Controls.Add(this.radioX);
            this.Controls.Add(this.readValues);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComSlot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZSlot);
            this.Controls.Add(this.YSlot);
            this.Controls.Add(this.XSlot);
            this.Controls.Add(this.IdSlot);
            this.Name = "Configurator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurator";
            this.Load += new System.EventHandler(this.Configurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdSlot;
        private System.Windows.Forms.NumericUpDown XSlot;
        private System.Windows.Forms.NumericUpDown YSlot;
        private System.Windows.Forms.NumericUpDown ZSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox ComSlot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label readValues;
        private System.Windows.Forms.RadioButton radioX;
        private System.Windows.Forms.RadioButton radioY;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


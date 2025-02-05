namespace SwpTrmIfDemo
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
            this.characterHeights = new System.Windows.Forms.ComboBox();
            this.characterWidths = new System.Windows.Forms.ComboBox();
            this.alignments = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.colors = new System.Windows.Forms.ComboBox();
            this.startRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // characterHeights
            // 
            this.characterHeights.FormattingEnabled = true;
            this.characterHeights.Location = new System.Drawing.Point(12, 23);
            this.characterHeights.Name = "characterHeights";
            this.characterHeights.Size = new System.Drawing.Size(121, 21);
            this.characterHeights.TabIndex = 1;
            this.characterHeights.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // characterWidths
            // 
            this.characterWidths.FormattingEnabled = true;
            this.characterWidths.Location = new System.Drawing.Point(139, 23);
            this.characterWidths.Name = "characterWidths";
            this.characterWidths.Size = new System.Drawing.Size(121, 21);
            this.characterWidths.TabIndex = 2;
            // 
            // alignments
            // 
            this.alignments.FormattingEnabled = true;
            this.alignments.Location = new System.Drawing.Point(266, 23);
            this.alignments.Name = "alignments";
            this.alignments.Size = new System.Drawing.Size(121, 21);
            this.alignments.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(672, 349);
            this.textBox2.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 90);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // colors
            // 
            this.colors.FormattingEnabled = true;
            this.colors.Location = new System.Drawing.Point(393, 23);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(121, 21);
            this.colors.TabIndex = 4;
            // 
            // startRow
            // 
            this.startRow.Location = new System.Drawing.Point(520, 23);
            this.startRow.MaxLength = 3;
            this.startRow.Name = "startRow";
            this.startRow.Size = new System.Drawing.Size(100, 20);
            this.startRow.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "StartRow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "The text";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 21);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startRow);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.alignments);
            this.Controls.Add(this.characterWidths);
            this.Controls.Add(this.characterHeights);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox characterHeights;
        private System.Windows.Forms.ComboBox characterWidths;
        private System.Windows.Forms.ComboBox alignments;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox colors;
        private System.Windows.Forms.TextBox startRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}
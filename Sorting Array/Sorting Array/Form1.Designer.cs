namespace Sorting_Array
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
            this.rtbRawArray = new System.Windows.Forms.RichTextBox();
            this.rtbSortedArray = new System.Windows.Forms.RichTextBox();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnSortTheArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numTheArrayLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTheArrayLength)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbRawArray
            // 
            this.rtbRawArray.Location = new System.Drawing.Point(12, 12);
            this.rtbRawArray.Name = "rtbRawArray";
            this.rtbRawArray.Size = new System.Drawing.Size(776, 185);
            this.rtbRawArray.TabIndex = 0;
            this.rtbRawArray.Text = "";
            // 
            // rtbSortedArray
            // 
            this.rtbSortedArray.Location = new System.Drawing.Point(12, 222);
            this.rtbSortedArray.Name = "rtbSortedArray";
            this.rtbSortedArray.Size = new System.Drawing.Size(776, 185);
            this.rtbSortedArray.TabIndex = 1;
            this.rtbSortedArray.Text = "";
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(12, 415);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(75, 23);
            this.btnCreateArray.TabIndex = 2;
            this.btnCreateArray.Text = "Create Array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnSortTheArray
            // 
            this.btnSortTheArray.Location = new System.Drawing.Point(704, 415);
            this.btnSortTheArray.Name = "btnSortTheArray";
            this.btnSortTheArray.Size = new System.Drawing.Size(84, 23);
            this.btnSortTheArray.TabIndex = 3;
            this.btnSortTheArray.Text = "Sort theArray";
            this.btnSortTheArray.UseVisualStyleBackColor = true;
            this.btnSortTheArray.Click += new System.EventHandler(this.btnSortTheArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "of length";
            // 
            // numTheArrayLength
            // 
            this.numTheArrayLength.Location = new System.Drawing.Point(143, 416);
            this.numTheArrayLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTheArrayLength.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTheArrayLength.Name = "numTheArrayLength";
            this.numTheArrayLength.Size = new System.Drawing.Size(47, 20);
            this.numTheArrayLength.TabIndex = 5;
            this.numTheArrayLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTheArrayLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortTheArray);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.rtbSortedArray);
            this.Controls.Add(this.rtbRawArray);
            this.Name = "Form1";
            this.Text = "Sorting Array";
            ((System.ComponentModel.ISupportInitialize)(this.numTheArrayLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRawArray;
        private System.Windows.Forms.RichTextBox rtbSortedArray;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnSortTheArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTheArrayLength;
    }
}


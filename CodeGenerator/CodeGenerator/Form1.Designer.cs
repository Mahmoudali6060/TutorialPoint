namespace CodeGenerator
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
            this.txtOriginalText = new System.Windows.Forms.TextBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOriginalText = new System.Windows.Forms.Label();
            this.lblConvertedText = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.btnConvertToFrontend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.Location = new System.Drawing.Point(22, 94);
            this.txtOriginalText.Multiline = true;
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.Size = new System.Drawing.Size(710, 334);
            this.txtOriginalText.TabIndex = 0;
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(907, 94);
            this.txtConverted.Multiline = true;
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(710, 334);
            this.txtConverted.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(343, 32);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(84, 29);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOriginalText
            // 
            this.lblOriginalText.AutoSize = true;
            this.lblOriginalText.Location = new System.Drawing.Point(267, 431);
            this.lblOriginalText.Name = "lblOriginalText";
            this.lblOriginalText.Size = new System.Drawing.Size(93, 20);
            this.lblOriginalText.TabIndex = 2;
            this.lblOriginalText.Text = "Original Text";
            // 
            // lblConvertedText
            // 
            this.lblConvertedText.AutoSize = true;
            this.lblConvertedText.Location = new System.Drawing.Point(1224, 431);
            this.lblConvertedText.Name = "lblConvertedText";
            this.lblConvertedText.Size = new System.Drawing.Size(108, 20);
            this.lblConvertedText.TabIndex = 2;
            this.lblConvertedText.Text = "Converted Text";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(243, 32);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(94, 27);
            this.txtDelimiter.TabIndex = 3;
            // 
            // btnConvertToFrontend
            // 
            this.btnConvertToFrontend.Location = new System.Drawing.Point(456, 31);
            this.btnConvertToFrontend.Name = "btnConvertToFrontend";
            this.btnConvertToFrontend.Size = new System.Drawing.Size(276, 29);
            this.btnConvertToFrontend.TabIndex = 1;
            this.btnConvertToFrontend.Text = "Convert Entities to Front end";
            this.btnConvertToFrontend.UseVisualStyleBackColor = true;
            this.btnConvertToFrontend.Click += new System.EventHandler(this.btnConvertToFrontend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 714);
            this.Controls.Add(this.btnConvertToFrontend);
            this.Controls.Add(this.txtDelimiter);
            this.Controls.Add(this.lblConvertedText);
            this.Controls.Add(this.lblOriginalText);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtOriginalText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginalText;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOriginalText;
        private System.Windows.Forms.Label lblConvertedText;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.Button btnConvertToFrontend;
    }
}


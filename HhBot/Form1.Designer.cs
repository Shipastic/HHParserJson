namespace HhBot
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
            this.textRes = new System.Windows.Forms.TextBox();
            this.butTest = new System.Windows.Forms.Button();
            this.butParse = new System.Windows.Forms.Button();
            this.textParse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textRes
            // 
            this.textRes.Location = new System.Drawing.Point(27, 21);
            this.textRes.Multiline = true;
            this.textRes.Name = "textRes";
            this.textRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRes.Size = new System.Drawing.Size(394, 317);
            this.textRes.TabIndex = 0;
            // 
            // butTest
            // 
            this.butTest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTest.Location = new System.Drawing.Point(27, 357);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(173, 67);
            this.butTest.TabIndex = 1;
            this.butTest.Text = "TEST";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.ButTest_Click);
            // 
            // butParse
            // 
            this.butParse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butParse.Location = new System.Drawing.Point(688, 357);
            this.butParse.Name = "butParse";
            this.butParse.Size = new System.Drawing.Size(173, 67);
            this.butParse.TabIndex = 2;
            this.butParse.Text = "PARSING";
            this.butParse.UseVisualStyleBackColor = true;
            this.butParse.Click += new System.EventHandler(this.ButParse_Click);
            // 
            // textParse
            // 
            this.textParse.Location = new System.Drawing.Point(467, 21);
            this.textParse.Multiline = true;
            this.textParse.Name = "textParse";
            this.textParse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textParse.Size = new System.Drawing.Size(394, 317);
            this.textParse.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.textParse);
            this.Controls.Add(this.butParse);
            this.Controls.Add(this.butTest);
            this.Controls.Add(this.textRes);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HH API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRes;
        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.Button butParse;
        private System.Windows.Forms.TextBox textParse;
    }
}


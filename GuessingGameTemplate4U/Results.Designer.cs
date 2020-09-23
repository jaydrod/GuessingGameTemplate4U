namespace GuessingGameTemplate4U
{
    partial class Results
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.resultslable = new System.Windows.Forms.Label();
            this.results2lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // resultslable
            // 
            this.resultslable.AutoSize = true;
            this.resultslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultslable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultslable.Location = new System.Drawing.Point(59, 0);
            this.resultslable.Name = "resultslable";
            this.resultslable.Size = new System.Drawing.Size(90, 25);
            this.resultslable.TabIndex = 1;
            this.resultslable.Text = "Results!";
            // 
            // results2lable
            // 
            this.results2lable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.results2lable.Location = new System.Drawing.Point(4, 39);
            this.results2lable.Name = "results2lable";
            this.results2lable.Size = new System.Drawing.Size(216, 185);
            this.results2lable.TabIndex = 2;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.results2lable);
            this.Controls.Add(this.resultslable);
            this.Controls.Add(this.label1);
            this.Name = "Results";
            this.Size = new System.Drawing.Size(223, 224);
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultslable;
        private System.Windows.Forms.Label results2lable;
    }
}

namespace Rosalind {
    sealed partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(569, 523);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 523);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
    }
}


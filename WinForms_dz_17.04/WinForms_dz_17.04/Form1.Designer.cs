namespace WinForms_dz_17._04
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
            this.btnZagadatTschislo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZagadatTschislo
            // 
            this.btnZagadatTschislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZagadatTschislo.Location = new System.Drawing.Point(115, 113);
            this.btnZagadatTschislo.Name = "btnZagadatTschislo";
            this.btnZagadatTschislo.Size = new System.Drawing.Size(175, 41);
            this.btnZagadatTschislo.TabIndex = 0;
            this.btnZagadatTschislo.Text = "Загадать число";
            this.btnZagadatTschislo.UseVisualStyleBackColor = true;
            this.btnZagadatTschislo.Click += new System.EventHandler(this.btnZagadatTschislo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 276);
            this.Controls.Add(this.btnZagadatTschislo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZagadatTschislo;
    }
}


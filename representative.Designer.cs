namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    partial class RepresentativeForm
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
            this.dt2 = new System.Windows.Forms.DataGridView();
            this.label41 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dt2
            // 
            this.dt2.BackgroundColor = System.Drawing.Color.White;
            this.dt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt2.Location = new System.Drawing.Point(35, 112);
            this.dt2.Name = "dt2";
            this.dt2.ReadOnly = true;
            this.dt2.Size = new System.Drawing.Size(1008, 422);
            this.dt2.TabIndex = 217;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.DarkGreen;
            this.label41.Location = new System.Drawing.Point(417, 21);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(210, 32);
            this.label41.TabIndex = 219;
            this.label41.Text = "Employers List\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KASAMBAHAY_MANAGEMENT_SYSTEM.Properties.Resources.Divider__1_;
            this.pictureBox2.Location = new System.Drawing.Point(25, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1008, 23);
            this.pictureBox2.TabIndex = 218;
            this.pictureBox2.TabStop = false;
            // 
            // RepresentativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 570);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dt2);
            this.Name = "RepresentativeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "representative";
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
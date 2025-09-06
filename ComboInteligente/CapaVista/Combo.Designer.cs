namespace CapaVista
{
    partial class Combo
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
            this.cmb_auto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_auto
            // 
            this.cmb_auto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_auto.FormattingEnabled = true;
            this.cmb_auto.Location = new System.Drawing.Point(0, 0);
            this.cmb_auto.Name = "cmb_auto";
            this.cmb_auto.Size = new System.Drawing.Size(328, 24);
            this.cmb_auto.TabIndex = 0;
            this.cmb_auto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_auto);
            this.Name = "Combo";
            this.Size = new System.Drawing.Size(328, 33);
            this.Load += new System.EventHandler(this.Combo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_auto;
    }
}

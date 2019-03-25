namespace SudokuHelp
{
    partial class Tile
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
            this.Control = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Control)).BeginInit();
            this.SuspendLayout();
            // 
            // Control
            // 
            this.Control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.Location = new System.Drawing.Point(2, 3);
            this.Control.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(61, 49);
            this.Control.TabIndex = 16;
            this.Control.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SudokuTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Control);
            this.Name = "SudokuTile";
            this.Size = new System.Drawing.Size(66, 55);
            ((System.ComponentModel.ISupportInitialize)(this.Control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Control;
    }
}

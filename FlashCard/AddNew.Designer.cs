namespace FlashCard
{
    partial class AddNew
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
            this.frontword = new System.Windows.Forms.TextBox();
            this.backword = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frontword
            // 
            this.frontword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frontword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.frontword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.frontword.Location = new System.Drawing.Point(74, 59);
            this.frontword.Margin = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.frontword.MaximumSize = new System.Drawing.Size(560, 100);
            this.frontword.MinimumSize = new System.Drawing.Size(200, 80);
            this.frontword.Name = "frontword";
            this.frontword.Size = new System.Drawing.Size(434, 80);
            this.frontword.TabIndex = 0;
            this.frontword.Text = "Front Word";
            this.frontword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frontword.WordWrap = false;
            this.frontword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frontword_MouseClick);
            // 
            // backword
            // 
            this.backword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.backword.Location = new System.Drawing.Point(74, 155);
            this.backword.Margin = new System.Windows.Forms.Padding(20);
            this.backword.Multiline = true;
            this.backword.Name = "backword";
            this.backword.Size = new System.Drawing.Size(434, 89);
            this.backword.TabIndex = 1;
            this.backword.Text = "Back Word";
            this.backword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(196, 268);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(153, 49);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // AddNew
            // 
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.backword);
            this.Controls.Add(this.frontword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AddNew";
            this.Text = "Flash Cards";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox backword;
        private System.Windows.Forms.TextBox frontword;
        private System.Windows.Forms.Button addbutton;
    }
}
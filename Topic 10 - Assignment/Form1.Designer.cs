namespace Topic_10___Assignment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnH = new System.Windows.Forms.Button();
            this.btnSm = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(85, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(602, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Please Select An Element To Learn More";
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(72, 108);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(104, 47);
            this.btnH.TabIndex = 1;
            this.btnH.Text = "Hydrogen";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnSm
            // 
            this.btnSm.Location = new System.Drawing.Point(72, 214);
            this.btnSm.Name = "btnSm";
            this.btnSm.Size = new System.Drawing.Size(104, 47);
            this.btnSm.TabIndex = 2;
            this.btnSm.Text = "Samarium";
            this.btnSm.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(72, 161);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(104, 47);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Carbon";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnRn
            // 
            this.btnRn.Location = new System.Drawing.Point(72, 267);
            this.btnRn.Name = "btnRn";
            this.btnRn.Size = new System.Drawing.Size(104, 47);
            this.btnRn.TabIndex = 4;
            this.btnRn.Text = "Radon";
            this.btnRn.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(72, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 47);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(489, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRn);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnSm);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnSm;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnRn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


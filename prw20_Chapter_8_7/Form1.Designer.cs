namespace prw20_Chapter_8_7
{
	partial class PigLatin
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
			this.btnPig = new System.Windows.Forms.Button();
			this.txtEnglish = new System.Windows.Forms.TextBox();
			this.lblPigLatin = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPig
			// 
			this.btnPig.Location = new System.Drawing.Point(73, 195);
			this.btnPig.Name = "btnPig";
			this.btnPig.Size = new System.Drawing.Size(75, 23);
			this.btnPig.TabIndex = 0;
			this.btnPig.Text = "Translate";
			this.btnPig.UseVisualStyleBackColor = true;
			this.btnPig.Click += new System.EventHandler(this.btnPig_Click);
			// 
			// txtEnglish
			// 
			this.txtEnglish.Location = new System.Drawing.Point(137, 47);
			this.txtEnglish.Name = "txtEnglish";
			this.txtEnglish.Size = new System.Drawing.Size(100, 20);
			this.txtEnglish.TabIndex = 1;
			// 
			// lblPigLatin
			// 
			this.lblPigLatin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPigLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPigLatin.Location = new System.Drawing.Point(12, 70);
			this.lblPigLatin.Name = "lblPigLatin";
			this.lblPigLatin.Size = new System.Drawing.Size(372, 122);
			this.lblPigLatin.TabIndex = 2;
			this.lblPigLatin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblPigLatin.Visible = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(235, 195);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(154, 195);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(93, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Let\'s try Pig Latin!";
			// 
			// PigLatin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(396, 230);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblPigLatin);
			this.Controls.Add(this.txtEnglish);
			this.Controls.Add(this.btnPig);
			this.Name = "PigLatin";
			this.Text = "Pig Latin";
			this.Load += new System.EventHandler(this.PigLatin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPig;
		private System.Windows.Forms.TextBox txtEnglish;
		private System.Windows.Forms.Label lblPigLatin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label1;
	}
}


namespace Practice4
{
	partial class StringUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnFind = new System.Windows.Forms.Button();
			this.m_btnReplace = new System.Windows.Forms.Button();
			this.m_lblFind = new System.Windows.Forms.Label();
			this.m_lblReplace = new System.Windows.Forms.Label();
			this.m_txtFind = new System.Windows.Forms.TextBox();
			this.m_txtReplace = new System.Windows.Forms.TextBox();
			this.m_txtContext = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// Find_btn
			// 
			this.m_btnFind.Location = new System.Drawing.Point( 508, 355 );
			this.m_btnFind.Name = "Find_btn";
			this.m_btnFind.Size = new System.Drawing.Size( 75, 23 );
			this.m_btnFind.TabIndex = 0;
			this.m_btnFind.Text = "搜尋";
			this.m_btnFind.UseVisualStyleBackColor = true;
			this.m_btnFind.Click += new System.EventHandler( this.Find_btn_Click );
			// 
			// Replace_btn
			// 
			this.m_btnReplace.Location = new System.Drawing.Point( 508, 420 );
			this.m_btnReplace.Name = "Replace_btn";
			this.m_btnReplace.Size = new System.Drawing.Size( 75, 23 );
			this.m_btnReplace.TabIndex = 1;
			this.m_btnReplace.Text = "取代";
			this.m_btnReplace.UseVisualStyleBackColor = true;
			this.m_btnReplace.Click += new System.EventHandler( this.Replace_btn_Click );
			// 
			// label1
			// 
			this.m_lblFind.AutoSize = true;
			this.m_lblFind.Location = new System.Drawing.Point( 83, 360 );
			this.m_lblFind.Name = "label1";
			this.m_lblFind.Size = new System.Drawing.Size( 41, 12 );
			this.m_lblFind.TabIndex = 2;
			this.m_lblFind.Text = "搜尋：";
			// 
			// label2
			// 
			this.m_lblReplace.AutoSize = true;
			this.m_lblReplace.Location = new System.Drawing.Point( 83, 425 );
			this.m_lblReplace.Name = "label2";
			this.m_lblReplace.Size = new System.Drawing.Size( 41, 12 );
			this.m_lblReplace.TabIndex = 3;
			this.m_lblReplace.Text = "取代：";
			// 
			// textBox1
			// 
			this.m_txtFind.Location = new System.Drawing.Point( 137, 355 );
			this.m_txtFind.Name = "textBox1";
			this.m_txtFind.Size = new System.Drawing.Size( 289, 22 );
			this.m_txtFind.TabIndex = 4;

			// 
			// textBox2
			// 
			this.m_txtReplace.Location = new System.Drawing.Point( 137, 420 );
			this.m_txtReplace.Name = "textBox2";
			this.m_txtReplace.Size = new System.Drawing.Size( 289, 22 );
			this.m_txtReplace.TabIndex = 5;

			// 
			// richTextBox1
			// 
			this.m_txtContext.Location = new System.Drawing.Point( 117, 65 );
			this.m_txtContext.Name = "richTextBox1";
			this.m_txtContext.Size = new System.Drawing.Size( 415, 173 );
			this.m_txtContext.TabIndex = 7;
			this.m_txtContext.Text = "";

			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 638, 475 );
			this.Controls.Add( this.m_txtContext );
			this.Controls.Add( this.m_txtReplace );
			this.Controls.Add( this.m_txtFind );
			this.Controls.Add( this.m_lblReplace );
			this.Controls.Add( this.m_lblFind );
			this.Controls.Add( this.m_btnReplace );
			this.Controls.Add( this.m_btnFind );
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnFind;
		private System.Windows.Forms.Button m_btnReplace;
		private System.Windows.Forms.Label m_lblFind;
		private System.Windows.Forms.Label m_lblReplace;
		private System.Windows.Forms.TextBox m_txtFind;
		private System.Windows.Forms.TextBox m_txtReplace;
		private System.Windows.Forms.RichTextBox m_txtContext;
	}
}


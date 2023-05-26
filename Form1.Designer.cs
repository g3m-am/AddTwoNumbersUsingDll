namespace AddTwoNumbersUsingDll
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(286, 14);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(286, 32);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(122, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(286, 61);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(122, 23);
			textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(286, 90);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(122, 23);
			textBox3.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(500, 54);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button1;
	}
}
namespace LAb15
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxX = new System.Windows.Forms.TextBox();
			this.textBoxT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxZ = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelU = new System.Windows.Forms.Label();
			this.textBoxN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите значения X";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(294, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "Результат";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxX
			// 
			this.textBoxX.Location = new System.Drawing.Point(157, 24);
			this.textBoxX.Name = "textBoxX";
			this.textBoxX.Size = new System.Drawing.Size(151, 20);
			this.textBoxX.TabIndex = 2;
			this.textBoxX.Text = "1";
			// 
			// textBoxT
			// 
			this.textBoxT.Location = new System.Drawing.Point(157, 71);
			this.textBoxT.Name = "textBoxT";
			this.textBoxT.Size = new System.Drawing.Size(151, 20);
			this.textBoxT.TabIndex = 4;
			this.textBoxT.Text = "1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Введите значения T";
			// 
			// textBoxZ
			// 
			this.textBoxZ.Location = new System.Drawing.Point(157, 116);
			this.textBoxZ.Name = "textBoxZ";
			this.textBoxZ.Size = new System.Drawing.Size(151, 20);
			this.textBoxZ.TabIndex = 6;
			this.textBoxZ.Text = "1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Введите значения Z";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Результат U";
			// 
			// labelU
			// 
			this.labelU.AutoSize = true;
			this.labelU.Location = new System.Drawing.Point(213, 208);
			this.labelU.Name = "labelU";
			this.labelU.Size = new System.Drawing.Size(13, 13);
			this.labelU.TabIndex = 8;
			this.labelU.Text = "0";
			// 
			// textBoxN
			// 
			this.textBoxN.Location = new System.Drawing.Point(157, 162);
			this.textBoxN.Name = "textBoxN";
			this.textBoxN.Size = new System.Drawing.Size(151, 20);
			this.textBoxN.TabIndex = 10;
			this.textBoxN.Text = "1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Введите значения N";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 302);
			this.Controls.Add(this.textBoxN);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelU);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxZ);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxX);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Калькулятор";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxX;
		private System.Windows.Forms.TextBox textBoxT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxZ;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelU;
		private System.Windows.Forms.TextBox textBoxN;
		private System.Windows.Forms.Label label5;
	}
}


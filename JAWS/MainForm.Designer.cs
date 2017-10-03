/*
 * Created by SharpDevelop.
 * User: IRU-OAS
 * Date: 28/07/2017
 * Time: 5:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JAWS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox mFromTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox mToTextBox;
		private System.Windows.Forms.Button selButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox cToTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox cFromTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button genButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckBox textCheckBox;
		private System.Windows.Forms.Button revButton;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button abtButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mFromTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mToTextBox = new System.Windows.Forms.TextBox();
			this.selButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.cToTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cFromTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.genButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.textCheckBox = new System.Windows.Forms.CheckBox();
			this.revButton = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.abtButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(45, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(323, 20);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(374, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Get HTML";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(340, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "HTML Codes (You can paste HTML codes here also): ";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 89);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(437, 440);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(486, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Main Selector: ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(486, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "From";
			// 
			// mFromTextBox
			// 
			this.mFromTextBox.Location = new System.Drawing.Point(521, 85);
			this.mFromTextBox.Name = "mFromTextBox";
			this.mFromTextBox.Size = new System.Drawing.Size(215, 20);
			this.mFromTextBox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(486, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "To";
			// 
			// mToTextBox
			// 
			this.mToTextBox.Location = new System.Drawing.Point(521, 114);
			this.mToTextBox.Name = "mToTextBox";
			this.mToTextBox.Size = new System.Drawing.Size(215, 20);
			this.mToTextBox.TabIndex = 9;
			// 
			// selButton
			// 
			this.selButton.Location = new System.Drawing.Point(486, 149);
			this.selButton.Name = "selButton";
			this.selButton.Size = new System.Drawing.Size(75, 23);
			this.selButton.TabIndex = 10;
			this.selButton.Text = "Select";
			this.selButton.UseVisualStyleBackColor = true;
			this.selButton.Click += new System.EventHandler(this.SelButtonClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(486, 335);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Columns in CSV";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(486, 361);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(250, 160);
			this.listBox1.TabIndex = 12;
			// 
			// cToTextBox
			// 
			this.cToTextBox.Location = new System.Drawing.Point(521, 257);
			this.cToTextBox.Name = "cToTextBox";
			this.cToTextBox.Size = new System.Drawing.Size(215, 20);
			this.cToTextBox.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(486, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "To";
			// 
			// cFromTextBox
			// 
			this.cFromTextBox.Location = new System.Drawing.Point(521, 228);
			this.cFromTextBox.Name = "cFromTextBox";
			this.cFromTextBox.Size = new System.Drawing.Size(215, 20);
			this.cFromTextBox.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(486, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "From";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(486, 202);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 23);
			this.label9.TabIndex = 13;
			this.label9.Text = "Selector for Column: ";
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(661, 283);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 18;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// genButton
			// 
			this.genButton.Location = new System.Drawing.Point(780, 19);
			this.genButton.Name = "genButton";
			this.genButton.Size = new System.Drawing.Size(105, 29);
			this.genButton.TabIndex = 19;
			this.genButton.Text = "Generate CSV";
			this.genButton.UseVisualStyleBackColor = true;
			this.genButton.Click += new System.EventHandler(this.GenButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(780, 55);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(105, 29);
			this.cancelButton.TabIndex = 20;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// textCheckBox
			// 
			this.textCheckBox.Location = new System.Drawing.Point(521, 282);
			this.textCheckBox.Name = "textCheckBox";
			this.textCheckBox.Size = new System.Drawing.Size(104, 24);
			this.textCheckBox.TabIndex = 21;
			this.textCheckBox.Text = "Text Only";
			this.textCheckBox.UseVisualStyleBackColor = true;
			// 
			// revButton
			// 
			this.revButton.Location = new System.Drawing.Point(742, 361);
			this.revButton.Name = "revButton";
			this.revButton.Size = new System.Drawing.Size(33, 23);
			this.revButton.TabIndex = 22;
			this.revButton.Text = "-";
			this.revButton.UseVisualStyleBackColor = true;
			this.revButton.Click += new System.EventHandler(this.RevButtonClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Normal",
			"Regular Expression",
			"HTML Agility"});
			this.comboBox1.Location = new System.Drawing.Point(544, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(192, 21);
			this.comboBox1.TabIndex = 23;
			this.comboBox1.Text = "Normal";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(486, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "Method: ";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(567, 154);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(169, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "Hint:  From: <table> To: </table>";
			// 
			// abtButton
			// 
			this.abtButton.Location = new System.Drawing.Point(780, 114);
			this.abtButton.Name = "abtButton";
			this.abtButton.Size = new System.Drawing.Size(105, 29);
			this.abtButton.TabIndex = 26;
			this.abtButton.Text = "About";
			this.abtButton.UseVisualStyleBackColor = true;
			this.abtButton.Click += new System.EventHandler(this.AbtButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 541);
			this.Controls.Add(this.abtButton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.revButton);
			this.Controls.Add(this.textCheckBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.genButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.cToTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cFromTextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.selButton);
			this.Controls.Add(this.mToTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.mFromTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "JAWS - Just Another Web Scraper v1.0.0 beta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

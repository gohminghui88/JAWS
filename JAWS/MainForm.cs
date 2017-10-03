/*
 * Created by SharpDevelop.
 * User: IRU-OAS
 * Date: 28/07/2017
 * Time: 5:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using HtmlAgilityPack;  

namespace JAWS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			try {
				
			richTextBox1.Text = "";
			WebClient web = new WebClient();
			web.DownloadFile(textBox1.Text, Directory.GetCurrentDirectory() + "\\temp.html");
			
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\temp.html");
			string line = sr.ReadLine(); int i = 0;
			while(line != null) {
				richTextBox1.Text += "\n" + line;
				line = sr.ReadLine();
				i++;
			}
			sr.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
			
			//MessageBox.Show(i.ToString());
			//richTextBox1.Text = web.DownloadString(textBox1.Text);
		}
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void SelButtonClick(object sender, EventArgs e)
		{
			try {
			
				if(comboBox1.Text == "Normal") {
					MatchCollection matches = Regex.Matches(richTextBox1.Text, mFromTextBox.Text + @"\s*(.+?)\s*" + mToTextBox.Text, RegexOptions.Singleline);
				
					richTextBox1.Text = "";
				
					foreach(Match m in matches) {
						richTextBox1.Text += m.Value;
					}
				}
				
				else if(comboBox1.Text == "Regular Expression") {
					
					MatchCollection matches = Regex.Matches(richTextBox1.Text, mFromTextBox.Text, RegexOptions.Singleline);
				
					richTextBox1.Text = "";
				
					foreach(Match m in matches) {
						richTextBox1.Text += m.Value;
					}
					
				}
				
				else {
					richTextBox1.SaveFile(Directory.GetCurrentDirectory() + "\\temp.html");
					
					HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
					doc.Load(Directory.GetCurrentDirectory() + "\\temp.html");
					
					richTextBox1.Text = "";
					
					foreach (HtmlNode n in doc.DocumentNode.SelectNodes(mFromTextBox.Text)) {
						richTextBox1.Text += n.InnerHtml;
					}
				}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
			
		}
		
		int h = 0;
		void AddButtonClick(object sender, EventArgs e)
		{
			try {
			listBox1.Items.Add("Column" + h.ToString() + "|" + "[From]" + cFromTextBox.Text + ":" + "[To]" + cToTextBox.Text + "|" + textCheckBox.Checked.ToString());
			h++;
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		void RevButtonClick(object sender, EventArgs e)
		{
			try {
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);
			}
			
			catch(Exception ex) {
			//	MessageBox.Show(ex.Message);
			}
		}
		void GenButtonClick(object sender, EventArgs e)
		{
			try {
			List<string> ls = new List<string>();
			
			string headers = ""; int k = 0;
			foreach (var it in listBox1.Items) {
				if(k > 0) headers += ",\"" + it.ToString().Split('|')[0] + "\"";
				else headers += "\"" + it.ToString().Split('|')[0] + "\"";
				k++;
			}	
			
			ls.Add("," + headers);
		
			List<List<string>> data2 = new List<List<string>>();
			List<MatchCollection> data = new List<MatchCollection>();
			foreach(var it in listBox1.Items) {
				
				string strFrom = it.ToString().Split('|')[1].Split(':')[0].Replace("[From]", "");
				string strTo = it.ToString().Split('|')[1].Split(':')[1].Replace("[To]", "");
				bool isRemoveTags = bool.Parse(it.ToString().Split('|')[2]);
				
				MatchCollection tmp = null;
				
				if(comboBox1.Text == "Normal") {
					tmp = Regex.Matches(richTextBox1.Text,strFrom + @"\s*(.+?)\s*" + strTo,RegexOptions.Singleline);
					data.Add(tmp);
				}
				
				else if(comboBox1.Text == "Regular Expression") {
					tmp = Regex.Matches(richTextBox1.Text,strFrom,RegexOptions.Singleline);
					data.Add(tmp);
				}
				
				else {
					
					richTextBox1.SaveFile(Directory.GetCurrentDirectory() + "\\temp.html");
					
					HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
					doc.Load(Directory.GetCurrentDirectory() + "\\temp.html");
					
					//richTextBox1.Text = "";
					
					List<string> t = new List<string>();
					foreach (HtmlNode n in doc.DocumentNode.SelectNodes(strFrom)) {
						t.Add(n.InnerHtml);
					}
					
					data2.Add(t);
					
				}
				//data.Add(tmp);
			
			}
			
			
			if(comboBox1.Text.Contains("Agility") != true) {
				int min = 999;
				foreach(MatchCollection dt in data) {
					if(dt.Count < min) min = dt.Count;
				}
			
				int numRows = min;
				int numCols = data.Count;
				for(int x = 0; x < numRows; x++) {
					string row = "";
					for(int y = 0; y < numCols; y++) {
					
						if(textCheckBox.Checked)
							row += "," + "\"" + Regex.Replace(data[x][y].Value, @"<[^>]*>", String.Empty) + "\"";
						else row += "," + "\"" + data[x][y].Value + "\"";
					}
					ls.Add(row);
				}
			}
			
			else {
				int min = 999;
				foreach(List<string> dt in data2) {
					if(dt.Count < min) min = dt.Count;
				}
			
				int numRows = min;
				int numCols = data2.Count;
				for(int x = 0; x < numRows; x++) {
					string row = "";
					for(int y = 0; y < numCols; y++) {
					
						if(textCheckBox.Checked)
							row += "," + "\"" + Regex.Replace(data2[x][y], @"<[^>]*>", String.Empty) + "\"";
						else row += "," + "\"" + data2[x][y] + "\"";
					}
					ls.Add(row);
				}
			}
			
			
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "CSV Files|*.csv";
			DialogResult res = sfd.ShowDialog();
			
			if(res == DialogResult.OK) {
				
				StreamWriter sw = new StreamWriter(sfd.FileName);
				foreach (string l in ls) {
					sw.WriteLine(l.Replace("\n", ""));
				}	
				sw.Close();
			}
			
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Normal") {
				mToTextBox.Enabled = true;
				cToTextBox.Enabled = true;
				
				label4.Text = "From";
				label8.Text = "From";
				
				label11.Text = "Hint: From: <table> To: </table>";
				
			}
			
			else if(comboBox1.Text == "Regular Expression") {
				mToTextBox.Enabled = false;
				cToTextBox.Enabled = false;
				
				label4.Text = "Regex";
				label8.Text = "Regex";
				
				label11.Text = "Hint: <table>\\s*(.+?)\\s*</table>";
				
			}
			
			else {
				mToTextBox.Enabled = false;
				cToTextBox.Enabled = false;
				
				label4.Text = "Input";
				label8.Text = "Input";
				
				label11.Text = "Hint: //table[@id='abc']//a";
				
			}
		}
		void AbtButtonClick(object sender, EventArgs e)
		{
			AboutForm af = new AboutForm();
			af.ShowDialog();
		}
	}
}

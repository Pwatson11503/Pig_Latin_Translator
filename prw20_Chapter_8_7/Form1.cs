using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prw20_Chapter_8_7
{
	public partial class PigLatin : Form
	{
		string firstLetter, restOfWord;
		string pigWords = "";
		string returnSentence = "";

		public PigLatin()
		{
			InitializeComponent();
		}


		private void btnPig_Click(object sender, EventArgs e)
		{
			lblPigLatin.Text = "";
			pigLatin();
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void Clear()
		{
			lblPigLatin.Text = "";
			txtEnglish.Text = "";
			txtEnglish.Focus();

			pigWords = "";
			returnSentence = "";
			firstLetter = "";
			restOfWord = "";
		}

		private void pigLatin()
		{

			//Use a string array and the split function to get each word
			//Get the first letter to move to the end 
			//At the end of each entry into the array append the "ay" to the words
			//Return the full sentence and insert it into the label.

			string str = txtEnglish.Text.Trim();
			string[] tokens = str.Split(null);
			if (str != "")
			{
				foreach (string word in tokens)
				{
					firstLetter = word.Substring(0, 1);
					restOfWord = word.Substring(1, word.Length - 1);
					pigWords = restOfWord + firstLetter + "ay";
					returnSentence += pigWords.ToUpper() + " ";
				
					//MessageBox.Show(pigWords.ToString());
				}
				lblPigLatin.Visible = true;
				lblPigLatin.Text = returnSentence;
			}
			else
			{
				Clear();
				MessageBox.Show("Please enter text");
			}

			/*for (int index = 0; index < tokens.Length; index++)
			{
				string tokens1 = tokens[index].Insert(0, tokens[index]);
				StringBuilder s = new StringBuilder(tokens1 + "ay");
				MessageBox.Show(s.ToString());
			}*/
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PigLatin_Load(object sender, EventArgs e)
		{
			//Whoops
		}

		
	}
}

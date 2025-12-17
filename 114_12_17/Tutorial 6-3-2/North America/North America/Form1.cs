using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;

            fileName = GetFileName();
            GetCounttries(fileName);
        }

        private string GetFileName()
        {
            string filename;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filename = openFile.FileName;
            }
            else
            {
                filename = string.Empty;
            }
            return filename;
        }

        private void GetCounttries(string filename)
        {
            string country;

            countriesListBox.Items.Clear();

            if(filename != string.Empty)
            {
                StreamReader inputFile = File.OpenText(filename);
                
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("未選取檔案","錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}

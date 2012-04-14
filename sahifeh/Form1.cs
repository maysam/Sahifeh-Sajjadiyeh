using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sahifeh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sahifehDataSet.word1' table. You can move, or remove it, as needed.
            this.word1TableAdapter.Fill(this.sahifehDataSet.word1);
            // TODO: This line of code loads data into the 'sahifehDataSet.word' table. You can move, or remove it, as needed.
            this.wordTableAdapter.Fill(this.sahifehDataSet.word);
            // TODO: This line of code loads data into the 'sahifehDataSet.text' table. You can move, or remove it, as needed.
            this.textTableAdapter.Fill(this.sahifehDataSet.text);
            // TODO: This line of code loads data into the 'sahifehDataSet.faghare' table. You can move, or remove it, as needed.
            this.faghareTableAdapter.Fill(this.sahifehDataSet.faghare);
            // TODO: This line of code loads data into the 'sahifehDataSet.doa' table. You can move, or remove it, as needed.
            this.doaTableAdapter.Fill(this.sahifehDataSet.doa);

        }
    }
}
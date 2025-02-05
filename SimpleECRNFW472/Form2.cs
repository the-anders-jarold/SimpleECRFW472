using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwpTrmLib.Nexo;

namespace SwpTrmIfDemo
{
    public partial class Form2 : Form
    {
        private List<OutputText> outputTexts = new List<OutputText>();

        public Form2()
        {
            InitializeComponent();

            characterHeights.DataSource = Enum.GetNames(typeof(OutputText.CharacterHeights));
            characterWidths.DataSource = Enum.GetNames(typeof(OutputText.CharacterWidths));
            alignments.DataSource = Enum.GetNames(typeof(OutputText.Alignments));
            colors.DataSource = Enum.GetNames(typeof(OutputText.Colors));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<OutputText> GetOutputTexts()
        {
            return outputTexts;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var t = new OutputText()
            {
                Content = textBox1.Text,
            };
            if (!String.IsNullOrEmpty(characterHeights.Text))
            {
                t.Height = (OutputText.CharacterHeights)Enum.Parse(typeof(OutputText.CharacterHeights), characterHeights.Text);
            }
            if (!String.IsNullOrEmpty(characterWidths.Text))
            {
                t.Width = (OutputText.CharacterWidths)Enum.Parse(typeof(OutputText.CharacterWidths), characterWidths.Text);
            }
            if (!String.IsNullOrEmpty(alignments.Text))
            {
                t.Alignment = (OutputText.Alignments)Enum.Parse(typeof(OutputText.Alignments), alignments.Text);
            }
            if (!String.IsNullOrEmpty(colors.Text))
            {
                t.Color = (OutputText.Colors)Enum.Parse(typeof(OutputText.Colors), colors.Text);
            }
            if (!String.IsNullOrEmpty(startRow.Text))
            {
                t.StartRow = int.Parse(startRow.Text);
            }
            outputTexts.Add(t);

            textBox2.AppendText(t.Content + Environment.NewLine);
            characterHeights.Text = string.Empty;
            characterWidths.Text = string.Empty;
            alignments.Text = string.Empty;
            colors.Text = string.Empty;
            startRow.Text = string.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

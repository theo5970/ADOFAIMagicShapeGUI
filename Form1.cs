using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;
using ADOFAIMagicShape;

namespace ADOFAIMagicShapeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly string adofaiLevelFilter = "ADOFAI Level|*.adofai";
        private void findSourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = adofaiLevelFilter;
            openFileDialog.Multiselect = false;
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                sourcePathText.Text = openFileDialog.FileName;

                string autoDestPath = Path.ChangeExtension(openFileDialog.FileName, null) + ".magicshape.adofai";
                destinationPathText.Text = autoDestPath;

                ScrollTextToEnd(sourcePathText);
                ScrollTextToEnd(destinationPathText);
            }
        }
        private void destFindButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = adofaiLevelFilter;

            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                destinationPathText.Text = saveFileDialog.FileName;

                ScrollTextToEnd(destinationPathText);
            }
        }

        private void ScrollTextToEnd(TextBox textBox)
        {
            textBox.SelectionStart = textBox.TextLength;
            textBox.ScrollToCaret();
        }

        private void speedMultiplierRadio_CheckedChanged(object sender, EventArgs e)
        {
            bpmNumeric.Enabled = false;
        }

        private void speedBpmRadio_CheckedChanged(object sender, EventArgs e)
        {
            bpmNumeric.Enabled = true;
        }

        private bool IsUseBpm()
        {
            return speedBpmRadio.Checked;
        }

        private TwirlMode GetCurrentTwirlMode()
        {
            if (twirlDefaultRadio.Checked) return TwirlMode.Default;
            if (twirlInsideRadio.Checked) return TwirlMode.Inside;
            if (twirlOutsideRatio.Checked) return TwirlMode.Outside;
            return TwirlMode.Default;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Run()
        {
            string sourceFilePath = sourcePathText.Text;
            string destinationFilePath = destinationPathText.Text;

            if (!File.Exists(sourceFilePath))
            {
                throw new Exception("원본 파일이 존재하지 않습니다!\n\nSource File does not exist!");
            }

            ParseResult parseResult = ADOFAIParser.Parse(sourceFilePath);
            var calculator = new AngleBetweenTileCalculator();
            calculator.Calculate(parseResult.Events);

            JObject levelObj = parseResult.LevelObject;
            var builder = new MagicShapeMultiplierBuilder();
            builder.Input = calculator.Result;
            builder.Mode = GetCurrentTwirlMode();
            builder.UseBpm = IsUseBpm();

            if (builder.UseBpm)
            {
                builder.TargetBpm = Convert.ToSingle(bpmNumeric.Value);
            }
            builder.Build(levelObj);

            string json = levelObj.ToString();
            File.WriteAllText(destinationFilePath, json, Encoding.UTF8);

            MessageBox.Show("성공했습니다!\n\nThe operation ended successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

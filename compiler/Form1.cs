using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;

namespace compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", tbFrameworke.Text } });

            CompilerParameters parameters = new CompilerParameters(new string[] { "mscorlib.dll", "System.Core.dll" }, tbFilePath.Text, true);

            parameters.GenerateExecutable = true;

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, tbCodeArea.Text);
            
            if (results.Errors.HasErrors)
            {
                foreach(CompilerError error in results.Errors.Cast<CompilerError>())
                {
                    tbDebugArea.Text += $"Строка {error.Line}: {error.ErrorText}";
                }
                
            }
            else
            {
                tbDebugArea.Text = "[Сборка завершена]";

                Process.Start($"{Application.StartupPath}/{tbFilePath.Text}");
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}  

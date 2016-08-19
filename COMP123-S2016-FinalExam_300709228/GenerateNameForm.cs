using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam_300709228
{
    public partial class GenerateNameForm : Form
    {
        private Random _random;

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateName()
        {
            
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGenerateorForm = new AbilityGeneratorForm();
            abilityGenerateorForm.Show();
            this.Hide();
        }
    }
}

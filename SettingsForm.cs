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
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace mPlayer
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance; //create a new materialskinmanager instance
            materialSkinManager.AddFormToManage(this); //add this form to the managed forms of materialskinmanager
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //set the theme to dark

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red800, Primary.Red500, Accent.Red700, TextShade.WHITE); //my special red theme    
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Settings coming soon", "Error");
            this.Close();
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

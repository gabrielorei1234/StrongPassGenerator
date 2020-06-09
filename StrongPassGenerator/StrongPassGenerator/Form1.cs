using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPassGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            string text = txtNumber.Text;
            if (text == "")
            {
                MessageBox.Show("Error", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numero = int.Parse(text);
            if ((numero == 0) || text == "")
            {
                MessageBox.Show("Error", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string senha = string.Empty;
            
            for (int i = 0; i < numero; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
                
            }
            txtPass.Text = senha;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

            
        
    


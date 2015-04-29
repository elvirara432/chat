using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formChat.referenciachat;

namespace formChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        referenciachat.CHATSoapClient ch= new referenciachat.CHATSoapClient();
      
        private void btnEnviar_Click(object sender, EventArgs e)
        {


 lstSala.Items.Add(txtMensaje.Text);
        var res=    ch.chat(txtMensaje.Text);
            lstSala.Items.Add(res);
           

        }
    }
}

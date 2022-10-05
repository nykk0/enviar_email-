using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
using System.Net;
using System.Net.Mail;

namespace testeasd
{
    public partial class Form1 : Form
    {
        enviar_email enviar_Email = new enviar_email();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviar_Email.Enviar_email(txtemail.Text);// email do destinatario 
            MessageBox.Show(enviar_Email.mensagem());
        }
    }
}

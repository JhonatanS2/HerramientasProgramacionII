﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona Jaime = new Persona();
           // MessageBox.Show(Jaime.Addres);
            Jaime.Addres = "Cra 33 #33-33";
            Jaime.Cellphone = "3012223366";
           // MessageBox.Show(Jaime.Cellphone);

            Persona Milena = new Persona("Milena");
            Persona Esperanza = new Persona("Esperanza","Calle 1");
            Persona Eddie = new Persona("Eddie", "Calle 6", "301222555");
            Persona Ivan = new Persona("Ivan",cellphone:"315666666");

            BankAccount colmena = new BankAccount();
            MessageBox.Show("Número de cuenta colmena: " + colmena.NumeroCuenta.ToString());

            BankAccount sudameris = new BankAccount();
            MessageBox.Show("Número de cuenta sudameris: " + sudameris.NumeroCuenta.ToString());

            BankAccount bancodo = new BankAccount();
            MessageBox.Show("Número de cuenta bancocodo: " + bancodo.NumeroCuenta.ToString());
        }
    }
}

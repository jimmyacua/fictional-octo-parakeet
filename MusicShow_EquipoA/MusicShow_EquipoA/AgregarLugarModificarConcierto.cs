﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace MusicShow_EquipoA
{
    public partial class AgregarLugarModificarConcierto : MetroForm
    {
        public AgregarLugarModificarConcierto()
        {
            InitializeComponent();
        }

        private void AgregarLugarModificarConcierto_Load(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            AgregarLugarModificarConcierto a = new AgregarLugarModificarConcierto();
            a.Show();
            this.Hide();
        }
    }
}

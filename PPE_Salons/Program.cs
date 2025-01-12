﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Salons
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin MonFormLogin = new FormLogin();

            MonFormLogin.ShowDialog();
            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
                int NiveauUtilisateur = MonFormLogin.Level;
                int LeNomUtilisateur = MonFormLogin.Identifiant;
                int TypeCo = MonFormLogin.TypeCo;
                MonFormLogin.Close();
                Application.Run(new FormMainMenu(NiveauUtilisateur, LeNomUtilisateur, TypeCo));
            }
            else
            {
                MonFormLogin.Close();
                MessageBox.Show("Au revoir");
            }
        }
    }
}

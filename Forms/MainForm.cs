﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingPractice_03.Forms;

namespace TrainingPractice_03
{
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        public MainForm()
        {
            InitializeComponent();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuideForm guideForm=new GuideForm();
            guideForm.FormClosed += formClosed;
            Hide();
            guideForm.Show();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelForm fuelForm = new FuelForm();
            fuelForm.FormClosed += formClosed;
            Hide();
            fuelForm.Show();
        }

        private void учётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemainsForm remainsForm = new RemainsForm();
            remainsForm.FormClosed += formClosed;
            Hide();
            remainsForm.Show();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Пегушин Григорий, студент гр. ИП-20-3", "Контакты",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

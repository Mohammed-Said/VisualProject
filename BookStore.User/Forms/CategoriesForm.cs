﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.User.Forms
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void code_Click(object sender, EventArgs e)
        {
            string selectedCategory = "code";
            OneCategoryForm OneCategoryForm = new OneCategoryForm(selectedCategory);
            OneCategoryForm.Show();
        }

        private void Fiction_Click(object sender, EventArgs e)
        {

        }

        private void Suspense_Click(object sender, EventArgs e)
        {

        }

        private void Beauty_Click(object sender, EventArgs e)
        {

        }

        private void Science_Click(object sender, EventArgs e)
        {

        }
    }
}

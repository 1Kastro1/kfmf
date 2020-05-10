using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.kvartirs.Load();
            kvartirBindingSource.DataSource = db.kvartirs.Local.ToBindingList();
        }

        private void kvartirBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            db.Dispose();
        }
    }
}

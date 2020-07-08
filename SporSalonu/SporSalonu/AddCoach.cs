using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonu
{
    public partial class AddCoach : Form
    {
        public AddCoach()
        {
            InitializeComponent();
        }
        private void coachesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coachesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void AddCoach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Coaches' table. You can move, or remove it, as needed.
            this.coachesTableAdapter.Fill(this.databaseDataSet.Coaches);
            this.coachesBindingSource.AddNew();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.coachesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            Coachs coachs = new Coachs();
            coachs.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Coachs coachs = new Coachs();
            coachs.Show();
            this.Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

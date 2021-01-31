using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class Class : Form
    {
        MSGCPAEntities1 db = new MSGCPAEntities1();
        Grade gd = new Grade();
        int id;
        public Class()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Grade.Text = "";
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Grade.Text == "")
            {
                MessageBox.Show("Please enter Grade");
                txt_Grade.Focus();
                return;
            }
            gd.grade1 = txt_Grade.Text.Trim();
            //SQL Execution
            db.Grade.Add(gd);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            dgv_Grade.DataSource = db.Grade.ToList<Grade>();
         }

        private void Class_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Dgv_Grade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var command = dgv_Grade.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            id = Convert.ToInt32(dgv_Grade.Rows[e.RowIndex].Cells["grade_Id"].Value);

            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var grade = db.Grade.Find(id);
                    db.Grade.Remove(grade);
                    db.SaveChanges();
                    MessageBox.Show("Grade SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (command.ToString() == "Edit")
            {
                var grade = db.Grade.Find(id);
                txt_Grade.Text = grade.grade1.ToString();

            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            using (var context = new MSGCPAEntities1())
            {
                var commandText = "UPDATE Grade SET grade1='"
                   + txt_Grade.Text.ToString()+ "' where  grade_Id='" + id.ToString() + "'";
                context.Database.ExecuteSqlCommand(commandText);
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
}


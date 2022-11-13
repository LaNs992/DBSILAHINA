using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace склад
{
    public partial class Form1 : Form
    {    
        private readonly BindingSource BSourse;
        public Form1()
        {
            InitializeComponent();
            BSourse = new BindingSource();
            dataGridView1.DataSource = ReadDb();
            repit();
            SchComboBox.SelectedIndex = 0;
        }
        private void CreateDb(addform infoform)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                infoform.sclad.Id = Guid.NewGuid();
                db.ScladDB.Add(infoform.sclad);
                db.SaveChanges();
            }
        }
        private static List<sclad> ReadDb()
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                return db.ScladDB.ToList();
            }
        }
        private static void UpDateDb(sclad scld)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                var Scld = db.ScladDB.FirstOrDefault(u => u.Id == scld.Id);
                if (Scld != null)
                {
                    Scld.name = scld.name;
                    Scld.raz = scld.raz;
                    Scld.mater = scld.mater;
                    Scld.kol = scld.kol;
                    Scld.min = scld.min;
                    Scld.price = scld.price;
                    Scld.fulprice = scld.fulprice;
                    db.SaveChanges();
                }
            }
        }
        private static void RemoveDb(sclad scld)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                var Scld = db.ScladDB.FirstOrDefault(u => u.Id == scld.Id);
                if (scld != null)
                {
                    db.ScladDB.Remove(Scld);
                    db.SaveChanges();
                }
            }
        }
        public void repit()
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options())) {
                toolStripStatusLabel1.Text = "Колличество товаров на складе: " + Convert.ToString(db.ScladDB.ToList().Count());
                toolStripStatusLabel3.Text = "Общая цена товаров(cНДС): " + Convert.ToString(db.ScladDB.ToList().Sum(x => x.fulprice + (x.fulprice * 0.2)));
                toolStripStatusLabel2.Text = "Общая цена товаров(безНДС): " + Convert.ToString(db.ScladDB.ToList().Sum(x => x.fulprice));
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var infoForm = new addform();
            infoForm.Text = "Добавление товара";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {                
                BSourse.ResetBindings(false);
                CreateDb(infoForm);
                dataGridView1.DataSource = ReadDb();
                repit();
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "AgeColumn")
            { 
                e.PaintBackground(e.CellBounds, true);
                var val = decimal.Parse(e.Value.ToString());
                var width = (float)(val*e.CellBounds.Width / 100.0m);
                var rect = new Rectangle(e.CellBounds.X,
                        e.CellBounds.Y,
                        (int)(width + 1),
                        e.CellBounds.Height);
                LinearGradientBrush GradBrash = new LinearGradientBrush(rect,Color.OrangeRed,Color.GreenYellow,0f);
                if (val >50 )
                {
                    e.Graphics.FillRectangle(GradBrash, e.CellBounds.X,
                        e.CellBounds.Y,
                        width,
                        e.CellBounds.Height);
                    e.Graphics.DrawString(val.ToString(), new Font("Arial", 10, FontStyle.Regular),new SolidBrush(Color.Black), e.CellBounds.X+45,
                        e.CellBounds.Y+5 );
                }
                else if (val < 50&&val>10)
                {
                    e.Graphics.FillRectangle(GradBrash, e.CellBounds.X,
                       e.CellBounds.Y,
                       width,
                       e.CellBounds.Height);
                    e.Graphics.DrawString(val.ToString(), new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), e.CellBounds.X + 45,
                       e.CellBounds.Y + 5);

                }
                else if( val < 10)
                {
                    e.Graphics.FillRectangle(GradBrash, e.CellBounds.X,
                       e.CellBounds.Y,
                       width,
                       e.CellBounds.Height);
                    e.Graphics.DrawString(val.ToString(), new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), e.CellBounds.X + 45,
                       e.CellBounds.Y + 5);
                }
                e.Handled = true;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var id = (sclad)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new addform(id);
            
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {

                id.name = infoForm.sclad.name;
                id.mater = infoForm.sclad.mater;
                id.kol = infoForm.sclad.kol;
                id.raz = infoForm.sclad.raz;
                id.min = infoForm.sclad.min;
                id.price = infoForm.sclad.price;          
                id.fulprice = infoForm.sclad.fulprice;
                BSourse.ResetBindings(false);
                UpDateDb(id);  
                dataGridView1.DataSource = ReadDb();
                repit();
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = toolStripButton3.Enabled = dataGridView1.SelectedRows.Count > 0;
            удалитьToolStripMenuItem.Enabled = изменитьToolStripMenuItem.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DepterColumn")
            {
                var id = (sclad)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = id.price + (id.price * 0.2);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "noNDS")
            {
                var id = (sclad)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = id.fulprice + (id.fulprice * 0.2);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var id = (sclad)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            DialogResult result = MessageBox.Show(
        "Вы уверены что хотите удалить товар?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                BSourse.ResetBindings(false);
                RemoveDb(id);
                dataGridView1.DataSource = ReadDb();
                repit();

                this.TopMost = true;
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(sender, e);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(sender, e);
        }

        private void forprogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Склад", "Бажин Кирилл Адреевич", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scladDBDataSet.ScladDB". При необходимости она может быть перемещена или удалена.
            this.scladDBTableAdapter.Fill(this.scladDBDataSet.ScladDB);
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scladDBTableAdapter.Fill(this.scladDBDataSet.ScladDB);
        }
        private void Search_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                scladDBBindingSource.Filter = string.Format($"{SchComboBox.Text}='{Search.Text.Trim()}'");
            }
            catch (SyntaxErrorException)
            {
                // recover from exception
            }
            if (string.IsNullOrWhiteSpace(Search.Text))
            {
                this.scladDBTableAdapter.Fill(this.scladDBDataSet.ScladDB);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                scladDBBindingSource.Filter = string.Format("{0}='{1}'", SchComboBox.Text, Search.Text);
            }
            catch (SyntaxErrorException)
            {
                // recover from exception
            }
            if (string.IsNullOrWhiteSpace(Search.Text))
            {
                dataGridView2.DataSource= scladDBDataSet.ScladDB.ToList();
            }
        }
    }
}
     


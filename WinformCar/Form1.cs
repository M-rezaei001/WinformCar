using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCar
{
    public partial class Form1 : Form
    {
        List<Car> arrCars = new List<Car>
        {
            new Car(){Name = "Sam" , Brand = MyBrand.Bmw , Rang = MyRang.Black , IsAutomatic = true
            , IsGaz = false , MaxSpeed = 200 , VMOTOR = 1500 , ProductionDate = new MyDate(1990 , 10 , 20)}  ,
            new Car(){Name = "Dan" , Brand = MyBrand.Bmw , Rang = MyRang.Black , IsAutomatic = true
            , IsGaz = false , MaxSpeed = 200 , VMOTOR = 1500 , ProductionDate = new MyDate(1990 , 10 , 20)} ,
            new Car(){Name = "Max" , Brand = MyBrand.Bmw , Rang = MyRang.Black , IsAutomatic = true
            , IsGaz = false , MaxSpeed = 200 , VMOTOR = 1500 , ProductionDate = new MyDate(1990 , 10 , 20)}  ,
            new Car(){Name = "Tom" , Brand = MyBrand.Bmw , Rang = MyRang.Black , IsAutomatic = false
            , IsGaz = true , MaxSpeed = 200 , VMOTOR = 1500 , ProductionDate = new MyDate(1990 , 10 , 20)}
    };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            rdGasno.Checked = true;
            rdAutomatyes.Checked = true;

            cmbColors.DataSource = Enum.GetValues(typeof(MyRang));
            cmdBrands.DataSource = Enum.GetValues(typeof(MyBrand));
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Name = txtName.Text,
                MaxSpeed = int.Parse(txtMaxspeed.Value.ToString()),
                VMOTOR = int.Parse(txtVMotor.Value.ToString()),
                IsGaz = !rdGasno.Checked,
                IsAutomatic = !rdAutomatno.Checked,
                Brand = (MyBrand)cmdBrands.SelectedItem,
                Rang = (MyRang)cmbColors.SelectedItem
            };

            arrCars.Add(car);

            RefreshGrid();
        }

        public void RefreshGrid()
        {
            dgvCar.DataSource = null;
            dgvCar.DataSource = arrCars;
        }

        private void dgvCar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.ColumnIndex == 5)
                {

                    //MyDate dt = (MyDate)e.Value;
                    //string s = $"{dt.Year}-{dt.Month}-{dt.Day}";
                    //e.Value = s;

                    e.Value = ((MyDate)e.Value).PrintInfo();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCar.SelectedRows[0];

            //MessageBox.Show(row.Cells[].Value.ToString());

            arrCars.RemoveAt(row.Index);

            RefreshGrid();
        }

        private void dgvCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            
        }

        private void dgvCar_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCar.SelectedRows[0];

            txtName.Text = row.Cells["Name"].Value.ToString(); 
            txtMaxspeed.Text = row.Cells["maxSpeed"].Value.ToString(); 
            txtVMotor.Text = row.Cells["VMOTOR"].Value.ToString();

            cmbColors.SelectedItem = row.Cells["Rang"].Value;
            cmdBrands.SelectedItem = row.Cells["Brand"].Value;

            rdAutomatyes.Checked = Convert.ToBoolean(row.Cells["IsAutomatic"].Value);
            rdAutomatno.Checked = !rdAutomatyes.Checked;
            rdGasno.Checked = Convert.ToBoolean(row.Cells["IsGaz"].Value);
            rdGasyes.Checked = !rdGasno.Checked;
        }
    }
}

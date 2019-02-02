using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class AddOrChange : Form
    {
        public CarOwner Own { get; set; }
        public AddOrChange()
        {
            InitializeComponent();
            Own = new CarOwner();
            for(int i = 1; i<5; i++)
            {
                cmbTypeCar.Items.Add(HelperEnum.GetEnumDescription((TypeCar)i));
                cmbTypeLincence.Items.Add(HelperEnum.GetEnumDescription((TypeCar)i));
            }
            cmbTypeCar.SelectedIndex = 0;
            cmbTypeLincence.SelectedIndex = 0;
            cmbTypeCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeLincence.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public AddOrChange(CarOwner car)
        {
            InitializeComponent();
            Own = car;
            //отобразить на форме
            txbFIO.Text = Own.FullName;
            //cmbTypeLincence.SelectedItem = Own.TypeLicense;
            txbModelCar.Text = Own.ModelCar;//
            
            txbNumCar.Text = Own.CarNumber.ToString();//
            txbDateLince.Text = Own.CarDate.ToString();
            for (int i = 1; i < 5; i++)
            {
                cmbTypeCar.Items.Add(HelperEnum.GetEnumDescription((TypeCar)i));
                cmbTypeLincence.Items.Add(HelperEnum.GetEnumDescription((TypeCar)i));
            }
            cmbTypeLincence.SelectedIndex = (int)Own.TypeLicense-1;
            cmbTypeCar.SelectedIndex = (int)Own.TypeCar - 1;
            cmbTypeCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeLincence.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Own = new CarOwner();
            Own.FullName = txbFIO.Text;
            Own.TypeLicense = (TypeCar)(cmbTypeLincence.SelectedIndex+1);
            Own.ModelCar = txbModelCar.Text;
            Own.TypeCar = (TypeCar)(cmbTypeCar.SelectedIndex+1);
            Own.CarDate = Convert.ToDateTime(txbDateLince.Text);
            Own.CarNumber = Convert.ToInt32(txbNumCar.Text);
            //
            //
            DialogResult = DialogResult.OK;
        }

    }
}

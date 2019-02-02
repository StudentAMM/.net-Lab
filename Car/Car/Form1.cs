using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace Car
{
    public partial class FrmMain : Form
    {
        ListDrivers drivers, canDrivers, notCanDrivers;
        
        public FrmMain()
        {
            InitializeComponent();
            drivers = new ListDrivers();
            canDrivers = new ListDrivers();
            notCanDrivers = new ListDrivers();
            for (int i= 1; i<=3;i++)//немного не правильно
                cmbSort.Items.Add(HelperEnum.GetEnumDescription((ModDrive)i));
            cmbSort.SelectedIndex = 0;
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void tsmAdd_Click(object sender, EventArgs e)
        {
            AddOrChange rec =new AddOrChange();
            if (rec.ShowDialog() == DialogResult.OK)
            {
                drivers.Add(rec.Own);
            }
            dgMain.DataSource = drivers.GetList();
        }


        private void tsmNew_Click(object sender, EventArgs e)
        {
            dgMain.Rows.Clear();
            drivers = new ListDrivers();
            //создать дата грид
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                FileManager fm = GetFileByExtention(fi.Extension);
                drivers = fm.Load(fi.FullName);
                dgMain.DataSource = drivers.GetList();
            }
        }

        private FileManager GetFileByExtention(string ext)//абстрактная фабрика timplate
        {
            switch (ext.ToLower())
            {
                case ".txt": return new TxtManager();
                case ".xml": return new XmlManager();
                default: return new BinManager();
            }
        }

        private void tsmSaveAs_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                Save(saveFileDialog.FileName);
            }
        }

        private void Save(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            FileManager fm = GetFileByExtention(fi.Extension);
            fm.Save(fi.FullName, drivers);
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            if(openFileDialog.FileName != "")
            {
                Save(openFileDialog.FileName);
            }
            else
            {
                tsmSaveAs_Click(sender, e);//Так плохо делать
            }

        }

        private void tsmNoRight_Click(object sender, EventArgs e)
        {
            //главная задача
            drivers = drivers.ListDriveCar(ModDrive.No);
            drivers.GetList().Sort();
            dgMain.Rows.Clear();
            dgMain.DataSource = drivers.GetList();
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            dgMain.Rows.Clear();
            drivers.Cleare();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int ind = dgMain.CurrentRow.Index;
            AddOrChange rec = new AddOrChange(drivers.Ind(ind));//передать выбранную строку 
            if (rec.ShowDialog() == DialogResult.OK)
            {
                drivers.Edit(ind,rec.Own);
                dgMain.DataSource = drivers.GetList();
            }
        }

        private void tsmDel_Click(object sender, EventArgs e)
        {
            int ind = dgMain.CurrentRow.Index;
            drivers.RemoveInd(ind);
            dgMain.DataSource = drivers.GetList();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbSort.SelectedItem) //это не красиво
            {
                case "Все":
                    drivers = drivers.ListDriveCar(ModDrive.All);
                    drivers.GetList().Sort();
                    dgMain.DataSource = drivers.GetList();
                    break;
                case "Может":
                    canDrivers = drivers.ListDriveCar(ModDrive.Yes);
                    canDrivers.GetList().Sort();
                    dgMain.DataSource = canDrivers.GetList();
                    break;
                case "Не может":
                    notCanDrivers = drivers.ListDriveCar(ModDrive.No);
                    notCanDrivers.GetList().Sort();
                    dgMain.DataSource = notCanDrivers.GetList();
                    break;
            }
            
        }
    }
}

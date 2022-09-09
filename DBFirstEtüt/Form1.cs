using DBFirstEtüt.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstEtüt
{
    public partial class Form1 : Form
    {
        EmployeeRepository employeeRepository;
        ShipperRepository shipperRepository;
        OrderRepository orderRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            shipperRepository = new ShipperRepository();

            List<Employee> emp = employeeRepository.GetEmployees();

            lblEmployees.DataSource = emp;
            lblEmployees.DisplayMember = "FirstName";
            lblEmployees.ValueMember = "EmployeeID";
            lblEmployees.ClearSelected();

            List<Shipper> shp = shipperRepository.GetShippers();

            lblSupplier.DataSource = shp;
            lblSupplier.DisplayMember = "CompanyName";
            lblSupplier.ValueMember = "ShipperID";
            lblSupplier.ClearSelected();

            FillListView();
        }

        //Tüm Orderları Bas ..

        private void FillListView()
        {
            orderRepository = new OrderRepository();

            List<Order> orders = orderRepository.GetOrders();

            foreach (var item in orders)
            {
                string[] items = { item.OrderID.ToString(), item.OrderDate.ToString(), item.ShipCity.ToString() };

                ListViewItem listView = new ListViewItem(items);
                lvOrders.Items.Add(listView);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        //Employeelere göre orderları bas

    }
}

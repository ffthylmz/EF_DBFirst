using DBFirstEtüt.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstEtüt
{
    public partial class Form2 : Form
    {
        EmployeeRepository employeeRepository;
        OrderRepository orderRepository;
        ShipperRepository shipperRepository;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            orderRepository = new OrderRepository();
            shipperRepository = new ShipperRepository();

            cboxEmployeeName.DataSource = employeeRepository.GetEmployees();
            cboxEmployeeName.DisplayMember = "FirstName";
            cboxEmployeeName.ValueMember = "EmployeeID";

            cboxShipper.DataSource = shipperRepository.GetShippers();
            cboxShipper.DisplayMember = "CompanyName";
            cboxShipper.ValueMember = "ShipperID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int employeeID = (int)cboxEmployeeName.SelectedValue;
            int shipperID = (int)cboxShipper.SelectedValue;

            Order order = new Order();
            order.EmployeeID = employeeID;
            order.ShipVia = shipperID;
            order.OrderDate = dtpOrderDate.Value;
            order.ShipCity = txtShipCity.Text;

            int rows = orderRepository.AddOrder2(order);

            MessageBox.Show(rows > 0 ? "Added succesful" : "Add failed!");
            this.Hide();
           


        }

    }
}

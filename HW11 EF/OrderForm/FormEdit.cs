﻿using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class FormEdit : Form
    {
        public Order CurrentOrder { get; set; }

        public FormEdit()
        {
            InitializeComponent();
            customerBindingSource.Add(new Customer("1", "li"));
            customerBindingSource.Add(new Customer("2", "zhang"));
            using (var context = new OrderContext()) 
            {
                context.Customers.Add(new Customer("1", "li"));
                context.Customers.Add(new Customer("2", "zhang"));
                context.SaveChanges();
            }
        }

        public FormEdit(Order order, bool editMode = false) : this()
        {
            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            CurrentOrder = order;
            orderBindingSource.DataSource = CurrentOrder;
            txtOrderId.Enabled = !editMode;
            if (!editMode)
            {
                CurrentOrder.Customer = (Customer)customerBindingSource.Current;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FormItemEdit formItemEdit = new FormItemEdit(new OrderItem());
            try
            {
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    int index = 0;
                    if (CurrentOrder.Items.Count != 0)
                    {
                        index = CurrentOrder.Items.Max(i => i.OrderItemID) + 1;
                    }
                    formItemEdit.OrderItem.OrderItemID = index;
                    CurrentOrder.AddItem(formItemEdit.OrderItem);
                    itemsBindingSource.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO 加上订单合法性验证
            this.Close();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            EditItem();
        }

        private void EditItem()
        {
            OrderItem orderItem = itemsBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            FormItemEdit formItemEdit = new FormItemEdit(orderItem);
            if (formItemEdit.ShowDialog() == DialogResult.OK)
            {
                itemsBindingSource.ResetBindings(false);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = itemsBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveItem(orderItem);
            itemsBindingSource.ResetBindings(false);
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

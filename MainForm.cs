using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace gxxf {
    public partial class MainForm : Form {
        private bool init = false;
        private int tab = 0;
        private String username = null;
        private String password = "123123";
        private String superuserpass = "gxxf123123";

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            init = true;
        }

        private String DateToStr(DateTime d) {
            return String.Format("{0:000}-{1:00}-{2:00}", d.Year - 1911, d.Month, d.Day);
        }
        private String ValidateDate(String datestr) {
            if (datestr != null && datestr.Equals("   -  -"))
                return "";

            string pattern = "^(\\d{1,})-(\\d{1,})-(\\d{1,})$";
            Match m = Regex.Match(datestr, pattern);
            if (!m.Success)
                return null;

            int y = Int32.Parse(m.Groups[1].Value);
            int mm = Int32.Parse(m.Groups[2].Value);
            int d = Int32.Parse(m.Groups[3].Value);
            if (y > 150)
                return null;
            if (mm > 12 || mm < 1)
                return null;
            if (d > 31 || d < 1)
                return null;
            return String.Format("{0:000}-{1:00}-{2:00}", y, mm, d);
        }

        private bool chkInt(String str) {
            if (str == null)
                return false;
            String s = str.Trim();
            if (s.Length == 0)
                return true;
            int r;
            return int.TryParse(s, out r);
        }
        private int ToInt(String str) {
            if (str == null)
                return 0;
            String s = str.Trim();
            if (s.Length == 0)
                return 0;
            if (s.Equals("Y") || s.Equals("y"))
                return 1;
            if (s.Equals("N") || s.Equals("n"))
                return 0;
            int r;
            return int.TryParse(s, out r) ? r : 0;
        }
        private String DrGetStr(DataRow dr, DataColumn c) {
            if (dr == null)
                return "";
            Object o = dr[c];
            return o == null || (o is System.DBNull) ? "" : o.ToString();
        }
        private int DrGetInt(DataRow dr, DataColumn c) {
            return ToInt(DrGetStr(dr, c));
        }
        private void DrGet(DataRow dr, DataColumn c, TextBox tb, bool clear = false) {
            if (clear) {
                tb.Text = "";
                tb.Enabled = true;
            } else {
                tb.Text = DrGetStr(dr, c);
                tb.Enabled = (dr != null);
            }
        }
        private void DrGet(DataRow dr, DataColumn c, ComboBox cb, bool clear = false) {
            if (clear) {
                cb.Text = "";
                cb.Enabled = true;
            } else {
                cb.Text = DrGetStr(dr, c);
                cb.Enabled = (dr != null);
            }
        }
        private void DrGet(DataRow dr, DataColumn c, MaskedTextBox mtb) {
            String s = ValidateDate(DrGetStr(dr, c));
            if (s == null) {
                mtb.Text = "";
            } else {
                mtb.Text = s;
            }
            mtb.Enabled = (dr != null);
        }
        private bool DrChkModified(DataRow dr, DataColumn c, String s) {
            if (dr == null)
                return false;
            if (s != null)
                s = s.Trim();
            if (dr[c] is DBNull && (s == null || s.Length == 0))
                return false;
            if (dr[c].Equals(s))
                return false;
            return true;
        }
        private bool DrSet(DataRow dr, DataColumn c, String s) {
            bool r = DrChkModified(dr, c, s);
            if (r)
                dr[c] = s;
            return r;
        }
        private bool DrSet(DataRow dr, DataColumn c, int i) {
            return DrSet(dr, c, i.ToString());
        }

        
        private void edit_Enter(object sender, EventArgs e) {
            Control c = (Control)sender;
            c.BackColor = Color.Yellow;
            if (c is TextBox)
                ((TextBox)c).SelectAll();
            if (c is MaskedTextBox) {
                ((MaskedTextBox)c).Focus();
                ((MaskedTextBox)c).SelectAll();
            }
        }
        private void edit_Leave(object sender, EventArgs e) {
            Control c = (Control)sender;
            if (c.BackColor != Color.Red)
                c.BackColor = Color.White;
        }
        private void edit_MouseClick(object sender, MouseEventArgs e) {
            if (sender is TextBox)
                ((TextBox)sender).SelectAll();
            if (sender is MaskedTextBox) {
                ((MaskedTextBox)sender).Focus();
                ((MaskedTextBox)sender).SelectAll();
            }
        }
        private void mtbDate_Validated(object sender, EventArgs e) {
            MaskedTextBox tb = (MaskedTextBox)sender;
            if (ValidateDate(tb.Text) == null) {
                tb.BackColor = Color.Red;
            } else {
                tb.BackColor = Color.White;
            }
        }
        private void edit_number_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) e.Handled = true;
        }
        private bool checkPassword() {
            Form prompt = new Form();
            prompt.Width = 150;
            prompt.Height = 90;
            prompt.Text = "請輸入密碼";
            TextBox textBox = new TextBox() { Left = 10, Top = 10, Width = 100, UseSystemPasswordChar = true };
            Button confirmation = new Button() { Left = 10, Top = 30, Width = 40, Text = "Ok" };
            confirmation.Click += (s, ee) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();

            if (!textBox.Text.Equals(password)) {
                MessageBox.Show("密碼錯誤");
                return false;
            }
            return true;
        }

        // Login
        private void setupParameter(ComboBox cb) {
            cb.BindingContext = new BindingContext();
            cb.DataSource = gxxfDataSet.Parameter;
            cb.DisplayMember = gxxfDataSet.Parameter.ParameterNameColumn.ToString();
            cb.SelectedIndex = -1;
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            if (!tbPassword.Text.Equals(superuserpass)) {
                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM AppUser WHERE UserName = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'");
                cmd.Connection = (SqlConnection)tableAdapterManager.Connection;
                tableAdapterManager.Connection.Open();
                int c = (int)cmd.ExecuteScalar();

                if (c < 1) {
                    MessageBox.Show("登入失敗!! 帳號或密碼錯誤");
                    return;
                }
            }

            lbLoginPrompt.Text = "登入中，請稍候...";
            lbLoginPrompt.Update();

            Cursor.Current = Cursors.WaitCursor;
            this.customerBindingSource.Filter = "1 <> 1";
            this.customerTableAdapter.Fill(this.gxxfDataSet.Customer);
            changeTicketFilter(null, null);
            this.ticketTableAdapter.Fill(this.gxxfDataSet.Ticket);
            this.ticketTrousersBindingSource.Filter = "1 <> 1";
            this.ticketTrousersTableAdapter.Fill(this.gxxfDataSet.TicketTrousers);
            this.ticketJacketBindingSource.Filter = "1 <> 1";
            this.ticketJacketTableAdapter.Fill(this.gxxfDataSet.TicketJacket);
            this.parameterTableAdapter.Fill(this.gxxfDataSet.Parameter);
            Cursor.Current = Cursors.Default;

            dgvCustomerTicket.BindingContext = new BindingContext();
            dgvQueryTicket.BindingContext = new BindingContext();

            setupParameter(cbJianKuanP);
            setupParameter(cbShangWeiP);
            setupParameter(cbXiaWeiP);
            setupParameter(cbXiuChangP);
            setupParameter(cbXiuKouP);
            setupParameter(cbQianXiongP);
            setupParameter(cbHouBeiP);
            setupParameter(cbShenChangP);
            setupParameter(cbBeiChangP);
            setupParameter(cbBeiXinP);
            setupParameter(cbLingKouP);

            setupParameter(cbKuYaoP);
            setupParameter(cbKuXiaWeiP);
            setupParameter(cbKuChangP);
            setupParameter(cbZhongChangP);
            setupParameter(cbShangDangP);
            setupParameter(cbKaiDangP);
            setupParameter(cbZhongDangP);
            setupParameter(cbKuKouP);
            setupParameter(cbKouZiP);
            setupParameter(cbLaLianP);
            setupParameter(cbYaoDaiP);

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Report";
            rds.Value = reportBindingSource;
            rvReport.LocalReport.DataSources.Add(rds);

            username = tbUsername.Text;
            password = tbPassword.Text;
            panelLogin.Visible = false;
            panelMain.Visible = true;
            panelEdit.Visible = false;

            customerQueryInit();

            showCurrentCustomer();
            showCurrentTicket();
            showCurrentTicketJacket();
            showCurrentTicketTrousers();
        }

        // tab switch
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabMain.SelectedIndex == 0) {
                tab = 0;
                customerQueryInit();
            } else if (tabMain.SelectedIndex == 1) {
                tab = 1;
                ticketQueryInit();
            } else if (tabMain.SelectedIndex == 2) {
                tab = 2;
                reportQueryInit();
            } else if (tabMain.SelectedIndex == 3) {
                tab = 3;
                setupInit();
            }
        }

        // Customer
        private void customerQueryInit() {
            lbCustomers.Parent = tabPage1;
            tbQueryCustomer.Focus();
            customerQueryRefresh();
        }
        private void customerQueryRefresh() {
            String q = this.tbQueryCustomer.Text;
            if (q == null || q.Length == 0) {
                this.customerBindingSource.Filter = "1 <> 1";
            } else {
                this.customerBindingSource.Filter =
                    "CustomerCode LIKE '" + q + "%' OR CustomerName LIKE '%" + q + "%' OR Telephone LIKE '" + q + "%' OR IDCard LIKE '" + q + "%' OR Birthday LIKE '%" + q + "%'";
            }
            this.customerBindingSource.Sort = "CustomerName";
            if (customerDataGridView.Rows.Count > 0)
                customerDataGridView.CurrentCell = customerDataGridView.Rows[0].Cells[0];
        }

        private void tbQueryCustomer_TextChanged(object sender, EventArgs e) {
            customerQueryRefresh();
        }
        private class ListItem {
            public String id;
            public String name;
            public ListItem(String id, String name) {
                this.id = id;
                this.name = name;
            }
            public override string ToString() {
                return name;
            }
        }

        private void customerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            if (drv == null)
                return;

            String cid = DrGetStr(drv.Row, this.gxxfDataSet.Customer.customeridColumn);
            String cname = DrGetStr(drv.Row, this.gxxfDataSet.Customer.CustomerNameColumn);
            ListItem newItem = new ListItem(cid, cname);
            lbCustomers.Items.Add(newItem);
        }
        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e) {
            ListItem li = (ListItem)lbCustomers.SelectedItem;
            if (li == null)
                return;

            this.customerBindingSource.Filter = "customerid = '" + li.id + "'";
        }
        private void lbCustomers_DoubleClick(object sender, EventArgs e) {
            ListItem li = (ListItem)lbCustomers.SelectedItem;
            if (li == null)
                return;
            lbCustomers.Items.Remove(li);
        }



        // Ticket Query
        private void ticketQueryInit() {
            ticketBindingSource_CurrentChanged(null, null);
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT CompanyName FROM Ticket ORDER BY CompanyName");
            cmd.Connection = (SqlConnection)tableAdapterManager.Connection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtsrc = new DataTable();
            adapter.Fill(dtsrc);
            queryCompanyName.Items.Clear();
            foreach (DataRow dr in dtsrc.Rows) {
                Object o = dr["CompanyName"];
                String cn = (o == null || (o is System.DBNull)) ? null : o.ToString();
                if (cn != null && cn.Length > 0)
                    queryCompanyName.Items.Add(dr["CompanyName"]);
            }
            ticketQueryRefresh();
        }
        private void ticketQueryRefresh() {
            String d;
            String filter = "";

            if (!init)
                return;

            d = tbQueryTicketCode.Text;
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "TicketCode LIKE '" + d + "%'";
            }

            d = queryCompanyName.Text;
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "CompanyName = '" + d + "'";
            }
            d = ValidateDate(queryOrderDate1.Text);
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "OrderDate >= '" + d + "'";
            }
            d = ValidateDate(queryOrderDate2.Text);
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "OrderDate <= '" + d + "'";
            }
            d = ValidateDate(queryPlanDate1.Text);
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "PlanDate >= '" + d + "'";
            }
            d = ValidateDate(queryPlanDate2.Text);
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "PlanDate <= '" + d + "'";
            }
            d = ValidateDate(queryCarryDate1.Text);
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "CarryDate >= '" + d + "'";
            }
            d = ValidateDate(queryCarryDate2.Text);
            if (d != null && d.Length > 0) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "CarryDate <= '" + d + "'";
            }

            if (queryIfCarry1.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "IfCarry = 0";
            }
            if (queryIfCarry2.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "IfCarry = 1";
            }
            if (queryIfPayoff1.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "IfPayoff = 0";
            }
            if (queryIfPayoff2.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "IfPayoff = 1";
            }

            if (filter.Length == 0)
                filter = "1 <> 1";

            changeTicketFilter(filter, "OrderDate DESC");
            if (dgvQueryTicket.Rows.Count > 0)
                dgvQueryTicket.CurrentCell = dgvQueryTicket.Rows[0].Cells[0];
        }

        private void queryCompanyName_SelectedIndexChanged(object sender, EventArgs e) {
            ticketQueryRefresh();
        }
        private void dgvCustomerTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (tab == 2)
                return;

            btnEdit_Click(sender, null);
        }


        private void query_CheckedChanged(object sender, EventArgs e) {
            if (sender == queryIfCarry1) {
                if (queryIfCarry1.Checked)
                    queryIfCarry2.Checked = false;
            } else if (sender == queryIfCarry2) {
                if (queryIfCarry2.Checked)
                    queryIfCarry1.Checked = false;
            } else if (sender == queryIfPayoff1) {
                if (queryIfPayoff1.Checked)
                    queryIfPayoff2.Checked = false;
            } else if (sender == queryIfPayoff2) {
                if (queryIfPayoff2.Checked)
                    queryIfPayoff1.Checked = false;
            }
            ticketQueryRefresh();
        }
        private void queryDate_Validated(object sender, EventArgs e) {
            mtbDate_Validated(sender, e);
            ticketQueryRefresh();
        }
        private void queryDate_TextChanged(object sender, EventArgs e) {
            MaskedTextBox mtb = (MaskedTextBox)sender;
            if (ValidateDate(mtb.Text) != null) {
                ticketQueryRefresh();
            }
        }
        private void tbQueryTicketCode_TextChanged(object sender, EventArgs e) {
            ticketQueryRefresh();
        }



        // Report
        public class Report {
            public Report() { }
            public String OrderDate { get; set; }
            public int TicketCount { get; set; }
            public int TotalPrice { get; set; }
            public int Earnest { get; set; }
            public int AccountReceived { get; set; }
            public int Carry { get; set; }
            public int Payoff { get; set; }
        }
        private void reportQueryInit() {
            reportQueryRefresh();
        }
        private void reportQueryRefresh() {
            String filter = null;
            Report r = (Report)reportBindingSource.Current;
            if (r != null)
                filter = "OrderDate LIKE '" + r.OrderDate + "%'";

            try {
                changeTicketFilter(filter, "OrderDate");
                if (dgvQueryReport.Rows.Count > 0)
                    dgvQueryReport.CurrentCell = dgvQueryReport.Rows[0].Cells[0];
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void reportBindingSource_CurrentChanged(object sender, EventArgs e) {
            reportQueryRefresh();
        }
        private void btnUpdateReport_Click(object sender, EventArgs e) {
            Report r = null;
            String lastod = null;
            int tc = 0;
            int totalPrice = 0;
            int earnest = 0;
            int accountReceived = 0;
            int carry = 0;
            int payoff = 0;

            Cursor.Current = Cursors.WaitCursor;
            reportBindingSource.Clear();
            gxxfDataSet.Ticket.DefaultView.Sort = "OrderDate DESC";
            foreach (DataRowView drv in gxxfDataSet.Ticket.DefaultView) {
                String od = DrGetStr(drv.Row, gxxfDataSet.Ticket.OrderDateColumn);
                if (od.Length > 6) {
                    od = od.Substring(0, 6);
                }

                if (lastod == null) {
                    lastod = od;
                }
                if (!lastod.Equals(od)) {
                    r = new Report();
                    r.OrderDate = lastod;
                    r.TicketCount = tc;
                    r.TotalPrice = totalPrice;
                    r.Earnest = earnest;
                    r.AccountReceived = accountReceived;
                    r.Carry = carry;
                    r.Payoff = payoff;
                    reportBindingSource.Add(r);

                    lastod = od;
                    tc = totalPrice = earnest = accountReceived = carry = payoff = 0;
                }

                ++tc;
                totalPrice += DrGetInt(drv.Row, gxxfDataSet.Ticket.TotalPriceColumn);
                earnest += DrGetInt(drv.Row, gxxfDataSet.Ticket.EarnestColumn);
                accountReceived += DrGetInt(drv.Row, gxxfDataSet.Ticket.AccountReceivedColumn);
                carry += DrGetInt(drv.Row, gxxfDataSet.Ticket.IfCarryColumn);
                payoff += DrGetInt(drv.Row, gxxfDataSet.Ticket.IfPayoffColumn);
            }
            r = new Report();
            r.OrderDate = lastod;
            r.TicketCount = tc;
            r.TotalPrice = totalPrice;
            r.Earnest = earnest;
            r.AccountReceived = accountReceived;
            r.Carry = carry;
            r.Payoff = payoff;
            reportBindingSource.Add(r);

            Cursor.Current = Cursors.Default;
        }


        // Setup
        private void setupInit() {
            
        }
        private void parameterBindingSource_CurrentChanged(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)parameterBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.Parameter.ParameterNameColumn, tbParameter);
        }
        private void btnParameterNew_Click(object sender, EventArgs e) {
            String str = tbParameter.Text.Trim();
            if (str.Length == 0)
                return;

            DataRow dr = gxxfDataSet.Parameter.AddParameterRow("", "", str);
            if (this.parameterTableAdapter.Update(dr) != 1) {
                // TODO
            }
            if (dgvParameter.Rows.Count > 0)
                dgvParameter.CurrentCell = dgvParameter.Rows[dgvParameter.Rows.Count-1].Cells[0];
        }
        private void btnParameterUpdate_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)parameterBindingSource.Current;
            if (drv == null)
                return;
            DataRow dr = drv.Row;

            DrSet(dr, this.gxxfDataSet.Parameter.ParameterNameColumn, tbParameter.Text);
            if (this.parameterTableAdapter.Update(dr) != 1) {
                // TODO
            }
        }
        private void btnParameterDelete_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)parameterBindingSource.Current;
            if (drv == null)
                return;
            DataRow dr = drv.Row;

            if (MessageBox.Show("確定要刪除 " + DrGetStr(dr, gxxfDataSet.Parameter.ParameterNameColumn) + " ?", "刪除參數", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            dr.Delete();
            if (this.parameterTableAdapter.Update(dr) != 1) {
                // TODO
            }
        }



        // Right side panel
        private void changeTicketFilter(String filter, String sort) {
            if (filter == null) {
                ticketBindingSource.Filter = "1 <> 1";
                return;
            }
            ticketBindingSource.Filter = filter;
            if (sort != null) {
                ticketBindingSource.Sort = sort;
            }
        }

        private String showCurrentCustomer() {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.Customer.CustomerCodeColumn, showCustomerCode);
            DrGet(dr, this.gxxfDataSet.Customer.CustomerNameColumn, showCustomerName);
            DrGet(dr, this.gxxfDataSet.Customer.IDCardColumn, showIDCard);
            if (dr == null) {
                showSex.Enabled = false;
                showSex.Text = "";
            } else {
                showSex.Enabled = true;
                showSex.Text = DrGetInt(dr, this.gxxfDataSet.Customer.SexColumn) == 1 ? "男" : "女";
            }
            DrGet(dr, this.gxxfDataSet.Customer.BirthdayColumn, showBirthday);
            DrGet(dr, this.gxxfDataSet.Customer.TelephoneColumn, showTelephone);
            DrGet(dr, this.gxxfDataSet.Customer.addressgColumn, showAddress);
            DrGet(dr, this.gxxfDataSet.Customer.CompanyNameColumn, showCompanyName);
            DrGet(dr, this.gxxfDataSet.Customer.CompanyTelephoneColumn, showCompanyTelephone);
            DrGet(dr, this.gxxfDataSet.Customer.CompanyAddressColumn, showCompanyAddress);

            btnEdit.Enabled = (dr != null);
            btnTicketNew.Enabled = (dr != null);
            btnCustomerDelete.Enabled = (dr != null);

            if (dr == null)
                return null;
            return DrGetStr(dr, this.gxxfDataSet.Customer.customeridColumn);
        }
        private DataRow showCurrentTicket() {
            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.Ticket.TicketCodeColumn, showTicketCode);
            DrGet(dr, this.gxxfDataSet.Ticket.OrderDateColumn, showOrderDate);
            DrGet(dr, this.gxxfDataSet.Ticket.PlanDateColumn, showPlanDate);
            DrGet(dr, this.gxxfDataSet.Ticket.CarryDateColumn, showCarryDate);
            DrGet(dr, this.gxxfDataSet.Ticket.TotalPriceColumn, showTotalPrice);
            DrGet(dr, this.gxxfDataSet.Ticket.EarnestColumn, showEarnest);
            DrGet(dr, this.gxxfDataSet.Ticket.AccountReceivedColumn, showAccountReceived);
            DrGet(dr, this.gxxfDataSet.Ticket.CompanyNameColumn, showTicketCompanyName);
            DrGet(dr, this.gxxfDataSet.Ticket.CompanyTelephoneColumn, showTicketCompanyTelephone);
            DrGet(dr, this.gxxfDataSet.Ticket.CompanyAddressColumn, showTicketCompanyAddress);
            showRemark.UseSystemPasswordChar = true;
            DrGet(dr, this.gxxfDataSet.Ticket.RemarkColumn, showRemark);
            showIfCarry.Enabled = (dr != null);
            showIfPayoff.Enabled = (dr != null);
            if (dr == null) {
                showIfCarry.Text = "";
                showIfPayoff.Text = "";
            } else {
                showIfCarry.Text = DrGetInt(dr, this.gxxfDataSet.Ticket.IfCarryColumn) == 0 ? "未取件" : "已取件";
                showIfPayoff.Text = DrGetInt(dr, this.gxxfDataSet.Ticket.IfPayoffColumn) == 0 ? "未付清" : "已付清";
            }

            btnTicketDelete.Enabled = (dr != null);

            return dr;
        }
        private void showCurrentTicketJacket() {
            DataRowView drv = (DataRowView)ticketJacketBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.TicketJacket.JianKuanColumn, showJianKuan);
            DrGet(dr, this.gxxfDataSet.TicketJacket.JianKuanPColumn, showJianKuanP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShangWeiColumn, showShangWei);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShangWeiPColumn, showShangWeiP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiaWeiColumn, showXiaWei);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiaWeiPColumn, showXiaWeiP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuChangColumn, showXiuChang);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuChangPColumn, showXiuChangP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuKouColumn, showXiuKou);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuKouPColumn, showXiuKouP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.QianXiongColumn, showQianXiong);
            DrGet(dr, this.gxxfDataSet.TicketJacket.QianXiongPColumn, showQianXiongP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.HouBeiColumn, showHouBei);
            DrGet(dr, this.gxxfDataSet.TicketJacket.HouBeiPColumn, showHouBeiP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShenChangColumn, showShenChang);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShenChangPColumn, showShenChangP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiChangColumn, showBeiChang);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiChangPColumn, showBeiChangP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiXinColumn, showBeiXin);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiXinPColumn, showBeiXinP);
            DrGet(dr, this.gxxfDataSet.TicketJacket.LingKouColumn, showLingKou);
            DrGet(dr, this.gxxfDataSet.TicketJacket.LingKouPColumn, showLingKouP);
        }
        private void showCurrentTicketTrousers() {
            DataRowView drv = (DataRowView)ticketTrousersBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuYaoColumn, showKuYao);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuYaoPColumn, showKuYaoP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.XiaWeiColumn, showKuXiaWei);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.XiaWeiPColumn, showKuXiaWeiP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuChangColumn, showKuChang);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuChangPColumn, showKuChangP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongChangColumn, showZhongChang);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongChangPColumn, showZhongChangP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ShangDangColumn, showShangDang);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ShangDangPColumn, showShangDangP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KaiDangColumn, showKaiDang);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KaiDangPColumn, showKaiDangP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongDangColumn, showZhongDang);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongDangPColumn, showZhongDangP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuKouColumn, showKuKou);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuKouPColumn, showKuKouP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KouZiColumn, showKouZi);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KouZiPColumn, showKouZiP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.LaLianColumn, showLaLian);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.LaLianPColumn, showLaLianP);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.YaoDaiColumn, showYaoDai);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.YaoDaiPColumn, showYaoDaiP);
        }
        private void customerBindingSource_CurrentChanged(object sender, EventArgs e) {
            String cid = showCurrentCustomer();
            if (tab == 0) {
                if (cid == null) {
                    changeTicketFilter(null, null);
                } else {
                    changeTicketFilter("customerid = " + cid, "OrderDate DESC");
                    if (dgvCustomerTicket.Rows.Count > 0)
                        dgvCustomerTicket.CurrentCell = dgvCustomerTicket.Rows[0].Cells[0];
                }
            }
        }
        private void ticketBindingSource_CurrentChanged(object sender, EventArgs e) {
            DataRow dr = showCurrentTicket();
            if (dr == null) {
                this.ticketJacketBindingSource.Filter = "1 <> 1";
                this.ticketTrousersBindingSource.Filter = "1 <> 1";
            } else {
                String tid = DrGetStr(dr, this.gxxfDataSet.Ticket.TicketIdColumn);
                this.ticketJacketBindingSource.Filter = "TicketId = " + tid;
                this.ticketTrousersBindingSource.Filter = "TicketId = " + tid;
            }

            if (tab == 1 || tab == 2) {
                if (dr == null) {
                    this.customerBindingSource.Filter = "1 <> 1";
                } else {
                    this.customerBindingSource.Filter = "customerid = " + DrGetStr(dr, this.gxxfDataSet.Ticket.CustomerIdColumn);
                }
            }
        }

        private void ticketJacketBindingSource_CurrentChanged(object sender, EventArgs e) {
            showCurrentTicketJacket();
        }
        private void ticketTrousersbindingSource_CurrentChanged(object sender, EventArgs e) {
            showCurrentTicketTrousers();
        }

        // Edit Operation
        private int EditMode = 0;
        private void loadCustomer() {
            DataRowView drv1 = (DataRowView)customerBindingSource.Current;
            DataRow dr1 = (drv1 == null) ? null : drv1.Row;
            DrGet(dr1, this.gxxfDataSet.Customer.CustomerCodeColumn, tbCustomerCode);
            DrGet(dr1, this.gxxfDataSet.Customer.CustomerNameColumn, tbCustomerName);
            DrGet(dr1, this.gxxfDataSet.Customer.IDCardColumn, tbIDCard);
            if (DrGetInt(dr1, this.gxxfDataSet.Customer.SexColumn) == 1) {
                rbSex1.Checked = true;
            } else {
                rbSex2.Checked = true;
            }
            DrGet(dr1, this.gxxfDataSet.Customer.BirthdayColumn, mtbBirthday);
            DrGet(dr1, this.gxxfDataSet.Customer.TelephoneColumn, tbTelephone);
            DrGet(dr1, this.gxxfDataSet.Customer.addressgColumn, tbAddress);
            DrGet(dr1, this.gxxfDataSet.Customer.CompanyNameColumn, tbCompanyName);
            DrGet(dr1, this.gxxfDataSet.Customer.CompanyTelephoneColumn, tbCompanyTelephone);
            DrGet(dr1, this.gxxfDataSet.Customer.CompanyAddressColumn, tbCompanyAddress);
        }
        private void clearCustomer() {
            tbCustomerCode.Text = "";
            tbCustomerName.Text = "";
            tbIDCard.Text = "";
            tbTelephone.Text = "";
            mtbBirthday.Text = "";
            rbSex1.Checked = true;
            tbAddress.Text = "";
            tbCompanyName.Text = "";
            tbCompanyTelephone.Text = "";
            tbCompanyAddress.Text = "";
        }
        private void enableCustomer(bool enable) {
            tbCustomerCode.Enabled = enable;
            tbCustomerName.Enabled = enable;
            tbIDCard.Enabled = enable;
            tbTelephone.Enabled = enable;
            mtbBirthday.Enabled = enable;
            rbSex1.Enabled = enable;
            rbSex2.Enabled = enable;
            tbAddress.Enabled = enable;
            tbCompanyName.Enabled = enable;
            tbCompanyTelephone.Enabled = enable;
            tbCompanyAddress.Enabled = enable;
        }
        private void loadTicket(bool clear, bool clearMore) {
            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;

            DrGet(dr, this.gxxfDataSet.Ticket.TicketCodeColumn, tbTicketCode, clear);
            DrGet(dr, this.gxxfDataSet.Ticket.TotalPriceColumn, tbTotalPrice, clear);
            DrGet(dr, this.gxxfDataSet.Ticket.EarnestColumn, tbEarnest, clear);
            DrGet(dr, this.gxxfDataSet.Ticket.AccountReceivedColumn, tbAccountReceived, clear);
            if (clear) {
                mtbOrderDate.Text = DateToStr(DateTime.Now);
                mtbPlanDate.Text = DateToStr(DateTime.Now);
                mtbCarryDate.Text = "";
                rbIfCarry1.Checked = true;
                rbIfPayoff1.Checked = true;
            } else {
                DrGet(dr, this.gxxfDataSet.Ticket.OrderDateColumn, mtbOrderDate);
                DrGet(dr, this.gxxfDataSet.Ticket.PlanDateColumn, mtbPlanDate);
                DrGet(dr, this.gxxfDataSet.Ticket.CarryDateColumn, mtbCarryDate);
                if (DrGetInt(dr, this.gxxfDataSet.Ticket.IfCarryColumn) == 0) {
                    rbIfCarry1.Checked = true;
                } else {
                    rbIfCarry2.Checked = true;
                }
                if (DrGetInt(dr, this.gxxfDataSet.Ticket.IfPayoffColumn) == 0) {
                    rbIfPayoff1.Checked = true;
                } else {
                    rbIfPayoff2.Checked = true;
                }
            }

            DrGet(dr, this.gxxfDataSet.Ticket.CompanyNameColumn, tbTicketCompanyName, clearMore);
            DrGet(dr, this.gxxfDataSet.Ticket.CompanyTelephoneColumn, tbTicketCompanyTelephone, clearMore);
            DrGet(dr, this.gxxfDataSet.Ticket.CompanyAddressColumn, tbTicketCompanyAddress, clearMore);
            DrGet(dr, this.gxxfDataSet.Ticket.RemarkColumn, tbRemark, clearMore);

            drv = (DataRowView)ticketJacketBindingSource.Current;
            dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.TicketJacket.JianKuanColumn, tbJianKuan, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.JianKuanPColumn, cbJianKuanP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShangWeiColumn, tbShangWei, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShangWeiPColumn, cbShangWeiP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiaWeiColumn, tbXiaWei, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiaWeiPColumn, cbXiaWeiP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuChangColumn, tbXiuChang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuChangPColumn, cbXiuChangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuKouColumn, tbXiuKou, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.XiuKouPColumn, cbXiuKouP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.QianXiongColumn, tbQianXiong, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.QianXiongPColumn, cbQianXiongP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.HouBeiColumn, tbHouBei, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.HouBeiPColumn, cbHouBeiP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShenChangColumn, tbShenChang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.ShenChangPColumn, cbShenChangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiChangColumn, tbBeiChang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiChangPColumn, cbBeiChangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiXinColumn, tbBeiXin, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.BeiXinPColumn, cbBeiXinP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.LingKouColumn, tbLingKou, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketJacket.LingKouPColumn, cbLingKouP, clearMore);

            drv = (DataRowView)ticketTrousersBindingSource.Current;
            dr = (drv == null) ? null : drv.Row;
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuYaoColumn, tbKuYao, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuYaoPColumn, cbKuYaoP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.XiaWeiColumn, tbKuXiaWei, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.XiaWeiPColumn, cbKuXiaWeiP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuChangColumn, tbKuChang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuChangPColumn, cbKuChangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongChangColumn, tbZhongChang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongChangPColumn, cbZhongChangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ShangDangColumn, tbShangDang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ShangDangPColumn, cbShangDangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KaiDangColumn, tbKaiDang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KaiDangPColumn, cbKaiDangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongDangColumn, tbZhongDang, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.ZhongDangPColumn, cbZhongDangP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuKouColumn, tbKuKou, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KuKouPColumn, cbKuKouP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KouZiColumn, tbKouZi, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.KouZiPColumn, cbKouZiP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.LaLianColumn, tbLaLian, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.LaLianPColumn, cbLaLianP, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.YaoDaiColumn, tbYaoDai, clearMore);
            DrGet(dr, this.gxxfDataSet.TicketTrousers.YaoDaiPColumn, cbYaoDaiP, clearMore);

            tbRemark.UseSystemPasswordChar = true;

            tbCustomerCode.Focus();
        }
        private void btnCustomerNew_Click(object sender, EventArgs e) {
            EditMode = 0;
            clearCustomer();
            enableCustomer(true);
            loadTicket(true, true);
            panelMain.Visible = false;
            panelEdit.Visible = true;
        }
        private void btnTicketNew_Click(object sender, EventArgs e) {
            EditMode = 1;
            loadCustomer();
            enableCustomer(false);
            loadTicket(true, false);
            panelMain.Visible = false;
            panelEdit.Visible = true;
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            if (drv == null)
                return;

            EditMode = 2;
            loadCustomer();
            enableCustomer(true);
            loadTicket(false, false);
            panelMain.Visible = false;
            panelEdit.Visible = true;
        }

        // Save Operation
        private bool checkCustomer() {
            if (tbCustomerCode.Text.Trim().Length == 0) { MessageBox.Show("編號不可空白"); return false; }
            if (tbCustomerName.Text.Trim().Length == 0) { MessageBox.Show("姓名不可空白"); return false; }
            if (ValidateDate(mtbBirthday.Text) == null) { MessageBox.Show("生日錯誤"); return false; }
            return true;
        }
        private bool checkTicket() {
            if (tbTicketCode.Text.Trim().Length == 0) { MessageBox.Show("訂單編號不可空白"); return false; }
            String bs = ValidateDate(mtbOrderDate.Text);
            if (bs == null || bs.Length == 0) { MessageBox.Show("訂購日期錯誤"); return false; }
            bs = ValidateDate(mtbPlanDate.Text);
            if (bs == null || bs.Length == 0) { MessageBox.Show("預交日期錯誤"); return false; }
            bs = ValidateDate(mtbCarryDate.Text);
            if (bs == null) { MessageBox.Show("取件日期錯誤"); return false; }
            if (!chkInt(tbTotalPrice.Text) || !chkInt(tbEarnest.Text) || !chkInt(tbAccountReceived.Text)) {
                MessageBox.Show("金額錯誤");
                return false;
            }
            return true;
        }
        private bool checkDupTicketCode() {
            String ticketCode = tbTicketCode.Text.Trim();

            DataRow[] drs = gxxfDataSet.Ticket.Select("TicketCode = '" + ticketCode + "'");
            if (drs.Length > 0) {
                return true;
            }
            return false;
        }
        private bool storeCustomer(DataRow dr) {
            bool needUpdate = false;
            String nc = tbCustomerCode.Text.Trim().ToUpper();
            if (DrChkModified(dr, gxxfDataSet.Customer.CustomerCodeColumn, nc)) {
                DataRow[] drs = gxxfDataSet.Customer.Select("CustomerCode = '" + nc + "' OR CustomerCode LIKE '" + nc + "-%'");
                if (drs.Length != 0) {
                    nc += ("-" + drs.Length);
                }
                needUpdate = DrSet(dr, gxxfDataSet.Customer.CustomerCodeColumn, nc) | needUpdate;
            }
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CustomerNameColumn, tbCustomerName.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.IDCardColumn, tbIDCard.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.TelephoneColumn, tbTelephone.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.BirthdayColumn, ValidateDate(mtbBirthday.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.SexColumn, rbSex1.Checked ? 1 : 2) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.addressgColumn, tbAddress.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CompanyNameColumn, tbCompanyName.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CompanyTelephoneColumn, tbCompanyTelephone.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CompanyAddressColumn, tbCompanyAddress.Text) | needUpdate;
            return needUpdate;
        }
        private bool storeTicket(DataRow dr) {
            bool needUpdate = false;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.TicketCodeColumn, tbTicketCode.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.OrderDateColumn, ValidateDate(mtbOrderDate.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.PlanDateColumn, ValidateDate(mtbPlanDate.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CarryDateColumn, ValidateDate(mtbCarryDate.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.IfCarryColumn, rbIfCarry1.Checked ? 0 : 1) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.TotalPriceColumn, ToInt(tbTotalPrice.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.EarnestColumn, ToInt(tbEarnest.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.AccountReceivedColumn, ToInt(tbAccountReceived.Text)) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.IfPayoffColumn, rbIfPayoff1.Checked ? 0 : 1) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CompanyNameColumn, tbTicketCompanyName.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CompanyTelephoneColumn, tbTicketCompanyTelephone.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CompanyAddressColumn, tbTicketCompanyAddress.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.RemarkColumn, tbRemark.Text) | needUpdate;
            return needUpdate;
        }
        private bool storeTicketJacket(DataRow dr) {
            bool needUpdate = false;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.JianKuanColumn, tbJianKuan.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.JianKuanPColumn, cbJianKuanP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.ShangWeiColumn, tbShangWei.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.ShangWeiPColumn, cbShangWeiP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.XiaWeiColumn, tbXiaWei.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.XiaWeiPColumn, cbXiaWeiP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.XiuChangColumn, tbXiuChang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.XiuChangPColumn, cbXiuChangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.XiuKouColumn, tbXiuKou.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.XiuKouPColumn, cbXiuKouP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.QianXiongColumn, tbQianXiong.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.QianXiongPColumn, cbQianXiongP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.HouBeiColumn, tbHouBei.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.HouBeiPColumn, cbHouBeiP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.ShenChangColumn, tbShenChang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.ShenChangPColumn, cbShenChangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.BeiChangColumn, tbBeiChang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.BeiChangPColumn, cbBeiChangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.BeiXinColumn, tbBeiXin.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.BeiXinPColumn, cbBeiXinP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.LingKouColumn, tbLingKou.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketJacket.LingKouPColumn, cbLingKouP.Text) | needUpdate;
            return needUpdate;
        }
        private bool storeTicketTrousers(DataRow dr) {
            bool needUpdate = false;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KuYaoColumn, tbKuYao.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KuYaoPColumn, cbKuYaoP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.XiaWeiColumn, tbKuXiaWei.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.XiaWeiPColumn, cbKuXiaWeiP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KuChangColumn, tbKuChang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KuChangPColumn, cbKuChangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.ZhongChangColumn, tbZhongChang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.ZhongChangPColumn, cbZhongChangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.ShangDangColumn, tbShangDang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.ShangDangPColumn, cbShangDangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KaiDangColumn, tbKaiDang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KaiDangPColumn, cbKaiDangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.ZhongDangColumn, tbZhongDang.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.ZhongDangPColumn, cbZhongDangP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KuKouColumn, tbKuKou.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KuKouPColumn, cbKuKouP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KouZiColumn, tbKouZi.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.KouZiPColumn, cbKouZiP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.LaLianColumn, tbLaLian.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.LaLianPColumn, cbLaLianP.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.YaoDaiColumn, tbYaoDai.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.TicketTrousers.YaoDaiPColumn, cbYaoDaiP.Text) | needUpdate;
            return needUpdate;
        }
        private bool saveNewCustomer() {
            if (!checkCustomer())
                return false;
            if (!checkTicket())
                return false;

            if (checkDupTicketCode()) {
                MessageBox.Show("訂單編號已存在");
                return false;
            }

            int cid = -1;
            int tid = -1;
            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope()) {
                DataRow dr = gxxfDataSet.Customer.AddCustomerRow("", "", null, "1", null, null, null, null, null, null);
                storeCustomer(dr);
                if (customerTableAdapter.Update(dr) != 1) {
                    // TODO
                }

                cid = Int32.Parse(DrGetStr(dr, gxxfDataSet.Customer.customeridColumn));

                dr = gxxfDataSet.Ticket.AddTicketRow("", cid, "", "", "", "0", "0", "0", "0", "0", null, null, null, null, null);
                storeTicket(dr);
                if (this.ticketTableAdapter.Update(dr) != 1) {
                    // TODO
                }

                tid = Int32.Parse(DrGetStr(dr, this.gxxfDataSet.Ticket.TicketIdColumn));

                dr = gxxfDataSet.TicketJacket.AddTicketJacketRow(tid, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                storeTicketJacket(dr);
                this.ticketJacketTableAdapter.Update(dr);
                dr = gxxfDataSet.TicketTrousers.AddTicketTrousersRow(tid, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                storeTicketTrousers(dr);
                this.ticketTrousersTableAdapter.Update(dr);

                updateTransaction.Complete();
            }
            if (cid > 0)
                customerBindingSource.Filter = "customerid = '" + cid + "'";
            if (tid > 0)
                ticketBindingSource.Filter = "TicketId = '" + tid + "'";
            return true;
        }
        private bool saveNewTicket() {
            DataRowView drvCustomer = (DataRowView)customerBindingSource.Current;
            if (drvCustomer == null)
                return false;

            if (!checkTicket())
                return false;

            if (checkDupTicketCode()) {
                MessageBox.Show("訂單編號已存在");
                return false;
            }

            int cid = Int32.Parse(DrGetStr(drvCustomer.Row, gxxfDataSet.Customer.customeridColumn));
            int tid = -1;
            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope()) {
                DataRow dr = gxxfDataSet.Ticket.AddTicketRow("", cid, "", "", "", "0", "0", "0", "0", "0", null, null, null, null, null);
                storeTicket(dr);
                if (this.ticketTableAdapter.Update(dr) != 1) {
                    // TODO
                }

                tid = Int32.Parse(DrGetStr(dr, this.gxxfDataSet.Ticket.TicketIdColumn));

                dr = gxxfDataSet.TicketJacket.AddTicketJacketRow(tid, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                storeTicketJacket(dr);
                this.ticketJacketTableAdapter.Update(dr);
                dr = gxxfDataSet.TicketTrousers.AddTicketTrousersRow(tid, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                storeTicketTrousers(dr);
                this.ticketTrousersTableAdapter.Update(dr);

                updateTransaction.Complete();
            }
            if (tid > 0)
                ticketBindingSource.Filter = "TicketId = '" + tid + "'";
            return true;
        }
        private bool saveEditTicket() {
            DataRowView drvCustomer = (DataRowView)customerBindingSource.Current;
            if (drvCustomer == null || !checkCustomer())
                return false;
            DataRowView drvTicket = (DataRowView)ticketBindingSource.Current;
            if (drvTicket == null || !checkTicket())
                return false;

            String ticketCode = tbTicketCode.Text.Trim();
            String origtc = DrGetStr(drvTicket.Row, gxxfDataSet.Ticket.TicketCodeColumn);
            if (!ticketCode.Equals(origtc)) {
                if (MessageBox.Show("確定修改訂單編號?", "訂單編號修改", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return false;

                if (checkDupTicketCode()) {
                    MessageBox.Show("訂單編號已存在");
                    return false;
                }
            }

            DataRowView drvJacket = (DataRowView)ticketJacketBindingSource.Current;
            if (drvJacket == null)
                return false;
            DataRowView drvTrousers = (DataRowView)ticketTrousersBindingSource.Current;
            if (drvTrousers == null)
                return false;

            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope()) {
                if (storeCustomer(drvCustomer.Row))
                    this.customerTableAdapter.Update(drvCustomer.Row);
                if (storeTicket(drvTicket.Row))
                    this.ticketTableAdapter.Update(drvTicket.Row);
                if (storeTicketJacket(drvJacket.Row))
                    this.ticketJacketTableAdapter.Update(drvJacket.Row);
                if (storeTicketTrousers(drvTrousers.Row))
                    this.ticketTrousersTableAdapter.Update(drvTrousers.Row);
                updateTransaction.Complete();
            }
            return true;
        }

        private void btnEditCancel_Click(object sender, EventArgs e) {
            panelEdit.Visible = false;
            panelMain.Visible = true;
        }
        private void btnEditCommit_Click(object sender, EventArgs e) {
            if (EditMode == 0) {
                if (!saveNewCustomer())
                    return;
            } else if (EditMode == 1) {
                if (!saveNewTicket())
                    return;
            } else if (EditMode == 2) {
                if (!saveEditTicket())
                    return;
            }

            panelEdit.Visible = false;

            showCurrentCustomer();
            showCurrentTicket();
            showCurrentTicketJacket();
            showCurrentTicketTrousers();
            panelMain.Visible = true;
        }

        private void unmask_DoubleClick(object sender, EventArgs e) {
            if (checkPassword()) {
                TextBox tb = (TextBox)sender;
                tb.UseSystemPasswordChar = false;
            }
        }


        private void deleteTicket(DataRow dr) {
            String tid = DrGetStr(dr, this.gxxfDataSet.Ticket.TicketIdColumn);

            dr.Delete();
            ticketTableAdapter.Update(dr);

            DataRow[] rows = gxxfDataSet.TicketJacket.Select("TicketId = '" + tid + "'");
            foreach (DataRow r in rows) {
                r.Delete();
                ticketJacketTableAdapter.Update(r);
            }

            rows = gxxfDataSet.TicketTrousers.Select("TicketId = '" + tid + "'");
            foreach (DataRow r in rows) {
                r.Delete();
                ticketTrousersTableAdapter.Update(r);
            }
        }
        private void btnTicketDelete_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            if (drv == null)
                return;

            DataRow dr = drv.Row;

            if (MessageBox.Show("確定要刪除訂單 " + DrGetStr(dr, gxxfDataSet.Ticket.TicketCodeColumn) + "?", "刪除訂單", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (!checkPassword())
                return;

            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope()) {
                deleteTicket(dr);
                updateTransaction.Complete();
            }
            MessageBox.Show("刪除成功");
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            if (drv == null)
                return;

            DataRow dr = drv.Row;
            if (MessageBox.Show("確定要刪除顧客 " + DrGetStr(dr, gxxfDataSet.Customer.CustomerNameColumn) + " 和其所有的訂單?", "刪除顧客", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (!checkPassword())
                return;

            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope()) {
                String cid = DrGetStr(dr, this.gxxfDataSet.Customer.customeridColumn);

                dr.Delete();
                customerTableAdapter.Update(dr);

                DataRow[] rows = gxxfDataSet.Ticket.Select("CustomerId = '" + cid + "'");
                foreach (DataRow r in rows) {
                    deleteTicket(r);
                }

                updateTransaction.Complete();
            }
            MessageBox.Show("刪除成功");
        }


        // Print
        private void showPrintPage(String template) {
            panelMain.Visible = false;
            panelEdit.Visible = false;
            panelLogin.Visible = false;
            panelPrint.Visible = true;
            rvReport.LocalReport.ReportEmbeddedResource = template;
            rvReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvReport.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            rvReport.ShowBackButton = false;
            rvReport.ShowFindControls = false;
            rvReport.ShowRefreshButton = false;
            rvReport.ShowStopButton = false;
            rvReport.Refresh();
            rvReport.RefreshReport();
        }
        private void btnTicketPrint_Click(object sender, EventArgs e) {
            showPrintPage("gxxf.TicketReport.rdlc");
        }

        private void btnReportPrint_Click(object sender, EventArgs e) {
            showPrintPage("gxxf.ReportReport.rdlc");
        }
        private void btnPrintMonthlyReport_Click(object sender, EventArgs e) {
            showPrintPage("gxxf.ReportMonthly.rdlc");
        }

        private void btnBack_Click(object sender, EventArgs e) {
            panelMain.Visible = true;
            panelEdit.Visible = false;
            panelLogin.Visible = false;
            panelPrint.Visible = false;
        }
    }
}


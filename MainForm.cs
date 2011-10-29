using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace gxxf {
    public partial class MainForm : Form {
        private bool init = false;
        private int mode = 0;
        private String username = null;
        private String password = "123123";
        private String superuserpass = "gxxf123123";

        public MainForm() {
            InitializeComponent();
        }

        private void setupParameter(ComboBox cb) {
            cb.BindingContext = new BindingContext();
            cb.DataSource = gxxfDataSet.Parameter;
            cb.DisplayMember = gxxfDataSet.Parameter.ParameterNameColumn.ToString();
            cb.SelectedIndex = -1;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO
            //CultureInfo twCulture = new CultureInfo("zh-tw");
            //twCulture.DateTimeFormat.Calendar = new System.Globalization.TaiwanCalendar();
            //System.Threading.Thread.CurrentThread.CurrentCulture = twCulture;
            //System.Threading.Thread.CurrentThread.CurrentUICulture = twCulture;

            this.appUserTableAdapter.Fill(this.gxxfDataSet.AppUser);
            this.parameterTableAdapter.Fill(this.gxxfDataSet.Parameter);

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

            cbQueryIfCarry.SelectedIndex = 0;
            ckQueryIfCarry.Checked = false;
            cbQueryIfPayoff.SelectedIndex = 0;
            ckQueryIfPayoff.Checked = false;

            init = true;
        }


        private String DateToStr(DateTime d) {
            return String.Format("{0:000}-{1:00}-{2:00}", d.Year - 1911, d.Month, d.Day);
        }
        private String DrGetStr(DataRow dr, DataColumn c) {
            if (dr == null)
                return "";
            Object o = dr[c];
            return o == null || (o is System.DBNull) ? "" : o.ToString();
        }
        private bool DrSet(DataRow dr, DataColumn c, String s) {
            if (dr == null)
                return false;
            if (s != null)
                s = s.Trim();
            if (dr[c] is DBNull && (s == null || s.Length == 0))
                return false;
            if (dr[c].Equals(s))
                return false;
            dr[c] = s;
            return true;
        }
        private int DrGetInt(DataRow dr, DataColumn c) {
            if (dr == null)
                return 0;
            Object o = dr[c];
            if (o == null || (o is System.DBNull))
                return 0;
            String s = o.ToString();
            if (s.Length == 0)
                return 0;
            if (s.Equals("Y") || s.Equals("y"))
                return 1;
            if (s.Equals("N") || s.Equals("n"))
                return 0;
            try {
                return Int32.Parse(s);
            } catch (Exception e) {
                return 0;
            }
        }
        private bool DrSet(DataRow dr, DataColumn c, int i) {
            if (dr == null)
                return false;
            if (dr[c].Equals(i.ToString()))
                return false;
            dr[c] = i;
            return true;
        }
        private void DrGetDate(DataRow dr, DataColumn c, DateTimePicker dtp, CheckBox ck) {
            string pattern = "^(\\d{1,})-(\\d{1,})-(\\d{1,})$";

            bool check = false;
            DateTime dt = DateTime.Today;

            if (dr != null) {
                Object o = dr[c];
                if (o != null && !(o is System.DBNull)) {
                    String s = o.ToString();
                    Match m = Regex.Match(s, pattern);
                    if (m.Success) {
                        int y = Int32.Parse(m.Groups[1].Value) + 1911;
                        int mm = Int32.Parse(m.Groups[2].Value);
                        int d = Int32.Parse(m.Groups[3].Value);
                        check = true;
                        dt = new DateTime(y, mm, d);
                    }
                }
            }
            ck.Checked = check;
            dtp.Value = dt;
        }
        private bool DrSet(DataRow dr, DataColumn c, DateTimePicker dtp, CheckBox ck) {
            if (dr == null)
                return false;

            String val;
            if (ck.Checked) {
                DateTime d = dtp.Value;
                val = DateToStr(dtp.Value);
            } else {
                val = "";
            }
            return DrSet(dr, c, val);
        }

        // Login
        private void btnLogin_Click(object sender, EventArgs e) {
            if (!tbPassword.Text.Equals(superuserpass)) {
                DataRow[] rows = gxxfDataSet.AppUser.Select("UserName = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'");
                if (rows.Length == 0) {
                    MessageBox.Show("登入失敗!! 帳號或密碼錯誤");
                }
            }

            Cursor.Current = Cursors.WaitCursor;
            this.customerBindingSource.Filter = "1 <> 1";
            this.customerTableAdapter.Fill(this.gxxfDataSet.Customer);
            this.ticketBindingSource.Filter = "1 <> 1";
            this.ticketTableAdapter.Fill(this.gxxfDataSet.Ticket);
            this.ticketTrousersBindingSource.Filter = "1 <> 1";
            this.ticketTrousersTableAdapter.Fill(this.gxxfDataSet.TicketTrousers);
            this.ticketJacketBindingSource.Filter = "1 <> 1";
            this.ticketJacketTableAdapter.Fill(this.gxxfDataSet.TicketJacket);
            Cursor.Current = Cursors.Default;

            username = tbUsername.Text;
            password = tbPassword.Text;
            tabMain.Visible = true;
            panelDetail.Visible = true;
            panelLogin.Visible = false;
        }

        // tab switch
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabMain.SelectedIndex == 0) {
                mode = 0;
                lbCustomers.Parent = tabPage1;
                ticketDataGridView.Parent = tabPage1;
                customerBindingSource_CurrentChanged(sender, e);
            } else if (tabMain.SelectedIndex == 1) {
                mode = 1;
                lbCustomers.Parent = tabPage2;
                ticketDataGridView.Parent = tabPage2;
                ticketBindingSource_CurrentChanged(sender, e);
            } else if (tabMain.SelectedIndex == 2) {
                mode = 2;
                ticketDataGridView.Parent = tabPage5;
            }
        }

        // Customer
        private void customerQuery() {
            String q = this.tbQueryCustomer.Text;
            this.customerBindingSource.Filter =
                "CustomerCode LIKE '" + q + "%' OR CustomerName LIKE '%" + q + "%' OR Telephone LIKE '" + q + "%' OR IDCard LIKE '" + q + "%'";
            this.customerBindingSource.Sort = "CustomerName";
        }

        private void tbQueryCustomer_TextChanged(object sender, EventArgs e) {
            customerQuery();
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
        private void ticketDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (mode == 2)
                return;

            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            if (drv == null)
                return;

            int cid = Int32.Parse(DrGetStr(drv.Row, this.gxxfDataSet.Ticket.CustomerIdColumn));
            DataRow r = gxxfDataSet.Customer.FindBycustomerid(cid);
            if (r == null)
                return;
            String cname = DrGetStr(r, this.gxxfDataSet.Customer.CustomerNameColumn);
            ListItem newItem = new ListItem(cid.ToString(), cname);
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




        private void customerBindingSource_CurrentChanged(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;
            tbCustomerCode.Text = DrGetStr(dr, this.gxxfDataSet.Customer.CustomerCodeColumn);
            tbCustomerName.Text = DrGetStr(dr, this.gxxfDataSet.Customer.CustomerNameColumn);
            tbIDCard.Text = DrGetStr(dr, this.gxxfDataSet.Customer.IDCardColumn);
            cbSex.SelectedIndex = DrGetInt(dr, this.gxxfDataSet.Customer.SexColumn) - 1;
            DrGetDate(dr, this.gxxfDataSet.Customer.BirthdayColumn, dtpBirthday, ckBirthday);
            tbTelephone.Text = DrGetStr(dr, this.gxxfDataSet.Customer.TelephoneColumn);
            tbAddress.Text = DrGetStr(dr, this.gxxfDataSet.Customer.addressgColumn);
            tbCompanyName.Text = DrGetStr(dr, this.gxxfDataSet.Customer.CompanyNameColumn);
            tbCompanyTelephone.Text = DrGetStr(dr, this.gxxfDataSet.Customer.CompanyTelephoneColumn);
            tbCompanyAddress.Text = DrGetStr(dr, this.gxxfDataSet.Customer.CompanyAddressColumn);

            if (mode == 0) {
                if (drv == null) {
                    this.ticketBindingSource.Filter = "1 <> 1";
                } else {
                    this.ticketBindingSource.Filter = "customerid = " + DrGetStr(dr, this.gxxfDataSet.Customer.customeridColumn);
                    this.ticketBindingSource.Sort = "OrderDate DESC";
                }
            }
        }

        private void ticketBindingSource_CurrentChanged(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;

            tbTicketCode.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.TicketCodeColumn);
            DrGetDate(dr, gxxfDataSet.Ticket.OrderDateColumn, dtpOrderDate, ckOrderDate);
            DrGetDate(dr, gxxfDataSet.Ticket.PlanDateColumn, dtpPlanDate, ckPlanDate);
            DrGetDate(dr, gxxfDataSet.Ticket.CarryDateColumn, dtpCarryDate, ckCarryDate);
            cbIfCarry.SelectedIndex = DrGetInt(dr, this.gxxfDataSet.Ticket.IfCarryColumn);
            tbTotalPrice.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.TotalPriceColumn);
            tbEarnest.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.EarnestColumn);
            tbAccountReceived.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.AccountReceivedColumn);
            cbIfPayoff.SelectedIndex = DrGetInt(dr, this.gxxfDataSet.Ticket.IfPayoffColumn);
            tbTicketCompanyName.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.CompanyNameColumn);
            tbTicketCompanyTelephone.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.CompanyTelephoneColumn);
            tbTicketCompanyAddress.Text = DrGetStr(dr, this.gxxfDataSet.Ticket.CompanyAddressColumn);
            String remark = DrGetStr(dr, this.gxxfDataSet.Ticket.RemarkColumn);
            if (remark == null || remark.Length == 0) {
                btnRemark.Enabled = false;
                tbRemark.Text = remark;
                tbRemark.ReadOnly = false;
                tbRemark.UseSystemPasswordChar = false;
            } else {
                btnRemark.Enabled = true;
                tbRemark.ReadOnly = true;
                tbRemark.UseSystemPasswordChar = true;
                tbRemark.Text = remark;
            }

            if (drv == null) {
                this.ticketJacketBindingSource.Filter = "1 <> 1";
                this.ticketTrousersBindingSource.Filter = "1 <> 1";
            } else {
                String tid = DrGetStr(dr, this.gxxfDataSet.Ticket.TicketIdColumn);
                this.ticketJacketBindingSource.Filter = "TicketId = " + tid;
                this.ticketTrousersBindingSource.Filter = "TicketId = " + tid;
            }

            if (mode == 1 || mode == 2) {
                if (drv == null) {
                    this.customerBindingSource.Filter = "1 <> 1";
                } else {
                    this.customerBindingSource.Filter = "customerid = " + DrGetStr(dr, this.gxxfDataSet.Ticket.CustomerIdColumn);
                }
            }
        }

        private void btnRemark_Click(object sender, EventArgs e) {
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
                return;
            }

            tbRemark.ReadOnly = false;
            tbRemark.UseSystemPasswordChar = false;
            btnRemark.Enabled = false;
        }

        private void ticketJacketBindingSource_CurrentChanged(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)ticketJacketBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;

            cbIfWashing.SelectedIndex = DrGetInt(dr, this.gxxfDataSet.TicketJacket.IfWashingColumn);
            tbJianKuan.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.JianKuanColumn);
            cbJianKuanP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.JianKuanPColumn);
            tbShangWei.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.ShangWeiColumn);
            cbShangWeiP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.ShangWeiPColumn);
            tbXiaWei.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.XiaWeiColumn);
            cbXiaWeiP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.XiaWeiPColumn);
            tbXiuChang.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.XiuChangColumn);
            cbXiuChangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.XiuChangPColumn);
            tbXiuKou.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.XiuKouColumn);
            cbXiuKouP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.XiuKouPColumn);
            tbQianXiong.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.QianXiongColumn);
            cbQianXiongP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.QianXiongPColumn);
            tbHouBei.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.HouBeiColumn);
            cbHouBeiP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.HouBeiPColumn);
            tbShenChang.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.ShenChangColumn);
            cbShenChangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.ShenChangPColumn);
            tbBeiChang.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.BeiChangColumn);
            cbBeiChangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.BeiChangPColumn);
            tbBeiXin.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.BeiXinColumn);
            cbBeiXinP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.BeiXinPColumn);
            tbLingKou.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.LingKouColumn);
            cbLingKouP.Text = DrGetStr(dr, this.gxxfDataSet.TicketJacket.LingKouPColumn);
        }

        private void ticketTrousersbindingSource_CurrentChanged(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)ticketTrousersBindingSource.Current;
            DataRow dr = (drv == null) ? null : drv.Row;

            cbKuIfWashing.SelectedIndex = DrGetInt(dr, this.gxxfDataSet.TicketTrousers.IfWashingColumn);
            tbKuYao.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KuYaoColumn);
            cbKuYaoP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KuYaoPColumn);
            tbKuXiaWei.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.XiaWeiColumn);
            cbKuXiaWeiP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.XiaWeiPColumn);
            tbKuChang.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KuChangColumn);
            cbKuChangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KuChangPColumn);
            tbZhongChang.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.ZhongChangColumn);
            cbZhongChangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.ZhongChangPColumn);
            tbShangDang.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.ShangDangColumn);
            cbShangDangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.ShangDangPColumn);
            tbKaiDang.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KaiDangColumn);
            cbKaiDangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KaiDangPColumn);
            tbZhongDang.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.ZhongDangColumn);
            cbZhongDangP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.ZhongDangPColumn);
            tbKuKou.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KuKouColumn);
            cbKuKouP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KuKouPColumn);
            tbKouZi.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KouZiColumn);
            cbKouZiP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.KouZiPColumn);
            tbLaLian.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.LaLianColumn);
            cbLaLianP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.LaLianPColumn);
            tbYaoDai.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.YaoDaiColumn);
            cbYaoDaiP.Text = DrGetStr(dr, this.gxxfDataSet.TicketTrousers.YaoDaiPColumn);
        }

        private void btnCustomerNew_Click(object sender, EventArgs e) {
            String cid = null;
            DataRow[] rows = gxxfDataSet.Customer.Select("CustomerName = '<新增顧客>'");
            if (rows.Length > 0) {
                cid = DrGetStr(rows[0], gxxfDataSet.Customer.customeridColumn);
            } else {
                DataRow dr = gxxfDataSet.Customer.AddCustomerRow("", "<新增顧客>", null, "1", null, null, null, null, null, null);
                if (customerTableAdapter.Update(dr) > 0) {
                    cid = DrGetStr(dr, gxxfDataSet.Customer.customeridColumn);
                }
                MessageBox.Show("新增成功");
            }
            if (cid != null) {
                customerBindingSource.Filter = "customerid = '" + cid + "'";
                return;
            }
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            if (drv == null) {
                MessageBox.Show("無選定顧客，無法刪除");
                return;
            }

            drv.Delete();
            if (customerTableAdapter.Update(drv.Row) > 0) {
                MessageBox.Show("刪除成功");
            }
        }
        private void btnCustomerUpdate_Click(object sender, EventArgs e) {
            bool needUpdate = false;
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            if (drv == null) {
                MessageBox.Show("無選定顧客，無法儲存");
                return;
            }
            DataRow dr = drv.Row;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CustomerCodeColumn, tbCustomerCode.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CustomerNameColumn, tbCustomerName.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.IDCardColumn, tbIDCard.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.SexColumn, cbSex.SelectedIndex + 1) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.BirthdayColumn, dtpBirthday, ckBirthday) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.TelephoneColumn, tbTelephone.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.addressgColumn, tbAddress.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CompanyNameColumn, tbCompanyName.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CompanyTelephoneColumn, tbCompanyTelephone.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Customer.CompanyAddressColumn, tbCompanyAddress.Text) | needUpdate;
            if (needUpdate)
                this.customerTableAdapter.Update(this.gxxfDataSet.Customer);
            MessageBox.Show("已儲存");
        }

        private void btnTicketNew_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)customerBindingSource.Current;
            if (drv == null) {
                MessageBox.Show("無選定顧客，無法新增訂單");
                return;
            }
            int cid = Int32.Parse(DrGetStr(drv.Row, gxxfDataSet.Customer.customeridColumn));
            String tid = null;

            DataRow[] rows = gxxfDataSet.Ticket.Select("TotalPrice = '<新增訂單>' AND CustomerId = '" + cid + "'");
            if (rows.Length != 0) {
                tid = DrGetStr(rows[0], this.gxxfDataSet.Ticket.TicketIdColumn);
            } else {
                DataRow dr = gxxfDataSet.Ticket.AddTicketRow("", cid, DateToStr(DateTime.Now), "", "", "<新增訂單>", "0", "0", "0", "0", null, 1, null, 1, null, null, null, null);
                if (ticketTableAdapter.Update(dr) > 0) {
                    tid = DrGetStr(dr, this.gxxfDataSet.Ticket.TicketIdColumn);

                    dr = gxxfDataSet.TicketJacket.AddTicketJacketRow(Int32.Parse(tid), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                    ticketJacketTableAdapter.Update(dr);
                    dr = gxxfDataSet.TicketTrousers.AddTicketTrousersRow(Int32.Parse(tid), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                    ticketTrousersTableAdapter.Update(dr);
                }
                MessageBox.Show("新增成功");
            }
            if (tid != null) {
                if (mode == 0) {
                    customerBindingSource.Filter = "customerid = '" + cid + "'";
                }
                ticketBindingSource.Filter = "TicketId = '" + tid + "'";
                return;
            }
        }

        private void btnTicketDelete_Click(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            if (drv == null) {
                MessageBox.Show("無選定訂單，無法刪除");
                return;
            }

            String tid = DrGetStr(drv.Row, this.gxxfDataSet.Ticket.TicketIdColumn);
            drv.Row.Delete();
            if (ticketTableAdapter.Update(drv.Row) > 0) {
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

                MessageBox.Show("刪除成功");
            }
        }

        private void btnTicketUpdate_Click(object sender, EventArgs e) {
            bool needUpdate = false;
            DataRowView drv = (DataRowView)ticketBindingSource.Current;
            if (drv == null) {
                MessageBox.Show("無選定訂單，無法儲存");
                return;
            }
            DataRow dr = drv.Row;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.TicketCodeColumn, tbTicketCode.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.OrderDateColumn, dtpOrderDate, ckOrderDate) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.PlanDateColumn, dtpPlanDate, ckPlanDate) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CarryDateColumn, dtpCarryDate, ckCarryDate) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.IfCarryColumn, cbIfCarry.SelectedIndex) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.TotalPriceColumn, tbTotalPrice.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.EarnestColumn, tbEarnest.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.AccountReceivedColumn, tbAccountReceived.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.IfPayoffColumn, cbIfPayoff.SelectedIndex) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CompanyNameColumn, tbTicketCompanyName.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CompanyTelephoneColumn, tbTicketCompanyTelephone.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.CompanyAddressColumn, tbTicketCompanyAddress.Text) | needUpdate;
            needUpdate = DrSet(dr, gxxfDataSet.Ticket.RemarkColumn, tbRemark.Text) | needUpdate;
            if (needUpdate)
                this.ticketTableAdapter.Update(this.gxxfDataSet.Ticket);

            needUpdate = false;
            drv = (DataRowView)ticketJacketBindingSource.Current;
            dr = (drv == null) ? null : drv.Row;
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
            if (needUpdate)
                this.ticketJacketTableAdapter.Update(this.gxxfDataSet.TicketJacket);

            needUpdate = false;
            drv = (DataRowView)ticketTrousersBindingSource.Current;
            dr = (drv == null) ? null : drv.Row;
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
            if (needUpdate)
                this.ticketTrousersTableAdapter.Update(this.gxxfDataSet.TicketTrousers);
            MessageBox.Show("已儲存");
        }

        private void ticketQuery() {
            if (!init)
                return;

            String filter = "";
            if (ckQueryOrderDate.Checked) {
                filter = "OrderDate >= '" + DateToStr(dtpQueryOrderDate1.Value) + "' AND OrderDate <= '" + DateToStr(dtpQueryOrderDate2.Value) + "'";
            }
            if (ckQueryPlanDate.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "PlanDate >= '" + DateToStr(dtpQueryPlanDate1.Value) + "' AND PlanDate <= '" + DateToStr(dtpQueryPlanDate2.Value) + "'";
            }
            if (ckQueryIfCarry.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "IfCarry = " + cbQueryIfCarry.SelectedIndex;
            }
            if (ckQueryIfPayoff.Checked) {
                if (filter.Length > 0)
                    filter += " AND ";
                filter += "IfPayoff = " + cbQueryIfPayoff.SelectedIndex;
            }

            if (filter.Length == 0)
                filter = "1 <> 1";
            ticketBindingSource.Filter = filter;
            ticketBindingSource.Sort = "OrderDate DESC";
        }

        private void dtpQueryOrderDate1_ValueChanged(object sender, EventArgs e) {
            if (dtpQueryOrderDate1.Value > dtpQueryOrderDate2.Value) {
                dtpQueryOrderDate2.Value = dtpQueryOrderDate1.Value;
            }
            ckQueryOrderDate.Checked = true;
            ticketQuery();
        }

        private void dtpQueryOrderDate2_ValueChanged(object sender, EventArgs e) {
            if (dtpQueryOrderDate1.Value > dtpQueryOrderDate2.Value) {
                dtpQueryOrderDate1.Value = dtpQueryOrderDate2.Value;
            }
            ckQueryOrderDate.Checked = true;
            ticketQuery();
        }

        private void dtpQueryPlanDate1_ValueChanged(object sender, EventArgs e) {
            if (dtpQueryPlanDate1.Value > dtpQueryPlanDate2.Value) {
                dtpQueryPlanDate2.Value = dtpQueryPlanDate1.Value;
            }
            ckQueryPlanDate.Checked = true;
            ticketQuery();
        }

        private void dtpQueryPlanDate2_ValueChanged(object sender, EventArgs e) {
            if (dtpQueryPlanDate1.Value > dtpQueryPlanDate2.Value) {
                dtpQueryPlanDate1.Value = dtpQueryPlanDate2.Value;
            }
            ckQueryPlanDate.Checked = true;
            ticketQuery();
        }

        private void cbQueryIfCarry_SelectedIndexChanged(object sender, EventArgs e) {
            ckQueryIfCarry.Checked = true;
            ticketQuery();
        }

        private void cbQueryIfPayoff_SelectedIndexChanged(object sender, EventArgs e) {
            ckQueryIfPayoff.Checked = true;
            ticketQuery();
        }

        private void ckQueryOrderDate_CheckedChanged(object sender, EventArgs e) {
            ticketQuery();
        }
        private void ckQueryPlanDate_CheckedChanged(object sender, EventArgs e) {
            ticketQuery();
        }
        private void ckQueryIfCarry_CheckedChanged(object sender, EventArgs e) {
            ticketQuery();
        }

        private void ckQueryIfPayoff_CheckedChanged(object sender, EventArgs e) {
            ticketQuery();
        }

        private void ckBirthday_CheckedChanged(object sender, EventArgs e) {
            dtpBirthday.Enabled = ckBirthday.Checked;
        }
        private void ckOrderDate_CheckedChanged(object sender, EventArgs e) {
            dtpOrderDate.Enabled = ckOrderDate.Checked;
        }
        private void ckPlanDate_CheckedChanged(object sender, EventArgs e) {
            dtpPlanDate.Enabled = ckPlanDate.Checked;
        }
        private void ckCarryDate_CheckedChanged(object sender, EventArgs e) {
            dtpCarryDate.Enabled = ckCarryDate.Checked;
        }


        // Report
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

        private void reportBindingSource_CurrentChanged(object sender, EventArgs e) {
            Report r = (Report)reportBindingSource.Current;
            if (r == null)
                return;

            try {
                ticketBindingSource.Filter = "OrderDate LIKE '" + r.OrderDate + "%'";
                ticketBindingSource.Sort = "OrderDate";
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }

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
}


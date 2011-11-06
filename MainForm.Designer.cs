namespace gxxf
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gxxfDataSet = new gxxf.gxxfDataSet();
            this.ticketJacketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTrousersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.label43 = new System.Windows.Forms.Label();
            this.dgvCustomerTicket = new System.Windows.Forms.DataGridView();
            this.TicketCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbQueryCustomer = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReportPrint = new System.Windows.Forms.Button();
            this.dgvQueryTicket = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryCompanyName = new System.Windows.Forms.ComboBox();
            this.queryIfPayoff2 = new System.Windows.Forms.CheckBox();
            this.queryIfCarry2 = new System.Windows.Forms.CheckBox();
            this.queryIfPayoff1 = new System.Windows.Forms.CheckBox();
            this.queryIfCarry1 = new System.Windows.Forms.CheckBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.queryOrderDate2 = new System.Windows.Forms.MaskedTextBox();
            this.queryCarryDate2 = new System.Windows.Forms.MaskedTextBox();
            this.queryPlanDate2 = new System.Windows.Forms.MaskedTextBox();
            this.queryCarryDate1 = new System.Windows.Forms.MaskedTextBox();
            this.queryPlanDate1 = new System.Windows.Forms.MaskedTextBox();
            this.queryOrderDate1 = new System.Windows.Forms.MaskedTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvQueryReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateReport = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnParameterDelete = new System.Windows.Forms.Button();
            this.btnParameterUpdate = new System.Windows.Forms.Button();
            this.btnParameterNew = new System.Windows.Forms.Button();
            this.dgvParameter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new gxxf.gxxfDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new gxxf.gxxfDataSetTableAdapters.TableAdapterManager();
            this.ticketTableAdapter = new gxxf.gxxfDataSetTableAdapters.TicketTableAdapter();
            this.ticketJacketTableAdapter = new gxxf.gxxfDataSetTableAdapters.TicketJacketTableAdapter();
            this.ticketTrousersTableAdapter = new gxxf.gxxfDataSetTableAdapters.TicketTrousersTableAdapter();
            this.parameterTableAdapter = new gxxf.gxxfDataSetTableAdapters.ParameterTableAdapter();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbLoginPrompt = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.appUserTableAdapter = new gxxf.gxxfDataSetTableAdapters.AppUserTableAdapter();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.showTicketCode = new System.Windows.Forms.TextBox();
            this.showTicketCompanyTelephone = new System.Windows.Forms.TextBox();
            this.showTicketCompanyName = new System.Windows.Forms.TextBox();
            this.showTotalPrice = new System.Windows.Forms.TextBox();
            this.showEarnest = new System.Windows.Forms.TextBox();
            this.showAccountReceived = new System.Windows.Forms.TextBox();
            this.showBalance = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.showJianKuan = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.showShangWei = new System.Windows.Forms.TextBox();
            this.showXiaWei = new System.Windows.Forms.TextBox();
            this.showXiuChang = new System.Windows.Forms.TextBox();
            this.showXiuKou = new System.Windows.Forms.TextBox();
            this.showQianXiong = new System.Windows.Forms.TextBox();
            this.showHouBei = new System.Windows.Forms.TextBox();
            this.showShenChang = new System.Windows.Forms.TextBox();
            this.showBeiChang = new System.Windows.Forms.TextBox();
            this.showBeiXin = new System.Windows.Forms.TextBox();
            this.showLingKou = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.showOrderDate = new System.Windows.Forms.TextBox();
            this.showPlanDate = new System.Windows.Forms.TextBox();
            this.showCarryDate = new System.Windows.Forms.TextBox();
            this.showJianKuanP = new System.Windows.Forms.TextBox();
            this.showShangWeiP = new System.Windows.Forms.TextBox();
            this.showXiaWeiP = new System.Windows.Forms.TextBox();
            this.showXiuChangP = new System.Windows.Forms.TextBox();
            this.showXiuKouP = new System.Windows.Forms.TextBox();
            this.showQianXiongP = new System.Windows.Forms.TextBox();
            this.showHouBeiP = new System.Windows.Forms.TextBox();
            this.showShenChangP = new System.Windows.Forms.TextBox();
            this.showBeiChangP = new System.Windows.Forms.TextBox();
            this.showBeiXinP = new System.Windows.Forms.TextBox();
            this.showLingKouP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.showYaoDaiP = new System.Windows.Forms.TextBox();
            this.showLaLianP = new System.Windows.Forms.TextBox();
            this.showKouZiP = new System.Windows.Forms.TextBox();
            this.showKuKouP = new System.Windows.Forms.TextBox();
            this.showZhongDangP = new System.Windows.Forms.TextBox();
            this.showKaiDangP = new System.Windows.Forms.TextBox();
            this.showShangDangP = new System.Windows.Forms.TextBox();
            this.showZhongChangP = new System.Windows.Forms.TextBox();
            this.showKuChangP = new System.Windows.Forms.TextBox();
            this.showKuXiaWeiP = new System.Windows.Forms.TextBox();
            this.showKuYaoP = new System.Windows.Forms.TextBox();
            this.showYaoDai = new System.Windows.Forms.TextBox();
            this.showLaLian = new System.Windows.Forms.TextBox();
            this.showKouZi = new System.Windows.Forms.TextBox();
            this.showKuKou = new System.Windows.Forms.TextBox();
            this.showZhongDang = new System.Windows.Forms.TextBox();
            this.showKaiDang = new System.Windows.Forms.TextBox();
            this.showShangDang = new System.Windows.Forms.TextBox();
            this.showZhongChang = new System.Windows.Forms.TextBox();
            this.showKuChang = new System.Windows.Forms.TextBox();
            this.showKuYao = new System.Windows.Forms.TextBox();
            this.showKuXiaWei = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.showTicketCompanyAddress = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.showIfCarry = new System.Windows.Forms.TextBox();
            this.showIfPayoff = new System.Windows.Forms.TextBox();
            this.showRemark = new System.Windows.Forms.TextBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnEditCommit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbIfPayoff2 = new System.Windows.Forms.RadioButton();
            this.rbIfPayoff1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbIfCarry2 = new System.Windows.Forms.RadioButton();
            this.rbIfCarry1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSex1 = new System.Windows.Forms.RadioButton();
            this.rbSex2 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.mtbCarryDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbPlanDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbBirthday = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbKuXiaWeiP = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tbJianKuan = new System.Windows.Forms.TextBox();
            this.cbLingKouP = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbShangWei = new System.Windows.Forms.TextBox();
            this.tbXiaWei = new System.Windows.Forms.TextBox();
            this.tbXiuChang = new System.Windows.Forms.TextBox();
            this.tbXiuKou = new System.Windows.Forms.TextBox();
            this.tbQianXiong = new System.Windows.Forms.TextBox();
            this.tbHouBei = new System.Windows.Forms.TextBox();
            this.tbShenChang = new System.Windows.Forms.TextBox();
            this.tbBeiChang = new System.Windows.Forms.TextBox();
            this.tbBeiXin = new System.Windows.Forms.TextBox();
            this.tbLingKou = new System.Windows.Forms.TextBox();
            this.cbBeiXinP = new System.Windows.Forms.ComboBox();
            this.cbBeiChangP = new System.Windows.Forms.ComboBox();
            this.cbShenChangP = new System.Windows.Forms.ComboBox();
            this.cbHouBeiP = new System.Windows.Forms.ComboBox();
            this.cbQianXiongP = new System.Windows.Forms.ComboBox();
            this.cbXiuKouP = new System.Windows.Forms.ComboBox();
            this.cbXiuChangP = new System.Windows.Forms.ComboBox();
            this.cbLaLianP = new System.Windows.Forms.ComboBox();
            this.cbKuYaoP = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbXiaWeiP = new System.Windows.Forms.ComboBox();
            this.cbKuKouP = new System.Windows.Forms.ComboBox();
            this.cbShangWeiP = new System.Windows.Forms.ComboBox();
            this.cbZhongDangP = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.cbKaiDangP = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.cbZhongChangP = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cbKuChangP = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbKuYao = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbYaoDai = new System.Windows.Forms.TextBox();
            this.tbKuXiaWei = new System.Windows.Forms.TextBox();
            this.tbKuChang = new System.Windows.Forms.TextBox();
            this.tbLaLian = new System.Windows.Forms.TextBox();
            this.tbZhongChang = new System.Windows.Forms.TextBox();
            this.tbKouZi = new System.Windows.Forms.TextBox();
            this.tbShangDang = new System.Windows.Forms.TextBox();
            this.tbKuKou = new System.Windows.Forms.TextBox();
            this.tbKaiDang = new System.Windows.Forms.TextBox();
            this.tbZhongDang = new System.Windows.Forms.TextBox();
            this.cbShangDangP = new System.Windows.Forms.ComboBox();
            this.cbKouZiP = new System.Windows.Forms.ComboBox();
            this.cbYaoDaiP = new System.Windows.Forms.ComboBox();
            this.cbJianKuanP = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCompanyAddress = new System.Windows.Forms.TextBox();
            this.tbCompanyTelephone = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerCode = new System.Windows.Forms.TextBox();
            this.tbIDCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTicketCode = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbTicketCompanyAddress = new System.Windows.Forms.TextBox();
            this.tbTicketCompanyTelephone = new System.Windows.Forms.TextBox();
            this.tbTicketCompanyName = new System.Windows.Forms.TextBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbEarnest = new System.Windows.Forms.TextBox();
            this.tbAccountReceived = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnTicketPrint = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerNew = new System.Windows.Forms.Button();
            this.btnTicketDelete = new System.Windows.Forms.Button();
            this.btnTicketNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.showAddress = new System.Windows.Forms.TextBox();
            this.showCompanyTelephone = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.showSex = new System.Windows.Forms.TextBox();
            this.showBirthday = new System.Windows.Forms.TextBox();
            this.showCustomerCode = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.showTelephone = new System.Windows.Forms.TextBox();
            this.showIDCard = new System.Windows.Forms.TextBox();
            this.showCompanyAddress = new System.Windows.Forms.TextBox();
            this.showCompanyName = new System.Windows.Forms.TextBox();
            this.showCustomerName = new System.Windows.Forms.TextBox();
            this.rvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gxxfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketJacketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTrousersBindingSource)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryTicket)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterBindingSource)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.gxxfDataSet;
            this.ticketBindingSource.CurrentChanged += new System.EventHandler(this.ticketBindingSource_CurrentChanged);
            // 
            // gxxfDataSet
            // 
            this.gxxfDataSet.DataSetName = "gxxfDataSet";
            this.gxxfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketJacketBindingSource
            // 
            this.ticketJacketBindingSource.DataMember = "TicketJacket";
            this.ticketJacketBindingSource.DataSource = this.gxxfDataSet;
            this.ticketJacketBindingSource.CurrentChanged += new System.EventHandler(this.ticketJacketBindingSource_CurrentChanged);
            // 
            // ticketTrousersBindingSource
            // 
            this.ticketTrousersBindingSource.DataMember = "TicketTrousers";
            this.ticketTrousersBindingSource.DataSource = this.gxxfDataSet;
            this.ticketTrousersBindingSource.CurrentChanged += new System.EventHandler(this.ticketTrousersbindingSource_CurrentChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage5);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Location = new System.Drawing.Point(6, 5);
            this.tabMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(589, 986);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabStop = false;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.lbCustomers);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.dgvCustomerTicket);
            this.tabPage1.Controls.Add(this.customerDataGridView);
            this.tabPage1.Controls.Add(this.tbQueryCustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(581, 949);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客戶查詢";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbCustomers
            // 
            this.lbCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 24;
            this.lbCustomers.Location = new System.Drawing.Point(6, 5);
            this.lbCustomers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(100, 936);
            this.lbCustomers.TabIndex = 1;
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.lbCustomers_SelectedIndexChanged);
            this.lbCustomers.DoubleClick += new System.EventHandler(this.lbCustomers_DoubleClick);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(109, 10);
            this.label43.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(48, 24);
            this.label43.TabIndex = 31;
            this.label43.Text = "查詢";
            // 
            // dgvCustomerTicket
            // 
            this.dgvCustomerTicket.AllowUserToAddRows = false;
            this.dgvCustomerTicket.AllowUserToDeleteRows = false;
            this.dgvCustomerTicket.AllowUserToResizeRows = false;
            this.dgvCustomerTicket.AutoGenerateColumns = false;
            this.dgvCustomerTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketCode,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.CarryDate,
            this.dataGridViewTextBoxColumn11,
            this.Earnest,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgvCustomerTicket.DataSource = this.ticketBindingSource;
            this.dgvCustomerTicket.Location = new System.Drawing.Point(111, 434);
            this.dgvCustomerTicket.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvCustomerTicket.MultiSelect = false;
            this.dgvCustomerTicket.Name = "dgvCustomerTicket";
            this.dgvCustomerTicket.ReadOnly = true;
            this.dgvCustomerTicket.RowHeadersVisible = false;
            this.dgvCustomerTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerTicket.ShowCellToolTips = false;
            this.dgvCustomerTicket.Size = new System.Drawing.Size(463, 511);
            this.dgvCustomerTicket.TabIndex = 2;
            this.dgvCustomerTicket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTicket_CellDoubleClick);
            // 
            // TicketCode
            // 
            this.TicketCode.DataPropertyName = "TicketCode";
            this.TicketCode.HeaderText = "編號";
            this.TicketCode.Name = "TicketCode";
            this.TicketCode.ReadOnly = true;
            this.TicketCode.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "訂購日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlanDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "預交日期";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 110;
            // 
            // CarryDate
            // 
            this.CarryDate.DataPropertyName = "CarryDate";
            this.CarryDate.HeaderText = "取件日期";
            this.CarryDate.Name = "CarryDate";
            this.CarryDate.ReadOnly = true;
            this.CarryDate.Width = 110;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn11.HeaderText = "總價";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 70;
            // 
            // Earnest
            // 
            this.Earnest.DataPropertyName = "Earnest";
            this.Earnest.HeaderText = "訂金";
            this.Earnest.Name = "Earnest";
            this.Earnest.ReadOnly = true;
            this.Earnest.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "IfCarry";
            this.dataGridViewTextBoxColumn14.HeaderText = "取件";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 30;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IfPayoff";
            this.dataGridViewTextBoxColumn15.HeaderText = "付清";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 30;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.Birthday,
            this.dataGridViewTextBoxColumn4});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(111, 44);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.ShowCellToolTips = false;
            this.customerDataGridView.Size = new System.Drawing.Size(463, 382);
            this.customerDataGridView.TabIndex = 1;
            this.customerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "編號";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn7.HeaderText = "電話";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "生日";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDCard";
            this.dataGridViewTextBoxColumn4.HeaderText = "身分字號";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.gxxfDataSet;
            this.customerBindingSource.CurrentChanged += new System.EventHandler(this.customerBindingSource_CurrentChanged);
            // 
            // tbQueryCustomer
            // 
            this.tbQueryCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQueryCustomer.Location = new System.Drawing.Point(163, 10);
            this.tbQueryCustomer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbQueryCustomer.Name = "tbQueryCustomer";
            this.tbQueryCustomer.Size = new System.Drawing.Size(411, 25);
            this.tbQueryCustomer.TabIndex = 0;
            this.tbQueryCustomer.TextChanged += new System.EventHandler(this.tbQueryCustomer_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReportPrint);
            this.tabPage2.Controls.Add(this.dgvQueryTicket);
            this.tabPage2.Controls.Add(this.queryCompanyName);
            this.tabPage2.Controls.Add(this.queryIfPayoff2);
            this.tabPage2.Controls.Add(this.queryIfCarry2);
            this.tabPage2.Controls.Add(this.queryIfPayoff1);
            this.tabPage2.Controls.Add(this.queryIfCarry1);
            this.tabPage2.Controls.Add(this.label92);
            this.tabPage2.Controls.Add(this.label91);
            this.tabPage2.Controls.Add(this.label93);
            this.tabPage2.Controls.Add(this.label90);
            this.tabPage2.Controls.Add(this.queryOrderDate2);
            this.tabPage2.Controls.Add(this.queryCarryDate2);
            this.tabPage2.Controls.Add(this.queryPlanDate2);
            this.tabPage2.Controls.Add(this.queryCarryDate1);
            this.tabPage2.Controls.Add(this.queryPlanDate1);
            this.tabPage2.Controls.Add(this.queryOrderDate1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(581, 949);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "訂單查詢";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.AutoSize = true;
            this.btnReportPrint.Location = new System.Drawing.Point(479, 177);
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.Size = new System.Drawing.Size(93, 34);
            this.btnReportPrint.TabIndex = 12;
            this.btnReportPrint.Text = "列印";
            this.btnReportPrint.UseVisualStyleBackColor = true;
            this.btnReportPrint.Click += new System.EventHandler(this.btnReportPrint_Click);
            // 
            // dgvQueryTicket
            // 
            this.dgvQueryTicket.AllowUserToAddRows = false;
            this.dgvQueryTicket.AllowUserToDeleteRows = false;
            this.dgvQueryTicket.AllowUserToResizeRows = false;
            this.dgvQueryTicket.AutoGenerateColumns = false;
            this.dgvQueryTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.dgvQueryTicket.DataSource = this.ticketBindingSource;
            this.dgvQueryTicket.Location = new System.Drawing.Point(0, 219);
            this.dgvQueryTicket.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvQueryTicket.MultiSelect = false;
            this.dgvQueryTicket.Name = "dgvQueryTicket";
            this.dgvQueryTicket.ReadOnly = true;
            this.dgvQueryTicket.RowHeadersVisible = false;
            this.dgvQueryTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryTicket.ShowCellToolTips = false;
            this.dgvQueryTicket.Size = new System.Drawing.Size(578, 730);
            this.dgvQueryTicket.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TicketCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "編號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn5.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "訂購日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PlanDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "預交日期";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 110;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CarryDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "取件日期";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 110;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn16.HeaderText = "總價";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 70;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Earnest";
            this.dataGridViewTextBoxColumn17.HeaderText = "訂金";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 70;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "IfCarry";
            this.dataGridViewTextBoxColumn18.HeaderText = "取件";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 30;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "IfPayoff";
            this.dataGridViewTextBoxColumn19.HeaderText = "付清";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 30;
            // 
            // queryCompanyName
            // 
            this.queryCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryCompanyName.FormattingEnabled = true;
            this.queryCompanyName.Location = new System.Drawing.Point(102, 9);
            this.queryCompanyName.Name = "queryCompanyName";
            this.queryCompanyName.Size = new System.Drawing.Size(242, 32);
            this.queryCompanyName.TabIndex = 0;
            this.queryCompanyName.SelectedIndexChanged += new System.EventHandler(this.queryCompanyName_SelectedIndexChanged);
            this.queryCompanyName.Enter += new System.EventHandler(this.edit_Enter);
            this.queryCompanyName.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // queryIfPayoff2
            // 
            this.queryIfPayoff2.Location = new System.Drawing.Point(236, 176);
            this.queryIfPayoff2.Name = "queryIfPayoff2";
            this.queryIfPayoff2.Size = new System.Drawing.Size(108, 25);
            this.queryIfPayoff2.TabIndex = 10;
            this.queryIfPayoff2.Text = "已付清";
            this.queryIfPayoff2.UseVisualStyleBackColor = true;
            this.queryIfPayoff2.CheckedChanged += new System.EventHandler(this.query_CheckedChanged);
            // 
            // queryIfCarry2
            // 
            this.queryIfCarry2.Location = new System.Drawing.Point(236, 150);
            this.queryIfCarry2.Name = "queryIfCarry2";
            this.queryIfCarry2.Size = new System.Drawing.Size(108, 25);
            this.queryIfCarry2.TabIndex = 8;
            this.queryIfCarry2.Text = "已取件";
            this.queryIfCarry2.UseVisualStyleBackColor = true;
            this.queryIfCarry2.CheckedChanged += new System.EventHandler(this.query_CheckedChanged);
            // 
            // queryIfPayoff1
            // 
            this.queryIfPayoff1.Location = new System.Drawing.Point(102, 176);
            this.queryIfPayoff1.Name = "queryIfPayoff1";
            this.queryIfPayoff1.Size = new System.Drawing.Size(108, 25);
            this.queryIfPayoff1.TabIndex = 9;
            this.queryIfPayoff1.Text = "未付清";
            this.queryIfPayoff1.UseVisualStyleBackColor = true;
            this.queryIfPayoff1.CheckedChanged += new System.EventHandler(this.query_CheckedChanged);
            // 
            // queryIfCarry1
            // 
            this.queryIfCarry1.Location = new System.Drawing.Point(102, 148);
            this.queryIfCarry1.Name = "queryIfCarry1";
            this.queryIfCarry1.Size = new System.Drawing.Size(108, 25);
            this.queryIfCarry1.TabIndex = 7;
            this.queryIfCarry1.Text = "未取件";
            this.queryIfCarry1.UseVisualStyleBackColor = true;
            this.queryIfCarry1.CheckedChanged += new System.EventHandler(this.query_CheckedChanged);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(8, 107);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(86, 24);
            this.label92.TabIndex = 10;
            this.label92.Text = "取件日期";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(8, 79);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(86, 24);
            this.label91.TabIndex = 10;
            this.label91.Text = "預交日期";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(8, 12);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(86, 24);
            this.label93.TabIndex = 10;
            this.label93.Text = "單位名稱";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(8, 48);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(86, 24);
            this.label90.TabIndex = 10;
            this.label90.Text = "訂購日期";
            // 
            // queryOrderDate2
            // 
            this.queryOrderDate2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryOrderDate2.Location = new System.Drawing.Point(236, 47);
            this.queryOrderDate2.Mask = "900-90-90";
            this.queryOrderDate2.Name = "queryOrderDate2";
            this.queryOrderDate2.Size = new System.Drawing.Size(108, 25);
            this.queryOrderDate2.TabIndex = 2;
            this.queryOrderDate2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.queryOrderDate2.TextChanged += new System.EventHandler(this.queryDate_TextChanged);
            this.queryOrderDate2.Enter += new System.EventHandler(this.edit_Enter);
            this.queryOrderDate2.Validated += new System.EventHandler(this.queryDate_Validated);
            // 
            // queryCarryDate2
            // 
            this.queryCarryDate2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryCarryDate2.Location = new System.Drawing.Point(236, 108);
            this.queryCarryDate2.Mask = "900-90-90";
            this.queryCarryDate2.Name = "queryCarryDate2";
            this.queryCarryDate2.Size = new System.Drawing.Size(108, 25);
            this.queryCarryDate2.TabIndex = 6;
            this.queryCarryDate2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.queryCarryDate2.TextChanged += new System.EventHandler(this.queryDate_TextChanged);
            this.queryCarryDate2.Enter += new System.EventHandler(this.edit_Enter);
            this.queryCarryDate2.Validated += new System.EventHandler(this.queryDate_Validated);
            // 
            // queryPlanDate2
            // 
            this.queryPlanDate2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryPlanDate2.Location = new System.Drawing.Point(236, 78);
            this.queryPlanDate2.Mask = "900-90-90";
            this.queryPlanDate2.Name = "queryPlanDate2";
            this.queryPlanDate2.Size = new System.Drawing.Size(108, 25);
            this.queryPlanDate2.TabIndex = 4;
            this.queryPlanDate2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.queryPlanDate2.TextChanged += new System.EventHandler(this.queryDate_TextChanged);
            this.queryPlanDate2.Enter += new System.EventHandler(this.edit_Enter);
            this.queryPlanDate2.Validated += new System.EventHandler(this.queryDate_Validated);
            // 
            // queryCarryDate1
            // 
            this.queryCarryDate1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryCarryDate1.Location = new System.Drawing.Point(102, 108);
            this.queryCarryDate1.Mask = "900-90-90";
            this.queryCarryDate1.Name = "queryCarryDate1";
            this.queryCarryDate1.Size = new System.Drawing.Size(108, 25);
            this.queryCarryDate1.TabIndex = 5;
            this.queryCarryDate1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.queryCarryDate1.TextChanged += new System.EventHandler(this.queryDate_TextChanged);
            this.queryCarryDate1.Enter += new System.EventHandler(this.edit_Enter);
            this.queryCarryDate1.Validated += new System.EventHandler(this.queryDate_Validated);
            // 
            // queryPlanDate1
            // 
            this.queryPlanDate1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryPlanDate1.Location = new System.Drawing.Point(102, 78);
            this.queryPlanDate1.Mask = "900-90-90";
            this.queryPlanDate1.Name = "queryPlanDate1";
            this.queryPlanDate1.Size = new System.Drawing.Size(108, 25);
            this.queryPlanDate1.TabIndex = 3;
            this.queryPlanDate1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.queryPlanDate1.TextChanged += new System.EventHandler(this.queryDate_TextChanged);
            this.queryPlanDate1.Enter += new System.EventHandler(this.edit_Enter);
            this.queryPlanDate1.Validated += new System.EventHandler(this.queryDate_Validated);
            // 
            // queryOrderDate1
            // 
            this.queryOrderDate1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryOrderDate1.Location = new System.Drawing.Point(102, 47);
            this.queryOrderDate1.Mask = "900-90-90";
            this.queryOrderDate1.Name = "queryOrderDate1";
            this.queryOrderDate1.Size = new System.Drawing.Size(108, 25);
            this.queryOrderDate1.TabIndex = 1;
            this.queryOrderDate1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.queryOrderDate1.TextChanged += new System.EventHandler(this.queryDate_TextChanged);
            this.queryOrderDate1.Enter += new System.EventHandler(this.edit_Enter);
            this.queryOrderDate1.Validated += new System.EventHandler(this.queryDate_Validated);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvQueryReport);
            this.tabPage5.Controls.Add(this.dgvReport);
            this.tabPage5.Controls.Add(this.btnUpdateReport);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage5.Size = new System.Drawing.Size(581, 949);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "每月銷售明細";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvQueryReport
            // 
            this.dgvQueryReport.AllowUserToAddRows = false;
            this.dgvQueryReport.AllowUserToDeleteRows = false;
            this.dgvQueryReport.AllowUserToResizeRows = false;
            this.dgvQueryReport.AutoGenerateColumns = false;
            this.dgvQueryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dgvQueryReport.DataSource = this.ticketBindingSource;
            this.dgvQueryReport.Location = new System.Drawing.Point(0, 432);
            this.dgvQueryReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvQueryReport.MultiSelect = false;
            this.dgvQueryReport.Name = "dgvQueryReport";
            this.dgvQueryReport.ReadOnly = true;
            this.dgvQueryReport.RowHeadersVisible = false;
            this.dgvQueryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryReport.ShowCellToolTips = false;
            this.dgvQueryReport.Size = new System.Drawing.Size(581, 517);
            this.dgvQueryReport.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TicketCode";
            this.dataGridViewTextBoxColumn20.HeaderText = "編號";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 75;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn21.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn22.HeaderText = "訂購日期";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 110;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PlanDate";
            this.dataGridViewTextBoxColumn23.HeaderText = "預交日期";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 110;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "CarryDate";
            this.dataGridViewTextBoxColumn24.HeaderText = "取件日期";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 110;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn25.HeaderText = "總價";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 70;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Earnest";
            this.dataGridViewTextBoxColumn26.HeaderText = "訂金";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 70;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IfCarry";
            this.dataGridViewTextBoxColumn27.HeaderText = "取件";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 30;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "IfPayoff";
            this.dataGridViewTextBoxColumn28.HeaderText = "付清";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 30;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.TicketCount,
            this.TotalPrice,
            this.dataGridViewTextBoxColumn10,
            this.AccountReceived,
            this.Carry,
            this.Payoff});
            this.dgvReport.DataSource = this.reportBindingSource;
            this.dgvReport.Location = new System.Drawing.Point(0, 37);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.ShowCellToolTips = false;
            this.dgvReport.Size = new System.Drawing.Size(580, 386);
            this.dgvReport.TabIndex = 13;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "期間";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // TicketCount
            // 
            this.TicketCount.DataPropertyName = "TicketCount";
            this.TicketCount.HeaderText = "訂單數";
            this.TicketCount.Name = "TicketCount";
            this.TicketCount.ReadOnly = true;
            this.TicketCount.Width = 75;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "總價合計";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Earnest";
            this.dataGridViewTextBoxColumn10.HeaderText = "預付合計";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // AccountReceived
            // 
            this.AccountReceived.DataPropertyName = "AccountReceived";
            this.AccountReceived.HeaderText = "收款合計";
            this.AccountReceived.Name = "AccountReceived";
            this.AccountReceived.ReadOnly = true;
            this.AccountReceived.Width = 80;
            // 
            // Carry
            // 
            this.Carry.DataPropertyName = "Carry";
            this.Carry.HeaderText = "取件合計";
            this.Carry.Name = "Carry";
            this.Carry.ReadOnly = true;
            this.Carry.Width = 75;
            // 
            // Payoff
            // 
            this.Payoff.DataPropertyName = "Payoff";
            this.Payoff.HeaderText = "付清合計";
            this.Payoff.Name = "Payoff";
            this.Payoff.ReadOnly = true;
            this.Payoff.Width = 75;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(gxxf.MainForm.Report);
            this.reportBindingSource.CurrentChanged += new System.EventHandler(this.reportBindingSource_CurrentChanged);
            // 
            // btnUpdateReport
            // 
            this.btnUpdateReport.Location = new System.Drawing.Point(6, 2);
            this.btnUpdateReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdateReport.Name = "btnUpdateReport";
            this.btnUpdateReport.Size = new System.Drawing.Size(130, 32);
            this.btnUpdateReport.TabIndex = 12;
            this.btnUpdateReport.Text = "更新報表";
            this.btnUpdateReport.UseVisualStyleBackColor = true;
            this.btnUpdateReport.Click += new System.EventHandler(this.btnUpdateReport_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnParameterDelete);
            this.tabPage3.Controls.Add(this.btnParameterUpdate);
            this.tabPage3.Controls.Add(this.btnParameterNew);
            this.tabPage3.Controls.Add(this.dgvParameter);
            this.tabPage3.Controls.Add(this.tbParameter);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 949);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnParameterDelete
            // 
            this.btnParameterDelete.AutoSize = true;
            this.btnParameterDelete.Location = new System.Drawing.Point(482, 56);
            this.btnParameterDelete.Name = "btnParameterDelete";
            this.btnParameterDelete.Size = new System.Drawing.Size(93, 34);
            this.btnParameterDelete.TabIndex = 2;
            this.btnParameterDelete.Text = "刪除";
            this.btnParameterDelete.UseVisualStyleBackColor = true;
            this.btnParameterDelete.Click += new System.EventHandler(this.btnParameterDelete_Click);
            // 
            // btnParameterUpdate
            // 
            this.btnParameterUpdate.AutoSize = true;
            this.btnParameterUpdate.Location = new System.Drawing.Point(383, 56);
            this.btnParameterUpdate.Name = "btnParameterUpdate";
            this.btnParameterUpdate.Size = new System.Drawing.Size(93, 34);
            this.btnParameterUpdate.TabIndex = 2;
            this.btnParameterUpdate.Text = "修改";
            this.btnParameterUpdate.UseVisualStyleBackColor = true;
            this.btnParameterUpdate.Click += new System.EventHandler(this.btnParameterUpdate_Click);
            // 
            // btnParameterNew
            // 
            this.btnParameterNew.AutoSize = true;
            this.btnParameterNew.Location = new System.Drawing.Point(284, 56);
            this.btnParameterNew.Name = "btnParameterNew";
            this.btnParameterNew.Size = new System.Drawing.Size(93, 34);
            this.btnParameterNew.TabIndex = 2;
            this.btnParameterNew.Text = "新增";
            this.btnParameterNew.UseVisualStyleBackColor = true;
            this.btnParameterNew.Click += new System.EventHandler(this.btnParameterNew_Click);
            // 
            // dgvParameter
            // 
            this.dgvParameter.AllowUserToAddRows = false;
            this.dgvParameter.AllowUserToDeleteRows = false;
            this.dgvParameter.AllowUserToResizeRows = false;
            this.dgvParameter.AutoGenerateColumns = false;
            this.dgvParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32});
            this.dgvParameter.DataSource = this.parameterBindingSource;
            this.dgvParameter.Location = new System.Drawing.Point(6, 6);
            this.dgvParameter.MultiSelect = false;
            this.dgvParameter.Name = "dgvParameter";
            this.dgvParameter.ReadOnly = true;
            this.dgvParameter.RowHeadersVisible = false;
            this.dgvParameter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParameter.ShowCellToolTips = false;
            this.dgvParameter.Size = new System.Drawing.Size(272, 334);
            this.dgvParameter.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "ParameterName";
            this.dataGridViewTextBoxColumn32.HeaderText = "參數";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 240;
            // 
            // parameterBindingSource
            // 
            this.parameterBindingSource.DataMember = "Parameter";
            this.parameterBindingSource.DataSource = this.gxxfDataSet;
            this.parameterBindingSource.CurrentChanged += new System.EventHandler(this.parameterBindingSource_CurrentChanged);
            // 
            // tbParameter
            // 
            this.tbParameter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbParameter.Location = new System.Drawing.Point(284, 15);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(291, 25);
            this.tbParameter.TabIndex = 1;
            this.tbParameter.Enter += new System.EventHandler(this.edit_Enter);
            this.tbParameter.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppUserTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.ParameterTableAdapter = null;
            this.tableAdapterManager.TicketJacketTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.TicketTrousersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gxxf.gxxfDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // ticketJacketTableAdapter
            // 
            this.ticketJacketTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTrousersTableAdapter
            // 
            this.ticketTrousersTableAdapter.ClearBeforeFill = true;
            // 
            // parameterTableAdapter
            // 
            this.parameterTableAdapter.ClearBeforeFill = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lbLoginPrompt);
            this.panelLogin.Controls.Add(this.label47);
            this.panelLogin.Controls.Add(this.label46);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.tbUsername);
            this.panelLogin.Location = new System.Drawing.Point(50, 50);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(367, 185);
            this.panelLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(66, 81);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 43);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLoginPrompt
            // 
            this.lbLoginPrompt.Location = new System.Drawing.Point(11, 131);
            this.lbLoginPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLoginPrompt.Name = "lbLoginPrompt";
            this.lbLoginPrompt.Size = new System.Drawing.Size(340, 41);
            this.lbLoginPrompt.TabIndex = 1;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 46);
            this.label47.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(48, 24);
            this.label47.TabIndex = 1;
            this.label47.Text = "密碼";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 11);
            this.label46.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(48, 24);
            this.label46.TabIndex = 1;
            this.label46.Text = "帳號";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Location = new System.Drawing.Point(66, 46);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(285, 25);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "z4578";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbPassword.Enter += new System.EventHandler(this.edit_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Location = new System.Drawing.Point(66, 11);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(285, 25);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "a4578";
            this.tbUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbUsername.Enter += new System.EventHandler(this.edit_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // appUserTableAdapter
            // 
            this.appUserTableAdapter.ClearBeforeFill = true;
            // 
            // label57
            // 
            this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(8, 64);
            this.label57.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(86, 24);
            this.label57.TabIndex = 71;
            this.label57.Text = "預交日期";
            // 
            // label58
            // 
            this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(8, 192);
            this.label58.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(86, 24);
            this.label58.TabIndex = 72;
            this.label58.Text = "單位地址";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(346, 160);
            this.label59.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(48, 24);
            this.label59.TabIndex = 69;
            this.label59.Text = "電話";
            // 
            // label60
            // 
            this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 160);
            this.label60.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(86, 24);
            this.label60.TabIndex = 70;
            this.label60.Text = "單位名稱";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(346, 64);
            this.label61.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(48, 24);
            this.label61.TabIndex = 68;
            this.label61.Text = "收款";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(346, 96);
            this.label62.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(48, 24);
            this.label62.TabIndex = 76;
            this.label62.Text = "餘額";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(346, 32);
            this.label63.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(48, 24);
            this.label63.TabIndex = 78;
            this.label63.Text = "定金";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(346, 0);
            this.label64.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(48, 24);
            this.label64.TabIndex = 73;
            this.label64.Text = "總價";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(8, 96);
            this.label65.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(86, 24);
            this.label65.TabIndex = 74;
            this.label65.Text = "取件日期";
            // 
            // label66
            // 
            this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(8, 0);
            this.label66.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(86, 24);
            this.label66.TabIndex = 75;
            this.label66.Text = "訂單編號";
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(8, 32);
            this.label67.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(86, 24);
            this.label67.TabIndex = 77;
            this.label67.Text = "訂購日期";
            // 
            // showTicketCode
            // 
            this.showTicketCode.BackColor = System.Drawing.SystemColors.Info;
            this.showTicketCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTicketCode.Location = new System.Drawing.Point(100, 0);
            this.showTicketCode.Margin = new System.Windows.Forms.Padding(0);
            this.showTicketCode.Name = "showTicketCode";
            this.showTicketCode.ReadOnly = true;
            this.showTicketCode.Size = new System.Drawing.Size(230, 25);
            this.showTicketCode.TabIndex = 53;
            this.showTicketCode.TabStop = false;
            // 
            // showTicketCompanyTelephone
            // 
            this.showTicketCompanyTelephone.BackColor = System.Drawing.SystemColors.Info;
            this.showTicketCompanyTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTicketCompanyTelephone.Location = new System.Drawing.Point(403, 161);
            this.showTicketCompanyTelephone.Margin = new System.Windows.Forms.Padding(1);
            this.showTicketCompanyTelephone.Name = "showTicketCompanyTelephone";
            this.showTicketCompanyTelephone.ReadOnly = true;
            this.showTicketCompanyTelephone.Size = new System.Drawing.Size(230, 25);
            this.showTicketCompanyTelephone.TabIndex = 66;
            this.showTicketCompanyTelephone.TabStop = false;
            // 
            // showTicketCompanyName
            // 
            this.showTicketCompanyName.BackColor = System.Drawing.SystemColors.Info;
            this.showTicketCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTicketCompanyName.Location = new System.Drawing.Point(100, 160);
            this.showTicketCompanyName.Margin = new System.Windows.Forms.Padding(0);
            this.showTicketCompanyName.Name = "showTicketCompanyName";
            this.showTicketCompanyName.ReadOnly = true;
            this.showTicketCompanyName.Size = new System.Drawing.Size(230, 25);
            this.showTicketCompanyName.TabIndex = 65;
            this.showTicketCompanyName.TabStop = false;
            // 
            // showTotalPrice
            // 
            this.showTotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.showTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTotalPrice.Location = new System.Drawing.Point(403, 1);
            this.showTotalPrice.Margin = new System.Windows.Forms.Padding(1);
            this.showTotalPrice.Name = "showTotalPrice";
            this.showTotalPrice.ReadOnly = true;
            this.showTotalPrice.Size = new System.Drawing.Size(230, 25);
            this.showTotalPrice.TabIndex = 61;
            this.showTotalPrice.TabStop = false;
            // 
            // showEarnest
            // 
            this.showEarnest.BackColor = System.Drawing.SystemColors.Info;
            this.showEarnest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showEarnest.Location = new System.Drawing.Point(403, 33);
            this.showEarnest.Margin = new System.Windows.Forms.Padding(1);
            this.showEarnest.Name = "showEarnest";
            this.showEarnest.ReadOnly = true;
            this.showEarnest.Size = new System.Drawing.Size(230, 25);
            this.showEarnest.TabIndex = 62;
            this.showEarnest.TabStop = false;
            // 
            // showAccountReceived
            // 
            this.showAccountReceived.BackColor = System.Drawing.SystemColors.Info;
            this.showAccountReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showAccountReceived.Location = new System.Drawing.Point(403, 65);
            this.showAccountReceived.Margin = new System.Windows.Forms.Padding(1);
            this.showAccountReceived.Name = "showAccountReceived";
            this.showAccountReceived.ReadOnly = true;
            this.showAccountReceived.Size = new System.Drawing.Size(230, 25);
            this.showAccountReceived.TabIndex = 63;
            this.showAccountReceived.TabStop = false;
            // 
            // showBalance
            // 
            this.showBalance.BackColor = System.Drawing.SystemColors.Info;
            this.showBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showBalance.Location = new System.Drawing.Point(403, 97);
            this.showBalance.Margin = new System.Windows.Forms.Padding(1);
            this.showBalance.Name = "showBalance";
            this.showBalance.ReadOnly = true;
            this.showBalance.Size = new System.Drawing.Size(230, 25);
            this.showBalance.TabIndex = 64;
            this.showBalance.TabStop = false;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(0, 32);
            this.label68.Margin = new System.Windows.Forms.Padding(0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(48, 24);
            this.label68.TabIndex = 126;
            this.label68.Text = "上圍";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(0, 64);
            this.label69.Margin = new System.Windows.Forms.Padding(0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(48, 24);
            this.label69.TabIndex = 122;
            this.label69.Text = "下圍";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(0, 96);
            this.label70.Margin = new System.Windows.Forms.Padding(0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(48, 24);
            this.label70.TabIndex = 123;
            this.label70.Text = "袖長";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(0, 128);
            this.label71.Margin = new System.Windows.Forms.Padding(0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(48, 24);
            this.label71.TabIndex = 124;
            this.label71.Text = "袖口";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(0, 160);
            this.label72.Margin = new System.Windows.Forms.Padding(0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(48, 24);
            this.label72.TabIndex = 119;
            this.label72.Text = "前胸";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(0, 192);
            this.label73.Margin = new System.Windows.Forms.Padding(0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(48, 24);
            this.label73.TabIndex = 120;
            this.label73.Text = "後背";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(0, 224);
            this.label74.Margin = new System.Windows.Forms.Padding(0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(48, 24);
            this.label74.TabIndex = 121;
            this.label74.Text = "身長";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(0, 256);
            this.label75.Margin = new System.Windows.Forms.Padding(0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(48, 24);
            this.label75.TabIndex = 128;
            this.label75.Text = "背長";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(0, 288);
            this.label76.Margin = new System.Windows.Forms.Padding(0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(48, 24);
            this.label76.TabIndex = 129;
            this.label76.Text = "背心";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(0, 320);
            this.label77.Margin = new System.Windows.Forms.Padding(0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(48, 24);
            this.label77.TabIndex = 130;
            this.label77.Text = "領口";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showJianKuan
            // 
            this.showJianKuan.BackColor = System.Drawing.SystemColors.Info;
            this.showJianKuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showJianKuan.Location = new System.Drawing.Point(50, 0);
            this.showJianKuan.Margin = new System.Windows.Forms.Padding(0);
            this.showJianKuan.Name = "showJianKuan";
            this.showJianKuan.ReadOnly = true;
            this.showJianKuan.Size = new System.Drawing.Size(89, 25);
            this.showJianKuan.TabIndex = 79;
            this.showJianKuan.TabStop = false;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(0, 0);
            this.label78.Margin = new System.Windows.Forms.Padding(0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(48, 24);
            this.label78.TabIndex = 125;
            this.label78.Text = "肩寬";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showShangWei
            // 
            this.showShangWei.BackColor = System.Drawing.SystemColors.Info;
            this.showShangWei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showShangWei.Location = new System.Drawing.Point(50, 32);
            this.showShangWei.Margin = new System.Windows.Forms.Padding(0);
            this.showShangWei.Name = "showShangWei";
            this.showShangWei.ReadOnly = true;
            this.showShangWei.Size = new System.Drawing.Size(89, 25);
            this.showShangWei.TabIndex = 81;
            this.showShangWei.TabStop = false;
            // 
            // showXiaWei
            // 
            this.showXiaWei.BackColor = System.Drawing.SystemColors.Info;
            this.showXiaWei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXiaWei.Location = new System.Drawing.Point(50, 64);
            this.showXiaWei.Margin = new System.Windows.Forms.Padding(0);
            this.showXiaWei.Name = "showXiaWei";
            this.showXiaWei.ReadOnly = true;
            this.showXiaWei.Size = new System.Drawing.Size(89, 25);
            this.showXiaWei.TabIndex = 83;
            this.showXiaWei.TabStop = false;
            // 
            // showXiuChang
            // 
            this.showXiuChang.BackColor = System.Drawing.SystemColors.Info;
            this.showXiuChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXiuChang.Location = new System.Drawing.Point(50, 96);
            this.showXiuChang.Margin = new System.Windows.Forms.Padding(0);
            this.showXiuChang.Name = "showXiuChang";
            this.showXiuChang.ReadOnly = true;
            this.showXiuChang.Size = new System.Drawing.Size(89, 25);
            this.showXiuChang.TabIndex = 85;
            this.showXiuChang.TabStop = false;
            // 
            // showXiuKou
            // 
            this.showXiuKou.BackColor = System.Drawing.SystemColors.Info;
            this.showXiuKou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXiuKou.Location = new System.Drawing.Point(50, 128);
            this.showXiuKou.Margin = new System.Windows.Forms.Padding(0);
            this.showXiuKou.Name = "showXiuKou";
            this.showXiuKou.ReadOnly = true;
            this.showXiuKou.Size = new System.Drawing.Size(89, 25);
            this.showXiuKou.TabIndex = 87;
            this.showXiuKou.TabStop = false;
            // 
            // showQianXiong
            // 
            this.showQianXiong.BackColor = System.Drawing.SystemColors.Info;
            this.showQianXiong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showQianXiong.Location = new System.Drawing.Point(50, 160);
            this.showQianXiong.Margin = new System.Windows.Forms.Padding(0);
            this.showQianXiong.Name = "showQianXiong";
            this.showQianXiong.ReadOnly = true;
            this.showQianXiong.Size = new System.Drawing.Size(89, 25);
            this.showQianXiong.TabIndex = 89;
            this.showQianXiong.TabStop = false;
            // 
            // showHouBei
            // 
            this.showHouBei.BackColor = System.Drawing.SystemColors.Info;
            this.showHouBei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showHouBei.Location = new System.Drawing.Point(50, 192);
            this.showHouBei.Margin = new System.Windows.Forms.Padding(0);
            this.showHouBei.Name = "showHouBei";
            this.showHouBei.ReadOnly = true;
            this.showHouBei.Size = new System.Drawing.Size(89, 25);
            this.showHouBei.TabIndex = 91;
            this.showHouBei.TabStop = false;
            // 
            // showShenChang
            // 
            this.showShenChang.BackColor = System.Drawing.SystemColors.Info;
            this.showShenChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showShenChang.Location = new System.Drawing.Point(50, 224);
            this.showShenChang.Margin = new System.Windows.Forms.Padding(0);
            this.showShenChang.Name = "showShenChang";
            this.showShenChang.ReadOnly = true;
            this.showShenChang.Size = new System.Drawing.Size(89, 25);
            this.showShenChang.TabIndex = 93;
            this.showShenChang.TabStop = false;
            // 
            // showBeiChang
            // 
            this.showBeiChang.BackColor = System.Drawing.SystemColors.Info;
            this.showBeiChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showBeiChang.Location = new System.Drawing.Point(50, 256);
            this.showBeiChang.Margin = new System.Windows.Forms.Padding(0);
            this.showBeiChang.Name = "showBeiChang";
            this.showBeiChang.ReadOnly = true;
            this.showBeiChang.Size = new System.Drawing.Size(89, 25);
            this.showBeiChang.TabIndex = 95;
            this.showBeiChang.TabStop = false;
            // 
            // showBeiXin
            // 
            this.showBeiXin.BackColor = System.Drawing.SystemColors.Info;
            this.showBeiXin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showBeiXin.Location = new System.Drawing.Point(50, 288);
            this.showBeiXin.Margin = new System.Windows.Forms.Padding(0);
            this.showBeiXin.Name = "showBeiXin";
            this.showBeiXin.ReadOnly = true;
            this.showBeiXin.Size = new System.Drawing.Size(89, 25);
            this.showBeiXin.TabIndex = 97;
            this.showBeiXin.TabStop = false;
            // 
            // showLingKou
            // 
            this.showLingKou.BackColor = System.Drawing.SystemColors.Info;
            this.showLingKou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showLingKou.Location = new System.Drawing.Point(50, 320);
            this.showLingKou.Margin = new System.Windows.Forms.Padding(0);
            this.showLingKou.Name = "showLingKou";
            this.showLingKou.ReadOnly = true;
            this.showLingKou.Size = new System.Drawing.Size(89, 25);
            this.showLingKou.TabIndex = 99;
            this.showLingKou.TabStop = false;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(345, 0);
            this.label79.Margin = new System.Windows.Forms.Padding(0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(48, 24);
            this.label79.TabIndex = 127;
            this.label79.Text = "褲腰";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(345, 320);
            this.label80.Margin = new System.Windows.Forms.Padding(0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(48, 24);
            this.label80.TabIndex = 111;
            this.label80.Text = "腰帶";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(345, 288);
            this.label81.Margin = new System.Windows.Forms.Padding(0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(48, 24);
            this.label81.TabIndex = 109;
            this.label81.Text = "拉鍊";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(345, 256);
            this.label82.Margin = new System.Windows.Forms.Padding(0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(48, 24);
            this.label82.TabIndex = 115;
            this.label82.Text = "釦子";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(345, 224);
            this.label83.Margin = new System.Windows.Forms.Padding(0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(48, 24);
            this.label83.TabIndex = 114;
            this.label83.Text = "褲口";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(345, 192);
            this.label84.Margin = new System.Windows.Forms.Padding(0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(48, 24);
            this.label84.TabIndex = 117;
            this.label84.Text = "中檔";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(345, 160);
            this.label85.Margin = new System.Windows.Forms.Padding(0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(48, 24);
            this.label85.TabIndex = 116;
            this.label85.Text = "開檔";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(345, 128);
            this.label86.Margin = new System.Windows.Forms.Padding(0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(48, 24);
            this.label86.TabIndex = 112;
            this.label86.Text = "上檔";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(345, 96);
            this.label87.Margin = new System.Windows.Forms.Padding(0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(48, 24);
            this.label87.TabIndex = 108;
            this.label87.Text = "中長";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(345, 64);
            this.label88.Margin = new System.Windows.Forms.Padding(0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(48, 24);
            this.label88.TabIndex = 110;
            this.label88.Text = "褲長";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(345, 32);
            this.label89.Margin = new System.Windows.Forms.Padding(0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(48, 24);
            this.label89.TabIndex = 113;
            this.label89.Text = "下圍";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showOrderDate
            // 
            this.showOrderDate.BackColor = System.Drawing.SystemColors.Info;
            this.showOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showOrderDate.Location = new System.Drawing.Point(100, 32);
            this.showOrderDate.Margin = new System.Windows.Forms.Padding(0);
            this.showOrderDate.Name = "showOrderDate";
            this.showOrderDate.ReadOnly = true;
            this.showOrderDate.Size = new System.Drawing.Size(230, 25);
            this.showOrderDate.TabIndex = 53;
            this.showOrderDate.TabStop = false;
            // 
            // showPlanDate
            // 
            this.showPlanDate.BackColor = System.Drawing.SystemColors.Info;
            this.showPlanDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showPlanDate.Location = new System.Drawing.Point(100, 64);
            this.showPlanDate.Margin = new System.Windows.Forms.Padding(0);
            this.showPlanDate.Name = "showPlanDate";
            this.showPlanDate.ReadOnly = true;
            this.showPlanDate.Size = new System.Drawing.Size(230, 25);
            this.showPlanDate.TabIndex = 53;
            this.showPlanDate.TabStop = false;
            // 
            // showCarryDate
            // 
            this.showCarryDate.BackColor = System.Drawing.SystemColors.Info;
            this.showCarryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCarryDate.Location = new System.Drawing.Point(100, 96);
            this.showCarryDate.Margin = new System.Windows.Forms.Padding(0);
            this.showCarryDate.Name = "showCarryDate";
            this.showCarryDate.ReadOnly = true;
            this.showCarryDate.Size = new System.Drawing.Size(230, 25);
            this.showCarryDate.TabIndex = 53;
            this.showCarryDate.TabStop = false;
            // 
            // showJianKuanP
            // 
            this.showJianKuanP.BackColor = System.Drawing.SystemColors.Info;
            this.showJianKuanP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showJianKuanP.Location = new System.Drawing.Point(145, 0);
            this.showJianKuanP.Margin = new System.Windows.Forms.Padding(0);
            this.showJianKuanP.Name = "showJianKuanP";
            this.showJianKuanP.ReadOnly = true;
            this.showJianKuanP.Size = new System.Drawing.Size(184, 25);
            this.showJianKuanP.TabIndex = 65;
            this.showJianKuanP.TabStop = false;
            // 
            // showShangWeiP
            // 
            this.showShangWeiP.BackColor = System.Drawing.SystemColors.Info;
            this.showShangWeiP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showShangWeiP.Location = new System.Drawing.Point(145, 32);
            this.showShangWeiP.Margin = new System.Windows.Forms.Padding(0);
            this.showShangWeiP.Name = "showShangWeiP";
            this.showShangWeiP.ReadOnly = true;
            this.showShangWeiP.Size = new System.Drawing.Size(184, 25);
            this.showShangWeiP.TabIndex = 65;
            this.showShangWeiP.TabStop = false;
            // 
            // showXiaWeiP
            // 
            this.showXiaWeiP.BackColor = System.Drawing.SystemColors.Info;
            this.showXiaWeiP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXiaWeiP.Location = new System.Drawing.Point(145, 64);
            this.showXiaWeiP.Margin = new System.Windows.Forms.Padding(0);
            this.showXiaWeiP.Name = "showXiaWeiP";
            this.showXiaWeiP.ReadOnly = true;
            this.showXiaWeiP.Size = new System.Drawing.Size(184, 25);
            this.showXiaWeiP.TabIndex = 65;
            this.showXiaWeiP.TabStop = false;
            // 
            // showXiuChangP
            // 
            this.showXiuChangP.BackColor = System.Drawing.SystemColors.Info;
            this.showXiuChangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXiuChangP.Location = new System.Drawing.Point(145, 96);
            this.showXiuChangP.Margin = new System.Windows.Forms.Padding(0);
            this.showXiuChangP.Name = "showXiuChangP";
            this.showXiuChangP.ReadOnly = true;
            this.showXiuChangP.Size = new System.Drawing.Size(184, 25);
            this.showXiuChangP.TabIndex = 65;
            this.showXiuChangP.TabStop = false;
            // 
            // showXiuKouP
            // 
            this.showXiuKouP.BackColor = System.Drawing.SystemColors.Info;
            this.showXiuKouP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showXiuKouP.Location = new System.Drawing.Point(145, 128);
            this.showXiuKouP.Margin = new System.Windows.Forms.Padding(0);
            this.showXiuKouP.Name = "showXiuKouP";
            this.showXiuKouP.ReadOnly = true;
            this.showXiuKouP.Size = new System.Drawing.Size(184, 25);
            this.showXiuKouP.TabIndex = 65;
            this.showXiuKouP.TabStop = false;
            // 
            // showQianXiongP
            // 
            this.showQianXiongP.BackColor = System.Drawing.SystemColors.Info;
            this.showQianXiongP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showQianXiongP.Location = new System.Drawing.Point(145, 160);
            this.showQianXiongP.Margin = new System.Windows.Forms.Padding(0);
            this.showQianXiongP.Name = "showQianXiongP";
            this.showQianXiongP.ReadOnly = true;
            this.showQianXiongP.Size = new System.Drawing.Size(184, 25);
            this.showQianXiongP.TabIndex = 65;
            this.showQianXiongP.TabStop = false;
            // 
            // showHouBeiP
            // 
            this.showHouBeiP.BackColor = System.Drawing.SystemColors.Info;
            this.showHouBeiP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showHouBeiP.Location = new System.Drawing.Point(145, 192);
            this.showHouBeiP.Margin = new System.Windows.Forms.Padding(0);
            this.showHouBeiP.Name = "showHouBeiP";
            this.showHouBeiP.ReadOnly = true;
            this.showHouBeiP.Size = new System.Drawing.Size(184, 25);
            this.showHouBeiP.TabIndex = 65;
            this.showHouBeiP.TabStop = false;
            // 
            // showShenChangP
            // 
            this.showShenChangP.BackColor = System.Drawing.SystemColors.Info;
            this.showShenChangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showShenChangP.Location = new System.Drawing.Point(145, 224);
            this.showShenChangP.Margin = new System.Windows.Forms.Padding(0);
            this.showShenChangP.Name = "showShenChangP";
            this.showShenChangP.ReadOnly = true;
            this.showShenChangP.Size = new System.Drawing.Size(184, 25);
            this.showShenChangP.TabIndex = 65;
            this.showShenChangP.TabStop = false;
            // 
            // showBeiChangP
            // 
            this.showBeiChangP.BackColor = System.Drawing.SystemColors.Info;
            this.showBeiChangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showBeiChangP.Location = new System.Drawing.Point(145, 256);
            this.showBeiChangP.Margin = new System.Windows.Forms.Padding(0);
            this.showBeiChangP.Name = "showBeiChangP";
            this.showBeiChangP.ReadOnly = true;
            this.showBeiChangP.Size = new System.Drawing.Size(184, 25);
            this.showBeiChangP.TabIndex = 65;
            this.showBeiChangP.TabStop = false;
            // 
            // showBeiXinP
            // 
            this.showBeiXinP.BackColor = System.Drawing.SystemColors.Info;
            this.showBeiXinP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showBeiXinP.Location = new System.Drawing.Point(145, 288);
            this.showBeiXinP.Margin = new System.Windows.Forms.Padding(0);
            this.showBeiXinP.Name = "showBeiXinP";
            this.showBeiXinP.ReadOnly = true;
            this.showBeiXinP.Size = new System.Drawing.Size(184, 25);
            this.showBeiXinP.TabIndex = 65;
            this.showBeiXinP.TabStop = false;
            // 
            // showLingKouP
            // 
            this.showLingKouP.BackColor = System.Drawing.SystemColors.Info;
            this.showLingKouP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showLingKouP.Location = new System.Drawing.Point(145, 320);
            this.showLingKouP.Margin = new System.Windows.Forms.Padding(0);
            this.showLingKouP.Name = "showLingKouP";
            this.showLingKouP.ReadOnly = true;
            this.showLingKouP.Size = new System.Drawing.Size(184, 25);
            this.showLingKouP.TabIndex = 65;
            this.showLingKouP.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.Controls.Add(this.showYaoDaiP, 5, 10);
            this.tableLayoutPanel2.Controls.Add(this.showLaLianP, 5, 9);
            this.tableLayoutPanel2.Controls.Add(this.showKouZiP, 5, 8);
            this.tableLayoutPanel2.Controls.Add(this.showKuKouP, 5, 7);
            this.tableLayoutPanel2.Controls.Add(this.showZhongDangP, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.showKaiDangP, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.showShangDangP, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.showZhongChangP, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.showKuChangP, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.showKuXiaWeiP, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.showKuYaoP, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.showYaoDai, 4, 10);
            this.tableLayoutPanel2.Controls.Add(this.showLaLian, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.showKouZi, 4, 8);
            this.tableLayoutPanel2.Controls.Add(this.showKuKou, 4, 7);
            this.tableLayoutPanel2.Controls.Add(this.showZhongDang, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.showKaiDang, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.showShangDang, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.showZhongChang, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.showKuChang, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.showKuYao, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label78, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label80, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.label79, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label81, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.showLingKou, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label82, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.showBeiXin, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label83, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.showBeiChang, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label84, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.showShenChang, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label85, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.showHouBei, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label86, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label88, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label87, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.showQianXiong, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.showXiuKou, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.showXiuChang, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label89, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.showXiaWei, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.showShangWei, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.showJianKuan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label77, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label76, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label75, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label74, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label73, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label72, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label71, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label70, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label69, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label68, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.showShangWeiP, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.showXiaWeiP, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.showXiuChangP, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.showXiuKouP, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.showQianXiongP, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.showHouBeiP, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.showLingKouP, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.showShenChangP, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.showBeiXinP, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.showBeiChangP, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.showJianKuanP, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.showKuXiaWei, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(597, 514);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(679, 356);
            this.tableLayoutPanel2.TabIndex = 131;
            // 
            // showYaoDaiP
            // 
            this.showYaoDaiP.BackColor = System.Drawing.SystemColors.Info;
            this.showYaoDaiP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showYaoDaiP.Location = new System.Drawing.Point(490, 320);
            this.showYaoDaiP.Margin = new System.Windows.Forms.Padding(0);
            this.showYaoDaiP.Name = "showYaoDaiP";
            this.showYaoDaiP.ReadOnly = true;
            this.showYaoDaiP.Size = new System.Drawing.Size(184, 25);
            this.showYaoDaiP.TabIndex = 132;
            this.showYaoDaiP.TabStop = false;
            // 
            // showLaLianP
            // 
            this.showLaLianP.BackColor = System.Drawing.SystemColors.Info;
            this.showLaLianP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showLaLianP.Location = new System.Drawing.Point(490, 288);
            this.showLaLianP.Margin = new System.Windows.Forms.Padding(0);
            this.showLaLianP.Name = "showLaLianP";
            this.showLaLianP.ReadOnly = true;
            this.showLaLianP.Size = new System.Drawing.Size(184, 25);
            this.showLaLianP.TabIndex = 132;
            this.showLaLianP.TabStop = false;
            // 
            // showKouZiP
            // 
            this.showKouZiP.BackColor = System.Drawing.SystemColors.Info;
            this.showKouZiP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKouZiP.Location = new System.Drawing.Point(490, 256);
            this.showKouZiP.Margin = new System.Windows.Forms.Padding(0);
            this.showKouZiP.Name = "showKouZiP";
            this.showKouZiP.ReadOnly = true;
            this.showKouZiP.Size = new System.Drawing.Size(184, 25);
            this.showKouZiP.TabIndex = 132;
            this.showKouZiP.TabStop = false;
            // 
            // showKuKouP
            // 
            this.showKuKouP.BackColor = System.Drawing.SystemColors.Info;
            this.showKuKouP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuKouP.Location = new System.Drawing.Point(490, 224);
            this.showKuKouP.Margin = new System.Windows.Forms.Padding(0);
            this.showKuKouP.Name = "showKuKouP";
            this.showKuKouP.ReadOnly = true;
            this.showKuKouP.Size = new System.Drawing.Size(184, 25);
            this.showKuKouP.TabIndex = 132;
            this.showKuKouP.TabStop = false;
            // 
            // showZhongDangP
            // 
            this.showZhongDangP.BackColor = System.Drawing.SystemColors.Info;
            this.showZhongDangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showZhongDangP.Location = new System.Drawing.Point(490, 192);
            this.showZhongDangP.Margin = new System.Windows.Forms.Padding(0);
            this.showZhongDangP.Name = "showZhongDangP";
            this.showZhongDangP.ReadOnly = true;
            this.showZhongDangP.Size = new System.Drawing.Size(184, 25);
            this.showZhongDangP.TabIndex = 132;
            this.showZhongDangP.TabStop = false;
            // 
            // showKaiDangP
            // 
            this.showKaiDangP.BackColor = System.Drawing.SystemColors.Info;
            this.showKaiDangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKaiDangP.Location = new System.Drawing.Point(490, 160);
            this.showKaiDangP.Margin = new System.Windows.Forms.Padding(0);
            this.showKaiDangP.Name = "showKaiDangP";
            this.showKaiDangP.ReadOnly = true;
            this.showKaiDangP.Size = new System.Drawing.Size(184, 25);
            this.showKaiDangP.TabIndex = 132;
            this.showKaiDangP.TabStop = false;
            // 
            // showShangDangP
            // 
            this.showShangDangP.BackColor = System.Drawing.SystemColors.Info;
            this.showShangDangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showShangDangP.Location = new System.Drawing.Point(490, 128);
            this.showShangDangP.Margin = new System.Windows.Forms.Padding(0);
            this.showShangDangP.Name = "showShangDangP";
            this.showShangDangP.ReadOnly = true;
            this.showShangDangP.Size = new System.Drawing.Size(184, 25);
            this.showShangDangP.TabIndex = 132;
            this.showShangDangP.TabStop = false;
            // 
            // showZhongChangP
            // 
            this.showZhongChangP.BackColor = System.Drawing.SystemColors.Info;
            this.showZhongChangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showZhongChangP.Location = new System.Drawing.Point(490, 96);
            this.showZhongChangP.Margin = new System.Windows.Forms.Padding(0);
            this.showZhongChangP.Name = "showZhongChangP";
            this.showZhongChangP.ReadOnly = true;
            this.showZhongChangP.Size = new System.Drawing.Size(184, 25);
            this.showZhongChangP.TabIndex = 132;
            this.showZhongChangP.TabStop = false;
            // 
            // showKuChangP
            // 
            this.showKuChangP.BackColor = System.Drawing.SystemColors.Info;
            this.showKuChangP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuChangP.Location = new System.Drawing.Point(490, 64);
            this.showKuChangP.Margin = new System.Windows.Forms.Padding(0);
            this.showKuChangP.Name = "showKuChangP";
            this.showKuChangP.ReadOnly = true;
            this.showKuChangP.Size = new System.Drawing.Size(184, 25);
            this.showKuChangP.TabIndex = 132;
            this.showKuChangP.TabStop = false;
            // 
            // showKuXiaWeiP
            // 
            this.showKuXiaWeiP.BackColor = System.Drawing.SystemColors.Info;
            this.showKuXiaWeiP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuXiaWeiP.Location = new System.Drawing.Point(490, 32);
            this.showKuXiaWeiP.Margin = new System.Windows.Forms.Padding(0);
            this.showKuXiaWeiP.Name = "showKuXiaWeiP";
            this.showKuXiaWeiP.ReadOnly = true;
            this.showKuXiaWeiP.Size = new System.Drawing.Size(184, 25);
            this.showKuXiaWeiP.TabIndex = 132;
            this.showKuXiaWeiP.TabStop = false;
            // 
            // showKuYaoP
            // 
            this.showKuYaoP.BackColor = System.Drawing.SystemColors.Info;
            this.showKuYaoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuYaoP.Location = new System.Drawing.Point(490, 0);
            this.showKuYaoP.Margin = new System.Windows.Forms.Padding(0);
            this.showKuYaoP.Name = "showKuYaoP";
            this.showKuYaoP.ReadOnly = true;
            this.showKuYaoP.Size = new System.Drawing.Size(184, 25);
            this.showKuYaoP.TabIndex = 132;
            this.showKuYaoP.TabStop = false;
            // 
            // showYaoDai
            // 
            this.showYaoDai.BackColor = System.Drawing.SystemColors.Info;
            this.showYaoDai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showYaoDai.Location = new System.Drawing.Point(395, 320);
            this.showYaoDai.Margin = new System.Windows.Forms.Padding(0);
            this.showYaoDai.Name = "showYaoDai";
            this.showYaoDai.ReadOnly = true;
            this.showYaoDai.Size = new System.Drawing.Size(89, 25);
            this.showYaoDai.TabIndex = 132;
            this.showYaoDai.TabStop = false;
            // 
            // showLaLian
            // 
            this.showLaLian.BackColor = System.Drawing.SystemColors.Info;
            this.showLaLian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showLaLian.Location = new System.Drawing.Point(395, 288);
            this.showLaLian.Margin = new System.Windows.Forms.Padding(0);
            this.showLaLian.Name = "showLaLian";
            this.showLaLian.ReadOnly = true;
            this.showLaLian.Size = new System.Drawing.Size(89, 25);
            this.showLaLian.TabIndex = 132;
            this.showLaLian.TabStop = false;
            // 
            // showKouZi
            // 
            this.showKouZi.BackColor = System.Drawing.SystemColors.Info;
            this.showKouZi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKouZi.Location = new System.Drawing.Point(395, 256);
            this.showKouZi.Margin = new System.Windows.Forms.Padding(0);
            this.showKouZi.Name = "showKouZi";
            this.showKouZi.ReadOnly = true;
            this.showKouZi.Size = new System.Drawing.Size(89, 25);
            this.showKouZi.TabIndex = 132;
            this.showKouZi.TabStop = false;
            // 
            // showKuKou
            // 
            this.showKuKou.BackColor = System.Drawing.SystemColors.Info;
            this.showKuKou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuKou.Location = new System.Drawing.Point(395, 224);
            this.showKuKou.Margin = new System.Windows.Forms.Padding(0);
            this.showKuKou.Name = "showKuKou";
            this.showKuKou.ReadOnly = true;
            this.showKuKou.Size = new System.Drawing.Size(89, 25);
            this.showKuKou.TabIndex = 132;
            this.showKuKou.TabStop = false;
            // 
            // showZhongDang
            // 
            this.showZhongDang.BackColor = System.Drawing.SystemColors.Info;
            this.showZhongDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showZhongDang.Location = new System.Drawing.Point(395, 192);
            this.showZhongDang.Margin = new System.Windows.Forms.Padding(0);
            this.showZhongDang.Name = "showZhongDang";
            this.showZhongDang.ReadOnly = true;
            this.showZhongDang.Size = new System.Drawing.Size(89, 25);
            this.showZhongDang.TabIndex = 132;
            this.showZhongDang.TabStop = false;
            // 
            // showKaiDang
            // 
            this.showKaiDang.BackColor = System.Drawing.SystemColors.Info;
            this.showKaiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKaiDang.Location = new System.Drawing.Point(395, 160);
            this.showKaiDang.Margin = new System.Windows.Forms.Padding(0);
            this.showKaiDang.Name = "showKaiDang";
            this.showKaiDang.ReadOnly = true;
            this.showKaiDang.Size = new System.Drawing.Size(89, 25);
            this.showKaiDang.TabIndex = 132;
            this.showKaiDang.TabStop = false;
            // 
            // showShangDang
            // 
            this.showShangDang.BackColor = System.Drawing.SystemColors.Info;
            this.showShangDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showShangDang.Location = new System.Drawing.Point(395, 128);
            this.showShangDang.Margin = new System.Windows.Forms.Padding(0);
            this.showShangDang.Name = "showShangDang";
            this.showShangDang.ReadOnly = true;
            this.showShangDang.Size = new System.Drawing.Size(89, 25);
            this.showShangDang.TabIndex = 132;
            this.showShangDang.TabStop = false;
            // 
            // showZhongChang
            // 
            this.showZhongChang.BackColor = System.Drawing.SystemColors.Info;
            this.showZhongChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showZhongChang.Location = new System.Drawing.Point(395, 96);
            this.showZhongChang.Margin = new System.Windows.Forms.Padding(0);
            this.showZhongChang.Name = "showZhongChang";
            this.showZhongChang.ReadOnly = true;
            this.showZhongChang.Size = new System.Drawing.Size(89, 25);
            this.showZhongChang.TabIndex = 132;
            this.showZhongChang.TabStop = false;
            // 
            // showKuChang
            // 
            this.showKuChang.BackColor = System.Drawing.SystemColors.Info;
            this.showKuChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuChang.Location = new System.Drawing.Point(395, 64);
            this.showKuChang.Margin = new System.Windows.Forms.Padding(0);
            this.showKuChang.Name = "showKuChang";
            this.showKuChang.ReadOnly = true;
            this.showKuChang.Size = new System.Drawing.Size(89, 25);
            this.showKuChang.TabIndex = 132;
            this.showKuChang.TabStop = false;
            // 
            // showKuYao
            // 
            this.showKuYao.BackColor = System.Drawing.SystemColors.Info;
            this.showKuYao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuYao.Location = new System.Drawing.Point(395, 0);
            this.showKuYao.Margin = new System.Windows.Forms.Padding(0);
            this.showKuYao.Name = "showKuYao";
            this.showKuYao.ReadOnly = true;
            this.showKuYao.Size = new System.Drawing.Size(89, 25);
            this.showKuYao.TabIndex = 132;
            this.showKuYao.TabStop = false;
            // 
            // showKuXiaWei
            // 
            this.showKuXiaWei.BackColor = System.Drawing.SystemColors.Info;
            this.showKuXiaWei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showKuXiaWei.Location = new System.Drawing.Point(395, 32);
            this.showKuXiaWei.Margin = new System.Windows.Forms.Padding(0);
            this.showKuXiaWei.Name = "showKuXiaWei";
            this.showKuXiaWei.ReadOnly = true;
            this.showKuXiaWei.Size = new System.Drawing.Size(89, 25);
            this.showKuXiaWei.TabIndex = 132;
            this.showKuXiaWei.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel3.Controls.Add(this.showTicketCompanyTelephone, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.label59, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.showBalance, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.showAccountReceived, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.showEarnest, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.showTotalPrice, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label58, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label62, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label61, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label57, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label63, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label60, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label64, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.showCarryDate, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.showTicketCompanyName, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.showPlanDate, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.showOrderDate, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label66, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.showTicketCode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label67, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label65, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.showTicketCompanyAddress, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label45, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label48, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.showIfCarry, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.showIfPayoff, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.showRemark, 1, 7);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(595, 258);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(679, 252);
            this.tableLayoutPanel3.TabIndex = 132;
            // 
            // showTicketCompanyAddress
            // 
            this.showTicketCompanyAddress.BackColor = System.Drawing.SystemColors.Info;
            this.showTicketCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel3.SetColumnSpan(this.showTicketCompanyAddress, 3);
            this.showTicketCompanyAddress.Location = new System.Drawing.Point(100, 192);
            this.showTicketCompanyAddress.Margin = new System.Windows.Forms.Padding(0);
            this.showTicketCompanyAddress.Name = "showTicketCompanyAddress";
            this.showTicketCompanyAddress.ReadOnly = true;
            this.showTicketCompanyAddress.Size = new System.Drawing.Size(533, 25);
            this.showTicketCompanyAddress.TabIndex = 67;
            this.showTicketCompanyAddress.TabStop = false;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(46, 128);
            this.label45.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(48, 24);
            this.label45.TabIndex = 70;
            this.label45.Text = "取件";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(346, 128);
            this.label48.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(48, 24);
            this.label48.TabIndex = 69;
            this.label48.Text = "付清";
            // 
            // showIfCarry
            // 
            this.showIfCarry.BackColor = System.Drawing.SystemColors.Info;
            this.showIfCarry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showIfCarry.Location = new System.Drawing.Point(100, 128);
            this.showIfCarry.Margin = new System.Windows.Forms.Padding(0);
            this.showIfCarry.Name = "showIfCarry";
            this.showIfCarry.ReadOnly = true;
            this.showIfCarry.Size = new System.Drawing.Size(230, 25);
            this.showIfCarry.TabIndex = 53;
            this.showIfCarry.TabStop = false;
            // 
            // showIfPayoff
            // 
            this.showIfPayoff.BackColor = System.Drawing.SystemColors.Info;
            this.showIfPayoff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showIfPayoff.Location = new System.Drawing.Point(403, 129);
            this.showIfPayoff.Margin = new System.Windows.Forms.Padding(1);
            this.showIfPayoff.Name = "showIfPayoff";
            this.showIfPayoff.ReadOnly = true;
            this.showIfPayoff.Size = new System.Drawing.Size(230, 25);
            this.showIfPayoff.TabIndex = 64;
            this.showIfPayoff.TabStop = false;
            // 
            // showRemark
            // 
            this.showRemark.BackColor = System.Drawing.SystemColors.Info;
            this.showRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel3.SetColumnSpan(this.showRemark, 3);
            this.showRemark.Location = new System.Drawing.Point(100, 224);
            this.showRemark.Margin = new System.Windows.Forms.Padding(0);
            this.showRemark.Name = "showRemark";
            this.showRemark.ReadOnly = true;
            this.showRemark.Size = new System.Drawing.Size(533, 25);
            this.showRemark.TabIndex = 67;
            this.showRemark.TabStop = false;
            this.showRemark.DoubleClick += new System.EventHandler(this.unmask_DoubleClick);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnEditCommit);
            this.panelEdit.Controls.Add(this.btnEditCancel);
            this.panelEdit.Controls.Add(this.panel3);
            this.panelEdit.Controls.Add(this.panel2);
            this.panelEdit.Controls.Add(this.panel1);
            this.panelEdit.Controls.Add(this.label13);
            this.panelEdit.Controls.Add(this.mtbCarryDate);
            this.panelEdit.Controls.Add(this.mtbPlanDate);
            this.panelEdit.Controls.Add(this.mtbOrderDate);
            this.panelEdit.Controls.Add(this.mtbBirthday);
            this.panelEdit.Controls.Add(this.tableLayoutPanel1);
            this.panelEdit.Controls.Add(this.label18);
            this.panelEdit.Controls.Add(this.label17);
            this.panelEdit.Controls.Add(this.label14);
            this.panelEdit.Controls.Add(this.label16);
            this.panelEdit.Controls.Add(this.label15);
            this.panelEdit.Controls.Add(this.tbCompanyAddress);
            this.panelEdit.Controls.Add(this.tbCompanyTelephone);
            this.panelEdit.Controls.Add(this.tbCompanyName);
            this.panelEdit.Controls.Add(this.label44);
            this.panelEdit.Controls.Add(this.tbTelephone);
            this.panelEdit.Controls.Add(this.tbAddress);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label19);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.tbCustomerName);
            this.panelEdit.Controls.Add(this.tbCustomerCode);
            this.panelEdit.Controls.Add(this.tbIDCard);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.label12);
            this.panelEdit.Controls.Add(this.label11);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.label42);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.tbTicketCode);
            this.panelEdit.Controls.Add(this.tbRemark);
            this.panelEdit.Controls.Add(this.tbTicketCompanyAddress);
            this.panelEdit.Controls.Add(this.tbTicketCompanyTelephone);
            this.panelEdit.Controls.Add(this.tbTicketCompanyName);
            this.panelEdit.Controls.Add(this.tbTotalPrice);
            this.panelEdit.Controls.Add(this.tbEarnest);
            this.panelEdit.Controls.Add(this.tbAccountReceived);
            this.panelEdit.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelEdit.Location = new System.Drawing.Point(0, 0);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1275, 1000);
            this.panelEdit.TabIndex = 133;
            this.panelEdit.Visible = false;
            // 
            // btnEditCommit
            // 
            this.btnEditCommit.AutoSize = true;
            this.btnEditCommit.Location = new System.Drawing.Point(970, 887);
            this.btnEditCommit.Name = "btnEditCommit";
            this.btnEditCommit.Size = new System.Drawing.Size(105, 38);
            this.btnEditCommit.TabIndex = 36;
            this.btnEditCommit.Text = "確定";
            this.btnEditCommit.UseVisualStyleBackColor = true;
            this.btnEditCommit.Click += new System.EventHandler(this.btnEditCommit_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.AutoSize = true;
            this.btnEditCancel.Location = new System.Drawing.Point(970, 931);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(105, 38);
            this.btnEditCancel.TabIndex = 37;
            this.btnEditCancel.Text = "取消";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbIfPayoff2);
            this.panel3.Controls.Add(this.rbIfPayoff1);
            this.panel3.Location = new System.Drawing.Point(620, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 36);
            this.panel3.TabIndex = 19;
            // 
            // rbIfPayoff2
            // 
            this.rbIfPayoff2.AutoSize = true;
            this.rbIfPayoff2.Location = new System.Drawing.Point(106, 3);
            this.rbIfPayoff2.Name = "rbIfPayoff2";
            this.rbIfPayoff2.Size = new System.Drawing.Size(96, 32);
            this.rbIfPayoff2.TabIndex = 1;
            this.rbIfPayoff2.Text = "已付清";
            this.rbIfPayoff2.UseVisualStyleBackColor = true;
            // 
            // rbIfPayoff1
            // 
            this.rbIfPayoff1.AutoSize = true;
            this.rbIfPayoff1.Checked = true;
            this.rbIfPayoff1.Location = new System.Drawing.Point(3, 3);
            this.rbIfPayoff1.Name = "rbIfPayoff1";
            this.rbIfPayoff1.Size = new System.Drawing.Size(96, 32);
            this.rbIfPayoff1.TabIndex = 0;
            this.rbIfPayoff1.TabStop = true;
            this.rbIfPayoff1.Text = "未付清";
            this.rbIfPayoff1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbIfCarry2);
            this.panel2.Controls.Add(this.rbIfCarry1);
            this.panel2.Location = new System.Drawing.Point(142, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 36);
            this.panel2.TabIndex = 14;
            // 
            // rbIfCarry2
            // 
            this.rbIfCarry2.AutoSize = true;
            this.rbIfCarry2.Location = new System.Drawing.Point(106, 3);
            this.rbIfCarry2.Name = "rbIfCarry2";
            this.rbIfCarry2.Size = new System.Drawing.Size(96, 32);
            this.rbIfCarry2.TabIndex = 1;
            this.rbIfCarry2.Text = "已取件";
            this.rbIfCarry2.UseVisualStyleBackColor = true;
            // 
            // rbIfCarry1
            // 
            this.rbIfCarry1.AutoSize = true;
            this.rbIfCarry1.Checked = true;
            this.rbIfCarry1.Location = new System.Drawing.Point(3, 3);
            this.rbIfCarry1.Name = "rbIfCarry1";
            this.rbIfCarry1.Size = new System.Drawing.Size(96, 32);
            this.rbIfCarry1.TabIndex = 0;
            this.rbIfCarry1.TabStop = true;
            this.rbIfCarry1.Text = "未取件";
            this.rbIfCarry1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSex1);
            this.panel1.Controls.Add(this.rbSex2);
            this.panel1.Location = new System.Drawing.Point(813, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 37);
            this.panel1.TabIndex = 5;
            // 
            // rbSex1
            // 
            this.rbSex1.AutoSize = true;
            this.rbSex1.Checked = true;
            this.rbSex1.Location = new System.Drawing.Point(3, 2);
            this.rbSex1.Name = "rbSex1";
            this.rbSex1.Size = new System.Drawing.Size(52, 32);
            this.rbSex1.TabIndex = 0;
            this.rbSex1.TabStop = true;
            this.rbSex1.Text = "男";
            this.rbSex1.UseVisualStyleBackColor = true;
            // 
            // rbSex2
            // 
            this.rbSex2.AutoSize = true;
            this.rbSex2.Location = new System.Drawing.Point(56, 2);
            this.rbSex2.Name = "rbSex2";
            this.rbSex2.Size = new System.Drawing.Size(52, 32);
            this.rbSex2.TabIndex = 1;
            this.rbSex2.Text = "女";
            this.rbSex2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 477);
            this.label13.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "單位地址";
            // 
            // mtbCarryDate
            // 
            this.mtbCarryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbCarryDate.Location = new System.Drawing.Point(142, 363);
            this.mtbCarryDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCarryDate.Mask = "900-90-90";
            this.mtbCarryDate.Name = "mtbCarryDate";
            this.mtbCarryDate.Size = new System.Drawing.Size(108, 29);
            this.mtbCarryDate.TabIndex = 13;
            this.mtbCarryDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.mtbCarryDate.Enter += new System.EventHandler(this.edit_Enter);
            this.mtbCarryDate.Validated += new System.EventHandler(this.mtbDate_Validated);
            // 
            // mtbPlanDate
            // 
            this.mtbPlanDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPlanDate.Location = new System.Drawing.Point(142, 326);
            this.mtbPlanDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtbPlanDate.Mask = "900-90-90";
            this.mtbPlanDate.Name = "mtbPlanDate";
            this.mtbPlanDate.Size = new System.Drawing.Size(108, 29);
            this.mtbPlanDate.TabIndex = 12;
            this.mtbPlanDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.mtbPlanDate.Enter += new System.EventHandler(this.edit_Enter);
            this.mtbPlanDate.Validated += new System.EventHandler(this.mtbDate_Validated);
            // 
            // mtbOrderDate
            // 
            this.mtbOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbOrderDate.Location = new System.Drawing.Point(142, 289);
            this.mtbOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtbOrderDate.Mask = "900-90-90";
            this.mtbOrderDate.Name = "mtbOrderDate";
            this.mtbOrderDate.Size = new System.Drawing.Size(108, 29);
            this.mtbOrderDate.TabIndex = 11;
            this.mtbOrderDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.mtbOrderDate.Enter += new System.EventHandler(this.edit_Enter);
            this.mtbOrderDate.Validated += new System.EventHandler(this.mtbDate_Validated);
            // 
            // mtbBirthday
            // 
            this.mtbBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbBirthday.Location = new System.Drawing.Point(620, 88);
            this.mtbBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.mtbBirthday.Mask = "900-90-90";
            this.mtbBirthday.Name = "mtbBirthday";
            this.mtbBirthday.Size = new System.Drawing.Size(108, 29);
            this.mtbBirthday.TabIndex = 4;
            this.mtbBirthday.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.mtbBirthday.Enter += new System.EventHandler(this.edit_Enter);
            this.mtbBirthday.Validated += new System.EventHandler(this.mtbDate_Validated);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbKuXiaWeiP, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label29, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label30, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbJianKuan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbLingKouP, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbShangWei, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbXiaWei, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbXiuChang, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbXiuKou, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbQianXiong, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbHouBei, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbShenChang, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbBeiChang, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbBeiXin, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbLingKou, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbBeiXinP, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbBeiChangP, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbShenChangP, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbHouBeiP, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbQianXiongP, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbXiuKouP, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbXiuChangP, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbLaLianP, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbKuYaoP, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbXiaWeiP, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbKuKouP, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbShangWeiP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbZhongDangP, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label41, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbKaiDangP, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label40, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label39, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label38, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbZhongChangP, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label37, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label36, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbKuChangP, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label35, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbKuYao, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label34, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label33, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label32, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbYaoDai, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbKuXiaWei, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbKuChang, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLaLian, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbZhongChang, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbKouZi, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbShangDang, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbKuKou, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbKaiDang, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbZhongDang, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbShangDangP, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbKouZiP, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbYaoDaiP, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbJianKuanP, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 550);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 419);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(0, 38);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 28);
            this.label22.TabIndex = 31;
            this.label22.Text = "上圍";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(0, 76);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 28);
            this.label23.TabIndex = 31;
            this.label23.Text = "下圍";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(0, 114);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 28);
            this.label24.TabIndex = 31;
            this.label24.Text = "袖長";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(0, 152);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 28);
            this.label25.TabIndex = 31;
            this.label25.Text = "袖口";
            // 
            // cbKuXiaWeiP
            // 
            this.cbKuXiaWeiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKuXiaWeiP.FormattingEnabled = true;
            this.cbKuXiaWeiP.Location = new System.Drawing.Point(640, 38);
            this.cbKuXiaWeiP.Margin = new System.Windows.Forms.Padding(0);
            this.cbKuXiaWeiP.Name = "cbKuXiaWeiP";
            this.cbKuXiaWeiP.Size = new System.Drawing.Size(273, 35);
            this.cbKuXiaWeiP.TabIndex = 25;
            this.cbKuXiaWeiP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbKuXiaWeiP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(0, 190);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 28);
            this.label26.TabIndex = 31;
            this.label26.Text = "前胸";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(0, 228);
            this.label27.Margin = new System.Windows.Forms.Padding(0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 28);
            this.label27.TabIndex = 31;
            this.label27.Text = "後背";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(0, 266);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 28);
            this.label28.TabIndex = 31;
            this.label28.Text = "身長";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(0, 304);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 28);
            this.label29.TabIndex = 31;
            this.label29.Text = "背長";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(0, 342);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 28);
            this.label30.TabIndex = 31;
            this.label30.Text = "背心";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(0, 380);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 28);
            this.label31.TabIndex = 31;
            this.label31.Text = "領口";
            // 
            // tbJianKuan
            // 
            this.tbJianKuan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbJianKuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJianKuan.Location = new System.Drawing.Point(60, 4);
            this.tbJianKuan.Margin = new System.Windows.Forms.Padding(0);
            this.tbJianKuan.Name = "tbJianKuan";
            this.tbJianKuan.Size = new System.Drawing.Size(111, 29);
            this.tbJianKuan.TabIndex = 0;
            this.tbJianKuan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbJianKuan.Enter += new System.EventHandler(this.edit_Enter);
            this.tbJianKuan.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbLingKouP
            // 
            this.cbLingKouP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLingKouP.FormattingEnabled = true;
            this.cbLingKouP.Location = new System.Drawing.Point(175, 380);
            this.cbLingKouP.Margin = new System.Windows.Forms.Padding(0);
            this.cbLingKouP.Name = "cbLingKouP";
            this.cbLingKouP.Size = new System.Drawing.Size(273, 35);
            this.cbLingKouP.TabIndex = 21;
            this.cbLingKouP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbLingKouP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 28);
            this.label21.TabIndex = 31;
            this.label21.Text = "肩寬";
            // 
            // tbShangWei
            // 
            this.tbShangWei.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbShangWei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbShangWei.Location = new System.Drawing.Point(60, 42);
            this.tbShangWei.Margin = new System.Windows.Forms.Padding(0);
            this.tbShangWei.Name = "tbShangWei";
            this.tbShangWei.Size = new System.Drawing.Size(111, 29);
            this.tbShangWei.TabIndex = 2;
            this.tbShangWei.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbShangWei.Enter += new System.EventHandler(this.edit_Enter);
            this.tbShangWei.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbXiaWei
            // 
            this.tbXiaWei.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbXiaWei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbXiaWei.Location = new System.Drawing.Point(60, 80);
            this.tbXiaWei.Margin = new System.Windows.Forms.Padding(0);
            this.tbXiaWei.Name = "tbXiaWei";
            this.tbXiaWei.Size = new System.Drawing.Size(111, 29);
            this.tbXiaWei.TabIndex = 4;
            this.tbXiaWei.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbXiaWei.Enter += new System.EventHandler(this.edit_Enter);
            this.tbXiaWei.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbXiuChang
            // 
            this.tbXiuChang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbXiuChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbXiuChang.Location = new System.Drawing.Point(60, 118);
            this.tbXiuChang.Margin = new System.Windows.Forms.Padding(0);
            this.tbXiuChang.Name = "tbXiuChang";
            this.tbXiuChang.Size = new System.Drawing.Size(111, 29);
            this.tbXiuChang.TabIndex = 6;
            this.tbXiuChang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbXiuChang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbXiuChang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbXiuKou
            // 
            this.tbXiuKou.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbXiuKou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbXiuKou.Location = new System.Drawing.Point(60, 156);
            this.tbXiuKou.Margin = new System.Windows.Forms.Padding(0);
            this.tbXiuKou.Name = "tbXiuKou";
            this.tbXiuKou.Size = new System.Drawing.Size(111, 29);
            this.tbXiuKou.TabIndex = 8;
            this.tbXiuKou.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbXiuKou.Enter += new System.EventHandler(this.edit_Enter);
            this.tbXiuKou.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbQianXiong
            // 
            this.tbQianXiong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbQianXiong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQianXiong.Location = new System.Drawing.Point(60, 194);
            this.tbQianXiong.Margin = new System.Windows.Forms.Padding(0);
            this.tbQianXiong.Name = "tbQianXiong";
            this.tbQianXiong.Size = new System.Drawing.Size(111, 29);
            this.tbQianXiong.TabIndex = 10;
            this.tbQianXiong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbQianXiong.Enter += new System.EventHandler(this.edit_Enter);
            this.tbQianXiong.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbHouBei
            // 
            this.tbHouBei.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbHouBei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHouBei.Location = new System.Drawing.Point(60, 232);
            this.tbHouBei.Margin = new System.Windows.Forms.Padding(0);
            this.tbHouBei.Name = "tbHouBei";
            this.tbHouBei.Size = new System.Drawing.Size(111, 29);
            this.tbHouBei.TabIndex = 12;
            this.tbHouBei.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbHouBei.Enter += new System.EventHandler(this.edit_Enter);
            this.tbHouBei.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbShenChang
            // 
            this.tbShenChang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbShenChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbShenChang.Location = new System.Drawing.Point(60, 270);
            this.tbShenChang.Margin = new System.Windows.Forms.Padding(0);
            this.tbShenChang.Name = "tbShenChang";
            this.tbShenChang.Size = new System.Drawing.Size(111, 29);
            this.tbShenChang.TabIndex = 14;
            this.tbShenChang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbShenChang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbShenChang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbBeiChang
            // 
            this.tbBeiChang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbBeiChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBeiChang.Location = new System.Drawing.Point(60, 308);
            this.tbBeiChang.Margin = new System.Windows.Forms.Padding(0);
            this.tbBeiChang.Name = "tbBeiChang";
            this.tbBeiChang.Size = new System.Drawing.Size(111, 29);
            this.tbBeiChang.TabIndex = 16;
            this.tbBeiChang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbBeiChang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbBeiChang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbBeiXin
            // 
            this.tbBeiXin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbBeiXin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBeiXin.Location = new System.Drawing.Point(60, 346);
            this.tbBeiXin.Margin = new System.Windows.Forms.Padding(0);
            this.tbBeiXin.Name = "tbBeiXin";
            this.tbBeiXin.Size = new System.Drawing.Size(111, 29);
            this.tbBeiXin.TabIndex = 18;
            this.tbBeiXin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbBeiXin.Enter += new System.EventHandler(this.edit_Enter);
            this.tbBeiXin.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbLingKou
            // 
            this.tbLingKou.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLingKou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLingKou.Location = new System.Drawing.Point(60, 385);
            this.tbLingKou.Margin = new System.Windows.Forms.Padding(0);
            this.tbLingKou.Name = "tbLingKou";
            this.tbLingKou.Size = new System.Drawing.Size(111, 29);
            this.tbLingKou.TabIndex = 20;
            this.tbLingKou.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbLingKou.Enter += new System.EventHandler(this.edit_Enter);
            this.tbLingKou.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbBeiXinP
            // 
            this.cbBeiXinP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBeiXinP.FormattingEnabled = true;
            this.cbBeiXinP.Location = new System.Drawing.Point(175, 342);
            this.cbBeiXinP.Margin = new System.Windows.Forms.Padding(0);
            this.cbBeiXinP.Name = "cbBeiXinP";
            this.cbBeiXinP.Size = new System.Drawing.Size(273, 35);
            this.cbBeiXinP.TabIndex = 19;
            this.cbBeiXinP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbBeiXinP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbBeiChangP
            // 
            this.cbBeiChangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBeiChangP.FormattingEnabled = true;
            this.cbBeiChangP.Location = new System.Drawing.Point(175, 304);
            this.cbBeiChangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbBeiChangP.Name = "cbBeiChangP";
            this.cbBeiChangP.Size = new System.Drawing.Size(273, 35);
            this.cbBeiChangP.TabIndex = 17;
            this.cbBeiChangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbBeiChangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbShenChangP
            // 
            this.cbShenChangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShenChangP.FormattingEnabled = true;
            this.cbShenChangP.Location = new System.Drawing.Point(175, 266);
            this.cbShenChangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbShenChangP.Name = "cbShenChangP";
            this.cbShenChangP.Size = new System.Drawing.Size(273, 35);
            this.cbShenChangP.TabIndex = 15;
            this.cbShenChangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbShenChangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbHouBeiP
            // 
            this.cbHouBeiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHouBeiP.FormattingEnabled = true;
            this.cbHouBeiP.Location = new System.Drawing.Point(175, 228);
            this.cbHouBeiP.Margin = new System.Windows.Forms.Padding(0);
            this.cbHouBeiP.Name = "cbHouBeiP";
            this.cbHouBeiP.Size = new System.Drawing.Size(273, 35);
            this.cbHouBeiP.TabIndex = 13;
            this.cbHouBeiP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbHouBeiP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbQianXiongP
            // 
            this.cbQianXiongP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQianXiongP.FormattingEnabled = true;
            this.cbQianXiongP.Location = new System.Drawing.Point(175, 190);
            this.cbQianXiongP.Margin = new System.Windows.Forms.Padding(0);
            this.cbQianXiongP.Name = "cbQianXiongP";
            this.cbQianXiongP.Size = new System.Drawing.Size(273, 35);
            this.cbQianXiongP.TabIndex = 11;
            this.cbQianXiongP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbQianXiongP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbXiuKouP
            // 
            this.cbXiuKouP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbXiuKouP.FormattingEnabled = true;
            this.cbXiuKouP.Location = new System.Drawing.Point(175, 152);
            this.cbXiuKouP.Margin = new System.Windows.Forms.Padding(0);
            this.cbXiuKouP.Name = "cbXiuKouP";
            this.cbXiuKouP.Size = new System.Drawing.Size(273, 35);
            this.cbXiuKouP.TabIndex = 9;
            this.cbXiuKouP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbXiuKouP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbXiuChangP
            // 
            this.cbXiuChangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbXiuChangP.FormattingEnabled = true;
            this.cbXiuChangP.Location = new System.Drawing.Point(175, 114);
            this.cbXiuChangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbXiuChangP.Name = "cbXiuChangP";
            this.cbXiuChangP.Size = new System.Drawing.Size(273, 35);
            this.cbXiuChangP.TabIndex = 7;
            this.cbXiuChangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbXiuChangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbLaLianP
            // 
            this.cbLaLianP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLaLianP.FormattingEnabled = true;
            this.cbLaLianP.Location = new System.Drawing.Point(640, 342);
            this.cbLaLianP.Margin = new System.Windows.Forms.Padding(0);
            this.cbLaLianP.Name = "cbLaLianP";
            this.cbLaLianP.Size = new System.Drawing.Size(273, 35);
            this.cbLaLianP.TabIndex = 41;
            this.cbLaLianP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbLaLianP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbKuYaoP
            // 
            this.cbKuYaoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKuYaoP.FormattingEnabled = true;
            this.cbKuYaoP.Location = new System.Drawing.Point(640, 0);
            this.cbKuYaoP.Margin = new System.Windows.Forms.Padding(0);
            this.cbKuYaoP.Name = "cbKuYaoP";
            this.cbKuYaoP.Size = new System.Drawing.Size(273, 35);
            this.cbKuYaoP.TabIndex = 23;
            this.cbKuYaoP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbKuYaoP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(465, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 28);
            this.label20.TabIndex = 31;
            this.label20.Text = "褲腰";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbXiaWeiP
            // 
            this.cbXiaWeiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbXiaWeiP.FormattingEnabled = true;
            this.cbXiaWeiP.Location = new System.Drawing.Point(175, 76);
            this.cbXiaWeiP.Margin = new System.Windows.Forms.Padding(0);
            this.cbXiaWeiP.Name = "cbXiaWeiP";
            this.cbXiaWeiP.Size = new System.Drawing.Size(273, 35);
            this.cbXiaWeiP.TabIndex = 5;
            this.cbXiaWeiP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbXiaWeiP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbKuKouP
            // 
            this.cbKuKouP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKuKouP.FormattingEnabled = true;
            this.cbKuKouP.Location = new System.Drawing.Point(640, 266);
            this.cbKuKouP.Margin = new System.Windows.Forms.Padding(0);
            this.cbKuKouP.Name = "cbKuKouP";
            this.cbKuKouP.Size = new System.Drawing.Size(273, 35);
            this.cbKuKouP.TabIndex = 37;
            this.cbKuKouP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbKuKouP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbShangWeiP
            // 
            this.cbShangWeiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShangWeiP.FormattingEnabled = true;
            this.cbShangWeiP.Location = new System.Drawing.Point(175, 38);
            this.cbShangWeiP.Margin = new System.Windows.Forms.Padding(0);
            this.cbShangWeiP.Name = "cbShangWeiP";
            this.cbShangWeiP.Size = new System.Drawing.Size(273, 35);
            this.cbShangWeiP.TabIndex = 3;
            this.cbShangWeiP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbShangWeiP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbZhongDangP
            // 
            this.cbZhongDangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbZhongDangP.FormattingEnabled = true;
            this.cbZhongDangP.Location = new System.Drawing.Point(640, 228);
            this.cbZhongDangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbZhongDangP.Name = "cbZhongDangP";
            this.cbZhongDangP.Size = new System.Drawing.Size(273, 35);
            this.cbZhongDangP.TabIndex = 35;
            this.cbZhongDangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbZhongDangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(465, 380);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 28);
            this.label41.TabIndex = 31;
            this.label41.Text = "腰帶";
            // 
            // cbKaiDangP
            // 
            this.cbKaiDangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKaiDangP.FormattingEnabled = true;
            this.cbKaiDangP.Location = new System.Drawing.Point(640, 190);
            this.cbKaiDangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbKaiDangP.Name = "cbKaiDangP";
            this.cbKaiDangP.Size = new System.Drawing.Size(273, 35);
            this.cbKaiDangP.TabIndex = 33;
            this.cbKaiDangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbKaiDangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(465, 342);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 28);
            this.label40.TabIndex = 31;
            this.label40.Text = "拉鍊";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(465, 304);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 28);
            this.label39.TabIndex = 31;
            this.label39.Text = "釦子";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(465, 266);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(56, 28);
            this.label38.TabIndex = 31;
            this.label38.Text = "褲口";
            // 
            // cbZhongChangP
            // 
            this.cbZhongChangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbZhongChangP.FormattingEnabled = true;
            this.cbZhongChangP.Location = new System.Drawing.Point(640, 114);
            this.cbZhongChangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbZhongChangP.Name = "cbZhongChangP";
            this.cbZhongChangP.Size = new System.Drawing.Size(273, 35);
            this.cbZhongChangP.TabIndex = 29;
            this.cbZhongChangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbZhongChangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(465, 228);
            this.label37.Margin = new System.Windows.Forms.Padding(0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 28);
            this.label37.TabIndex = 31;
            this.label37.Text = "中檔";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(465, 190);
            this.label36.Margin = new System.Windows.Forms.Padding(0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 28);
            this.label36.TabIndex = 31;
            this.label36.Text = "開檔";
            // 
            // cbKuChangP
            // 
            this.cbKuChangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKuChangP.Location = new System.Drawing.Point(640, 76);
            this.cbKuChangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbKuChangP.Name = "cbKuChangP";
            this.cbKuChangP.Size = new System.Drawing.Size(273, 35);
            this.cbKuChangP.TabIndex = 27;
            this.cbKuChangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbKuChangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(465, 152);
            this.label35.Margin = new System.Windows.Forms.Padding(0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 28);
            this.label35.TabIndex = 31;
            this.label35.Text = "上檔";
            // 
            // tbKuYao
            // 
            this.tbKuYao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbKuYao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKuYao.Location = new System.Drawing.Point(525, 4);
            this.tbKuYao.Margin = new System.Windows.Forms.Padding(0);
            this.tbKuYao.Name = "tbKuYao";
            this.tbKuYao.Size = new System.Drawing.Size(111, 29);
            this.tbKuYao.TabIndex = 22;
            this.tbKuYao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbKuYao.Enter += new System.EventHandler(this.edit_Enter);
            this.tbKuYao.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(465, 114);
            this.label34.Margin = new System.Windows.Forms.Padding(0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 28);
            this.label34.TabIndex = 31;
            this.label34.Text = "中長";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(465, 76);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(56, 28);
            this.label33.TabIndex = 31;
            this.label33.Text = "褲長";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(465, 38);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 28);
            this.label32.TabIndex = 31;
            this.label32.Text = "下圍";
            // 
            // tbYaoDai
            // 
            this.tbYaoDai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbYaoDai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYaoDai.Location = new System.Drawing.Point(525, 385);
            this.tbYaoDai.Margin = new System.Windows.Forms.Padding(0);
            this.tbYaoDai.Name = "tbYaoDai";
            this.tbYaoDai.Size = new System.Drawing.Size(111, 29);
            this.tbYaoDai.TabIndex = 42;
            this.tbYaoDai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbYaoDai.Enter += new System.EventHandler(this.edit_Enter);
            this.tbYaoDai.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbKuXiaWei
            // 
            this.tbKuXiaWei.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbKuXiaWei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKuXiaWei.Location = new System.Drawing.Point(525, 42);
            this.tbKuXiaWei.Margin = new System.Windows.Forms.Padding(0);
            this.tbKuXiaWei.Name = "tbKuXiaWei";
            this.tbKuXiaWei.Size = new System.Drawing.Size(111, 29);
            this.tbKuXiaWei.TabIndex = 24;
            this.tbKuXiaWei.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbKuXiaWei.Enter += new System.EventHandler(this.edit_Enter);
            this.tbKuXiaWei.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbKuChang
            // 
            this.tbKuChang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbKuChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKuChang.Location = new System.Drawing.Point(525, 80);
            this.tbKuChang.Margin = new System.Windows.Forms.Padding(0);
            this.tbKuChang.Name = "tbKuChang";
            this.tbKuChang.Size = new System.Drawing.Size(111, 29);
            this.tbKuChang.TabIndex = 26;
            this.tbKuChang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbKuChang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbKuChang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbLaLian
            // 
            this.tbLaLian.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLaLian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLaLian.Location = new System.Drawing.Point(525, 346);
            this.tbLaLian.Margin = new System.Windows.Forms.Padding(0);
            this.tbLaLian.Name = "tbLaLian";
            this.tbLaLian.Size = new System.Drawing.Size(111, 29);
            this.tbLaLian.TabIndex = 40;
            this.tbLaLian.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbLaLian.Enter += new System.EventHandler(this.edit_Enter);
            this.tbLaLian.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbZhongChang
            // 
            this.tbZhongChang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbZhongChang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZhongChang.Location = new System.Drawing.Point(525, 118);
            this.tbZhongChang.Margin = new System.Windows.Forms.Padding(0);
            this.tbZhongChang.Name = "tbZhongChang";
            this.tbZhongChang.Size = new System.Drawing.Size(111, 29);
            this.tbZhongChang.TabIndex = 28;
            this.tbZhongChang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbZhongChang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbZhongChang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbKouZi
            // 
            this.tbKouZi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbKouZi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKouZi.Location = new System.Drawing.Point(525, 308);
            this.tbKouZi.Margin = new System.Windows.Forms.Padding(0);
            this.tbKouZi.Name = "tbKouZi";
            this.tbKouZi.Size = new System.Drawing.Size(111, 29);
            this.tbKouZi.TabIndex = 38;
            this.tbKouZi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbKouZi.Enter += new System.EventHandler(this.edit_Enter);
            this.tbKouZi.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbShangDang
            // 
            this.tbShangDang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbShangDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbShangDang.Location = new System.Drawing.Point(525, 156);
            this.tbShangDang.Margin = new System.Windows.Forms.Padding(0);
            this.tbShangDang.Name = "tbShangDang";
            this.tbShangDang.Size = new System.Drawing.Size(111, 29);
            this.tbShangDang.TabIndex = 30;
            this.tbShangDang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbShangDang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbShangDang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbKuKou
            // 
            this.tbKuKou.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbKuKou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKuKou.Location = new System.Drawing.Point(525, 270);
            this.tbKuKou.Margin = new System.Windows.Forms.Padding(0);
            this.tbKuKou.Name = "tbKuKou";
            this.tbKuKou.Size = new System.Drawing.Size(111, 29);
            this.tbKuKou.TabIndex = 36;
            this.tbKuKou.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbKuKou.Enter += new System.EventHandler(this.edit_Enter);
            this.tbKuKou.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbKaiDang
            // 
            this.tbKaiDang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbKaiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKaiDang.Location = new System.Drawing.Point(525, 194);
            this.tbKaiDang.Margin = new System.Windows.Forms.Padding(0);
            this.tbKaiDang.Name = "tbKaiDang";
            this.tbKaiDang.Size = new System.Drawing.Size(111, 29);
            this.tbKaiDang.TabIndex = 32;
            this.tbKaiDang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbKaiDang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbKaiDang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbZhongDang
            // 
            this.tbZhongDang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbZhongDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZhongDang.Location = new System.Drawing.Point(525, 232);
            this.tbZhongDang.Margin = new System.Windows.Forms.Padding(0);
            this.tbZhongDang.Name = "tbZhongDang";
            this.tbZhongDang.Size = new System.Drawing.Size(111, 29);
            this.tbZhongDang.TabIndex = 34;
            this.tbZhongDang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbZhongDang.Enter += new System.EventHandler(this.edit_Enter);
            this.tbZhongDang.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbShangDangP
            // 
            this.cbShangDangP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShangDangP.FormattingEnabled = true;
            this.cbShangDangP.Location = new System.Drawing.Point(640, 152);
            this.cbShangDangP.Margin = new System.Windows.Forms.Padding(0);
            this.cbShangDangP.Name = "cbShangDangP";
            this.cbShangDangP.Size = new System.Drawing.Size(273, 35);
            this.cbShangDangP.TabIndex = 31;
            this.cbShangDangP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbShangDangP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbKouZiP
            // 
            this.cbKouZiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKouZiP.FormattingEnabled = true;
            this.cbKouZiP.Location = new System.Drawing.Point(640, 304);
            this.cbKouZiP.Margin = new System.Windows.Forms.Padding(0);
            this.cbKouZiP.Name = "cbKouZiP";
            this.cbKouZiP.Size = new System.Drawing.Size(273, 35);
            this.cbKouZiP.TabIndex = 39;
            this.cbKouZiP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbKouZiP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbYaoDaiP
            // 
            this.cbYaoDaiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYaoDaiP.FormattingEnabled = true;
            this.cbYaoDaiP.Location = new System.Drawing.Point(640, 380);
            this.cbYaoDaiP.Margin = new System.Windows.Forms.Padding(0);
            this.cbYaoDaiP.Name = "cbYaoDaiP";
            this.cbYaoDaiP.Size = new System.Drawing.Size(273, 35);
            this.cbYaoDaiP.TabIndex = 43;
            this.cbYaoDaiP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbYaoDaiP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // cbJianKuanP
            // 
            this.cbJianKuanP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbJianKuanP.FormattingEnabled = true;
            this.cbJianKuanP.Location = new System.Drawing.Point(175, 0);
            this.cbJianKuanP.Margin = new System.Windows.Forms.Padding(0);
            this.cbJianKuanP.Name = "cbJianKuanP";
            this.cbJianKuanP.Size = new System.Drawing.Size(273, 35);
            this.cbJianKuanP.TabIndex = 1;
            this.cbJianKuanP.Enter += new System.EventHandler(this.edit_Enter);
            this.cbJianKuanP.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 198);
            this.label18.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 28);
            this.label18.TabIndex = 31;
            this.label18.Text = "單位地址";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(505, 161);
            this.label17.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 28);
            this.label17.TabIndex = 31;
            this.label17.Text = "單位電話";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 28);
            this.label14.TabIndex = 31;
            this.label14.Text = "電話";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 160);
            this.label16.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 28);
            this.label16.TabIndex = 31;
            this.label16.Text = "單位名稱";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 124);
            this.label15.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 28);
            this.label15.TabIndex = 31;
            this.label15.Text = "地址";
            // 
            // tbCompanyAddress
            // 
            this.tbCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCompanyAddress.Location = new System.Drawing.Point(142, 198);
            this.tbCompanyAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompanyAddress.Name = "tbCompanyAddress";
            this.tbCompanyAddress.Size = new System.Drawing.Size(804, 29);
            this.tbCompanyAddress.TabIndex = 9;
            this.tbCompanyAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbCompanyAddress.Enter += new System.EventHandler(this.edit_Enter);
            this.tbCompanyAddress.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbCompanyTelephone
            // 
            this.tbCompanyTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCompanyTelephone.Location = new System.Drawing.Point(620, 161);
            this.tbCompanyTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompanyTelephone.Name = "tbCompanyTelephone";
            this.tbCompanyTelephone.Size = new System.Drawing.Size(326, 29);
            this.tbCompanyTelephone.TabIndex = 8;
            this.tbCompanyTelephone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbCompanyTelephone.Enter += new System.EventHandler(this.edit_Enter);
            this.tbCompanyTelephone.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCompanyName.Location = new System.Drawing.Point(142, 161);
            this.tbCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(326, 29);
            this.tbCompanyName.TabIndex = 7;
            this.tbCompanyName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbCompanyName.Enter += new System.EventHandler(this.edit_Enter);
            this.tbCompanyName.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(71, 13);
            this.label44.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(56, 28);
            this.label44.TabIndex = 31;
            this.label44.Text = "編號";
            // 
            // tbTelephone
            // 
            this.tbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelephone.Location = new System.Drawing.Point(142, 87);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(326, 29);
            this.tbTelephone.TabIndex = 3;
            this.tbTelephone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbTelephone.Enter += new System.EventHandler(this.edit_Enter);
            this.tbTelephone.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Location = new System.Drawing.Point(142, 124);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(804, 29);
            this.tbAddress.TabIndex = 6;
            this.tbAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbAddress.Enter += new System.EventHandler(this.edit_Enter);
            this.tbAddress.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "姓名";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(505, 50);
            this.label19.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 28);
            this.label19.TabIndex = 31;
            this.label19.Text = "身分字號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "性別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "生日";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomerName.Location = new System.Drawing.Point(142, 50);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(326, 29);
            this.tbCustomerName.TabIndex = 1;
            this.tbCustomerName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbCustomerName.Enter += new System.EventHandler(this.edit_Enter);
            this.tbCustomerName.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbCustomerCode
            // 
            this.tbCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomerCode.Location = new System.Drawing.Point(142, 13);
            this.tbCustomerCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerCode.Name = "tbCustomerCode";
            this.tbCustomerCode.Size = new System.Drawing.Size(326, 29);
            this.tbCustomerCode.TabIndex = 0;
            this.tbCustomerCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbCustomerCode.Enter += new System.EventHandler(this.edit_Enter);
            this.tbCustomerCode.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbIDCard
            // 
            this.tbIDCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDCard.Location = new System.Drawing.Point(620, 50);
            this.tbIDCard.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDCard.Name = "tbIDCard";
            this.tbIDCard.Size = new System.Drawing.Size(326, 29);
            this.tbIDCard.TabIndex = 2;
            this.tbIDCard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbIDCard.Enter += new System.EventHandler(this.edit_Enter);
            this.tbIDCard.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "預交日期";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 440);
            this.label12.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 28);
            this.label12.TabIndex = 31;
            this.label12.Text = "單位電話";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 440);
            this.label11.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 28);
            this.label11.TabIndex = 31;
            this.label11.Text = "單位名稱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 363);
            this.label9.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 28);
            this.label9.TabIndex = 31;
            this.label9.Text = "收款";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 28);
            this.label8.TabIndex = 31;
            this.label8.Text = "定金";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "總價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "取件日期";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(27, 253);
            this.label42.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 28);
            this.label42.TabIndex = 31;
            this.label42.Text = "訂單編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "訂購日期";
            // 
            // tbTicketCode
            // 
            this.tbTicketCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTicketCode.Location = new System.Drawing.Point(142, 252);
            this.tbTicketCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbTicketCode.Name = "tbTicketCode";
            this.tbTicketCode.Size = new System.Drawing.Size(326, 29);
            this.tbTicketCode.TabIndex = 10;
            this.tbTicketCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbTicketCode.Enter += new System.EventHandler(this.edit_Enter);
            this.tbTicketCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_number_KeyPress);
            this.tbTicketCode.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbRemark
            // 
            this.tbRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRemark.Location = new System.Drawing.Point(142, 514);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(804, 29);
            this.tbRemark.TabIndex = 23;
            this.tbRemark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbRemark.DoubleClick += new System.EventHandler(this.unmask_DoubleClick);
            this.tbRemark.Enter += new System.EventHandler(this.edit_Enter);
            this.tbRemark.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbTicketCompanyAddress
            // 
            this.tbTicketCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTicketCompanyAddress.Location = new System.Drawing.Point(142, 477);
            this.tbTicketCompanyAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbTicketCompanyAddress.Name = "tbTicketCompanyAddress";
            this.tbTicketCompanyAddress.Size = new System.Drawing.Size(804, 29);
            this.tbTicketCompanyAddress.TabIndex = 22;
            this.tbTicketCompanyAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbTicketCompanyAddress.Enter += new System.EventHandler(this.edit_Enter);
            this.tbTicketCompanyAddress.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbTicketCompanyTelephone
            // 
            this.tbTicketCompanyTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTicketCompanyTelephone.Location = new System.Drawing.Point(620, 440);
            this.tbTicketCompanyTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTicketCompanyTelephone.Name = "tbTicketCompanyTelephone";
            this.tbTicketCompanyTelephone.Size = new System.Drawing.Size(326, 29);
            this.tbTicketCompanyTelephone.TabIndex = 21;
            this.tbTicketCompanyTelephone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbTicketCompanyTelephone.Enter += new System.EventHandler(this.edit_Enter);
            this.tbTicketCompanyTelephone.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbTicketCompanyName
            // 
            this.tbTicketCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTicketCompanyName.Location = new System.Drawing.Point(142, 440);
            this.tbTicketCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTicketCompanyName.Name = "tbTicketCompanyName";
            this.tbTicketCompanyName.Size = new System.Drawing.Size(326, 29);
            this.tbTicketCompanyName.TabIndex = 20;
            this.tbTicketCompanyName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbTicketCompanyName.Enter += new System.EventHandler(this.edit_Enter);
            this.tbTicketCompanyName.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalPrice.Location = new System.Drawing.Point(620, 289);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(326, 29);
            this.tbTotalPrice.TabIndex = 15;
            this.tbTotalPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbTotalPrice.Enter += new System.EventHandler(this.edit_Enter);
            this.tbTotalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_number_KeyPress);
            this.tbTotalPrice.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbEarnest
            // 
            this.tbEarnest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEarnest.Location = new System.Drawing.Point(620, 326);
            this.tbEarnest.Margin = new System.Windows.Forms.Padding(4);
            this.tbEarnest.Name = "tbEarnest";
            this.tbEarnest.Size = new System.Drawing.Size(326, 29);
            this.tbEarnest.TabIndex = 15;
            this.tbEarnest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbEarnest.Enter += new System.EventHandler(this.edit_Enter);
            this.tbEarnest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_number_KeyPress);
            this.tbEarnest.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // tbAccountReceived
            // 
            this.tbAccountReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAccountReceived.Location = new System.Drawing.Point(620, 363);
            this.tbAccountReceived.Margin = new System.Windows.Forms.Padding(4);
            this.tbAccountReceived.Name = "tbAccountReceived";
            this.tbAccountReceived.Size = new System.Drawing.Size(326, 29);
            this.tbAccountReceived.TabIndex = 17;
            this.tbAccountReceived.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edit_MouseClick);
            this.tbAccountReceived.Enter += new System.EventHandler(this.edit_Enter);
            this.tbAccountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_number_KeyPress);
            this.tbAccountReceived.Leave += new System.EventHandler(this.edit_Leave);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnTicketPrint);
            this.panelMain.Controls.Add(this.btnCustomerDelete);
            this.panelMain.Controls.Add(this.btnCustomerNew);
            this.panelMain.Controls.Add(this.btnTicketDelete);
            this.panelMain.Controls.Add(this.btnTicketNew);
            this.panelMain.Controls.Add(this.btnEdit);
            this.panelMain.Controls.Add(this.tabMain);
            this.panelMain.Controls.Add(this.tableLayoutPanel4);
            this.panelMain.Controls.Add(this.tableLayoutPanel3);
            this.panelMain.Controls.Add(this.tableLayoutPanel2);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1276, 1000);
            this.panelMain.TabIndex = 134;
            this.panelMain.Visible = false;
            // 
            // btnTicketPrint
            // 
            this.btnTicketPrint.AutoSize = true;
            this.btnTicketPrint.Location = new System.Drawing.Point(1183, 876);
            this.btnTicketPrint.Name = "btnTicketPrint";
            this.btnTicketPrint.Size = new System.Drawing.Size(93, 34);
            this.btnTicketPrint.TabIndex = 133;
            this.btnTicketPrint.Text = "列印";
            this.btnTicketPrint.UseVisualStyleBackColor = true;
            this.btnTicketPrint.Click += new System.EventHandler(this.btnTicketPrint_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.AutoSize = true;
            this.btnCustomerDelete.Location = new System.Drawing.Point(1149, 12);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(125, 34);
            this.btnCustomerDelete.TabIndex = 1;
            this.btnCustomerDelete.Text = "刪除顧客";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerNew
            // 
            this.btnCustomerNew.AutoSize = true;
            this.btnCustomerNew.Location = new System.Drawing.Point(730, 12);
            this.btnCustomerNew.Name = "btnCustomerNew";
            this.btnCustomerNew.Size = new System.Drawing.Size(125, 34);
            this.btnCustomerNew.TabIndex = 1;
            this.btnCustomerNew.Text = "新增顧客";
            this.btnCustomerNew.UseVisualStyleBackColor = true;
            this.btnCustomerNew.Click += new System.EventHandler(this.btnCustomerNew_Click);
            // 
            // btnTicketDelete
            // 
            this.btnTicketDelete.AutoSize = true;
            this.btnTicketDelete.Location = new System.Drawing.Point(1016, 12);
            this.btnTicketDelete.Name = "btnTicketDelete";
            this.btnTicketDelete.Size = new System.Drawing.Size(125, 34);
            this.btnTicketDelete.TabIndex = 1;
            this.btnTicketDelete.Text = "刪除訂單";
            this.btnTicketDelete.UseVisualStyleBackColor = true;
            this.btnTicketDelete.Click += new System.EventHandler(this.btnTicketDelete_Click);
            // 
            // btnTicketNew
            // 
            this.btnTicketNew.AutoSize = true;
            this.btnTicketNew.Location = new System.Drawing.Point(599, 12);
            this.btnTicketNew.Name = "btnTicketNew";
            this.btnTicketNew.Size = new System.Drawing.Size(125, 34);
            this.btnTicketNew.TabIndex = 1;
            this.btnTicketNew.Text = "新增訂單";
            this.btnTicketNew.UseVisualStyleBackColor = true;
            this.btnTicketNew.Click += new System.EventHandler(this.btnTicketNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Location = new System.Drawing.Point(861, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel4.Controls.Add(this.label94, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label95, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.showAddress, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.showCompanyTelephone, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.label101, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.showSex, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.showBirthday, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.showCustomerCode, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label105, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label106, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label107, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label108, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label110, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label111, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label112, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.showTelephone, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.showIDCard, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.showCompanyAddress, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.showCompanyName, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.showCustomerName, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(595, 52);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(679, 190);
            this.tableLayoutPanel4.TabIndex = 132;
            // 
            // label94
            // 
            this.label94.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(46, 0);
            this.label94.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(48, 24);
            this.label94.TabIndex = 40;
            this.label94.Text = "姓名";
            // 
            // label95
            // 
            this.label95.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(8, 32);
            this.label95.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(86, 24);
            this.label95.TabIndex = 42;
            this.label95.Text = "身分字號";
            // 
            // showAddress
            // 
            this.showAddress.BackColor = System.Drawing.SystemColors.Info;
            this.showAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel4.SetColumnSpan(this.showAddress, 3);
            this.showAddress.Location = new System.Drawing.Point(100, 96);
            this.showAddress.Margin = new System.Windows.Forms.Padding(0);
            this.showAddress.Name = "showAddress";
            this.showAddress.ReadOnly = true;
            this.showAddress.Size = new System.Drawing.Size(533, 25);
            this.showAddress.TabIndex = 45;
            this.showAddress.TabStop = false;
            // 
            // showCompanyTelephone
            // 
            this.showCompanyTelephone.BackColor = System.Drawing.SystemColors.Info;
            this.showCompanyTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCompanyTelephone.Location = new System.Drawing.Point(403, 129);
            this.showCompanyTelephone.Margin = new System.Windows.Forms.Padding(1);
            this.showCompanyTelephone.Name = "showCompanyTelephone";
            this.showCompanyTelephone.ReadOnly = true;
            this.showCompanyTelephone.Size = new System.Drawing.Size(230, 25);
            this.showCompanyTelephone.TabIndex = 47;
            this.showCompanyTelephone.TabStop = false;
            // 
            // label101
            // 
            this.label101.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(46, 64);
            this.label101.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(48, 24);
            this.label101.TabIndex = 0;
            this.label101.Text = "電話";
            // 
            // showSex
            // 
            this.showSex.BackColor = System.Drawing.SystemColors.Info;
            this.showSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showSex.Location = new System.Drawing.Point(403, 65);
            this.showSex.Margin = new System.Windows.Forms.Padding(1);
            this.showSex.Name = "showSex";
            this.showSex.ReadOnly = true;
            this.showSex.Size = new System.Drawing.Size(230, 25);
            this.showSex.TabIndex = 33;
            this.showSex.TabStop = false;
            // 
            // showBirthday
            // 
            this.showBirthday.BackColor = System.Drawing.SystemColors.Info;
            this.showBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showBirthday.Location = new System.Drawing.Point(403, 33);
            this.showBirthday.Margin = new System.Windows.Forms.Padding(1);
            this.showBirthday.Name = "showBirthday";
            this.showBirthday.ReadOnly = true;
            this.showBirthday.Size = new System.Drawing.Size(230, 25);
            this.showBirthday.TabIndex = 33;
            this.showBirthday.TabStop = false;
            // 
            // showCustomerCode
            // 
            this.showCustomerCode.BackColor = System.Drawing.SystemColors.Info;
            this.showCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCustomerCode.Location = new System.Drawing.Point(403, 1);
            this.showCustomerCode.Margin = new System.Windows.Forms.Padding(1);
            this.showCustomerCode.Name = "showCustomerCode";
            this.showCustomerCode.ReadOnly = true;
            this.showCustomerCode.Size = new System.Drawing.Size(230, 25);
            this.showCustomerCode.TabIndex = 33;
            this.showCustomerCode.TabStop = false;
            // 
            // label105
            // 
            this.label105.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(46, 96);
            this.label105.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(48, 24);
            this.label105.TabIndex = 52;
            this.label105.Text = "地址";
            // 
            // label106
            // 
            this.label106.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(8, 128);
            this.label106.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(86, 24);
            this.label106.TabIndex = 51;
            this.label106.Text = "單位名稱";
            // 
            // label107
            // 
            this.label107.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(8, 160);
            this.label107.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(86, 24);
            this.label107.TabIndex = 49;
            this.label107.Text = "單位地址";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(346, 128);
            this.label108.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(48, 24);
            this.label108.TabIndex = 50;
            this.label108.Text = "電話";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(346, 64);
            this.label110.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(48, 24);
            this.label110.TabIndex = 44;
            this.label110.Text = "性別";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(346, 0);
            this.label111.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(48, 24);
            this.label111.TabIndex = 41;
            this.label111.Text = "編號";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(346, 32);
            this.label112.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(48, 24);
            this.label112.TabIndex = 43;
            this.label112.Text = "生日";
            // 
            // showTelephone
            // 
            this.showTelephone.BackColor = System.Drawing.SystemColors.Info;
            this.showTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTelephone.Location = new System.Drawing.Point(100, 64);
            this.showTelephone.Margin = new System.Windows.Forms.Padding(0);
            this.showTelephone.Name = "showTelephone";
            this.showTelephone.ReadOnly = true;
            this.showTelephone.Size = new System.Drawing.Size(230, 25);
            this.showTelephone.TabIndex = 1;
            this.showTelephone.TabStop = false;
            // 
            // showIDCard
            // 
            this.showIDCard.BackColor = System.Drawing.SystemColors.Info;
            this.showIDCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showIDCard.Location = new System.Drawing.Point(100, 32);
            this.showIDCard.Margin = new System.Windows.Forms.Padding(0);
            this.showIDCard.Name = "showIDCard";
            this.showIDCard.ReadOnly = true;
            this.showIDCard.Size = new System.Drawing.Size(230, 25);
            this.showIDCard.TabIndex = 34;
            this.showIDCard.TabStop = false;
            // 
            // showCompanyAddress
            // 
            this.showCompanyAddress.BackColor = System.Drawing.SystemColors.Info;
            this.showCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel4.SetColumnSpan(this.showCompanyAddress, 3);
            this.showCompanyAddress.Location = new System.Drawing.Point(100, 160);
            this.showCompanyAddress.Margin = new System.Windows.Forms.Padding(0);
            this.showCompanyAddress.Name = "showCompanyAddress";
            this.showCompanyAddress.ReadOnly = true;
            this.showCompanyAddress.Size = new System.Drawing.Size(533, 25);
            this.showCompanyAddress.TabIndex = 48;
            this.showCompanyAddress.TabStop = false;
            // 
            // showCompanyName
            // 
            this.showCompanyName.BackColor = System.Drawing.SystemColors.Info;
            this.showCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCompanyName.Location = new System.Drawing.Point(100, 128);
            this.showCompanyName.Margin = new System.Windows.Forms.Padding(0);
            this.showCompanyName.Name = "showCompanyName";
            this.showCompanyName.ReadOnly = true;
            this.showCompanyName.Size = new System.Drawing.Size(230, 25);
            this.showCompanyName.TabIndex = 46;
            this.showCompanyName.TabStop = false;
            // 
            // showCustomerName
            // 
            this.showCustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.showCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCustomerName.Location = new System.Drawing.Point(100, 0);
            this.showCustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.showCustomerName.Name = "showCustomerName";
            this.showCustomerName.ReadOnly = true;
            this.showCustomerName.Size = new System.Drawing.Size(230, 25);
            this.showCustomerName.TabIndex = 32;
            this.showCustomerName.TabStop = false;
            // 
            // rvReport
            // 
            reportDataSource1.Name = "Ticket";
            reportDataSource1.Value = this.ticketBindingSource;
            reportDataSource2.Name = "TicketJacket";
            reportDataSource2.Value = this.ticketJacketBindingSource;
            reportDataSource3.Name = "TicketTrousers";
            reportDataSource3.Value = this.ticketTrousersBindingSource;
            this.rvReport.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReport.LocalReport.DataSources.Add(reportDataSource2);
            this.rvReport.LocalReport.DataSources.Add(reportDataSource3);
            this.rvReport.LocalReport.ReportEmbeddedResource = "gxxf.TicketReport.rdlc";
            this.rvReport.Location = new System.Drawing.Point(6, 61);
            this.rvReport.Name = "rvReport";
            this.rvReport.Size = new System.Drawing.Size(1266, 936);
            this.rvReport.TabIndex = 135;
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.btnBack);
            this.panelPrint.Controls.Add(this.rvReport);
            this.panelPrint.Location = new System.Drawing.Point(0, 0);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(1275, 1000);
            this.panelPrint.TabIndex = 136;
            this.panelPrint.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 34);
            this.btnBack.TabIndex = 136;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 1009);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "國信西服";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gxxfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketJacketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTrousersBindingSource)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryTicket)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterBindingSource)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbQueryCustomer;
        private gxxfDataSet gxxfDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private gxxfDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private gxxfDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private gxxfDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridView dgvCustomerTicket;
        private System.Windows.Forms.BindingSource ticketJacketBindingSource;
        private gxxfDataSetTableAdapters.TicketJacketTableAdapter ticketJacketTableAdapter;
        private System.Windows.Forms.BindingSource ticketTrousersBindingSource;
        private gxxfDataSetTableAdapters.TicketTrousersTableAdapter ticketTrousersTableAdapter;
        private gxxfDataSetTableAdapters.ParameterTableAdapter parameterTableAdapter;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private gxxfDataSetTableAdapters.AppUserTableAdapter appUserTableAdapter;
        private System.Windows.Forms.Button btnUpdateReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payoff;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox showTicketCode;
        private System.Windows.Forms.TextBox showTicketCompanyTelephone;
        private System.Windows.Forms.TextBox showTicketCompanyName;
        private System.Windows.Forms.TextBox showTotalPrice;
        private System.Windows.Forms.TextBox showEarnest;
        private System.Windows.Forms.TextBox showAccountReceived;
        private System.Windows.Forms.TextBox showBalance;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox showJianKuan;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox showShangWei;
        private System.Windows.Forms.TextBox showXiaWei;
        private System.Windows.Forms.TextBox showXiuChang;
        private System.Windows.Forms.TextBox showXiuKou;
        private System.Windows.Forms.TextBox showQianXiong;
        private System.Windows.Forms.TextBox showHouBei;
        private System.Windows.Forms.TextBox showShenChang;
        private System.Windows.Forms.TextBox showBeiChang;
        private System.Windows.Forms.TextBox showBeiXin;
        private System.Windows.Forms.TextBox showLingKou;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox showOrderDate;
        private System.Windows.Forms.TextBox showPlanDate;
        private System.Windows.Forms.TextBox showCarryDate;
        private System.Windows.Forms.TextBox showJianKuanP;
        private System.Windows.Forms.TextBox showShangWeiP;
        private System.Windows.Forms.TextBox showXiaWeiP;
        private System.Windows.Forms.TextBox showXiuChangP;
        private System.Windows.Forms.TextBox showXiuKouP;
        private System.Windows.Forms.TextBox showQianXiongP;
        private System.Windows.Forms.TextBox showHouBeiP;
        private System.Windows.Forms.TextBox showShenChangP;
        private System.Windows.Forms.TextBox showBeiChangP;
        private System.Windows.Forms.TextBox showBeiXinP;
        private System.Windows.Forms.TextBox showLingKouP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox showYaoDaiP;
        private System.Windows.Forms.TextBox showLaLianP;
        private System.Windows.Forms.TextBox showKouZiP;
        private System.Windows.Forms.TextBox showKuKouP;
        private System.Windows.Forms.TextBox showZhongDangP;
        private System.Windows.Forms.TextBox showKaiDangP;
        private System.Windows.Forms.TextBox showShangDangP;
        private System.Windows.Forms.TextBox showZhongChangP;
        private System.Windows.Forms.TextBox showKuChangP;
        private System.Windows.Forms.TextBox showKuXiaWeiP;
        private System.Windows.Forms.TextBox showKuYaoP;
        private System.Windows.Forms.TextBox showYaoDai;
        private System.Windows.Forms.TextBox showLaLian;
        private System.Windows.Forms.TextBox showKouZi;
        private System.Windows.Forms.TextBox showKuKou;
        private System.Windows.Forms.TextBox showZhongDang;
        private System.Windows.Forms.TextBox showKaiDang;
        private System.Windows.Forms.TextBox showShangDang;
        private System.Windows.Forms.TextBox showZhongChang;
        private System.Windows.Forms.TextBox showKuChang;
        private System.Windows.Forms.TextBox showKuYao;
        private System.Windows.Forms.TextBox showKuXiaWei;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbKuXiaWeiP;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbJianKuan;
        private System.Windows.Forms.ComboBox cbLingKouP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbShangWei;
        private System.Windows.Forms.TextBox tbXiaWei;
        private System.Windows.Forms.TextBox tbXiuChang;
        private System.Windows.Forms.TextBox tbXiuKou;
        private System.Windows.Forms.TextBox tbQianXiong;
        private System.Windows.Forms.TextBox tbHouBei;
        private System.Windows.Forms.TextBox tbShenChang;
        private System.Windows.Forms.TextBox tbBeiChang;
        private System.Windows.Forms.TextBox tbBeiXin;
        private System.Windows.Forms.TextBox tbLingKou;
        private System.Windows.Forms.ComboBox cbBeiXinP;
        private System.Windows.Forms.ComboBox cbBeiChangP;
        private System.Windows.Forms.ComboBox cbShenChangP;
        private System.Windows.Forms.ComboBox cbHouBeiP;
        private System.Windows.Forms.ComboBox cbQianXiongP;
        private System.Windows.Forms.ComboBox cbXiuKouP;
        private System.Windows.Forms.ComboBox cbYaoDaiP;
        private System.Windows.Forms.ComboBox cbXiuChangP;
        private System.Windows.Forms.ComboBox cbLaLianP;
        private System.Windows.Forms.ComboBox cbKuYaoP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbXiaWeiP;
        private System.Windows.Forms.ComboBox cbKuKouP;
        private System.Windows.Forms.ComboBox cbShangWeiP;
        private System.Windows.Forms.ComboBox cbZhongDangP;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cbKaiDangP;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cbZhongChangP;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cbKuChangP;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbKuYao;
        private System.Windows.Forms.TextBox tbYaoDai;
        private System.Windows.Forms.TextBox tbKuXiaWei;
        private System.Windows.Forms.TextBox tbKuChang;
        private System.Windows.Forms.TextBox tbLaLian;
        private System.Windows.Forms.TextBox tbZhongChang;
        private System.Windows.Forms.TextBox tbKouZi;
        private System.Windows.Forms.TextBox tbShangDang;
        private System.Windows.Forms.TextBox tbKuKou;
        private System.Windows.Forms.TextBox tbKaiDang;
        private System.Windows.Forms.TextBox tbZhongDang;
        private System.Windows.Forms.ComboBox cbShangDangP;
        private System.Windows.Forms.ComboBox cbKouZiP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCompanyAddress;
        private System.Windows.Forms.TextBox tbCompanyTelephone;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerCode;
        private System.Windows.Forms.TextBox tbIDCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicketCode;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbTicketCompanyAddress;
        private System.Windows.Forms.TextBox tbTicketCompanyTelephone;
        private System.Windows.Forms.TextBox tbTicketCompanyName;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbEarnest;
        private System.Windows.Forms.TextBox tbAccountReceived;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MaskedTextBox queryOrderDate1;
        private System.Windows.Forms.MaskedTextBox queryOrderDate2;
        private System.Windows.Forms.MaskedTextBox queryPlanDate2;
        private System.Windows.Forms.MaskedTextBox queryPlanDate1;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.MaskedTextBox queryCarryDate2;
        private System.Windows.Forms.MaskedTextBox queryCarryDate1;
        private System.Windows.Forms.CheckBox queryIfCarry2;
        private System.Windows.Forms.CheckBox queryIfCarry1;
        private System.Windows.Forms.CheckBox queryIfPayoff2;
        private System.Windows.Forms.CheckBox queryIfPayoff1;
        private System.Windows.Forms.ComboBox queryCompanyName;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TextBox showAddress;
        private System.Windows.Forms.TextBox showCompanyTelephone;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox showSex;
        private System.Windows.Forms.TextBox showBirthday;
        private System.Windows.Forms.TextBox showCustomerCode;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox showTelephone;
        private System.Windows.Forms.TextBox showIDCard;
        private System.Windows.Forms.TextBox showCompanyAddress;
        private System.Windows.Forms.TextBox showCompanyName;
        private System.Windows.Forms.TextBox showCustomerName;
        private System.Windows.Forms.MaskedTextBox mtbBirthday;
        private System.Windows.Forms.MaskedTextBox mtbCarryDate;
        private System.Windows.Forms.MaskedTextBox mtbPlanDate;
        private System.Windows.Forms.MaskedTextBox mtbOrderDate;
        private System.Windows.Forms.RadioButton rbSex2;
        private System.Windows.Forms.RadioButton rbSex1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbJianKuanP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbIfCarry2;
        private System.Windows.Forms.RadioButton rbIfCarry1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbIfPayoff2;
        private System.Windows.Forms.RadioButton rbIfPayoff1;
        private System.Windows.Forms.Button btnEditCommit;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnTicketNew;
        private System.Windows.Forms.DataGridView dgvQueryTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView dgvQueryReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.TextBox showTicketCompanyAddress;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox showIfCarry;
        private System.Windows.Forms.TextBox showIfPayoff;
        private System.Windows.Forms.Button btnCustomerNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox showRemark;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnTicketDelete;
        private Microsoft.Reporting.WinForms.ReportViewer rvReport;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Button btnTicketPrint;
        private System.Windows.Forms.Button btnReportPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.DataGridView dgvParameter;
        private System.Windows.Forms.BindingSource parameterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.Button btnParameterNew;
        private System.Windows.Forms.Button btnParameterDelete;
        private System.Windows.Forms.Button btnParameterUpdate;
        private System.Windows.Forms.Label lbLoginPrompt;
    }
}


using System;
using System.Windows.Forms;

namespace eShiftTransportSystem
{
    public partial class AdminDashboard : Form
    {
        private Button btnManageJobs;
        private Button btnGenerateReport;
        private Button btnManageCustomers;
        private Button btnManageProducts;
        private PictureBox pictureBox1;
        private Button btnLogout;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Text = "e-Shift - Admin Dashboard";
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.btnManageJobs = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageJobs
            // 
            this.btnManageJobs.BackColor = System.Drawing.Color.Blue;
            this.btnManageJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageJobs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageJobs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageJobs.Location = new System.Drawing.Point(70, 204);
            this.btnManageJobs.Name = "btnManageJobs";
            this.btnManageJobs.Size = new System.Drawing.Size(134, 76);
            this.btnManageJobs.TabIndex = 0;
            this.btnManageJobs.Text = "Manage Jobs";
            this.btnManageJobs.UseVisualStyleBackColor = false;
            this.btnManageJobs.Click += new System.EventHandler(this.btnManageJobs_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Blue;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateReport.Location = new System.Drawing.Point(323, 330);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(134, 76);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.Blue;
            this.btnManageCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCustomers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageCustomers.Location = new System.Drawing.Point(323, 204);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(134, 76);
            this.btnManageCustomers.TabIndex = 2;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.BackColor = System.Drawing.Color.Blue;
            this.btnManageProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageProducts.Location = new System.Drawing.Point(70, 330);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(134, 76);
            this.btnManageProducts.TabIndex = 3;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(366, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(535, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManageJobs);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnLogout);
            this.MaximumSize = new System.Drawing.Size(553, 510);
            this.MinimumSize = new System.Drawing.Size(553, 510);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnManageJobs_Click(object sender, EventArgs e)
        {
            new ManageJobsForm().ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            new GenerateReportForm().ShowDialog();
        }

        // New event handler for Manage Customers
        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            // This form will need to be created
            new ManageCustomersForm().ShowDialog();
        }

        // New event handler for Manage Products
        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            // This form will need to be created
            new ManageProductsForm().ShowDialog();
        }

        // Event handler for Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Go back to the login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close(); // Close the current dashboard form
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome, Admin!");
        }
    }

}
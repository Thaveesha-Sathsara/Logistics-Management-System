using System;
using System.Linq;
using System.Windows.Forms;
using eShiftTransportSystem;

namespace eShiftTransportSystem
{
    public partial class CustomerDashboard : Form
    {
        private Button btnRequestJob;
        private Button btnViewMyJobs; 
        private Button btnLogout;
        private ListBox lstMyJobs;
        private Label lblWelcome; 
        private PictureBox pictureBox1;
        private int _loggedInCustomerId;

        // Constructor to receive the logged-in CustomerId
        public CustomerDashboard(int customerId)
        {
            InitializeComponent();
            this.Text = "e-Shift - Customer Dashboard";
            _loggedInCustomerId = customerId; // Store the ID
            LoadCustomerInfo(); // Load customer-specific data
            LoadMyJobs(); // Load jobs for this customer
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.btnRequestJob = new System.Windows.Forms.Button();
            this.btnViewMyJobs = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstMyJobs = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequestJob
            // 
            this.btnRequestJob.BackColor = System.Drawing.Color.Blue;
            this.btnRequestJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestJob.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestJob.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRequestJob.Location = new System.Drawing.Point(26, 111);
            this.btnRequestJob.Name = "btnRequestJob";
            this.btnRequestJob.Size = new System.Drawing.Size(227, 49);
            this.btnRequestJob.TabIndex = 0;
            this.btnRequestJob.Text = "Request New Job";
            this.btnRequestJob.UseVisualStyleBackColor = false;
            this.btnRequestJob.Click += new System.EventHandler(this.btnRequestJob_Click);
            // 
            // btnViewMyJobs
            // 
            this.btnViewMyJobs.BackColor = System.Drawing.Color.Blue;
            this.btnViewMyJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMyJobs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMyJobs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewMyJobs.Location = new System.Drawing.Point(26, 196);
            this.btnViewMyJobs.Name = "btnViewMyJobs";
            this.btnViewMyJobs.Size = new System.Drawing.Size(227, 48);
            this.btnViewMyJobs.TabIndex = 1;
            this.btnViewMyJobs.Text = "View My Jobs";
            this.btnViewMyJobs.UseVisualStyleBackColor = false;
            this.btnViewMyJobs.Click += new System.EventHandler(this.btnViewMyJobs_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(26, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 43);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstMyJobs
            // 
            this.lstMyJobs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstMyJobs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMyJobs.FormattingEnabled = true;
            this.lstMyJobs.ItemHeight = 20;
            this.lstMyJobs.Location = new System.Drawing.Point(278, 90);
            this.lstMyJobs.Name = "lstMyJobs";
            this.lstMyJobs.Size = new System.Drawing.Size(400, 424);
            this.lstMyJobs.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(154, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(411, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Customer!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CustomerDashboard
            // 
            this.ClientSize = new System.Drawing.Size(706, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRequestJob);
            this.Controls.Add(this.btnViewMyJobs);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lstMyJobs);
            this.Controls.Add(this.lblWelcome);
            this.MaximumSize = new System.Drawing.Size(724, 591);
            this.MinimumSize = new System.Drawing.Size(724, 591);
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadCustomerInfo()
        {
            // Find the customer by ID and update the welcome label
            Customer loggedInCustomer = Program.Customers.FirstOrDefault(c => c.Id == _loggedInCustomerId);
            if (loggedInCustomer != null)
            {
                lblWelcome.Text = $"Welcome, {loggedInCustomer.Name}!";
            }
            else
            {
                lblWelcome.Text = "Welcome, Customer!"; // Fallback
            }
        }

        private void LoadMyJobs()
        {
            lstMyJobs.Items.Clear();
            // Filter jobs by the logged-in customer's ID
            var customerJobs = Program.Jobs.Where(j => j.CustomerId == _loggedInCustomerId).ToList();

            if (customerJobs.Any())
            {
                foreach (var job in customerJobs)
                {
                    // Display more comprehensive job details
                    lstMyJobs.Items.Add($"Job #{job.JobId}: From {job.PickupLocation} to {job.DeliveryLocation} - JobStatus: {job.JobStatus}");
                }
            }
            else
            {
                lstMyJobs.Items.Add("You have no active or past job requests.");
            }
        }

        private void btnRequestJob_Click(object sender, EventArgs e)
        {
            // Pass the logged-in customer ID to the JobRequestForm
            JobRequestForm jobRequestForm = new JobRequestForm(_loggedInCustomerId);
            // ShowDialog() is good here as it forces the user to finish with the sub-form
            // before interacting with the dashboard again.
            jobRequestForm.ShowDialog();
            // Refresh jobs after a new job might have been added
            LoadMyJobs();
        }

        private void btnViewMyJobs_Click(object sender, EventArgs e)
        {
            LoadMyJobs(); // Simply refresh the list
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close(); // Close the current dashboard
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
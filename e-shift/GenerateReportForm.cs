using eShiftTransportSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eShiftTransportSystem
{
    public partial class GenerateReportForm : Form
    {
        private Button btnGenerate;
        private RichTextBox rtbReportOutput; // To display report in UI
        private ComboBox cmbReportType;     // To select report type/filter
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label lblReportType;

        public GenerateReportForm()
        {
            InitializeComponent();
            this.Text = "e-Shift - Generate Reports";
            PopulateReportTypes(); // Populate the combo box
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReportForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbReportOutput = new System.Windows.Forms.RichTextBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Blue;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerate.Location = new System.Drawing.Point(523, 129);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(214, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rtbReportOutput
            // 
            this.rtbReportOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbReportOutput.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReportOutput.Location = new System.Drawing.Point(50, 202);
            this.rtbReportOutput.Name = "rtbReportOutput";
            this.rtbReportOutput.ReadOnly = true;
            this.rtbReportOutput.Size = new System.Drawing.Size(864, 538);
            this.rtbReportOutput.TabIndex = 2;
            this.rtbReportOutput.Text = "";
            // 
            // cmbReportType
            // 
            this.cmbReportType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReportType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(204, 141);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(251, 35);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(47, 141);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(141, 27);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(242, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 44);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "e-Shift System | Generate Report";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GenerateReportForm
            // 
            this.ClientSize = new System.Drawing.Size(974, 763);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rtbReportOutput);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.lblReportType);
            this.MaximumSize = new System.Drawing.Size(992, 810);
            this.MinimumSize = new System.Drawing.Size(992, 810);
            this.Name = "GenerateReportForm";
            this.Text = "Generate Report";
            this.Load += new System.EventHandler(this.GenerateReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PopulateReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("All Jobs");
            cmbReportType.Items.Add("Pending Jobs");
            cmbReportType.Items.Add("Approved Jobs");
            cmbReportType.Items.Add("Declined Jobs");
            // Add more if you have Product or Customer reports later
            cmbReportType.SelectedIndex = 0; // Default to "All Jobs"
        }

        private void GenerateReport()
        {
            StringBuilder reportBuilder = new StringBuilder();
            string selectedReportType = cmbReportType.SelectedItem?.ToString();
            List<Job> jobsToReport = new List<Job>();

            reportBuilder.AppendLine("--- e-Shift Transport System Report ---");
            reportBuilder.AppendLine($"Report Type: {selectedReportType}");
            reportBuilder.AppendLine($"Generated On: {DateTime.Now}");
            reportBuilder.AppendLine("------------------------------------");
            reportBuilder.AppendLine();

            switch (selectedReportType)
            {
                case "All Jobs":
                    jobsToReport = Program.Jobs.ToList(); // Use ToList() to ensure a new list, good practice
                    break;
                case "Pending Jobs":
                    // Compare with the enum member
                    jobsToReport = Program.Jobs.Where(j => j.JobStatus == Job.JobStatusEnum.Pending).ToList();
                    break;
                case "Approved Jobs":
                    // Assuming "Approved" maps to "Assigned"
                    jobsToReport = Program.Jobs.Where(j => j.JobStatus == Job.JobStatusEnum.Assigned).ToList();
                    break;
                case "Declined Jobs":
                    // Assuming "Declined" maps to "Cancelled"
                    jobsToReport = Program.Jobs.Where(j => j.JobStatus == Job.JobStatusEnum.Cancelled).ToList();
                    break;
                default:
                    jobsToReport = Program.Jobs.ToList(); // Default to all jobs
                    break;
            }

            if (!jobsToReport.Any())
            {
                reportBuilder.AppendLine("No jobs found for the selected criteria.");
            }
            else
            {
                foreach (var job in jobsToReport)
                {
                    // Find the customer for this job to include their name
                    Customer customer = Program.Customers.FirstOrDefault(c => c.Id == job.CustomerId);
                    string customerName = customer != null ? customer.Name : "N/A";

                    reportBuilder.AppendLine($"Job ID: {job.JobId}");
                    reportBuilder.AppendLine($"Customer Name: {customerName}");
                    reportBuilder.AppendLine($"Route: {job.PickupLocation} to {job.DeliveryLocation}");
                    reportBuilder.AppendLine($"JobStatus: {job.JobStatus}");
                    reportBuilder.AppendLine("---");
                }
            }

            rtbReportOutput.Text = reportBuilder.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateReport(); // Generate and display the report
                              // Option to save to file:
            try
            {
                string fileName = $"report_{cmbReportType.SelectedItem?.ToString().Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                File.WriteAllText(fileName, rtbReportOutput.Text);
                MessageBox.Show($"Report saved to {fileName}", "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving report: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optionally auto-generate report when selection changes
            GenerateReport();
        }

        private void GenerateReportForm_Load(object sender, EventArgs e)
        {
            GenerateReport(); // Generate initial report on load
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
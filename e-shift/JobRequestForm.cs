using eShiftTransportSystem;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class JobRequestForm : Form
{
    private TextBox txtStartLocation;
    private TextBox txtEndLocation;
    private Button btnSubmit;
    private Label labelStartLocation;
    private Label labelEndLocation; 
    private Label lblTitle;
    private PictureBox pictureBox1;
    private int _loggedInCustomerId;

    public JobRequestForm(int customerId)
    {
        InitializeComponent();
        this.Text = "e-Shift - Request New Job";
        _loggedInCustomerId = customerId;
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobRequestForm));
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.txtEndLocation = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelStartLocation = new System.Windows.Forms.Label();
            this.labelEndLocation = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartLocation.Location = new System.Drawing.Point(329, 184);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(251, 34);
            this.txtStartLocation.TabIndex = 0;
            // 
            // txtEndLocation
            // 
            this.txtEndLocation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndLocation.Location = new System.Drawing.Point(329, 257);
            this.txtEndLocation.Name = "txtEndLocation";
            this.txtEndLocation.Size = new System.Drawing.Size(251, 34);
            this.txtEndLocation.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(285, 358);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 52);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Job";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelStartLocation
            // 
            this.labelStartLocation.AutoSize = true;
            this.labelStartLocation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartLocation.Location = new System.Drawing.Point(138, 187);
            this.labelStartLocation.Name = "labelStartLocation";
            this.labelStartLocation.Size = new System.Drawing.Size(158, 27);
            this.labelStartLocation.TabIndex = 3;
            this.labelStartLocation.Text = "Start Location:";
            // 
            // labelEndLocation
            // 
            this.labelEndLocation.AutoSize = true;
            this.labelEndLocation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndLocation.Location = new System.Drawing.Point(138, 260);
            this.labelEndLocation.Name = "labelEndLocation";
            this.labelEndLocation.Size = new System.Drawing.Size(147, 27);
            this.labelEndLocation.TabIndex = 4;
            this.labelEndLocation.Text = "End Location:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(184, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 44);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "e-Shift System | Request New Job";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // JobRequestForm
            // 
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEndLocation);
            this.Controls.Add(this.labelStartLocation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEndLocation);
            this.Controls.Add(this.txtStartLocation);
            this.MaximumSize = new System.Drawing.Size(770, 501);
            this.MinimumSize = new System.Drawing.Size(770, 501);
            this.Name = "JobRequestForm";
            this.Text = "Request New Job";
            this.Load += new System.EventHandler(this.JobRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        // Input validation
        if (string.IsNullOrWhiteSpace(txtStartLocation.Text))
        {
            MessageBox.Show("Start location cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtStartLocation.Focus();
            return;
        }
        if (string.IsNullOrWhiteSpace(txtEndLocation.Text))
        {
            MessageBox.Show("End location cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEndLocation.Focus();
            return;
        }

        try
        {
            Job job = new Job
            {
                JobId = Program.Jobs.Any() ? Program.Jobs.Max(j => j.JobId) + 1 : 1, // Generate unique ID
                CustomerId = _loggedInCustomerId, // Use the actual logged-in customer's ID
                PickupLocation = txtStartLocation.Text.Trim(),
                DeliveryLocation = txtEndLocation.Text.Trim(),
                JobStatus = Job.JobStatusEnum.Pending
            };

            Program.Jobs.Add(job);
            DataManager.SaveData(); // Save data after adding a new job
            MessageBox.Show("Job request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while submitting the job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void JobRequestForm_Load(object sender, EventArgs e)
    {
    }

    private void lblTitle_Click(object sender, EventArgs e)
    {

    }
}
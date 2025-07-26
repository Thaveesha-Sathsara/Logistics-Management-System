using eShiftTransportSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eShiftTransportSystem
{
    public partial class ManageJobsForm : Form
    {
        private Button btnApprove;
        private Button btnDecline;
        private Button btnAssignTransportUnit;
        private ListBox lstJobs;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label lblInstructions;

        public ManageJobsForm()
        {
            InitializeComponent();
            this.Text = "e-Shift - Manage Transport Operations";
            LoadJobs(); // Load jobs when the form opens
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageJobsForm));
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAssignTransportUnit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstJobs
            // 
            this.lstJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstJobs.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 23;
            this.lstJobs.Location = new System.Drawing.Point(17, 193);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(885, 418);
            this.lstJobs.TabIndex = 0;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Blue;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApprove.Location = new System.Drawing.Point(951, 193);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(190, 54);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve Job";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.Red;
            this.btnDecline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecline.Location = new System.Drawing.Point(951, 298);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(190, 54);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "Decline Job";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAssignTransportUnit
            // 
            this.btnAssignTransportUnit.BackColor = System.Drawing.Color.Blue;
            this.btnAssignTransportUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignTransportUnit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTransportUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssignTransportUnit.Location = new System.Drawing.Point(951, 404);
            this.btnAssignTransportUnit.Name = "btnAssignTransportUnit";
            this.btnAssignTransportUnit.Size = new System.Drawing.Size(190, 54);
            this.btnAssignTransportUnit.TabIndex = 4;
            this.btnAssignTransportUnit.Text = "Assign Unit";
            this.btnAssignTransportUnit.UseVisualStyleBackColor = false;
            this.btnAssignTransportUnit.Click += new System.EventHandler(this.btnAssignTransportUnit_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 142);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(631, 27);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Select a job from the list to approve, decline, or assign a unit.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(247, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(721, 44);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "e-Shift System | Manage Transport Operations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ManageJobsForm
            // 
            this.ClientSize = new System.Drawing.Size(1181, 663);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnAssignTransportUnit);
            this.Controls.Add(this.lstJobs);
            this.MaximumSize = new System.Drawing.Size(1199, 710);
            this.MinimumSize = new System.Drawing.Size(1199, 710);
            this.Name = "ManageJobsForm";
            this.Text = "Manage Transport Operations";
            this.Load += new System.EventHandler(this.ManageJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadJobs()
        {
            lstJobs.Items.Clear();
            if (Program.Jobs.Any())
            {
                // Optionally sort jobs for a consistent display, e.g., Pending first, then by ID
                var sortedJobs = Program.Jobs
                                        .OrderBy(j => j.JobStatus == Job.JobStatusEnum.Pending ? 0 :
                                                      j.JobStatus == Job.JobStatusEnum.Assigned ? 1 :
                                                      j.JobStatus == Job.JobStatusEnum.InProgress ? 2 : 3)
                                        .ThenBy(j => j.JobId)
                                        .ToList();

                foreach (var job in sortedJobs)
                {
                    // Find the customer for this job to display their name
                    Customer customer = Program.Customers.FirstOrDefault(c => c.Id == job.CustomerId);
                    string customerName = customer != null ? customer.Name : "Unknown Customer";

                    // Add the actual Job object to the ListBox.
                    // The Job.ToString() override (from our previous discussion) will format it nicely.
                    lstJobs.Items.Add(job);
                }
            }
            else
            {
                lstJobs.Items.Add("No jobs currently available for management.");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Safely get the selected job from the ListBox
            if (lstJobs.SelectedItem is Job selectedJob)
            {
                // Only allow approval if the job is Pending
                if (selectedJob.JobStatus == Job.JobStatusEnum.Pending)
                {
                    selectedJob.JobStatus = Job.JobStatusEnum.Assigned; // Set to Assigned (which means Approved)
                    selectedJob.IsAssigned = true;

                    DataManager.SaveData(); // Save changes
                    MessageBox.Show($"Job #{selectedJob.JobId} has been Approved (Status: Assigned).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadJobs(); // Refresh the list to reflect the change
                }
                else if (selectedJob.JobStatus == Job.JobStatusEnum.Assigned)
                {
                    MessageBox.Show("Job is already Approved and ready for unit assignment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // For other statuses like InProgress, Completed, Cancelled, Declined
                {
                    MessageBox.Show($"Cannot approve a job in '{selectedJob.JobStatus}' status.", "Status Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lstJobs.SelectedIndex >= 0) // Case where "No jobs..." message is selected
            {
                MessageBox.Show("Please select a valid job to approve.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // No item selected
            {
                MessageBox.Show("Please select a job to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedItem is Job selectedJob) // Safely get selected job
            {
                // Only allow decline if the job is Pending or Assigned (not already in progress/completed)
                if (selectedJob.JobStatus == Job.JobStatusEnum.Pending || selectedJob.JobStatus == Job.JobStatusEnum.Assigned)
                {
                    selectedJob.JobStatus = Job.JobStatusEnum.Cancelled; // Set to Cancelled (which means Declined)
                    selectedJob.IsAssigned = false; // Ensure it's not considered assigned if cancelled
                    selectedJob.AssignedTransportUnitId = null; // Remove any assigned unit

                    // If a unit was previously assigned, make it available again
                    if (selectedJob.AssignedTransportUnitId.HasValue)
                    {
                        TransportUnit previouslyAssignedUnit = Program.TransportUnits.FirstOrDefault(u => u.UnitId == selectedJob.AssignedTransportUnitId.Value);
                        if (previouslyAssignedUnit != null)
                        {
                            previouslyAssignedUnit.IsAvailable = true;
                        }
                    }

                    DataManager.SaveData(); // Save changes
                    MessageBox.Show($"Job #{selectedJob.JobId} has been Declined.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadJobs(); // Refresh the list
                }
                else if (selectedJob.JobStatus == Job.JobStatusEnum.Cancelled)
                {
                    MessageBox.Show("Job is already Declined.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Job is in InProgress or Completed status
                {
                    MessageBox.Show($"Cannot decline a job in '{selectedJob.JobStatus}' status.", "Status Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lstJobs.SelectedIndex >= 0) { MessageBox.Show("Please select a valid job to decline.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else { MessageBox.Show("Please select a job to decline.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnAssignTransportUnit_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedItem is Job selectedJob) // Safely get selected job
            {
                // Condition 1: Job must be in 'Assigned' (Approved) status to receive a unit
                if (selectedJob.JobStatus == Job.JobStatusEnum.Assigned)
                {
                    // Condition 2: Job must NOT already have a unit assigned
                    // Using !HasValue for nullable int, or check if it's explicitly 0 if that's your 'no unit' value
                    if (!selectedJob.AssignedTransportUnitId.HasValue || selectedJob.AssignedTransportUnitId == 0)
                    {
                        // Open the assignment form
                        AssignTransportUnitForm assignForm = new AssignTransportUnitForm(selectedJob);
                        assignForm.ShowDialog(); // Show as dialog to pause execution until it closes

                        // After the assignment form closes, refresh the list
                        // The AssignTransportUnitForm should update selectedJob.AssignedTransportUnitId and potentially JobStatus to InProgress
                        LoadJobs();
                    }
                    else
                    {
                        // Job is in 'Assigned' status, but already has a unit.
                        MessageBox.Show($"Job #{selectedJob.JobId} already has a transport unit assigned (Unit ID: {selectedJob.AssignedTransportUnitId.Value}).", "Already Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (selectedJob.JobStatus == Job.JobStatusEnum.Pending)
                {
                    MessageBox.Show("This job must be 'Approved' first (set to 'Assigned' status) before a transport unit can be assigned.", "Cannot Assign Unit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // For Completed, Cancelled, InProgress, etc.
                {
                    MessageBox.Show($"A transport unit cannot be assigned to a job in '{selectedJob.JobStatus}' status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lstJobs.SelectedIndex >= 0) { MessageBox.Show("Please select a valid job.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else { MessageBox.Show("Please select a job to assign a transport unit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void ManageJobsForm_Load(object sender, EventArgs e)
        {
        }

        private void lstJobs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
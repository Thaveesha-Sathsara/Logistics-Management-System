using eShiftTransportSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class AssignTransportUnitForm : Form
{
    private Job _jobToAssign;

    private Label lblJobDetailsTitle;
    private Label lblJobId;
    private Label lblCustomerName;
    private Label lblRoute;
    private Label lblStatus;
    private Label lblSelectUnit;
    private ComboBox cmbAvailableUnits;
    private Button btnAssignUnit;
    private PictureBox pictureBox1;
    private Label lblTitle;
    private Button btnCancel;

    public AssignTransportUnitForm(Job job)
    {
        InitializeComponent();
        this.Text = "e-Shift - Assign Transport Unit";
        _jobToAssign = job;
        DisplayJobDetails();
        LoadAvailableTransportUnits();
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTransportUnitForm));
            this.lblJobDetailsTitle = new System.Windows.Forms.Label();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSelectUnit = new System.Windows.Forms.Label();
            this.cmbAvailableUnits = new System.Windows.Forms.ComboBox();
            this.btnAssignUnit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobDetailsTitle
            // 
            this.lblJobDetailsTitle.AutoSize = true;
            this.lblJobDetailsTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDetailsTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblJobDetailsTitle.Location = new System.Drawing.Point(53, 155);
            this.lblJobDetailsTitle.Name = "lblJobDetailsTitle";
            this.lblJobDetailsTitle.Size = new System.Drawing.Size(141, 31);
            this.lblJobDetailsTitle.TabIndex = 0;
            this.lblJobDetailsTitle.Text = "Job Details";
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobId.Location = new System.Drawing.Point(56, 201);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(82, 27);
            this.lblJobId.TabIndex = 1;
            this.lblJobId.Text = "Job ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(56, 243);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(182, 27);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(56, 279);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(78, 27);
            this.lblRoute.TabIndex = 3;
            this.lblRoute.Text = "Route:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(56, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 27);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "JobStatus:";
            // 
            // lblSelectUnit
            // 
            this.lblSelectUnit.AutoSize = true;
            this.lblSelectUnit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectUnit.Location = new System.Drawing.Point(56, 367);
            this.lblSelectUnit.Name = "lblSelectUnit";
            this.lblSelectUnit.Size = new System.Drawing.Size(231, 27);
            this.lblSelectUnit.TabIndex = 5;
            this.lblSelectUnit.Text = "Select Transport Unit:";
            // 
            // cmbAvailableUnits
            // 
            this.cmbAvailableUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAvailableUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableUnits.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvailableUnits.FormattingEnabled = true;
            this.cmbAvailableUnits.Location = new System.Drawing.Point(307, 364);
            this.cmbAvailableUnits.Name = "cmbAvailableUnits";
            this.cmbAvailableUnits.Size = new System.Drawing.Size(235, 35);
            this.cmbAvailableUnits.TabIndex = 0;
            // 
            // btnAssignUnit
            // 
            this.btnAssignUnit.BackColor = System.Drawing.Color.Blue;
            this.btnAssignUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignUnit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssignUnit.Location = new System.Drawing.Point(390, 446);
            this.btnAssignUnit.Name = "btnAssignUnit";
            this.btnAssignUnit.Size = new System.Drawing.Size(152, 40);
            this.btnAssignUnit.TabIndex = 1;
            this.btnAssignUnit.Text = "Assign Unit";
            this.btnAssignUnit.UseVisualStyleBackColor = false;
            this.btnAssignUnit.Click += new System.EventHandler(this.btnAssignUnit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(194, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(139, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 44);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "e-Shift System | Assign Transport Unit";
            // 
            // AssignTransportUnitForm
            // 
            this.ClientSize = new System.Drawing.Size(767, 517);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssignUnit);
            this.Controls.Add(this.cmbAvailableUnits);
            this.Controls.Add(this.lblSelectUnit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.lblJobDetailsTitle);
            this.MaximumSize = new System.Drawing.Size(785, 564);
            this.MinimumSize = new System.Drawing.Size(785, 564);
            this.Name = "AssignTransportUnitForm";
            this.Text = "Assign Transport Unit";
            this.Load += new System.EventHandler(this.AssignTransportUnitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void DisplayJobDetails()
    {
        if (_jobToAssign != null)
        {
            lblJobId.Text = $"Job ID: {_jobToAssign.JobId}";
            Customer customer = Program.Customers.FirstOrDefault(c => c.Id == _jobToAssign.CustomerId);
            lblCustomerName.Text = $"Customer Name: {(customer != null ? customer.Name : "N/A")}";
            lblRoute.Text = $"Route: {_jobToAssign.PickupLocation} to {_jobToAssign.DeliveryLocation}";
            lblStatus.Text = $"JobStatus: {_jobToAssign.JobStatus}";
        }
    }

    private void LoadAvailableTransportUnits()
    {
        cmbAvailableUnits.Items.Clear();
        // Filter for available units
        var availableUnits = Program.TransportUnits.Where(u => u.IsAvailable).ToList();

        if (availableUnits.Any())
        {
            foreach (var unit in availableUnits)
            {
                // Store the TransportUnit object directly in the ComboBox for easy retrieval
                cmbAvailableUnits.Items.Add(unit);
            }
            cmbAvailableUnits.DisplayMember = "LorryNumber"; // Display LorryNumber
            cmbAvailableUnits.ValueMember = "UnitId";       // Value will be UnitId (though not used directly for binding here)
            cmbAvailableUnits.SelectedIndex = 0;
        }
        else
        {
            MessageBox.Show("No available transport units found.", "No Units", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAssignUnit.Enabled = false; // Disable assign button if no units
        }
    }

    private void btnAssignUnit_Click(object sender, EventArgs e)
    {
        if (cmbAvailableUnits.SelectedItem == null)
        {
            MessageBox.Show("Please select a transport unit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            TransportUnit selectedUnit = cmbAvailableUnits.SelectedItem as TransportUnit;
            if (selectedUnit != null && _jobToAssign != null)
            {
                // Unassign previous unit if any
                if (_jobToAssign.AssignedTransportUnitId.HasValue)
                {
                    TransportUnit previousUnit = Program.TransportUnits.FirstOrDefault(u => u.UnitId == _jobToAssign.AssignedTransportUnitId.Value);
                    if (previousUnit != null)
                    {
                        previousUnit.IsAvailable = true; // Make previous unit available again
                    }
                }

                _jobToAssign.AssignedTransportUnitId = selectedUnit.UnitId;
                selectedUnit.IsAvailable = false; // Mark the selected unit as unavailable

                DataManager.SaveData(); // Save changes to job and transport unit
                MessageBox.Show($"Transport Unit {selectedUnit.LorryNumber} assigned to Job #{_jobToAssign.JobId} successfully!", "Assignment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred during assignment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close(); // Close the form without making changes
    }

    private void AssignTransportUnitForm_Load(object sender, EventArgs e)
    {

    }
}
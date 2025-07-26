using System;
using System.Linq;
using System.Windows.Forms;
using eShiftTransportSystem;
using System.Collections.Generic;

public partial class ManageCustomersForm : Form
{
    private DataGridView dgvCustomers;
    private Button btnAddCustomer;
    private Button btnEditCustomer;
    private Button btnDeleteCustomer;
    private Button btnRefreshCustomers;

    // Controls for individual customer details (for editing/adding)
    private GroupBox grpCustomerDetails;
    private Label lblId;
    private TextBox txtId; // Read-only
    private Label lblName;
    private TextBox txtName;
    private Label lblNIC;
    private TextBox txtNIC;
    private Label lblContact;
    private TextBox txtContact;
    private Label lblAddress;
    private TextBox txtAddress;
    private Label lblUsername;
    private TextBox txtUsername;
    private Label lblPassword;
    private TextBox txtPassword;
    private Button btnSaveCustomerChanges;
    private Button btnCancelEdit;
    private Label lblTitle;
    private PictureBox pictureBox1;
    private bool _isAddingNewCustomer = false; // Flag to distinguish add vs. edit mode

    public ManageCustomersForm()
    {
        InitializeComponent();
        this.Text = "e-Shift - Manage Customers";
        LoadCustomers(); // Load customers when the form opens
        SetDetailPanelEnabled(false); // Initially disable detail panel
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomersForm));
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnRefreshCustomers = new System.Windows.Forms.Button();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveCustomerChanges = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(16, 121);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1022, 269);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Blue;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCustomer.Location = new System.Drawing.Point(16, 411);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(209, 42);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add New";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Blue;
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditCustomer.Location = new System.Drawing.Point(284, 411);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(209, 42);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Selected";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(561, 411);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(209, 42);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Selected";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnRefreshCustomers
            // 
            this.btnRefreshCustomers.BackColor = System.Drawing.Color.Blue;
            this.btnRefreshCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCustomers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefreshCustomers.Location = new System.Drawing.Point(829, 411);
            this.btnRefreshCustomers.Name = "btnRefreshCustomers";
            this.btnRefreshCustomers.Size = new System.Drawing.Size(209, 42);
            this.btnRefreshCustomers.TabIndex = 4;
            this.btnRefreshCustomers.Text = "Refresh List";
            this.btnRefreshCustomers.UseVisualStyleBackColor = false;
            this.btnRefreshCustomers.Click += new System.EventHandler(this.btnRefreshCustomers_Click);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.lblPassword);
            this.grpCustomerDetails.Controls.Add(this.lblUsername);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Controls.Add(this.txtContact);
            this.grpCustomerDetails.Controls.Add(this.lblContact);
            this.grpCustomerDetails.Controls.Add(this.txtNIC);
            this.grpCustomerDetails.Controls.Add(this.lblNIC);
            this.grpCustomerDetails.Controls.Add(this.txtName);
            this.grpCustomerDetails.Controls.Add(this.lblName);
            this.grpCustomerDetails.Controls.Add(this.txtId);
            this.grpCustomerDetails.Controls.Add(this.lblId);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerDetails.Location = new System.Drawing.Point(67, 482);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(600, 250);
            this.grpCustomerDetails.TabIndex = 5;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelEdit.Location = new System.Drawing.Point(894, 585);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(144, 47);
            this.btnCancelEdit.TabIndex = 7;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnSaveCustomerChanges
            // 
            this.btnSaveCustomerChanges.BackColor = System.Drawing.Color.Blue;
            this.btnSaveCustomerChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCustomerChanges.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomerChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveCustomerChanges.Location = new System.Drawing.Point(894, 671);
            this.btnSaveCustomerChanges.Name = "btnSaveCustomerChanges";
            this.btnSaveCustomerChanges.Size = new System.Drawing.Size(144, 50);
            this.btnSaveCustomerChanges.TabIndex = 6;
            this.btnSaveCustomerChanges.Text = "Save";
            this.btnSaveCustomerChanges.UseVisualStyleBackColor = false;
            this.btnSaveCustomerChanges.Click += new System.EventHandler(this.btnSaveCustomerChanges_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(606, 691);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(400, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 27);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(606, 632);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 30);
            this.txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(400, 153);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 27);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(606, 520);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 60);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(400, 38);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(99, 27);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(126, 209);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(210, 34);
            this.txtContact.TabIndex = 2;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(6, 212);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(95, 27);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact:";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(126, 150);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(210, 34);
            this.txtNIC.TabIndex = 1;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(6, 153);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(55, 27);
            this.lblNIC.TabIndex = 3;
            this.lblNIC.Text = "NIC:";
            this.lblNIC.Click += new System.EventHandler(this.lblNIC_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 34);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 27);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(126, 35);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(210, 34);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(41, 27);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(249, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(557, 44);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "e-Shift System | Manage Customers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ManageCustomersForm
            // 
            this.ClientSize = new System.Drawing.Size(1056, 744);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSaveCustomerChanges);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.btnRefreshCustomers);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1074, 791);
            this.MinimumSize = new System.Drawing.Size(1074, 791);
            this.Name = "ManageCustomersForm";
            this.Text = "Manage Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void LoadCustomers()
    {
        dgvCustomers.DataSource = null; // Clear existing data source
        dgvCustomers.DataSource = Program.Customers; // Bind to the list of customers
        // Hide password column for security
        if (dgvCustomers.Columns.Contains("Password"))
        {
            dgvCustomers.Columns["Password"].Visible = false;
        }
        // Optionally hide other sensitive columns or reorder
        dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
    }

    private void SetDetailPanelEnabled(bool enabled)
    {
        grpCustomerDetails.Enabled = enabled;
        // Clear textboxes when disabling
        if (!enabled)
        {
            ClearCustomerDetails();
        }
    }

    private void ClearCustomerDetails()
    {
        txtId.Text = string.Empty;
        txtName.Text = string.Empty;
        txtNIC.Text = string.Empty;
        txtContact.Text = string.Empty;
        txtAddress.Text = string.Empty;
        txtUsername.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }

    private void PopulateCustomerDetails(Customer customer)
    {
        txtId.Text = customer.Id.ToString();
        txtName.Text = customer.Name;
        txtNIC.Text = customer.NIC;
        txtContact.Text = customer.Contact;
        txtAddress.Text = customer.Address;
        txtUsername.Text = customer.Username;
        txtPassword.Text = customer.Password; // For editing, show current password
    }

    private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count > 0 && !_isAddingNewCustomer)
        {
            // Get the selected Customer object directly from the DataGridView's bound item
            Customer selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (selectedCustomer != null)
            {
                PopulateCustomerDetails(selectedCustomer);
                SetDetailPanelEnabled(false); // Keep disabled until "Edit" is clicked
            }
        }
        else if (dgvCustomers.SelectedRows.Count == 0 && !_isAddingNewCustomer)
        {
            ClearCustomerDetails();
            SetDetailPanelEnabled(false);
        }
    }

    private void btnAddCustomer_Click(object sender, EventArgs e)
    {
        _isAddingNewCustomer = true;
        ClearCustomerDetails();
        txtId.Text = "New (Auto-generated)"; // Indicate it's a new ID
        SetDetailPanelEnabled(true);
        txtName.Focus();
    }

    private void btnEditCustomer_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count > 0)
        {
            _isAddingNewCustomer = false;
            SetDetailPanelEnabled(true);
            txtName.Focus();
        }
        else
        {
            MessageBox.Show("Please select a customer to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDeleteCustomer_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count > 0)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Customer customerToDelete = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
                if (customerToDelete != null)
                {
                    Program.Customers.Remove(customerToDelete);
                    DataManager.SaveData(); // Save changes after deletion
                    LoadCustomers(); // Refresh the DataGridView
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a customer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnSaveCustomerChanges_Click(object sender, EventArgs e)
    {
        // Input validation
        if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtNIC.Text) ||
            string.IsNullOrWhiteSpace(txtContact.Text) ||
            string.IsNullOrWhiteSpace(txtAddress.Text) ||
            string.IsNullOrWhiteSpace(txtUsername.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            MessageBox.Show("All customer detail fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (_isAddingNewCustomer)
            {
                // Add new customer
                if (Program.Customers.Any(c => c.Username.Equals(txtUsername.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                int newId = Program.Customers.Any() ? Program.Customers.Max(c => c.Id) + 1 : 1;
                Customer newCustomer = new Customer
                {
                    Id = newId,
                    Name = txtName.Text.Trim(),
                    NIC = txtNIC.Text.Trim(),
                    Contact = txtContact.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text // In a real app, hash this!
                };
                Program.Customers.Add(newCustomer);
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Editing existing customer
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    Customer customerToEdit = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
                    if (customerToEdit != null)
                    {
                        // Check for username uniqueness only if username is changed and not current customer's username
                        if (!customerToEdit.Username.Equals(txtUsername.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                            Program.Customers.Any(c => c.Username.Equals(txtUsername.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                        {
                            MessageBox.Show("Username already exists for another customer. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }

                        customerToEdit.Name = txtName.Text.Trim();
                        customerToEdit.NIC = txtNIC.Text.Trim();
                        customerToEdit.Contact = txtContact.Text.Trim();
                        customerToEdit.Address = txtAddress.Text.Trim();
                        customerToEdit.Username = txtUsername.Text.Trim();
                        customerToEdit.Password = txtPassword.Text;
                        MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            DataManager.SaveData(); // Save changes
            LoadCustomers(); // Refresh the DataGridView
            SetDetailPanelEnabled(false); // Disable panel after saving
            _isAddingNewCustomer = false; // Reset flag
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancelEdit_Click(object sender, EventArgs e)
    {
        SetDetailPanelEnabled(false);
        _isAddingNewCustomer = false;
        // Re-populate with selected customer's data if any, or clear
        if (dgvCustomers.SelectedRows.Count > 0)
        {
            Customer selectedCustomer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (selectedCustomer != null)
            {
                PopulateCustomerDetails(selectedCustomer);
            }
        }
        else
        {
            ClearCustomerDetails();
        }
    }

    private void btnRefreshCustomers_Click(object sender, EventArgs e)
    {
        LoadCustomers();
        SetDetailPanelEnabled(false);
        _isAddingNewCustomer = false;
    }

    private void lblContact_Click(object sender, EventArgs e)
    {

    }

    private void lblNIC_Click(object sender, EventArgs e)
    {

    }

    private void txtContact_TextChanged(object sender, EventArgs e)
    {

    }
}
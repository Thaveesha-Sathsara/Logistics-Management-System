using eShiftTransportSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class ManageProductsForm : Form
{
    private DataGridView dgvProducts;
    private Button btnAddProduct;
    private Button btnEditProduct;
    private Button btnDeleteProduct;
    private Button btnRefreshProducts;

    // Controls for individual product details
    private GroupBox grpProductDetails;
    private Label lblProductId;
    private TextBox txtProductId; // Read-only
    private Label lblProductName;
    private TextBox txtProductName;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblWeight;
    private TextBox txtWeight;
    private Button btnSaveProductChanges;
    private Button btnCancelEdit;
    private Label lblTitle;
    private PictureBox pictureBox1;
    private bool _isAddingNewProduct = false; // Flag to distinguish add vs. edit mode

    public ManageProductsForm()
    {
        InitializeComponent();
        this.Text = "e-Shift - Manage Products";
        LoadProducts(); // Load products when the form opens
        SetDetailPanelEnabled(false); // Initially disable detail panel
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductsForm));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.grpProductDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveProductChanges = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(25, 137);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1120, 258);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Blue;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProduct.Location = new System.Drawing.Point(25, 410);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(246, 45);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add New";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Blue;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditProduct.Location = new System.Drawing.Point(308, 410);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(246, 45);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Edit Selected";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteProduct.Location = new System.Drawing.Point(612, 410);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(246, 45);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Delete Selected";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.BackColor = System.Drawing.Color.Blue;
            this.btnRefreshProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefreshProducts.Location = new System.Drawing.Point(899, 410);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(246, 45);
            this.btnRefreshProducts.TabIndex = 4;
            this.btnRefreshProducts.Text = "Refresh List";
            this.btnRefreshProducts.UseVisualStyleBackColor = false;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // grpProductDetails
            // 
            this.grpProductDetails.Controls.Add(this.lblWeight);
            this.grpProductDetails.Controls.Add(this.txtDescription);
            this.grpProductDetails.Controls.Add(this.lblDescription);
            this.grpProductDetails.Controls.Add(this.txtProductName);
            this.grpProductDetails.Controls.Add(this.lblProductName);
            this.grpProductDetails.Controls.Add(this.txtProductId);
            this.grpProductDetails.Controls.Add(this.lblProductId);
            this.grpProductDetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductDetails.Location = new System.Drawing.Point(63, 509);
            this.grpProductDetails.Name = "grpProductDetails";
            this.grpProductDetails.Size = new System.Drawing.Size(815, 225);
            this.grpProductDetails.TabIndex = 5;
            this.grpProductDetails.TabStop = false;
            this.grpProductDetails.Text = "Product Details";
            this.grpProductDetails.Enter += new System.EventHandler(this.grpProductDetails_Enter);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelEdit.Location = new System.Drawing.Point(937, 541);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(146, 68);
            this.btnCancelEdit.TabIndex = 5;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnSaveProductChanges
            // 
            this.btnSaveProductChanges.BackColor = System.Drawing.Color.Blue;
            this.btnSaveProductChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProductChanges.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProductChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveProductChanges.Location = new System.Drawing.Point(937, 640);
            this.btnSaveProductChanges.Name = "btnSaveProductChanges";
            this.btnSaveProductChanges.Size = new System.Drawing.Size(146, 69);
            this.btnSaveProductChanges.TabIndex = 4;
            this.btnSaveProductChanges.Text = "Save";
            this.btnSaveProductChanges.UseVisualStyleBackColor = false;
            this.btnSaveProductChanges.Click += new System.EventHandler(this.btnSaveProductChanges_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(655, 541);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(186, 34);
            this.txtWeight.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(474, 35);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(92, 27);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 147);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 27);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(162, 89);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 34);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 92);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 27);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Name:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(162, 32);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(250, 34);
            this.txtProductId.TabIndex = 0;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(20, 35);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(41, 27);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(239, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(534, 44);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "e-Shift System | Manage Products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ManageProductsForm
            // 
            this.ClientSize = new System.Drawing.Size(1181, 746);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnSaveProductChanges);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpProductDetails);
            this.Controls.Add(this.btnRefreshProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvProducts);
            this.MaximumSize = new System.Drawing.Size(1199, 793);
            this.MinimumSize = new System.Drawing.Size(1199, 793);
            this.Name = "ManageProductsForm";
            this.Text = "Manage Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpProductDetails.ResumeLayout(false);
            this.grpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void LoadProducts()
    {
        this.dgvProducts.SelectionChanged -= new System.EventHandler(this.dgvProducts_SelectionChanged);

        dgvProducts.DataSource = null;
        ClearProductDetails();
        SetDetailPanelEnabled(false);
        if (Program.Products != null && Program.Products.Any())
        {
            dgvProducts.DataSource = Program.Products;
            dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            if (!_isAddingNewProduct && dgvProducts.Rows.Count > 0)
            {
                dgvProducts.Rows[0].Selected = true;
                dgvProducts.CurrentCell = dgvProducts.Rows[0].Cells[0];
            }
        }
        this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);

        _isAddingNewProduct = false;
    }

    private void SetDetailPanelEnabled(bool enabled)
    {
        grpProductDetails.Enabled = enabled;
        if (!enabled)
        {
            ClearProductDetails();
        }
    }

    private void ClearProductDetails()
    {
        txtProductId.Text = string.Empty;
        txtProductName.Text = string.Empty;
        txtDescription.Text = string.Empty;
        txtWeight.Text = string.Empty;
    }

    private void PopulateProductDetails(Product product)
    {
        txtProductId.Text = product.ProductId.ToString();
        txtProductName.Text = product.Name;
        txtDescription.Text = product.Description;
        txtWeight.Text = product.Weight.ToString();
    }

    private void dgvProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count > 0 && !_isAddingNewProduct)
        {
            Product selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                PopulateProductDetails(selectedProduct);
                SetDetailPanelEnabled(false);
            }
        }
        else if (dgvProducts.SelectedRows.Count == 0 && !_isAddingNewProduct)
        {
            ClearProductDetails();
            SetDetailPanelEnabled(false);
        }
    }

    private void btnAddProduct_Click(object sender, EventArgs e)
    {
        _isAddingNewProduct = true;
        ClearProductDetails();
        txtProductId.Text = "New (Auto-generated)";
        SetDetailPanelEnabled(true);
        txtProductName.Focus();
    }

    private void btnEditProduct_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count > 0)
        {
            _isAddingNewProduct = false;
            SetDetailPanelEnabled(true);
            txtProductName.Focus();
        }
        else
        {
            MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDeleteProduct_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count > 0)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Product productToDelete = dgvProducts.SelectedRows[0].DataBoundItem as Product;
                if (productToDelete != null)
                {
                    Program.Products.Remove(productToDelete);
                    DataManager.SaveData();
                    LoadProducts();
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnSaveProductChanges_Click(object sender, EventArgs e)
    {
        // Input validation
        if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
            string.IsNullOrWhiteSpace(txtDescription.Text) ||
            string.IsNullOrWhiteSpace(txtWeight.Text))
        {
            MessageBox.Show("All product detail fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!double.TryParse(txtWeight.Text, out double weight))
        {
            MessageBox.Show("Weight must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtWeight.Focus();
            return;
        }

        try
        {
            if (_isAddingNewProduct)
            {
                int newId = Program.Products.Any() ? Program.Products.Max(p => p.ProductId) + 1 : 1;
                Product newProduct = new Product
                {
                    ProductId = newId,
                    Name = txtProductName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Weight = weight
                };
                Program.Products.Add(newProduct);
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Editing existing product
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    Product productToEdit = dgvProducts.SelectedRows[0].DataBoundItem as Product;
                    if (productToEdit != null)
                    {
                        productToEdit.Name = txtProductName.Text.Trim();
                        productToEdit.Description = txtDescription.Text.Trim();
                        productToEdit.Weight = weight;
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            DataManager.SaveData();
            LoadProducts();
            SetDetailPanelEnabled(false);
            _isAddingNewProduct = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancelEdit_Click(object sender, EventArgs e)
    {
        SetDetailPanelEnabled(false);
        _isAddingNewProduct = false;
        if (dgvProducts.SelectedRows.Count > 0)
        {
            Product selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                PopulateProductDetails(selectedProduct);
            }
        }
        else
        {
            ClearProductDetails();
        }
    }

    private void btnRefreshProducts_Click(object sender, EventArgs e)
    {
        LoadProducts();
        SetDetailPanelEnabled(false);
        _isAddingNewProduct = false;
    }

    private void grpProductDetails_Enter(object sender, EventArgs e)
    {

    }
}
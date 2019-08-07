namespace RandomTvShow
{
    partial class CastingOptions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.DeviceDataGrid = new System.Windows.Forms.DataGridView();
            this.chromecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ScanButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ScanningLabel = new System.Windows.Forms.Label();
            this.friendlyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceUriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentDeviceLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.SetDeviceButton = new System.Windows.Forms.Button();
            this.MainGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chromecastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnCount = 1;
            this.MainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainGrid.Controls.Add(this.DeviceDataGrid, 0, 1);
            this.MainGrid.Controls.Add(this.splitContainer1, 0, 0);
            this.MainGrid.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.Location = new System.Drawing.Point(0, 0);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowCount = 3;
            this.MainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainGrid.Size = new System.Drawing.Size(445, 356);
            this.MainGrid.TabIndex = 0;
            // 
            // DeviceDataGrid
            // 
            this.DeviceDataGrid.AllowUserToAddRows = false;
            this.DeviceDataGrid.AllowUserToDeleteRows = false;
            this.DeviceDataGrid.AutoGenerateColumns = false;
            this.DeviceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeviceDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DeviceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.friendlyNameDataGridViewTextBoxColumn,
            this.deviceUriDataGridViewTextBoxColumn});
            this.DeviceDataGrid.DataSource = this.chromecastBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.DeviceDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DeviceDataGrid.Location = new System.Drawing.Point(20, 56);
            this.DeviceDataGrid.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DeviceDataGrid.MultiSelect = false;
            this.DeviceDataGrid.Name = "DeviceDataGrid";
            this.DeviceDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DeviceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceDataGrid.Size = new System.Drawing.Size(405, 243);
            this.DeviceDataGrid.TabIndex = 0;
            this.DeviceDataGrid.VirtualMode = true;
            this.DeviceDataGrid.SelectionChanged += new System.EventHandler(this.DeviceDataGrid_SelectionChanged);
            // 
            // chromecastBindingSource
            // 
            this.chromecastBindingSource.DataSource = typeof(SharpCaster.Models.Chromecast);
            // 
            // ScanButton
            // 
            this.ScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.ScanButton.Location = new System.Drawing.Point(97, 9);
            this.ScanButton.Margin = new System.Windows.Forms.Padding(0, 12, 20, 0);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(100, 35);
            this.ScanButton.TabIndex = 0;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ScanningLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ScanButton);
            this.splitContainer1.Size = new System.Drawing.Size(445, 53);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // ScanningLabel
            // 
            this.ScanningLabel.AutoSize = true;
            this.ScanningLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanningLabel.Location = new System.Drawing.Point(21, 18);
            this.ScanningLabel.Name = "ScanningLabel";
            this.ScanningLabel.Size = new System.Drawing.Size(69, 17);
            this.ScanningLabel.TabIndex = 0;
            this.ScanningLabel.Text = "Scanning...";
            this.ScanningLabel.Visible = false;
            // 
            // friendlyNameDataGridViewTextBoxColumn
            // 
            this.friendlyNameDataGridViewTextBoxColumn.DataPropertyName = "FriendlyName";
            this.friendlyNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.friendlyNameDataGridViewTextBoxColumn.Name = "friendlyNameDataGridViewTextBoxColumn";
            this.friendlyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceUriDataGridViewTextBoxColumn
            // 
            this.deviceUriDataGridViewTextBoxColumn.DataPropertyName = "DeviceUri";
            this.deviceUriDataGridViewTextBoxColumn.HeaderText = "Device Uri";
            this.deviceUriDataGridViewTextBoxColumn.Name = "deviceUriDataGridViewTextBoxColumn";
            this.deviceUriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.SetDeviceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeviceNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentDeviceLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 302);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 54);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // CurrentDeviceLabel
            // 
            this.CurrentDeviceLabel.AutoSize = true;
            this.CurrentDeviceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentDeviceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDeviceLabel.Location = new System.Drawing.Point(3, 0);
            this.CurrentDeviceLabel.Name = "CurrentDeviceLabel";
            this.CurrentDeviceLabel.Size = new System.Drawing.Size(149, 54);
            this.CurrentDeviceLabel.TabIndex = 1;
            this.CurrentDeviceLabel.Text = "Current Device:";
            this.CurrentDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceNameLabel.Location = new System.Drawing.Point(158, 0);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(149, 54);
            this.DeviceNameLabel.TabIndex = 2;
            this.DeviceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetDeviceButton
            // 
            this.SetDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDeviceButton.Enabled = false;
            this.SetDeviceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.SetDeviceButton.Location = new System.Drawing.Point(325, 9);
            this.SetDeviceButton.Margin = new System.Windows.Forms.Padding(15, 9, 20, 10);
            this.SetDeviceButton.Name = "SetDeviceButton";
            this.SetDeviceButton.Size = new System.Drawing.Size(100, 35);
            this.SetDeviceButton.TabIndex = 3;
            this.SetDeviceButton.Text = "Set Device";
            this.SetDeviceButton.UseVisualStyleBackColor = true;
            this.SetDeviceButton.Click += new System.EventHandler(this.SetDeviceButton_Click);
            // 
            // CastingOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 356);
            this.Controls.Add(this.MainGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CastingOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Casting Options";
            this.TopMost = true;
            this.MainGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chromecastBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainGrid;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.DataGridView DeviceDataGrid;
        private System.Windows.Forms.BindingSource chromecastBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ScanningLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendlyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceUriDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Label CurrentDeviceLabel;
        private System.Windows.Forms.Button SetDeviceButton;
    }
}
namespace WindowsFormsApp1
{
    partial class ProductInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInformation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bgu = new System.Windows.Forms.PictureBox();
            this.process = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.WorkcellNameLabel = new System.Windows.Forms.Label();
            this.WorkcellNameCombo = new System.Windows.Forms.ComboBox();
            this.SequenceNameLabel = new System.Windows.Forms.Label();
            this.SequenceNameText = new System.Windows.Forms.TextBox();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.SetDataButton = new System.Windows.Forms.Button();
            this.CalculateRouteButton = new System.Windows.Forms.Button();
            this.CalculateConfigButton = new System.Windows.Forms.Button();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.helpImage = new System.Windows.Forms.PictureBox();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.PartCatalogNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WristSafeDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WristSafeUpDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wristw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wristsxquaternion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wristsyquaternion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wristszquaternion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInformationTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bgu
            // 
            this.bgu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgu.BackgroundImage")));
            this.bgu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgu.Location = new System.Drawing.Point(79, 15);
            this.bgu.Name = "bgu";
            this.bgu.Size = new System.Drawing.Size(152, 48);
            this.bgu.TabIndex = 0;
            this.bgu.TabStop = false;
            this.bgu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // process
            // 
            this.process.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("process.BackgroundImage")));
            this.process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.process.Location = new System.Drawing.Point(2, 15);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(77, 48);
            this.process.TabIndex = 1;
            this.process.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Dubai Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 55;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartCatalogNumber,
            this.PartID,
            this.GroupID,
            this.WristSafeDistance,
            this.WristSafeUpDistance,
            this.xW,
            this.yW,
            this.zW,
            this.Wristw,
            this.Wristsxquaternion,
            this.Wristsyquaternion,
            this.Wristszquaternion});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(31, 261);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 336);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.ProductNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductNameLabel.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ProductNameLabel.Location = new System.Drawing.Point(101, 112);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.ProductNameLabel.Size = new System.Drawing.Size(138, 44);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Product name";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductNameText
            // 
            this.ProductNameText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProductNameText.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameText.Location = new System.Drawing.Point(101, 172);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(142, 29);
            this.ProductNameText.TabIndex = 5;
            // 
            // WorkcellNameLabel
            // 
            this.WorkcellNameLabel.AutoSize = true;
            this.WorkcellNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.WorkcellNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkcellNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkcellNameLabel.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkcellNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.WorkcellNameLabel.Location = new System.Drawing.Point(280, 112);
            this.WorkcellNameLabel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.WorkcellNameLabel.Name = "WorkcellNameLabel";
            this.WorkcellNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.WorkcellNameLabel.Size = new System.Drawing.Size(143, 44);
            this.WorkcellNameLabel.TabIndex = 6;
            this.WorkcellNameLabel.Text = "Workcell name";
            this.WorkcellNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WorkcellNameLabel.Click += new System.EventHandler(this.WorkcellNameLabel_Click);
            // 
            // WorkcellNameCombo
            // 
            this.WorkcellNameCombo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WorkcellNameCombo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkcellNameCombo.FormattingEnabled = true;
            this.WorkcellNameCombo.ItemHeight = 22;
            this.WorkcellNameCombo.Location = new System.Drawing.Point(280, 171);
            this.WorkcellNameCombo.Name = "WorkcellNameCombo";
            this.WorkcellNameCombo.Size = new System.Drawing.Size(147, 30);
            this.WorkcellNameCombo.TabIndex = 7;
            // 
            // SequenceNameLabel
            // 
            this.SequenceNameLabel.AutoSize = true;
            this.SequenceNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.SequenceNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SequenceNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SequenceNameLabel.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequenceNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SequenceNameLabel.Location = new System.Drawing.Point(464, 112);
            this.SequenceNameLabel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SequenceNameLabel.Name = "SequenceNameLabel";
            this.SequenceNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.SequenceNameLabel.Size = new System.Drawing.Size(150, 44);
            this.SequenceNameLabel.TabIndex = 8;
            this.SequenceNameLabel.Text = "Sequence name";
            this.SequenceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SequenceNameText
            // 
            this.SequenceNameText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SequenceNameText.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequenceNameText.Location = new System.Drawing.Point(464, 172);
            this.SequenceNameText.Name = "SequenceNameText";
            this.SequenceNameText.Size = new System.Drawing.Size(154, 29);
            this.SequenceNameText.TabIndex = 9;
            // 
            // GetDataButton
            // 
            this.GetDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(178)))), ((int)(((byte)(97)))));
            this.GetDataButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDataButton.Location = new System.Drawing.Point(668, 116);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(100, 34);
            this.GetDataButton.TabIndex = 10;
            this.GetDataButton.Text = "Get data";
            this.GetDataButton.UseVisualStyleBackColor = false;
            // 
            // SetDataButton
            // 
            this.SetDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(178)))), ((int)(((byte)(97)))));
            this.SetDataButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDataButton.Location = new System.Drawing.Point(668, 156);
            this.SetDataButton.Name = "SetDataButton";
            this.SetDataButton.Size = new System.Drawing.Size(100, 34);
            this.SetDataButton.TabIndex = 11;
            this.SetDataButton.Text = "Set data";
            this.SetDataButton.UseVisualStyleBackColor = false;
            // 
            // CalculateRouteButton
            // 
            this.CalculateRouteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(178)))), ((int)(((byte)(97)))));
            this.CalculateRouteButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateRouteButton.Location = new System.Drawing.Point(1049, 615);
            this.CalculateRouteButton.Name = "CalculateRouteButton";
            this.CalculateRouteButton.Size = new System.Drawing.Size(123, 34);
            this.CalculateRouteButton.TabIndex = 12;
            this.CalculateRouteButton.Text = "Calculate route";
            this.CalculateRouteButton.UseVisualStyleBackColor = false;
            // 
            // CalculateConfigButton
            // 
            this.CalculateConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(178)))), ((int)(((byte)(97)))));
            this.CalculateConfigButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateConfigButton.Location = new System.Drawing.Point(920, 615);
            this.CalculateConfigButton.Name = "CalculateConfigButton";
            this.CalculateConfigButton.Size = new System.Drawing.Size(123, 34);
            this.CalculateConfigButton.TabIndex = 13;
            this.CalculateConfigButton.Text = "Calculate config";
            this.CalculateConfigButton.UseVisualStyleBackColor = false;
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(855, 70);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(276, 146);
            this.ProductImage.TabIndex = 14;
            this.ProductImage.TabStop = false;
            // 
            // helpImage
            // 
            this.helpImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpImage.BackgroundImage")));
            this.helpImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpImage.Location = new System.Drawing.Point(1146, 12);
            this.helpImage.Name = "helpImage";
            this.helpImage.Size = new System.Drawing.Size(26, 29);
            this.helpImage.TabIndex = 15;
            this.helpImage.TabStop = false;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.Location = new System.Drawing.Point(1140, 41);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(40, 22);
            this.HelpLabel.TabIndex = 16;
            this.HelpLabel.Text = "HELP";
            // 
            // PartCatalogNumber
            // 
            this.PartCatalogNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartCatalogNumber.HeaderText = "Part’s catalog number";
            this.PartCatalogNumber.Name = "PartCatalogNumber";
            this.PartCatalogNumber.ReadOnly = true;
            // 
            // PartID
            // 
            this.PartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartID.HeaderText = "Part ID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            // 
            // GroupID
            // 
            this.GroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupID.HeaderText = "Group ID";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            // 
            // WristSafeDistance
            // 
            this.WristSafeDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WristSafeDistance.HeaderText = "Wrist safe distance";
            this.WristSafeDistance.Name = "WristSafeDistance";
            this.WristSafeDistance.ReadOnly = true;
            // 
            // WristSafeUpDistance
            // 
            this.WristSafeUpDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WristSafeUpDistance.HeaderText = "Wrist safe up distance";
            this.WristSafeUpDistance.Name = "WristSafeUpDistance";
            this.WristSafeUpDistance.ReadOnly = true;
            // 
            // xW
            // 
            this.xW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xW.HeaderText = "Wrist\'s x - coordinate";
            this.xW.Name = "xW";
            this.xW.ReadOnly = true;
            // 
            // yW
            // 
            this.yW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yW.HeaderText = "Wrist\'s y - coordinate";
            this.yW.Name = "yW";
            this.yW.ReadOnly = true;
            // 
            // zW
            // 
            this.zW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zW.HeaderText = "Wrist\'s z - coordinate";
            this.zW.Name = "zW";
            this.zW.ReadOnly = true;
            // 
            // Wristw
            // 
            this.Wristw.HeaderText = "Wrist\'s w - quaternion";
            this.Wristw.Name = "Wristw";
            this.Wristw.ReadOnly = true;
            // 
            // Wristsxquaternion
            // 
            this.Wristsxquaternion.HeaderText = "Wrist’s x - quaternion";
            this.Wristsxquaternion.Name = "Wristsxquaternion";
            this.Wristsxquaternion.ReadOnly = true;
            // 
            // Wristsyquaternion
            // 
            this.Wristsyquaternion.HeaderText = "Wrist’s y - quaternion";
            this.Wristsyquaternion.Name = "Wristsyquaternion";
            this.Wristsyquaternion.ReadOnly = true;
            // 
            // Wristszquaternion
            // 
            this.Wristszquaternion.HeaderText = "Wrist’s z - quaternion";
            this.Wristszquaternion.Name = "Wristszquaternion";
            this.Wristszquaternion.ReadOnly = true;
            // 
            // ProductInformationTitle
            // 
            this.ProductInformationTitle.AutoSize = true;
            this.ProductInformationTitle.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInformationTitle.Location = new System.Drawing.Point(444, 23);
            this.ProductInformationTitle.Name = "ProductInformationTitle";
            this.ProductInformationTitle.Size = new System.Drawing.Size(276, 49);
            this.ProductInformationTitle.TabIndex = 17;
            this.ProductInformationTitle.Text = "Product information";
            // 
            // ProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1198, 672);
            this.Controls.Add(this.ProductInformationTitle);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.helpImage);
            this.Controls.Add(this.ProductImage);
            this.Controls.Add(this.CalculateConfigButton);
            this.Controls.Add(this.CalculateRouteButton);
            this.Controls.Add(this.SetDataButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.SequenceNameText);
            this.Controls.Add(this.SequenceNameLabel);
            this.Controls.Add(this.WorkcellNameCombo);
            this.Controls.Add(this.WorkcellNameLabel);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.process);
            this.Controls.Add(this.bgu);
            this.Name = "ProductInformation";
            ((System.ComponentModel.ISupportInitialize)(this.bgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgu;
        private System.Windows.Forms.PictureBox process;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.Label WorkcellNameLabel;
        private System.Windows.Forms.ComboBox WorkcellNameCombo;
        private System.Windows.Forms.Label SequenceNameLabel;
        private System.Windows.Forms.TextBox SequenceNameText;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button SetDataButton;
        private System.Windows.Forms.Button CalculateRouteButton;
        private System.Windows.Forms.Button CalculateConfigButton;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.PictureBox helpImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCatalogNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WristSafeDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn WristSafeUpDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn xW;
        private System.Windows.Forms.DataGridViewTextBoxColumn yW;
        private System.Windows.Forms.DataGridViewTextBoxColumn zW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wristw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wristsxquaternion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wristsyquaternion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wristszquaternion;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label ProductInformationTitle;
    }
}


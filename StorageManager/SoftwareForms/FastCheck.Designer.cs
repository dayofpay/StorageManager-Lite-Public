namespace StorageManager.SoftwareForms
{
    partial class FastCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastCheck));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.awBg = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.infoGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.СКЛАД = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Брой = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageEdit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // awBg
            // 
            this.awBg.AnimateWindow = true;
            this.awBg.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.awBg.ContainerControl = this;
            this.awBg.DockIndicatorTransparencyValue = 0.6D;
            this.awBg.TransparentWhileDrag = true;
            // 
            // infoGrid
            // 
            this.infoGrid.AllowCustomTheming = true;
            this.infoGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.infoGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.infoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.infoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.infoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.infoGrid.ColumnHeadersHeight = 40;
            this.infoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.СКЛАД,
            this.itemId,
            this.Брой,
            this.price,
            this.value,
            this.productName});
            this.infoGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.infoGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.infoGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.infoGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.infoGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.infoGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.infoGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.infoGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.infoGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.infoGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.infoGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.infoGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.infoGrid.CurrentTheme.Name = null;
            this.infoGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.infoGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.infoGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.infoGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.infoGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infoGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.infoGrid.EnableHeadersVisualStyles = false;
            this.infoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.infoGrid.HeaderBackColor = System.Drawing.Color.DeepSkyBlue;
            this.infoGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.infoGrid.HeaderForeColor = System.Drawing.Color.White;
            this.infoGrid.Location = new System.Drawing.Point(0, 0);
            this.infoGrid.Name = "infoGrid";
            this.infoGrid.RowHeadersVisible = false;
            this.infoGrid.RowTemplate.Height = 40;
            this.infoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infoGrid.Size = new System.Drawing.Size(1196, 403);
            this.infoGrid.TabIndex = 0;
            this.infoGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.infoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoGrid_CellContentClick);
            // 
            // СКЛАД
            // 
            this.СКЛАД.HeaderText = "Склад";
            this.СКЛАД.Name = "СКЛАД";
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Номер на продукт";
            this.itemId.Name = "itemId";
            // 
            // Брой
            // 
            this.Брой.HeaderText = "Брой";
            this.Брой.Name = "Брой";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // value
            // 
            this.value.HeaderText = "Валута";
            this.value.Name = "value";
            // 
            // productName
            // 
            this.productName.HeaderText = "Име на продукт";
            this.productName.Name = "productName";
            // 
            // storageEdit
            // 
            this.storageEdit.AllowAnimations = true;
            this.storageEdit.AllowMouseEffects = true;
            this.storageEdit.AllowToggling = false;
            this.storageEdit.AnimationSpeed = 200;
            this.storageEdit.AutoGenerateColors = false;
            this.storageEdit.AutoRoundBorders = false;
            this.storageEdit.AutoSizeLeftIcon = true;
            this.storageEdit.AutoSizeRightIcon = true;
            this.storageEdit.BackColor = System.Drawing.Color.Transparent;
            this.storageEdit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.storageEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("storageEdit.BackgroundImage")));
            this.storageEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.storageEdit.ButtonText = "Затвори";
            this.storageEdit.ButtonTextMarginLeft = 0;
            this.storageEdit.ColorContrastOnClick = 45;
            this.storageEdit.ColorContrastOnHover = 45;
            this.storageEdit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = false;
            this.storageEdit.CustomizableEdges = borderEdges1;
            this.storageEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.storageEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.storageEdit.DisabledFillColor = System.Drawing.Color.Empty;
            this.storageEdit.DisabledForecolor = System.Drawing.Color.Empty;
            this.storageEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.storageEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storageEdit.ForeColor = System.Drawing.Color.White;
            this.storageEdit.IconLeft = ((System.Drawing.Image)(resources.GetObject("storageEdit.IconLeft")));
            this.storageEdit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storageEdit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.storageEdit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.storageEdit.IconMarginLeft = 11;
            this.storageEdit.IconPadding = 10;
            this.storageEdit.IconRight = null;
            this.storageEdit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.storageEdit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.storageEdit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.storageEdit.IconSize = 25;
            this.storageEdit.IdleBorderColor = System.Drawing.Color.Empty;
            this.storageEdit.IdleBorderRadius = 0;
            this.storageEdit.IdleBorderThickness = 0;
            this.storageEdit.IdleFillColor = System.Drawing.Color.Empty;
            this.storageEdit.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("storageEdit.IdleIconLeftImage")));
            this.storageEdit.IdleIconRightImage = null;
            this.storageEdit.IndicateFocus = false;
            this.storageEdit.Location = new System.Drawing.Point(0, 409);
            this.storageEdit.Name = "storageEdit";
            this.storageEdit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.storageEdit.OnDisabledState.BorderRadius = 3;
            this.storageEdit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.storageEdit.OnDisabledState.BorderThickness = 1;
            this.storageEdit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.storageEdit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.storageEdit.OnDisabledState.IconLeftImage = null;
            this.storageEdit.OnDisabledState.IconRightImage = null;
            this.storageEdit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.storageEdit.onHoverState.BorderRadius = 3;
            this.storageEdit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.storageEdit.onHoverState.BorderThickness = 1;
            this.storageEdit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.storageEdit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.storageEdit.onHoverState.IconLeftImage = null;
            this.storageEdit.onHoverState.IconRightImage = null;
            this.storageEdit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.storageEdit.OnIdleState.BorderRadius = 3;
            this.storageEdit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.storageEdit.OnIdleState.BorderThickness = 1;
            this.storageEdit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.storageEdit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.storageEdit.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("storageEdit.OnIdleState.IconLeftImage")));
            this.storageEdit.OnIdleState.IconRightImage = null;
            this.storageEdit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.storageEdit.OnPressedState.BorderRadius = 3;
            this.storageEdit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.storageEdit.OnPressedState.BorderThickness = 1;
            this.storageEdit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.storageEdit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.storageEdit.OnPressedState.IconLeftImage = null;
            this.storageEdit.OnPressedState.IconRightImage = null;
            this.storageEdit.Size = new System.Drawing.Size(264, 28);
            this.storageEdit.TabIndex = 9;
            this.storageEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storageEdit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.storageEdit.TextMarginLeft = 0;
            this.storageEdit.TextPadding = new System.Windows.Forms.Padding(0);
            this.storageEdit.UseDefaultRadiusAndThickness = true;
            this.storageEdit.Click += new System.EventHandler(this.storageEdit_Click);
            // 
            // FastCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.storageEdit);
            this.Controls.Add(this.infoGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastCheck";
            this.Text = "FastCheck";
            this.Load += new System.EventHandler(this.FastCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm awBg;
        private Bunifu.UI.WinForms.BunifuDataGridView infoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn СКЛАД;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Брой;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton storageEdit;
    }
}
namespace StorageManager.Security
{
    partial class PinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.awBg = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.exitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pinBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // awBg
            // 
            this.awBg.AnimateWindow = true;
            this.awBg.ContainerControl = this;
            this.awBg.DockIndicatorTransparencyValue = 0.6D;
            this.awBg.TransparentWhileDrag = true;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(340, -4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 33);
            this.exitButton.TabIndex = 9;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(63, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Този акаунт е защитен със пин код, \r\nза да продължите е нужно да го въведете,";
            // 
            // checkPin
            // 
            this.checkPin.Animated = true;
            this.checkPin.BorderColor = System.Drawing.Color.ForestGreen;
            this.checkPin.BorderRadius = 6;
            this.checkPin.BorderThickness = 1;
            this.checkPin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.checkPin.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.checkPin.CustomizableEdges.BottomLeft = false;
            this.checkPin.CustomizableEdges.TopRight = false;
            this.checkPin.DefaultAutoSize = true;
            this.checkPin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkPin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkPin.FillColor = System.Drawing.Color.Transparent;
            this.checkPin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.checkPin.ForeColor = System.Drawing.Color.Crimson;
            this.checkPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkPin.Location = new System.Drawing.Point(137, 237);
            this.checkPin.Name = "checkPin";
            this.checkPin.Size = new System.Drawing.Size(89, 26);
            this.checkPin.TabIndex = 11;
            this.checkPin.Text = "НАПРЕД";
            this.checkPin.Click += new System.EventHandler(this.checkPin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StorageManager.Properties.Resources.lock_error_512px;
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pinBox
            // 
            this.pinBox.AcceptsReturn = false;
            this.pinBox.AcceptsTab = false;
            this.pinBox.AnimationSpeed = 200;
            this.pinBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pinBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pinBox.AutoSize = true;
            this.pinBox.AutoSizeHeight = true;
            this.pinBox.BackColor = System.Drawing.Color.Transparent;
            this.pinBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinBox.BackgroundImage")));
            this.pinBox.BorderColorActive = System.Drawing.Color.Cyan;
            this.pinBox.BorderColorDisabled = System.Drawing.Color.Red;
            this.pinBox.BorderColorHover = System.Drawing.Color.BlueViolet;
            this.pinBox.BorderColorIdle = System.Drawing.Color.Crimson;
            this.pinBox.BorderRadius = 1;
            this.pinBox.BorderThickness = 2;
            this.pinBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pinBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pinBox.DefaultFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pinBox.DefaultText = "";
            this.pinBox.FillColor = System.Drawing.Color.Black;
            this.pinBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pinBox.HideSelection = true;
            this.pinBox.IconLeft = null;
            this.pinBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.pinBox.IconPadding = 10;
            this.pinBox.IconRight = null;
            this.pinBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.pinBox.Lines = new string[0];
            this.pinBox.Location = new System.Drawing.Point(43, 166);
            this.pinBox.MaxLength = 32767;
            this.pinBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.pinBox.Modified = false;
            this.pinBox.Multiline = false;
            this.pinBox.Name = "pinBox";
            stateProperties5.BorderColor = System.Drawing.Color.Cyan;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pinBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Red;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.pinBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.BlueViolet;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pinBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Crimson;
            stateProperties8.FillColor = System.Drawing.Color.Black;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pinBox.OnIdleState = stateProperties8;
            this.pinBox.Padding = new System.Windows.Forms.Padding(3);
            this.pinBox.PasswordChar = '\0';
            this.pinBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.pinBox.PlaceholderText = "Въведи пин код";
            this.pinBox.ReadOnly = false;
            this.pinBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pinBox.SelectedText = "";
            this.pinBox.SelectionLength = 0;
            this.pinBox.SelectionStart = 0;
            this.pinBox.ShortcutsEnabled = true;
            this.pinBox.Size = new System.Drawing.Size(303, 45);
            this.pinBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.pinBox.TabIndex = 2;
            this.pinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pinBox.TextMarginBottom = 0;
            this.pinBox.TextMarginLeft = 3;
            this.pinBox.TextMarginTop = 1;
            this.pinBox.TextPlaceholder = "Въведи пин код";
            this.pinBox.UseSystemPasswordChar = false;
            this.pinBox.WordWrap = true;
            this.pinBox.TextChanged += new System.EventHandler(this.pinBox_TextChanged);
            // 
            // alert
            // 
            this.alert.AllowDragging = false;
            this.alert.AllowMultipleViews = true;
            this.alert.ClickToClose = true;
            this.alert.DoubleClickToClose = true;
            this.alert.DurationAfterIdle = 3000;
            this.alert.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.ErrorOptions.ActionBorderRadius = 1;
            this.alert.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.alert.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.alert.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.alert.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.alert.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.alert.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.alert.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.alert.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.alert.ErrorOptions.IconLeftMargin = 12;
            this.alert.FadeCloseIcon = false;
            this.alert.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.alert.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.InformationOptions.ActionBorderRadius = 1;
            this.alert.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.alert.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.alert.InformationOptions.BackColor = System.Drawing.Color.White;
            this.alert.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.alert.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.alert.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.alert.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.alert.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.alert.InformationOptions.IconLeftMargin = 12;
            this.alert.Margin = 10;
            this.alert.MaximumSize = new System.Drawing.Size(0, 0);
            this.alert.MaximumViews = 7;
            this.alert.MessageRightMargin = 15;
            this.alert.MinimumSize = new System.Drawing.Size(0, 0);
            this.alert.ShowBorders = false;
            this.alert.ShowCloseIcon = false;
            this.alert.ShowIcon = true;
            this.alert.ShowShadows = true;
            this.alert.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.SuccessOptions.ActionBorderRadius = 1;
            this.alert.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.alert.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.alert.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.alert.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.alert.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.alert.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.alert.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.alert.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.alert.SuccessOptions.IconLeftMargin = 12;
            this.alert.ViewsMargin = 7;
            this.alert.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alert.WarningOptions.ActionBorderRadius = 1;
            this.alert.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.alert.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.alert.WarningOptions.BackColor = System.Drawing.Color.White;
            this.alert.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.alert.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.alert.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.alert.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.alert.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.alert.WarningOptions.IconLeftMargin = 12;
            this.alert.ZoomCloseIcon = true;
            // 
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(395, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkPin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pinBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinForm";
            this.Load += new System.EventHandler(this.PinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm awBg;
        private Bunifu.UI.WinForms.BunifuTextBox pinBox;
        private Guna.UI2.WinForms.Guna2ControlBox exitButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button checkPin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuSnackbar alert;
    }
}
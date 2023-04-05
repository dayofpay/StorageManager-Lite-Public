namespace StorageManager
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.awBg = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.exitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.passwordBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.exitButton.Location = new System.Drawing.Point(477, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 33);
            this.exitButton.TabIndex = 8;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.BorderColor = System.Drawing.Color.DarkSalmon;
            this.loginButton.BorderRadius = 6;
            this.loginButton.BorderThickness = 1;
            this.loginButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.loginButton.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.loginButton.CustomizableEdges.BottomLeft = false;
            this.loginButton.CustomizableEdges.BottomRight = false;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.Transparent;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.loginButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loginButton.Location = new System.Drawing.Point(159, 250);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(210, 52);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "ВХОД";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Здравейте, добре дошли в Demo версията на StorageManager\r\nИзползвайте username de" +
    "mo и парола demo за да продължите";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.DarkSalmon;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.guna2Button1.CustomizableEdges.BottomLeft = false;
            this.guna2Button1.CustomizableEdges.BottomRight = false;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button1.Location = new System.Drawing.Point(159, 308);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(210, 40);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "ЗАКУПИ ЛИЦЕНЗ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.AcceptsReturn = false;
            this.passwordBox.AcceptsTab = false;
            this.passwordBox.AnimationSpeed = 200;
            this.passwordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordBox.AutoSizeHeight = true;
            this.passwordBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordBox.BackgroundImage")));
            this.passwordBox.BorderColorActive = System.Drawing.Color.PaleGreen;
            this.passwordBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordBox.BorderColorHover = System.Drawing.Color.Lime;
            this.passwordBox.BorderColorIdle = System.Drawing.Color.LightSalmon;
            this.passwordBox.BorderRadius = 5;
            this.passwordBox.BorderThickness = 2;
            this.passwordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.DefaultText = "";
            this.passwordBox.FillColor = System.Drawing.Color.Black;
            this.passwordBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordBox.HideSelection = true;
            this.passwordBox.IconLeft = null;
            this.passwordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.IconPadding = 10;
            this.passwordBox.IconRight = null;
            this.passwordBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(175, 178);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordBox.Modified = false;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            stateProperties1.BorderColor = System.Drawing.Color.PaleGreen;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Lime;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.LightSalmon;
            stateProperties4.FillColor = System.Drawing.Color.Black;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordBox.OnIdleState = stateProperties4;
            this.passwordBox.Padding = new System.Windows.Forms.Padding(3);
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.PlaceholderForeColor = System.Drawing.Color.Salmon;
            this.passwordBox.PlaceholderText = "Въведи парола";
            this.passwordBox.ReadOnly = false;
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(303, 46);
            this.passwordBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordBox.TabIndex = 5;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.TextMarginBottom = 0;
            this.passwordBox.TextMarginLeft = 3;
            this.passwordBox.TextMarginTop = 1;
            this.passwordBox.TextPlaceholder = "Въведи парола";
            this.passwordBox.UseSystemPasswordChar = false;
            this.passwordBox.WordWrap = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StorageManager.Properties.Resources.key_2_40px;
            this.pictureBox2.Location = new System.Drawing.Point(51, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.AcceptsReturn = false;
            this.usernameBox.AcceptsTab = false;
            this.usernameBox.AnimationSpeed = 200;
            this.usernameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernameBox.AutoSizeHeight = true;
            this.usernameBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernameBox.BackgroundImage")));
            this.usernameBox.BorderColorActive = System.Drawing.Color.PaleGreen;
            this.usernameBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usernameBox.BorderColorHover = System.Drawing.Color.Lime;
            this.usernameBox.BorderColorIdle = System.Drawing.Color.LightSalmon;
            this.usernameBox.BorderRadius = 5;
            this.usernameBox.BorderThickness = 2;
            this.usernameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameBox.DefaultText = "";
            this.usernameBox.FillColor = System.Drawing.Color.Black;
            this.usernameBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernameBox.HideSelection = true;
            this.usernameBox.IconLeft = null;
            this.usernameBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.IconPadding = 10;
            this.usernameBox.IconRight = null;
            this.usernameBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.Lines = new string[0];
            this.usernameBox.Location = new System.Drawing.Point(175, 72);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.usernameBox.Modified = false;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            stateProperties5.BorderColor = System.Drawing.Color.PaleGreen;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernameBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.usernameBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Lime;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernameBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.LightSalmon;
            stateProperties8.FillColor = System.Drawing.Color.Black;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernameBox.OnIdleState = stateProperties8;
            this.usernameBox.Padding = new System.Windows.Forms.Padding(3);
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderForeColor = System.Drawing.Color.Salmon;
            this.usernameBox.PlaceholderText = "Въведи потребителско име";
            this.usernameBox.ReadOnly = false;
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.ShortcutsEnabled = true;
            this.usernameBox.Size = new System.Drawing.Size(303, 46);
            this.usernameBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.usernameBox.TabIndex = 1;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameBox.TextMarginBottom = 0;
            this.usernameBox.TextMarginLeft = 3;
            this.usernameBox.TextMarginTop = 1;
            this.usernameBox.TextPlaceholder = "Въведи потребителско име";
            this.usernameBox.UseSystemPasswordChar = false;
            this.usernameBox.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StorageManager.Properties.Resources.username_48px;
            this.pictureBox1.Location = new System.Drawing.Point(51, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добре дошли";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm awBg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox usernameBox;
        private Bunifu.UI.WinForms.BunifuTextBox passwordBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ControlBox exitButton;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Bunifu.UI.WinForms.BunifuSnackbar alert;
    }
}


namespace StorageManager.AutoActions
{
    partial class LoginLocalDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginLocalDatabase));
            this.awBg = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
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
            this.exitButton.Animated = true;
            this.exitButton.BorderColor = System.Drawing.Color.Red;
            this.exitButton.BorderRadius = 6;
            this.exitButton.BorderThickness = 1;
            this.exitButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.exitButton.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.exitButton.CustomizableEdges.BottomLeft = false;
            this.exitButton.CustomizableEdges.BottomRight = false;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.exitButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitButton.Location = new System.Drawing.Point(3, 120);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 34);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "ИЗХОД";
            this.exitButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Свързване към базата данни на проекта";
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = true;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(76, 12);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(113, 48);
            this.bunifuLoader1.Speed = 7;
            this.bunifuLoader1.TabIndex = 11;
            this.bunifuLoader1.Text = "bunifuLoader1";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 6;
            this.bunifuLoader1.Transparent = true;
            // 
            // LoginLocalDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(313, 166);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuLoader1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginLocalDatabase";
            this.Text = "Връзка към локалната база данни";
            this.Load += new System.EventHandler(this.LoginLocalDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm awBg;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
    }
}
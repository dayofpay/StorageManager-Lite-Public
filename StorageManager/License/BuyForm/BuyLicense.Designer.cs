namespace StorageManager.License.BuyForm
{
    partial class BuyLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyLicense));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.awBg = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.alreadyHave = new Guna.UI2.WinForms.Guna2Button();
            this.proPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.buyPro = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.litePanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.buyLite = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.proPanel.SuspendLayout();
            this.litePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // awBg
            // 
            this.awBg.AnimateWindow = true;
            this.awBg.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.awBg.ContainerControl = this;
            this.awBg.DockIndicatorTransparencyValue = 0.6D;
            this.awBg.TransparentWhileDrag = true;
            // 
            // alreadyHave
            // 
            this.alreadyHave.Animated = true;
            this.alreadyHave.BorderColor = System.Drawing.Color.DarkSalmon;
            this.alreadyHave.BorderRadius = 6;
            this.alreadyHave.BorderThickness = 1;
            this.alreadyHave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.alreadyHave.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.alreadyHave.CustomizableEdges.BottomLeft = false;
            this.alreadyHave.CustomizableEdges.BottomRight = false;
            this.alreadyHave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.alreadyHave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.alreadyHave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.alreadyHave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.alreadyHave.FillColor = System.Drawing.Color.Transparent;
            this.alreadyHave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyHave.ForeColor = System.Drawing.Color.DarkOrange;
            this.alreadyHave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.alreadyHave.Location = new System.Drawing.Point(215, 382);
            this.alreadyHave.Name = "alreadyHave";
            this.alreadyHave.Size = new System.Drawing.Size(283, 27);
            this.alreadyHave.TabIndex = 11;
            this.alreadyHave.Text = "Вече имам закупен лицензов ключ";
            this.alreadyHave.Click += new System.EventHandler(this.alreadyHave_Click);
            // 
            // proPanel
            // 
            this.proPanel.AutoSize = true;
            this.proPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.proPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proPanel.BackgroundImage")));
            this.proPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proPanel.BorderColor = System.Drawing.Color.Orange;
            this.proPanel.BorderRadius = 6;
            this.proPanel.BorderThickness = 4;
            this.proPanel.Controls.Add(this.label4);
            this.proPanel.Controls.Add(this.buyPro);
            this.proPanel.Controls.Add(this.label3);
            this.proPanel.Location = new System.Drawing.Point(349, 12);
            this.proPanel.Name = "proPanel";
            this.proPanel.ShowBorders = true;
            this.proPanel.Size = new System.Drawing.Size(340, 359);
            this.proPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(130, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "* Pro план *";
            // 
            // buyPro
            // 
            this.buyPro.Animated = true;
            this.buyPro.BorderColor = System.Drawing.Color.DarkSalmon;
            this.buyPro.BorderRadius = 6;
            this.buyPro.BorderThickness = 1;
            this.buyPro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buyPro.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.buyPro.CustomizableEdges.BottomLeft = false;
            this.buyPro.CustomizableEdges.BottomRight = false;
            this.buyPro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyPro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyPro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyPro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyPro.FillColor = System.Drawing.Color.Transparent;
            this.buyPro.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPro.ForeColor = System.Drawing.Color.DarkOrange;
            this.buyPro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buyPro.Location = new System.Drawing.Point(68, 305);
            this.buyPro.Name = "buyPro";
            this.buyPro.Size = new System.Drawing.Size(210, 27);
            this.buyPro.TabIndex = 11;
            this.buyPro.Text = "ЗАКУПИ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 280);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // litePanel
            // 
            this.litePanel.AutoSize = true;
            this.litePanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.litePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("litePanel.BackgroundImage")));
            this.litePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.litePanel.BorderColor = System.Drawing.Color.Coral;
            this.litePanel.BorderRadius = 6;
            this.litePanel.BorderThickness = 4;
            this.litePanel.Controls.Add(this.buyLite);
            this.litePanel.Controls.Add(this.label2);
            this.litePanel.Controls.Add(this.label1);
            this.litePanel.Location = new System.Drawing.Point(2, 12);
            this.litePanel.Name = "litePanel";
            this.litePanel.ShowBorders = true;
            this.litePanel.Size = new System.Drawing.Size(341, 332);
            this.litePanel.TabIndex = 0;
            // 
            // buyLite
            // 
            this.buyLite.Animated = true;
            this.buyLite.BorderColor = System.Drawing.Color.DarkSalmon;
            this.buyLite.BorderRadius = 6;
            this.buyLite.BorderThickness = 1;
            this.buyLite.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.buyLite.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.buyLite.CustomizableEdges.BottomLeft = false;
            this.buyLite.CustomizableEdges.BottomRight = false;
            this.buyLite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyLite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyLite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyLite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyLite.FillColor = System.Drawing.Color.Transparent;
            this.buyLite.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyLite.ForeColor = System.Drawing.Color.DarkOrange;
            this.buyLite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buyLite.Location = new System.Drawing.Point(50, 288);
            this.buyLite.Name = "buyLite";
            this.buyLite.Size = new System.Drawing.Size(210, 27);
            this.buyLite.TabIndex = 10;
            this.buyLite.Text = "ЗАКУПИ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 252);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Lite план *";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(2, 382);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 33);
            this.exitButton.TabIndex = 12;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BuyLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(701, 421);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.alreadyHave);
            this.Controls.Add(this.proPanel);
            this.Controls.Add(this.litePanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyLicense";
            this.Text = "Закупи лиценз";
            this.Load += new System.EventHandler(this.BuyLicense_Load);
            this.proPanel.ResumeLayout(false);
            this.proPanel.PerformLayout();
            this.litePanel.ResumeLayout(false);
            this.litePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm awBg;
        private Bunifu.UI.WinForms.BunifuPanel proPanel;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuPanel litePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button alreadyHave;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button buyPro;
        private Guna.UI2.WinForms.Guna2Button buyLite;
        private Guna.UI2.WinForms.Guna2ControlBox exitButton;
    }
}
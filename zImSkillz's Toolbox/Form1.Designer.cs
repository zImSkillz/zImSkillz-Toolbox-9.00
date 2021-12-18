namespace zImSkillz_s_Toolbox
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.connecttab = new MetroFramework.Controls.MetroTabPage();
            this.btnattach = new MetroFramework.Controls.MetroButton();
            this.btnconnect = new MetroFramework.Controls.MetroButton();
            this.ps4ip = new MetroFramework.Controls.MetroTextBox();
            this.payloadstab = new MetroFramework.Controls.MetroTabPage();
            this.soon = new MetroFramework.Controls.MetroLabel();
            this.payloadps4debug = new MetroFramework.Controls.MetroButton();
            this.bo3tab = new MetroFramework.Controls.MetroTabPage();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gscloacation = new MetroFramework.Controls.MetroTextBox();
            this.playstationtab = new MetroFramework.Controls.MetroTabPage();
            this.notifysymbol = new MetroFramework.Controls.MetroTextBox();
            this.notifysend = new MetroFramework.Controls.MetroButton();
            this.notifybox = new MetroFramework.Controls.MetroTextBox();
            this.statusps4 = new MetroFramework.Controls.MetroLabel();
            this.statusattached = new MetroFramework.Controls.MetroLabel();
            this.tabs.SuspendLayout();
            this.connecttab.SuspendLayout();
            this.payloadstab.SuspendLayout();
            this.bo3tab.SuspendLayout();
            this.playstationtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.connecttab);
            this.tabs.Controls.Add(this.payloadstab);
            this.tabs.Controls.Add(this.bo3tab);
            this.tabs.Controls.Add(this.playstationtab);
            this.tabs.Location = new System.Drawing.Point(1, 63);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(798, 364);
            this.tabs.Style = MetroFramework.MetroColorStyle.Red;
            this.tabs.TabIndex = 0;
            this.tabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabs.UseSelectable = true;
            // 
            // connecttab
            // 
            this.connecttab.Controls.Add(this.btnattach);
            this.connecttab.Controls.Add(this.btnconnect);
            this.connecttab.Controls.Add(this.ps4ip);
            this.connecttab.HorizontalScrollbarBarColor = true;
            this.connecttab.HorizontalScrollbarHighlightOnWheel = false;
            this.connecttab.HorizontalScrollbarSize = 10;
            this.connecttab.Location = new System.Drawing.Point(4, 38);
            this.connecttab.Name = "connecttab";
            this.connecttab.Size = new System.Drawing.Size(790, 322);
            this.connecttab.TabIndex = 0;
            this.connecttab.Text = "Connect";
            this.connecttab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.connecttab.VerticalScrollbarBarColor = true;
            this.connecttab.VerticalScrollbarHighlightOnWheel = false;
            this.connecttab.VerticalScrollbarSize = 10;
            this.connecttab.Click += new System.EventHandler(this.connecttab_Click);
            // 
            // btnattach
            // 
            this.btnattach.Location = new System.Drawing.Point(18, 99);
            this.btnattach.Name = "btnattach";
            this.btnattach.Size = new System.Drawing.Size(112, 25);
            this.btnattach.TabIndex = 4;
            this.btnattach.Text = "Attach";
            this.btnattach.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnattach.UseSelectable = true;
            this.btnattach.Click += new System.EventHandler(this.btnattach_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(18, 55);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(112, 38);
            this.btnconnect.TabIndex = 3;
            this.btnconnect.Text = "Connect";
            this.btnconnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnconnect.UseSelectable = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // ps4ip
            // 
            // 
            // 
            // 
            this.ps4ip.CustomButton.Image = null;
            this.ps4ip.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.ps4ip.CustomButton.Name = "";
            this.ps4ip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ps4ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ps4ip.CustomButton.TabIndex = 1;
            this.ps4ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ps4ip.CustomButton.UseSelectable = true;
            this.ps4ip.CustomButton.Visible = false;
            this.ps4ip.Lines = new string[] {
        "192.168.178.29"};
            this.ps4ip.Location = new System.Drawing.Point(18, 26);
            this.ps4ip.MaxLength = 32767;
            this.ps4ip.Name = "ps4ip";
            this.ps4ip.PasswordChar = '\0';
            this.ps4ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ps4ip.SelectedText = "";
            this.ps4ip.SelectionLength = 0;
            this.ps4ip.SelectionStart = 0;
            this.ps4ip.ShortcutsEnabled = true;
            this.ps4ip.Size = new System.Drawing.Size(112, 23);
            this.ps4ip.TabIndex = 2;
            this.ps4ip.Text = "192.168.178.29";
            this.ps4ip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ps4ip.UseSelectable = true;
            this.ps4ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ps4ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // payloadstab
            // 
            this.payloadstab.Controls.Add(this.soon);
            this.payloadstab.Controls.Add(this.payloadps4debug);
            this.payloadstab.HorizontalScrollbarBarColor = true;
            this.payloadstab.HorizontalScrollbarHighlightOnWheel = false;
            this.payloadstab.HorizontalScrollbarSize = 10;
            this.payloadstab.Location = new System.Drawing.Point(4, 38);
            this.payloadstab.Name = "payloadstab";
            this.payloadstab.Size = new System.Drawing.Size(790, 322);
            this.payloadstab.Style = MetroFramework.MetroColorStyle.Red;
            this.payloadstab.TabIndex = 1;
            this.payloadstab.Text = "Payloads";
            this.payloadstab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.payloadstab.VerticalScrollbarBarColor = true;
            this.payloadstab.VerticalScrollbarHighlightOnWheel = false;
            this.payloadstab.VerticalScrollbarSize = 10;
            // 
            // soon
            // 
            this.soon.AutoSize = true;
            this.soon.Location = new System.Drawing.Point(29, 29);
            this.soon.Name = "soon";
            this.soon.Size = new System.Drawing.Size(90, 19);
            this.soon.TabIndex = 3;
            this.soon.Text = "Coming Soon";
            this.soon.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // payloadps4debug
            // 
            this.payloadps4debug.Location = new System.Drawing.Point(18, 19);
            this.payloadps4debug.Name = "payloadps4debug";
            this.payloadps4debug.Size = new System.Drawing.Size(117, 38);
            this.payloadps4debug.TabIndex = 2;
            this.payloadps4debug.Text = "PS4Debug";
            this.payloadps4debug.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.payloadps4debug.UseSelectable = true;
            this.payloadps4debug.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bo3tab
            // 
            this.bo3tab.Controls.Add(this.metroButton4);
            this.bo3tab.Controls.Add(this.metroButton3);
            this.bo3tab.Controls.Add(this.metroButton2);
            this.bo3tab.Controls.Add(this.metroButton1);
            this.bo3tab.Controls.Add(this.gscloacation);
            this.bo3tab.HorizontalScrollbarBarColor = true;
            this.bo3tab.HorizontalScrollbarHighlightOnWheel = false;
            this.bo3tab.HorizontalScrollbarSize = 10;
            this.bo3tab.Location = new System.Drawing.Point(4, 38);
            this.bo3tab.Name = "bo3tab";
            this.bo3tab.Size = new System.Drawing.Size(790, 322);
            this.bo3tab.Style = MetroFramework.MetroColorStyle.Red;
            this.bo3tab.TabIndex = 2;
            this.bo3tab.Text = "BO3 1.33";
            this.bo3tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bo3tab.VerticalScrollbarBarColor = true;
            this.bo3tab.VerticalScrollbarHighlightOnWheel = false;
            this.bo3tab.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(83, 238);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(139, 34);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Give Ammo";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(83, 198);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(139, 34);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Give Money";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(239, 102);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(141, 21);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Browse";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(83, 102);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(150, 48);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Inject";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // gscloacation
            // 
            // 
            // 
            // 
            this.gscloacation.CustomButton.Image = null;
            this.gscloacation.CustomButton.Location = new System.Drawing.Point(355, 1);
            this.gscloacation.CustomButton.Name = "";
            this.gscloacation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gscloacation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gscloacation.CustomButton.TabIndex = 1;
            this.gscloacation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gscloacation.CustomButton.UseSelectable = true;
            this.gscloacation.CustomButton.Visible = false;
            this.gscloacation.Lines = new string[0];
            this.gscloacation.Location = new System.Drawing.Point(83, 73);
            this.gscloacation.MaxLength = 32767;
            this.gscloacation.Name = "gscloacation";
            this.gscloacation.PasswordChar = '\0';
            this.gscloacation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gscloacation.SelectedText = "";
            this.gscloacation.SelectionLength = 0;
            this.gscloacation.SelectionStart = 0;
            this.gscloacation.ShortcutsEnabled = true;
            this.gscloacation.Size = new System.Drawing.Size(377, 23);
            this.gscloacation.TabIndex = 3;
            this.gscloacation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gscloacation.UseSelectable = true;
            this.gscloacation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gscloacation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // playstationtab
            // 
            this.playstationtab.Controls.Add(this.notifysymbol);
            this.playstationtab.Controls.Add(this.notifysend);
            this.playstationtab.Controls.Add(this.notifybox);
            this.playstationtab.HorizontalScrollbarBarColor = true;
            this.playstationtab.HorizontalScrollbarHighlightOnWheel = false;
            this.playstationtab.HorizontalScrollbarSize = 10;
            this.playstationtab.Location = new System.Drawing.Point(4, 38);
            this.playstationtab.Name = "playstationtab";
            this.playstationtab.Size = new System.Drawing.Size(790, 322);
            this.playstationtab.Style = MetroFramework.MetroColorStyle.Red;
            this.playstationtab.TabIndex = 3;
            this.playstationtab.Text = "Playstation Settings";
            this.playstationtab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playstationtab.VerticalScrollbarBarColor = true;
            this.playstationtab.VerticalScrollbarHighlightOnWheel = false;
            this.playstationtab.VerticalScrollbarSize = 10;
            this.playstationtab.Click += new System.EventHandler(this.playstationtab_Click);
            // 
            // notifysymbol
            // 
            // 
            // 
            // 
            this.notifysymbol.CustomButton.Image = null;
            this.notifysymbol.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.notifysymbol.CustomButton.Name = "";
            this.notifysymbol.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.notifysymbol.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.notifysymbol.CustomButton.TabIndex = 1;
            this.notifysymbol.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.notifysymbol.CustomButton.UseSelectable = true;
            this.notifysymbol.CustomButton.Visible = false;
            this.notifysymbol.Lines = new string[] {
        "222"};
            this.notifysymbol.Location = new System.Drawing.Point(372, 21);
            this.notifysymbol.MaxLength = 32767;
            this.notifysymbol.Name = "notifysymbol";
            this.notifysymbol.PasswordChar = '\0';
            this.notifysymbol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notifysymbol.SelectedText = "";
            this.notifysymbol.SelectionLength = 0;
            this.notifysymbol.SelectionStart = 0;
            this.notifysymbol.ShortcutsEnabled = true;
            this.notifysymbol.Size = new System.Drawing.Size(51, 23);
            this.notifysymbol.TabIndex = 4;
            this.notifysymbol.Text = "222";
            this.notifysymbol.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.notifysymbol.UseSelectable = true;
            this.notifysymbol.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.notifysymbol.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // notifysend
            // 
            this.notifysend.Location = new System.Drawing.Point(19, 155);
            this.notifysend.Name = "notifysend";
            this.notifysend.Size = new System.Drawing.Size(159, 63);
            this.notifysend.TabIndex = 3;
            this.notifysend.Text = "Send Notify";
            this.notifysend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.notifysend.UseSelectable = true;
            this.notifysend.Click += new System.EventHandler(this.notifysend_Click);
            // 
            // notifybox
            // 
            // 
            // 
            // 
            this.notifybox.CustomButton.Image = null;
            this.notifybox.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.notifybox.CustomButton.Name = "";
            this.notifybox.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.notifybox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.notifybox.CustomButton.TabIndex = 1;
            this.notifybox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.notifybox.CustomButton.UseSelectable = true;
            this.notifybox.CustomButton.Visible = false;
            this.notifybox.Lines = new string[] {
        "Example"};
            this.notifybox.Location = new System.Drawing.Point(18, 21);
            this.notifybox.MaxLength = 32767;
            this.notifybox.Name = "notifybox";
            this.notifybox.PasswordChar = '\0';
            this.notifybox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notifybox.SelectedText = "";
            this.notifybox.SelectionLength = 0;
            this.notifybox.SelectionStart = 0;
            this.notifybox.ShortcutsEnabled = true;
            this.notifybox.Size = new System.Drawing.Size(348, 128);
            this.notifybox.TabIndex = 2;
            this.notifybox.Text = "Example";
            this.notifybox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.notifybox.UseSelectable = true;
            this.notifybox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.notifybox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.notifybox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // statusps4
            // 
            this.statusps4.AutoSize = true;
            this.statusps4.Location = new System.Drawing.Point(1, 430);
            this.statusps4.Name = "statusps4";
            this.statusps4.Size = new System.Drawing.Size(98, 19);
            this.statusps4.TabIndex = 1;
            this.statusps4.Text = "Not Connected";
            this.statusps4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // statusattached
            // 
            this.statusattached.AutoSize = true;
            this.statusattached.Location = new System.Drawing.Point(96, 430);
            this.statusattached.Name = "statusattached";
            this.statusattached.Size = new System.Drawing.Size(87, 19);
            this.statusattached.TabIndex = 2;
            this.statusattached.Text = "Not Attached";
            this.statusattached.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.statusattached.Click += new System.EventHandler(this.statusattached_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusattached);
            this.Controls.Add(this.statusps4);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "zImSkillz\'s Toolbox";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.connecttab.ResumeLayout(false);
            this.payloadstab.ResumeLayout(false);
            this.payloadstab.PerformLayout();
            this.bo3tab.ResumeLayout(false);
            this.playstationtab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroLabel statusps4;
        private MetroFramework.Controls.MetroLabel statusattached;
        private MetroFramework.Controls.MetroTabPage connecttab;
        private MetroFramework.Controls.MetroButton btnattach;
        private MetroFramework.Controls.MetroButton btnconnect;
        private MetroFramework.Controls.MetroTextBox ps4ip;
        private MetroFramework.Controls.MetroTabPage payloadstab;
        private MetroFramework.Controls.MetroButton payloadps4debug;
        private MetroFramework.Controls.MetroLabel soon;
        private MetroFramework.Controls.MetroTabPage bo3tab;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox gscloacation;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTabPage playstationtab;
        private MetroFramework.Controls.MetroTextBox notifybox;
        private MetroFramework.Controls.MetroButton notifysend;
        private MetroFramework.Controls.MetroTextBox notifysymbol;
    }
}


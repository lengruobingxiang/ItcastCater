namespace CaterUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuManagerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMemberInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTableInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDishInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tcHallInfo = new System.Windows.Forms.TabControl();
            this.ilTable = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManagerInfo,
            this.MenuMemberInfo,
            this.MenuTableInfo,
            this.MenuDishInfo,
            this.MenuOrder,
            this.MenuQuit});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(977, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuManagerInfo
            // 
            this.MenuManagerInfo.Name = "MenuManagerInfo";
            this.MenuManagerInfo.Size = new System.Drawing.Size(68, 21);
            this.MenuManagerInfo.Text = "店员管理";
            this.MenuManagerInfo.Click += new System.EventHandler(this.MenuManagerInfo_Click);
            // 
            // MenuMemberInfo
            // 
            this.MenuMemberInfo.Name = "MenuMemberInfo";
            this.MenuMemberInfo.Size = new System.Drawing.Size(68, 21);
            this.MenuMemberInfo.Text = "会员管理";
            this.MenuMemberInfo.Click += new System.EventHandler(this.MenuMemberInfo_Click);
            // 
            // MenuTableInfo
            // 
            this.MenuTableInfo.Name = "MenuTableInfo";
            this.MenuTableInfo.Size = new System.Drawing.Size(68, 21);
            this.MenuTableInfo.Text = "餐桌管理";
            this.MenuTableInfo.Click += new System.EventHandler(this.MenuTableInfo_Click);
            // 
            // MenuDishInfo
            // 
            this.MenuDishInfo.Name = "MenuDishInfo";
            this.MenuDishInfo.Size = new System.Drawing.Size(68, 21);
            this.MenuDishInfo.Text = "菜单管理";
            this.MenuDishInfo.Click += new System.EventHandler(this.MenuDishInfo_Click);
            // 
            // MenuOrder
            // 
            this.MenuOrder.Name = "MenuOrder";
            this.MenuOrder.Size = new System.Drawing.Size(44, 21);
            this.MenuOrder.Text = "结账";
            this.MenuOrder.Click += new System.EventHandler(this.MenuOrder_Click);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.Size = new System.Drawing.Size(44, 21);
            this.MenuQuit.Text = "退出";
            this.MenuQuit.Click += new System.EventHandler(this.MenuQuit_Click);
            // 
            // tcHallInfo
            // 
            this.tcHallInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHallInfo.Location = new System.Drawing.Point(0, 25);
            this.tcHallInfo.Name = "tcHallInfo";
            this.tcHallInfo.SelectedIndex = 0;
            this.tcHallInfo.Size = new System.Drawing.Size(977, 592);
            this.tcHallInfo.TabIndex = 1;
            // 
            // ilTable
            // 
            this.ilTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTable.ImageStream")));
            this.ilTable.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTable.Images.SetKeyName(0, "Free");
            this.ilTable.Images.SetKeyName(1, "Busy");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 617);
            this.Controls.Add(this.tcHallInfo);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐饮管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuManagerInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuMemberInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuTableInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuDishInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuOrder;
        private System.Windows.Forms.ToolStripMenuItem MenuQuit;
        private System.Windows.Forms.TabControl tcHallInfo;
        private System.Windows.Forms.ImageList ilTable;
    }
}
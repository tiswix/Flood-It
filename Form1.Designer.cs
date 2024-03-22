
namespace Flood_it
{
    partial class Root
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Root));
            this.tlpField = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butNewGame = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblPlayer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblComp = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.lblCount = new System.Windows.Forms.ToolStripLabel();
            this.butAbout = new System.Windows.Forms.ToolStripButton();
            this.Rule = new System.Windows.Forms.ToolStripButton();
            this.lblPlayerColor = new System.Windows.Forms.Label();
            this.lblCompColor = new System.Windows.Forms.Label();
            this.lblBarPlayer = new System.Windows.Forms.Label();
            this.lblBarBase = new System.Windows.Forms.Label();
            this.lblBarComp = new System.Windows.Forms.Label();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpField
            // 
            this.tlpField.ColumnCount = 2;
            this.tlpField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpField.Location = new System.Drawing.Point(12, 53);
            this.tlpField.Name = "tlpField";
            this.tlpField.RowCount = 2;
            this.tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpField.Size = new System.Drawing.Size(472, 416);
            this.tlpField.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butNewGame,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.lblPlayer,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.lblComp,
            this.toolStripSeparator3,
            this.toolStripLabel6,
            this.lblCount,
            this.toolStripSeparator4,
            this.butAbout,
            this.toolStripSeparator5,
            this.Rule});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(549, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butNewGame
            // 
            this.butNewGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.butNewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butNewGame.Image = ((System.Drawing.Image)(resources.GetObject("butNewGame.Image")));
            this.butNewGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butNewGame.Name = "butNewGame";
            this.butNewGame.Size = new System.Drawing.Size(68, 22);
            this.butNewGame.Text = "New game";
            this.butNewGame.Click += new System.EventHandler(this.butNewGame_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Player:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = false;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(30, 22);
            this.lblPlayer.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel3.Text = "Computer:";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = false;
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(30, 22);
            this.lblComp.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel6.Text = "Count of steps:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = false;
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 22);
            this.lblCount.Text = "0";
            // 
            // butAbout
            // 
            this.butAbout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.butAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butAbout.Image = ((System.Drawing.Image)(resources.GetObject("butAbout.Image")));
            this.butAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butAbout.Name = "butAbout";
            this.butAbout.Size = new System.Drawing.Size(102, 22);
            this.butAbout.Text = "About the author";
            this.butAbout.Click += new System.EventHandler(this.butAbout_Click);
            // 
            // Rule
            // 
            this.Rule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Rule.Image = ((System.Drawing.Image)(resources.GetObject("Rule.Image")));
            this.Rule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(34, 22);
            this.Rule.Text = "Rule";
            this.Rule.Click += new System.EventHandler(this.Rule_Click);
            // 
            // lblPlayerColor
            // 
            this.lblPlayerColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblPlayerColor.Location = new System.Drawing.Point(12, 28);
            this.lblPlayerColor.Name = "lblPlayerColor";
            this.lblPlayerColor.Size = new System.Drawing.Size(21, 21);
            this.lblPlayerColor.TabIndex = 2;
            // 
            // lblCompColor
            // 
            this.lblCompColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCompColor.Location = new System.Drawing.Point(519, 28);
            this.lblCompColor.Name = "lblCompColor";
            this.lblCompColor.Size = new System.Drawing.Size(21, 21);
            this.lblCompColor.TabIndex = 3;
            // 
            // lblBarPlayer
            // 
            this.lblBarPlayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBarPlayer.Location = new System.Drawing.Point(39, 28);
            this.lblBarPlayer.Name = "lblBarPlayer";
            this.lblBarPlayer.Size = new System.Drawing.Size(67, 21);
            this.lblBarPlayer.TabIndex = 4;
            // 
            // lblBarBase
            // 
            this.lblBarBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBarBase.Location = new System.Drawing.Point(38, 28);
            this.lblBarBase.Name = "lblBarBase";
            this.lblBarBase.Size = new System.Drawing.Size(474, 21);
            this.lblBarBase.TabIndex = 5;
            // 
            // lblBarComp
            // 
            this.lblBarComp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBarComp.Location = new System.Drawing.Point(446, 28);
            this.lblBarComp.Name = "lblBarComp";
            this.lblBarComp.Size = new System.Drawing.Size(67, 21);
            this.lblBarComp.TabIndex = 6;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 587);
            this.Controls.Add(this.lblBarComp);
            this.Controls.Add(this.lblBarPlayer);
            this.Controls.Add(this.lblBarBase);
            this.Controls.Add(this.lblPlayerColor);
            this.Controls.Add(this.lblCompColor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tlpField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Root";
            this.Text = "Flood It";
            this.Load += new System.EventHandler(this.Root_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpField;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblPlayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblComp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel lblCount;
        private System.Windows.Forms.ToolStripButton butAbout;
        private System.Windows.Forms.Label lblPlayerColor;
        private System.Windows.Forms.Label lblCompColor;
        private System.Windows.Forms.Label lblBarPlayer;
        private System.Windows.Forms.Label lblBarBase;
        private System.Windows.Forms.Label lblBarComp;
        private System.Windows.Forms.ToolStripButton Rule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}


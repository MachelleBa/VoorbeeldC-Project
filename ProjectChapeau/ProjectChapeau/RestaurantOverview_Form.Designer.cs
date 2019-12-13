namespace ProjectChapeau
{
    partial class RestaurantOverview_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantOverview_Form));
            this.flowlaypnl_table_overview_uneven = new System.Windows.Forms.FlowLayoutPanel();
            this.flowlaypnl_table_overview_even = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.lbl_loggedinEmployee = new System.Windows.Forms.Label();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.pnl_tableoverview_container = new System.Windows.Forms.Panel();
            this.lbl_title_table_overview = new System.Windows.Forms.Label();
            this.flowlaypnl_statusUneven = new System.Windows.Forms.FlowLayoutPanel();
            this.flowlaypnl_statusEven = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_topbar.SuspendLayout();
            this.pnl_tableoverview_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowlaypnl_table_overview_uneven
            // 
            this.flowlaypnl_table_overview_uneven.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlaypnl_table_overview_uneven.Location = new System.Drawing.Point(13, 29);
            this.flowlaypnl_table_overview_uneven.Name = "flowlaypnl_table_overview_uneven";
            this.flowlaypnl_table_overview_uneven.Size = new System.Drawing.Size(90, 608);
            this.flowlaypnl_table_overview_uneven.TabIndex = 0;
            // 
            // flowlaypnl_table_overview_even
            // 
            this.flowlaypnl_table_overview_even.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlaypnl_table_overview_even.Location = new System.Drawing.Point(229, 29);
            this.flowlaypnl_table_overview_even.Name = "flowlaypnl_table_overview_even";
            this.flowlaypnl_table_overview_even.Size = new System.Drawing.Size(90, 608);
            this.flowlaypnl_table_overview_even.TabIndex = 1;
            this.flowlaypnl_table_overview_even.Paint += new System.Windows.Forms.PaintEventHandler(this.flowlaypnl_table_overview_even_Paint);
            // 
            // btn_logoff
            // 
            this.btn_logoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(100)))));
            this.btn_logoff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_logoff.FlatAppearance.BorderSize = 0;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoff.Location = new System.Drawing.Point(404, 0);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(79, 50);
            this.btn_logoff.TabIndex = 2;
            this.btn_logoff.Text = "Log off";
            this.btn_logoff.UseVisualStyleBackColor = false;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // lbl_loggedinEmployee
            // 
            this.lbl_loggedinEmployee.AutoSize = true;
            this.lbl_loggedinEmployee.Location = new System.Drawing.Point(114, 16);
            this.lbl_loggedinEmployee.Name = "lbl_loggedinEmployee";
            this.lbl_loggedinEmployee.Size = new System.Drawing.Size(28, 18);
            this.lbl_loggedinEmployee.TabIndex = 3;
            this.lbl_loggedinEmployee.Text = "    ";
            // 
            // pnl_topbar
            // 
            this.pnl_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_topbar.Controls.Add(this.btn_logoff);
            this.pnl_topbar.Controls.Add(this.lbl_loggedinEmployee);
            this.pnl_topbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_topbar.ForeColor = System.Drawing.Color.White;
            this.pnl_topbar.Location = new System.Drawing.Point(-1, 0);
            this.pnl_topbar.Name = "pnl_topbar";
            this.pnl_topbar.Size = new System.Drawing.Size(486, 50);
            this.pnl_topbar.TabIndex = 4;
            // 
            // pnl_tableoverview_container
            // 
            this.pnl_tableoverview_container.Controls.Add(this.lbl_title_table_overview);
            this.pnl_tableoverview_container.Controls.Add(this.flowlaypnl_statusUneven);
            this.pnl_tableoverview_container.Controls.Add(this.flowlaypnl_statusEven);
            this.pnl_tableoverview_container.Controls.Add(this.flowlaypnl_table_overview_even);
            this.pnl_tableoverview_container.Controls.Add(this.flowlaypnl_table_overview_uneven);
            this.pnl_tableoverview_container.Location = new System.Drawing.Point(25, 56);
            this.pnl_tableoverview_container.Name = "pnl_tableoverview_container";
            this.pnl_tableoverview_container.Size = new System.Drawing.Size(436, 656);
            this.pnl_tableoverview_container.TabIndex = 5;
            // 
            // lbl_title_table_overview
            // 
            this.lbl_title_table_overview.AutoSize = true;
            this.lbl_title_table_overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_table_overview.Location = new System.Drawing.Point(126, 6);
            this.lbl_title_table_overview.Name = "lbl_title_table_overview";
            this.lbl_title_table_overview.Size = new System.Drawing.Size(170, 25);
            this.lbl_title_table_overview.TabIndex = 4;
            this.lbl_title_table_overview.Text = "Table: Overview";
            // 
            // flowlaypnl_statusUneven
            // 
            this.flowlaypnl_statusUneven.Location = new System.Drawing.Point(109, 29);
            this.flowlaypnl_statusUneven.Name = "flowlaypnl_statusUneven";
            this.flowlaypnl_statusUneven.Size = new System.Drawing.Size(100, 608);
            this.flowlaypnl_statusUneven.TabIndex = 3;
            // 
            // flowlaypnl_statusEven
            // 
            this.flowlaypnl_statusEven.Location = new System.Drawing.Point(325, 29);
            this.flowlaypnl_statusEven.Name = "flowlaypnl_statusEven";
            this.flowlaypnl_statusEven.Size = new System.Drawing.Size(100, 608);
            this.flowlaypnl_statusEven.TabIndex = 2;
            // 
            // RestaurantOverview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 753);
            this.Controls.Add(this.pnl_topbar);
            this.Controls.Add(this.pnl_tableoverview_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestaurantOverview_Form";
            this.Text = "Chapeau - Restaurant Overview";
            this.pnl_topbar.ResumeLayout(false);
            this.pnl_topbar.PerformLayout();
            this.pnl_tableoverview_container.ResumeLayout(false);
            this.pnl_tableoverview_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_table_overview_uneven;
        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_table_overview_even;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Label lbl_loggedinEmployee;
        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Panel pnl_tableoverview_container;
        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_statusUneven;
        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_statusEven;
        private System.Windows.Forms.Label lbl_title_table_overview;
    }
}
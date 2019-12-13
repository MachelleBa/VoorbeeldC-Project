namespace ProjectChapeau
{
    partial class OccupiedTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OccupiedTableForm));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.ordertimeLabel = new System.Windows.Forms.Label();
            this.statusDisplayLabel = new System.Windows.Forms.Label();
            this.textStatusLabel = new System.Windows.Forms.Label();
            this.tableReceiptListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.startPaymentButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.panelDisplaNameTableID = new System.Windows.Forms.Panel();
            this.labelDisplayTableID = new System.Windows.Forms.Label();
            this.FormPanel.SuspendLayout();
            this.panelDisplaNameTableID.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.panelDisplaNameTableID);
            this.FormPanel.Controls.Add(this.ordertimeLabel);
            this.FormPanel.Controls.Add(this.statusDisplayLabel);
            this.FormPanel.Controls.Add(this.textStatusLabel);
            this.FormPanel.Controls.Add(this.tableReceiptListView);
            this.FormPanel.Controls.Add(this.backButton);
            this.FormPanel.Controls.Add(this.startPaymentButton);
            this.FormPanel.Controls.Add(this.cancelOrderButton);
            this.FormPanel.Controls.Add(this.addItemButton);
            this.FormPanel.Location = new System.Drawing.Point(9, 1);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(345, 583);
            this.FormPanel.TabIndex = 0;
            // 
            // ordertimeLabel
            // 
            this.ordertimeLabel.AutoSize = true;
            this.ordertimeLabel.Location = new System.Drawing.Point(43, 126);
            this.ordertimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordertimeLabel.Name = "ordertimeLabel";
            this.ordertimeLabel.Size = new System.Drawing.Size(10, 13);
            this.ordertimeLabel.TabIndex = 8;
            this.ordertimeLabel.Text = "-";
            this.ordertimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusDisplayLabel
            // 
            this.statusDisplayLabel.AutoSize = true;
            this.statusDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplayLabel.Location = new System.Drawing.Point(110, 95);
            this.statusDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusDisplayLabel.Name = "statusDisplayLabel";
            this.statusDisplayLabel.Size = new System.Drawing.Size(119, 20);
            this.statusDisplayLabel.TabIndex = 7;
            this.statusDisplayLabel.Text = "Waiting Order";
            this.statusDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textStatusLabel
            // 
            this.textStatusLabel.AutoSize = true;
            this.textStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatusLabel.Location = new System.Drawing.Point(131, 72);
            this.textStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textStatusLabel.Name = "textStatusLabel";
            this.textStatusLabel.Size = new System.Drawing.Size(76, 20);
            this.textStatusLabel.TabIndex = 6;
            this.textStatusLabel.Text = "STATUS:";
            // 
            // tableReceiptListView
            // 
            this.tableReceiptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.dots,
            this.price});
            this.tableReceiptListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.tableReceiptListView.Location = new System.Drawing.Point(45, 162);
            this.tableReceiptListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableReceiptListView.Name = "tableReceiptListView";
            this.tableReceiptListView.Size = new System.Drawing.Size(247, 209);
            this.tableReceiptListView.TabIndex = 5;
            this.tableReceiptListView.UseCompatibleStateImageBehavior = false;
            this.tableReceiptListView.View = System.Windows.Forms.View.Details;
            this.tableReceiptListView.SelectedIndexChanged += new System.EventHandler(this.tableReceiptListView_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Width = 90;
            // 
            // dots
            // 
            this.dots.Width = 90;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(23, 526);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 37);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // startPaymentButton
            // 
            this.startPaymentButton.BackColor = System.Drawing.Color.DarkOrange;
            this.startPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPaymentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startPaymentButton.Location = new System.Drawing.Point(45, 461);
            this.startPaymentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startPaymentButton.Name = "startPaymentButton";
            this.startPaymentButton.Size = new System.Drawing.Size(246, 41);
            this.startPaymentButton.TabIndex = 2;
            this.startPaymentButton.Text = "Start Payment";
            this.startPaymentButton.UseVisualStyleBackColor = false;
            this.startPaymentButton.Click += new System.EventHandler(this.startPaymentButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.Brown;
            this.cancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelOrderButton.Location = new System.Drawing.Point(45, 405);
            this.cancelOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(121, 41);
            this.cancelOrderButton.TabIndex = 1;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.OliveDrab;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemButton.Location = new System.Drawing.Point(170, 405);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(121, 41);
            this.addItemButton.TabIndex = 0;
            this.addItemButton.Text = "Add a new Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // panelDisplaNameTableID
            // 
            this.panelDisplaNameTableID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelDisplaNameTableID.Controls.Add(this.labelDisplayTableID);
            this.panelDisplaNameTableID.Location = new System.Drawing.Point(0, 37);
            this.panelDisplaNameTableID.Name = "panelDisplaNameTableID";
            this.panelDisplaNameTableID.Size = new System.Drawing.Size(345, 32);
            this.panelDisplaNameTableID.TabIndex = 9;
            // 
            // labelDisplayTableID
            // 
            this.labelDisplayTableID.AutoSize = true;
            this.labelDisplayTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayTableID.Location = new System.Drawing.Point(163, 7);
            this.labelDisplayTableID.Name = "labelDisplayTableID";
            this.labelDisplayTableID.Size = new System.Drawing.Size(12, 15);
            this.labelDisplayTableID.TabIndex = 10;
            this.labelDisplayTableID.Text = "-";
            this.labelDisplayTableID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OccupiedTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(363, 612);
            this.Controls.Add(this.FormPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OccupiedTableForm";
            this.Text = "OccupiedTableForm";
            this.Load += new System.EventHandler(this.OccupiedTableForm_Load);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.panelDisplaNameTableID.ResumeLayout(false);
            this.panelDisplaNameTableID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label statusDisplayLabel;
        private System.Windows.Forms.Label textStatusLabel;
        private System.Windows.Forms.ListView tableReceiptListView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button startPaymentButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dots;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label ordertimeLabel;
        private System.Windows.Forms.Panel panelDisplaNameTableID;
        private System.Windows.Forms.Label labelDisplayTableID;
    }
}
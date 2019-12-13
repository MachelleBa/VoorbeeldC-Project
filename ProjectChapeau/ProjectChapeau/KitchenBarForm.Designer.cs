namespace ProjectChapeau
{
    partial class KitchenBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBarForm));
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnGetWait = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOffBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKitchen.BackColor = System.Drawing.Color.White;
            this.panelKitchen.ForeColor = System.Drawing.SystemColors.Window;
            this.panelKitchen.Location = new System.Drawing.Point(182, 77);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(786, 361);
            this.panelKitchen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(178, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // btnKitchen
            // 
            this.btnKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitchen.BackColor = System.Drawing.Color.Orange;
            this.btnKitchen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitchen.Location = new System.Drawing.Point(769, 479);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(207, 53);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "Complete Order";
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnGetWait
            // 
            this.btnGetWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetWait.BackColor = System.Drawing.Color.Orange;
            this.btnGetWait.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWait.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetWait.Location = new System.Drawing.Point(504, 479);
            this.btnGetWait.Name = "btnGetWait";
            this.btnGetWait.Size = new System.Drawing.Size(207, 53);
            this.btnGetWait.TabIndex = 2;
            this.btnGetWait.Text = "Call Waiter";
            this.btnGetWait.UseVisualStyleBackColor = false;
            this.btnGetWait.Click += new System.EventHandler(this.btnGetWait_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.logOffBtn);
            this.panel1.Location = new System.Drawing.Point(-6, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 41);
            this.panel1.TabIndex = 3;
            // 
            // logOffBtn
            // 
            this.logOffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOffBtn.FlatAppearance.BorderSize = 0;
            this.logOffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.logOffBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOffBtn.Location = new System.Drawing.Point(1049, 3);
            this.logOffBtn.Name = "logOffBtn";
            this.logOffBtn.Size = new System.Drawing.Size(101, 41);
            this.logOffBtn.TabIndex = 0;
            this.logOffBtn.Text = "LogOff";
            this.logOffBtn.UseVisualStyleBackColor = true;
            this.logOffBtn.Click += new System.EventHandler(this.logOffBtn_Click);
            // 
            // KitchenBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1142, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetWait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.panelKitchen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitchenBarForm";
            this.Text = "Kitchen Orders";
            this.Load += new System.EventHandler(this.KitchenBarForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnGetWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOffBtn;
    }
}
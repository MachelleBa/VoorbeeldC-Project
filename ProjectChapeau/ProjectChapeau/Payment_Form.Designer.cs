namespace ProjectChapeau
{
    partial class Payment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            this.payCashbttn = new System.Windows.Forms.RadioButton();
            this.payDebitbttn = new System.Windows.Forms.RadioButton();
            this.payCreditbttn = new System.Windows.Forms.RadioButton();
            this.orderItemsPaymentlv = new System.Windows.Forms.ListView();
            this.CommentsTxt = new System.Windows.Forms.TextBox();
            this.FinishedPaymentBttn = new System.Windows.Forms.Button();
            this.orderDetailsPaymentlv = new System.Windows.Forms.ListView();
            this.TipInputnum = new System.Windows.Forms.NumericUpDown();
            this.CancelPaymentbttn = new System.Windows.Forms.Button();
            this.tiplbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TipInputnum)).BeginInit();
            this.SuspendLayout();
            // 
            // payCashbttn
            // 
            this.payCashbttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payCashbttn.BackgroundImage")));
            this.payCashbttn.Location = new System.Drawing.Point(32, 516);
            this.payCashbttn.Name = "payCashbttn";
            this.payCashbttn.Size = new System.Drawing.Size(90, 70);
            this.payCashbttn.TabIndex = 0;
            this.payCashbttn.TabStop = true;
            this.payCashbttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payCashbttn.UseMnemonic = false;
            this.payCashbttn.UseVisualStyleBackColor = true;
            // 
            // payDebitbttn
            // 
            this.payDebitbttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payDebitbttn.BackgroundImage")));
            this.payDebitbttn.Location = new System.Drawing.Point(204, 516);
            this.payDebitbttn.Name = "payDebitbttn";
            this.payDebitbttn.Size = new System.Drawing.Size(90, 70);
            this.payDebitbttn.TabIndex = 1;
            this.payDebitbttn.TabStop = true;
            this.payDebitbttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payDebitbttn.UseVisualStyleBackColor = true;
            // 
            // payCreditbttn
            // 
            this.payCreditbttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payCreditbttn.BackgroundImage")));
            this.payCreditbttn.Location = new System.Drawing.Point(360, 516);
            this.payCreditbttn.Name = "payCreditbttn";
            this.payCreditbttn.Size = new System.Drawing.Size(90, 70);
            this.payCreditbttn.TabIndex = 2;
            this.payCreditbttn.TabStop = true;
            this.payCreditbttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payCreditbttn.UseVisualStyleBackColor = true;
            // 
            // orderItemsPaymentlv
            // 
            this.orderItemsPaymentlv.Location = new System.Drawing.Point(32, 29);
            this.orderItemsPaymentlv.Name = "orderItemsPaymentlv";
            this.orderItemsPaymentlv.Size = new System.Drawing.Size(418, 156);
            this.orderItemsPaymentlv.TabIndex = 3;
            this.orderItemsPaymentlv.UseCompatibleStateImageBehavior = false;
            // 
            // CommentsTxt
            // 
            this.CommentsTxt.Location = new System.Drawing.Point(32, 314);
            this.CommentsTxt.Multiline = true;
            this.CommentsTxt.Name = "CommentsTxt";
            this.CommentsTxt.Size = new System.Drawing.Size(418, 83);
            this.CommentsTxt.TabIndex = 4;
            // 
            // FinishedPaymentBttn
            // 
            this.FinishedPaymentBttn.BackColor = System.Drawing.Color.DarkOrange;
            this.FinishedPaymentBttn.Location = new System.Drawing.Point(149, 619);
            this.FinishedPaymentBttn.Name = "FinishedPaymentBttn";
            this.FinishedPaymentBttn.Size = new System.Drawing.Size(201, 50);
            this.FinishedPaymentBttn.TabIndex = 5;
            this.FinishedPaymentBttn.Text = "Finalise Payment";
            this.FinishedPaymentBttn.UseVisualStyleBackColor = false;
            this.FinishedPaymentBttn.Click += new System.EventHandler(this.FinishedPaymentBttn_Click);
            // 
            // orderDetailsPaymentlv
            // 
            this.orderDetailsPaymentlv.Location = new System.Drawing.Point(32, 208);
            this.orderDetailsPaymentlv.Name = "orderDetailsPaymentlv";
            this.orderDetailsPaymentlv.Size = new System.Drawing.Size(418, 67);
            this.orderDetailsPaymentlv.TabIndex = 6;
            this.orderDetailsPaymentlv.UseCompatibleStateImageBehavior = false;
            // 
            // TipInputnum
            // 
            this.TipInputnum.Location = new System.Drawing.Point(187, 432);
            this.TipInputnum.Name = "TipInputnum";
            this.TipInputnum.Size = new System.Drawing.Size(120, 22);
            this.TipInputnum.TabIndex = 7;
            // 
            // CancelPaymentbttn
            // 
            this.CancelPaymentbttn.Location = new System.Drawing.Point(32, 691);
            this.CancelPaymentbttn.Name = "CancelPaymentbttn";
            this.CancelPaymentbttn.Size = new System.Drawing.Size(124, 40);
            this.CancelPaymentbttn.TabIndex = 8;
            this.CancelPaymentbttn.Text = "Cancel Payment";
            this.CancelPaymentbttn.UseVisualStyleBackColor = true;
            this.CancelPaymentbttn.Click += new System.EventHandler(this.CancelPaymentbttn_Click);
            // 
            // tiplbl
            // 
            this.tiplbl.AutoSize = true;
            this.tiplbl.Location = new System.Drawing.Point(133, 434);
            this.tiplbl.Name = "tiplbl";
            this.tiplbl.Size = new System.Drawing.Size(36, 17);
            this.tiplbl.TabIndex = 9;
            this.tiplbl.Text = "Tip: ";
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 753);
            this.Controls.Add(this.tiplbl);
            this.Controls.Add(this.CancelPaymentbttn);
            this.Controls.Add(this.TipInputnum);
            this.Controls.Add(this.orderDetailsPaymentlv);
            this.Controls.Add(this.FinishedPaymentBttn);
            this.Controls.Add(this.CommentsTxt);
            this.Controls.Add(this.orderItemsPaymentlv);
            this.Controls.Add(this.payCreditbttn);
            this.Controls.Add(this.payDebitbttn);
            this.Controls.Add(this.payCashbttn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipInputnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton payCashbttn;
        private System.Windows.Forms.RadioButton payDebitbttn;
        private System.Windows.Forms.RadioButton payCreditbttn;
        private System.Windows.Forms.ListView orderItemsPaymentlv;
        private System.Windows.Forms.TextBox CommentsTxt;
        private System.Windows.Forms.Button FinishedPaymentBttn;
        private System.Windows.Forms.ListView orderDetailsPaymentlv;
        private System.Windows.Forms.NumericUpDown TipInputnum;
        private System.Windows.Forms.Button CancelPaymentbttn;
        private System.Windows.Forms.Label tiplbl;
    }
}
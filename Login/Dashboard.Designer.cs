
namespace Login
{
    partial class Dashboard
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
            this.btnUserAcc = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserAcc
            // 
            this.btnUserAcc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUserAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAcc.Location = new System.Drawing.Point(299, 159);
            this.btnUserAcc.Name = "btnUserAcc";
            this.btnUserAcc.Size = new System.Drawing.Size(195, 171);
            this.btnUserAcc.TabIndex = 1;
            this.btnUserAcc.Text = "Add Account";
            this.btnUserAcc.UseVisualStyleBackColor = false;
            this.btnUserAcc.Click += new System.EventHandler(this.btnUserAcc_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(50, 160);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(184, 171);
            this.btnItem.TabIndex = 0;
            this.btnItem.Text = "Add Item";
            this.btnItem.UseVisualStyleBackColor = false;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(547, 159);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(207, 171);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Add Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(698, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = " Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnUserAcc);
            this.Controls.Add(this.btnItem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserAcc;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button button2;
    }
}
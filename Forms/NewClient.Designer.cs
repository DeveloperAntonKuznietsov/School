namespace SchuleApp1
{
    partial class NewClient
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
            this.txtFirstnameClient = new System.Windows.Forms.TextBox();
            this.txtLastnameClient = new System.Windows.Forms.TextBox();
            this.txtAddressClient = new System.Windows.Forms.TextBox();
            this.txtPhoneClient = new System.Windows.Forms.TextBox();
            this.txtOrderClient = new System.Windows.Forms.TextBox();
            this.txtNumberClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstnameClient
            // 
            this.txtFirstnameClient.Location = new System.Drawing.Point(216, 95);
            this.txtFirstnameClient.Name = "txtFirstnameClient";
            this.txtFirstnameClient.Size = new System.Drawing.Size(156, 20);
            this.txtFirstnameClient.TabIndex = 23;
            // 
            // txtLastnameClient
            // 
            this.txtLastnameClient.Location = new System.Drawing.Point(216, 124);
            this.txtLastnameClient.Name = "txtLastnameClient";
            this.txtLastnameClient.Size = new System.Drawing.Size(156, 20);
            this.txtLastnameClient.TabIndex = 22;
            // 
            // txtAddressClient
            // 
            this.txtAddressClient.Location = new System.Drawing.Point(216, 156);
            this.txtAddressClient.Name = "txtAddressClient";
            this.txtAddressClient.Size = new System.Drawing.Size(156, 20);
            this.txtAddressClient.TabIndex = 21;
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.Location = new System.Drawing.Point(216, 185);
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.Size = new System.Drawing.Size(156, 20);
            this.txtPhoneClient.TabIndex = 20;
            // 
            // txtOrderClient
            // 
            this.txtOrderClient.Location = new System.Drawing.Point(216, 213);
            this.txtOrderClient.Name = "txtOrderClient";
            this.txtOrderClient.Size = new System.Drawing.Size(156, 20);
            this.txtOrderClient.TabIndex = 19;
            // 
            // txtNumberClient
            // 
            this.txtNumberClient.Location = new System.Drawing.Point(216, 66);
            this.txtNumberClient.Name = "txtNumberClient";
            this.txtNumberClient.Size = new System.Drawing.Size(156, 20);
            this.txtNumberClient.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lastname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Serial number:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFirstnameClient);
            this.Controls.Add(this.txtLastnameClient);
            this.Controls.Add(this.txtAddressClient);
            this.Controls.Add(this.txtPhoneClient);
            this.Controls.Add(this.txtOrderClient);
            this.Controls.Add(this.txtNumberClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewClient";
            this.Text = "NewClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstnameClient;
        private System.Windows.Forms.TextBox txtLastnameClient;
        private System.Windows.Forms.TextBox txtAddressClient;
        private System.Windows.Forms.TextBox txtPhoneClient;
        private System.Windows.Forms.TextBox txtOrderClient;
        private System.Windows.Forms.TextBox txtNumberClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
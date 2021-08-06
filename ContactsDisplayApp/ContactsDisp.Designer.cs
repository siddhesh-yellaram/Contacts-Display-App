
namespace ContactsDisplayApp
{
    partial class ContactsDisp
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
            this.displayContactsBtn = new System.Windows.Forms.Button();
            this.displayAddressBtn = new System.Windows.Forms.Button();
            this.dispContacts = new System.Windows.Forms.DataGridView();
            this.dispAddress = new System.Windows.Forms.DataGridView();
            this.addUserContacts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getAddr = new System.Windows.Forms.TextBox();
            this.getNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getNameAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displayUserAddrBtn = new System.Windows.Forms.Button();
            this.showUserAddr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dispContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showUserAddr)).BeginInit();
            this.SuspendLayout();
            // 
            // displayContactsBtn
            // 
            this.displayContactsBtn.Location = new System.Drawing.Point(77, 77);
            this.displayContactsBtn.Name = "displayContactsBtn";
            this.displayContactsBtn.Size = new System.Drawing.Size(149, 34);
            this.displayContactsBtn.TabIndex = 0;
            this.displayContactsBtn.Text = "Display Contacts";
            this.displayContactsBtn.UseVisualStyleBackColor = true;
            this.displayContactsBtn.Click += new System.EventHandler(this.displayContactsBtn_Click);
            // 
            // displayAddressBtn
            // 
            this.displayAddressBtn.Location = new System.Drawing.Point(369, 80);
            this.displayAddressBtn.Name = "displayAddressBtn";
            this.displayAddressBtn.Size = new System.Drawing.Size(149, 31);
            this.displayAddressBtn.TabIndex = 1;
            this.displayAddressBtn.Text = "Display Addresses";
            this.displayAddressBtn.UseVisualStyleBackColor = true;
            this.displayAddressBtn.Click += new System.EventHandler(this.displayAddressBtn_Click);
            // 
            // dispContacts
            // 
            this.dispContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispContacts.Location = new System.Drawing.Point(12, 117);
            this.dispContacts.Name = "dispContacts";
            this.dispContacts.RowHeadersWidth = 51;
            this.dispContacts.RowTemplate.Height = 24;
            this.dispContacts.Size = new System.Drawing.Size(297, 359);
            this.dispContacts.TabIndex = 2;
            // 
            // dispAddress
            // 
            this.dispAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispAddress.Location = new System.Drawing.Point(315, 117);
            this.dispAddress.Name = "dispAddress";
            this.dispAddress.RowHeadersWidth = 51;
            this.dispAddress.RowTemplate.Height = 24;
            this.dispAddress.Size = new System.Drawing.Size(313, 359);
            this.dispAddress.TabIndex = 3;
            // 
            // addUserContacts
            // 
            this.addUserContacts.Location = new System.Drawing.Point(729, 12);
            this.addUserContacts.Name = "addUserContacts";
            this.addUserContacts.Size = new System.Drawing.Size(157, 31);
            this.addUserContacts.TabIndex = 4;
            this.addUserContacts.Text = "Add Contact";
            this.addUserContacts.UseVisualStyleBackColor = true;
            this.addUserContacts.Click += new System.EventHandler(this.addUserContacts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(155, 16);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(121, 22);
            this.getName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // getAddr
            // 
            this.getAddr.Location = new System.Drawing.Point(585, 16);
            this.getAddr.Name = "getAddr";
            this.getAddr.Size = new System.Drawing.Size(121, 22);
            this.getAddr.TabIndex = 8;
            // 
            // getNo
            // 
            this.getNo.Location = new System.Drawing.Point(378, 16);
            this.getNo.Name = "getNo";
            this.getNo.Size = new System.Drawing.Size(121, 22);
            this.getNo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            // 
            // getNameAddr
            // 
            this.getNameAddr.Location = new System.Drawing.Point(693, 84);
            this.getNameAddr.Name = "getNameAddr";
            this.getNameAddr.Size = new System.Drawing.Size(121, 22);
            this.getNameAddr.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // displayUserAddrBtn
            // 
            this.displayUserAddrBtn.Location = new System.Drawing.Point(841, 79);
            this.displayUserAddrBtn.Name = "displayUserAddrBtn";
            this.displayUserAddrBtn.Size = new System.Drawing.Size(119, 31);
            this.displayUserAddrBtn.TabIndex = 13;
            this.displayUserAddrBtn.Text = "Show Address";
            this.displayUserAddrBtn.UseVisualStyleBackColor = true;
            this.displayUserAddrBtn.Click += new System.EventHandler(this.displayUserAddrBtn_Click);
            // 
            // showUserAddr
            // 
            this.showUserAddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showUserAddr.Location = new System.Drawing.Point(634, 117);
            this.showUserAddr.Name = "showUserAddr";
            this.showUserAddr.RowHeadersWidth = 51;
            this.showUserAddr.RowTemplate.Height = 24;
            this.showUserAddr.Size = new System.Drawing.Size(334, 359);
            this.showUserAddr.TabIndex = 14;
            // 
            // ContactsDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 488);
            this.Controls.Add(this.showUserAddr);
            this.Controls.Add(this.displayUserAddrBtn);
            this.Controls.Add(this.getNameAddr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUserContacts);
            this.Controls.Add(this.dispAddress);
            this.Controls.Add(this.dispContacts);
            this.Controls.Add(this.displayAddressBtn);
            this.Controls.Add(this.displayContactsBtn);
            this.Name = "ContactsDisp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dispContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showUserAddr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayContactsBtn;
        private System.Windows.Forms.Button displayAddressBtn;
        private System.Windows.Forms.DataGridView dispContacts;
        private System.Windows.Forms.DataGridView dispAddress;
        private System.Windows.Forms.Button addUserContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getAddr;
        private System.Windows.Forms.TextBox getNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox getNameAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button displayUserAddrBtn;
        private System.Windows.Forms.DataGridView showUserAddr;
    }
}


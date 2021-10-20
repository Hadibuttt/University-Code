
namespace DesktopA
{
    partial class supplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.hg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.sGrid = new System.Windows.Forms.DataGridView();
            this.create = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Form";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(25, 103);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(32, 13);
            this.lab.TabIndex = 2;
            this.lab.Text = "CNIC";
            // 
            // hg
            // 
            this.hg.AutoSize = true;
            this.hg.Location = new System.Drawing.Point(25, 143);
            this.hg.Name = "hg";
            this.hg.Size = new System.Drawing.Size(38, 13);
            this.hg.TabIndex = 3;
            this.hg.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(72, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 6;
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(72, 100);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(100, 20);
            this.cnic.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(72, 140);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 8;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(304, 62);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(304, 100);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 10;
            // 
            // sGrid
            // 
            this.sGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sGrid.Location = new System.Drawing.Point(25, 216);
            this.sGrid.Name = "sGrid";
            this.sGrid.Size = new System.Drawing.Size(614, 150);
            this.sGrid.TabIndex = 11;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(564, 59);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(564, 103);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 13;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(666, 59);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(666, 103);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(564, 143);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Suppliers";
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.create);
            this.Controls.Add(this.sGrid);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hg);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "supplier";
            this.Text = "supplier";
            ((System.ComponentModel.ISupportInitialize)(this.sGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label hg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.DataGridView sGrid;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
    }
}
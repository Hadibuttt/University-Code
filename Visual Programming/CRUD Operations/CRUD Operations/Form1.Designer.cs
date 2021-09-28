
namespace CRUD_Operations
{
	partial class Form1
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtn = new System.Windows.Forms.TextBox();
			this.txte = new System.Windows.Forms.TextBox();
			this.create = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.Read = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email";
			// 
			// txtn
			// 
			this.txtn.Location = new System.Drawing.Point(115, 30);
			this.txtn.Name = "txtn";
			this.txtn.Size = new System.Drawing.Size(100, 20);
			this.txtn.TabIndex = 3;
			// 
			// txte
			// 
			this.txte.Location = new System.Drawing.Point(115, 72);
			this.txte.Name = "txte";
			this.txte.Size = new System.Drawing.Size(100, 20);
			this.txte.TabIndex = 4;
			// 
			// create
			// 
			this.create.Location = new System.Drawing.Point(254, 69);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(75, 23);
			this.create.TabIndex = 5;
			this.create.Text = "Create";
			this.create.UseVisualStyleBackColor = true;
			this.create.Click += new System.EventHandler(this.Create_Click);
			// 
			// Update
			// 
			this.Update.Location = new System.Drawing.Point(356, 70);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(75, 23);
			this.Update.TabIndex = 6;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// Read
			// 
			this.Read.Location = new System.Drawing.Point(254, 118);
			this.Read.Name = "Read";
			this.Read.Size = new System.Drawing.Size(75, 23);
			this.Read.TabIndex = 7;
			this.Read.Text = "Read";
			this.Read.UseVisualStyleBackColor = true;
			this.Read.Click += new System.EventHandler(this.Read_Click);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(356, 118);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 8;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Read);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.create);
			this.Controls.Add(this.txte);
			this.Controls.Add(this.txtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtn;
		private System.Windows.Forms.TextBox txte;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Read;
		private System.Windows.Forms.Button Delete;
	}
}


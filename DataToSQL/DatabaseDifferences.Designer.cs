namespace DisplayLayer
{
	partial class DataToSQL
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConnectionString1 = new System.Windows.Forms.TextBox();
			this.txtConnectionString2 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtSQLSelect = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnPreview = new System.Windows.Forms.Button();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtDataSQL = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSaveSQL = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.btnRunSQL = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "To";
			// 
			// txtConnectionString1
			// 
			this.txtConnectionString1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnectionString1.Location = new System.Drawing.Point(124, 13);
			this.txtConnectionString1.Name = "txtConnectionString1";
			this.txtConnectionString1.Size = new System.Drawing.Size(649, 20);
			this.txtConnectionString1.TabIndex = 2;
			this.txtConnectionString1.Text = "server=Prod_Server;user id=sa; pwd=!N0password; database=Signet";
			// 
			// txtConnectionString2
			// 
			this.txtConnectionString2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnectionString2.Location = new System.Drawing.Point(124, 39);
			this.txtConnectionString2.Name = "txtConnectionString2";
			this.txtConnectionString2.Size = new System.Drawing.Size(649, 20);
			this.txtConnectionString2.TabIndex = 3;
			this.txtConnectionString2.Text = "server=Prod_Server;user id=sa; pwd=!N0password; database=SignetDev";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGridView1.GridColor = System.Drawing.Color.Peru;
			this.dataGridView1.Location = new System.Drawing.Point(13, 212);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Size = new System.Drawing.Size(760, 175);
			this.dataGridView1.TabIndex = 7;
			// 
			// txtSQLSelect
			// 
			this.txtSQLSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSQLSelect.Location = new System.Drawing.Point(124, 65);
			this.txtSQLSelect.Multiline = true;
			this.txtSQLSelect.Name = "txtSQLSelect";
			this.txtSQLSelect.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSQLSelect.Size = new System.Drawing.Size(649, 99);
			this.txtSQLSelect.TabIndex = 9;
			this.txtSQLSelect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSQLSelect_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Select SQL";
			// 
			// btnPreview
			// 
			this.btnPreview.Location = new System.Drawing.Point(698, 170);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(75, 23);
			this.btnPreview.TabIndex = 10;
			this.btnPreview.Text = "Preview";
			this.btnPreview.UseVisualStyleBackColor = true;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(757, 195);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(13, 13);
			this.lblCount.TabIndex = 11;
			this.lblCount.Text = "0";
			// 
			// txtDataSQL
			// 
			this.txtDataSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDataSQL.Location = new System.Drawing.Point(124, 404);
			this.txtDataSQL.Multiline = true;
			this.txtDataSQL.Name = "txtDataSQL";
			this.txtDataSQL.ReadOnly = true;
			this.txtDataSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDataSQL.Size = new System.Drawing.Size(649, 99);
			this.txtDataSQL.TabIndex = 13;
			this.txtDataSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataSQL_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 407);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Data SQL";
			// 
			// btnSaveSQL
			// 
			this.btnSaveSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveSQL.Location = new System.Drawing.Point(698, 515);
			this.btnSaveSQL.Name = "btnSaveSQL";
			this.btnSaveSQL.Size = new System.Drawing.Size(75, 23);
			this.btnSaveSQL.TabIndex = 14;
			this.btnSaveSQL.Text = "Save SQL";
			this.btnSaveSQL.UseVisualStyleBackColor = true;
			this.btnSaveSQL.Click += new System.EventHandler(this.btnSaveSQL_Click);
			// 
			// btnRunSQL
			// 
			this.btnRunSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRunSQL.Location = new System.Drawing.Point(563, 515);
			this.btnRunSQL.Name = "btnRunSQL";
			this.btnRunSQL.Size = new System.Drawing.Size(129, 23);
			this.btnRunSQL.TabIndex = 15;
			this.btnRunSQL.Text = "Run SQL on \"To\"";
			this.btnRunSQL.UseVisualStyleBackColor = true;
			// 
			// DataToSQL
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(785, 550);
			this.Controls.Add(this.btnRunSQL);
			this.Controls.Add(this.btnSaveSQL);
			this.Controls.Add(this.txtDataSQL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.btnPreview);
			this.Controls.Add(this.txtSQLSelect);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtConnectionString2);
			this.Controls.Add(this.txtConnectionString1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(480, 333);
			this.Name = "DataToSQL";
			this.Text = "Data To SQL";
			this.Load += new System.EventHandler(this.DataDifferences_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtConnectionString1;
        private System.Windows.Forms.TextBox txtConnectionString2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSQLSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtDataSQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveSQL;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRunSQL;
	}
}


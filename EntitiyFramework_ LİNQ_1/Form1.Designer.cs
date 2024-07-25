
namespace EntitiyFramework__LİNQ_1
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgwResult = new System.Windows.Forms.DataGridView();
			this.btnWhere = new System.Windows.Forms.Button();
			this.btnOrderBy = new System.Windows.Forms.Button();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnTake = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnSingle = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.btnContains = new System.Windows.Forms.Button();
			this.btnVia = new System.Windows.Forms.Button();
			this.btnAny = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtKategori = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwResult
			// 
			this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwResult.Location = new System.Drawing.Point(66, 44);
			this.dgwResult.Name = "dgwResult";
			this.dgwResult.RowHeadersWidth = 51;
			this.dgwResult.RowTemplate.Height = 24;
			this.dgwResult.Size = new System.Drawing.Size(1336, 396);
			this.dgwResult.TabIndex = 0;
			// 
			// btnWhere
			// 
			this.btnWhere.Location = new System.Drawing.Point(66, 480);
			this.btnWhere.Name = "btnWhere";
			this.btnWhere.Size = new System.Drawing.Size(139, 67);
			this.btnWhere.TabIndex = 1;
			this.btnWhere.Text = "Where";
			this.btnWhere.UseVisualStyleBackColor = true;
			this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
			// 
			// btnOrderBy
			// 
			this.btnOrderBy.Location = new System.Drawing.Point(247, 480);
			this.btnOrderBy.Name = "btnOrderBy";
			this.btnOrderBy.Size = new System.Drawing.Size(139, 67);
			this.btnOrderBy.TabIndex = 2;
			this.btnOrderBy.Text = "Order By";
			this.btnOrderBy.UseVisualStyleBackColor = true;
			this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
			// 
			// btnSkip
			// 
			this.btnSkip.Location = new System.Drawing.Point(609, 480);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(139, 67);
			this.btnSkip.TabIndex = 3;
			this.btnSkip.Text = "Skip";
			this.btnSkip.UseVisualStyleBackColor = true;
			this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
			// 
			// btnTake
			// 
			this.btnTake.Location = new System.Drawing.Point(426, 480);
			this.btnTake.Name = "btnTake";
			this.btnTake.Size = new System.Drawing.Size(139, 67);
			this.btnTake.TabIndex = 4;
			this.btnTake.Text = "Take";
			this.btnTake.UseVisualStyleBackColor = true;
			this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(790, 480);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(139, 67);
			this.btnFind.TabIndex = 5;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnSingle
			// 
			this.btnSingle.Location = new System.Drawing.Point(956, 480);
			this.btnSingle.Name = "btnSingle";
			this.btnSingle.Size = new System.Drawing.Size(139, 67);
			this.btnSingle.TabIndex = 6;
			this.btnSingle.Text = "Single";
			this.btnSingle.UseVisualStyleBackColor = true;
			this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(1120, 480);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(139, 67);
			this.btnList.TabIndex = 7;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnContains
			// 
			this.btnContains.Location = new System.Drawing.Point(66, 573);
			this.btnContains.Name = "btnContains";
			this.btnContains.Size = new System.Drawing.Size(139, 67);
			this.btnContains.TabIndex = 8;
			this.btnContains.Text = "Contains";
			this.btnContains.UseVisualStyleBackColor = true;
			this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
			// 
			// btnVia
			// 
			this.btnVia.Location = new System.Drawing.Point(247, 573);
			this.btnVia.Name = "btnVia";
			this.btnVia.Size = new System.Drawing.Size(139, 67);
			this.btnVia.TabIndex = 9;
			this.btnVia.Text = "Via Category";
			this.btnVia.UseVisualStyleBackColor = true;
			this.btnVia.Click += new System.EventHandler(this.btnVia_Click);
			// 
			// btnAny
			// 
			this.btnAny.Location = new System.Drawing.Point(426, 573);
			this.btnAny.Name = "btnAny";
			this.btnAny.Size = new System.Drawing.Size(139, 67);
			this.btnAny.TabIndex = 10;
			this.btnAny.Text = "Any";
			this.btnAny.UseVisualStyleBackColor = true;
			this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(609, 573);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(139, 67);
			this.btnSelect.TabIndex = 11;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(1276, 480);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(126, 22);
			this.txtSearch.TabIndex = 12;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(1276, 524);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(126, 22);
			this.txtFirstName.TabIndex = 13;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(1276, 562);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(126, 22);
			this.txtLastName.TabIndex = 14;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(790, 573);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 22);
			this.txtID.TabIndex = 15;
			// 
			// txtKategori
			// 
			this.txtKategori.Location = new System.Drawing.Point(247, 657);
			this.txtKategori.Name = "txtKategori";
			this.txtKategori.Size = new System.Drawing.Size(100, 22);
			this.txtKategori.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1438, 713);
			this.Controls.Add(this.txtKategori);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnAny);
			this.Controls.Add(this.btnVia);
			this.Controls.Add(this.btnContains);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.btnSingle);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnTake);
			this.Controls.Add(this.btnSkip);
			this.Controls.Add(this.btnOrderBy);
			this.Controls.Add(this.btnWhere);
			this.Controls.Add(this.dgwResult);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwResult;
		private System.Windows.Forms.Button btnWhere;
		private System.Windows.Forms.Button btnOrderBy;
		private System.Windows.Forms.Button btnSkip;
		private System.Windows.Forms.Button btnTake;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnSingle;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnContains;
		private System.Windows.Forms.Button btnVia;
		private System.Windows.Forms.Button btnAny;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtKategori;
	}
}


namespace GetPokeAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(12, 38);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(97, 71);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "GET ALL";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(115, 68);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 41);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(372, 38);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 62);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 63);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(453, 38);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(75, 63);
            this.btnPut.TabIndex = 4;
            this.btnPut.Text = "PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 151);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(343, 262);
            this.txtResponse.TabIndex = 5;
            this.txtResponse.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 6;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(255, 78);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 23);
            this.txtJob.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(255, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(255, 63);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(28, 15);
            this.jobLabel.TabIndex = 10;
            this.jobLabel.Text = "Job:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(115, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(385, 151);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(362, 262);
            this.dataGrid.TabIndex = 12;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(591, 419);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(672, 419);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGetAll);
            this.Name = "Form1";
            this.Text = "Info System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetAll;
        private Button btnGet;
        private Button btnPost;
        private Button btnDelete;
        private Button btnPut;
        private RichTextBox txtResponse;
        private TextBox txtID;
        private TextBox txtJob;
        private TextBox txtName;
        private Label nameLabel;
        private Label jobLabel;
        private Label idLabel;
        private DataGridView dataGrid;
        private Button btnShow;
        private Button btnDownload;
    }
}
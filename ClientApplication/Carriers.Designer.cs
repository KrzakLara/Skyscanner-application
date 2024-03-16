namespace ClientApplication
{
    partial class Carriers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carriers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.gbConverter = new System.Windows.Forms.GroupBox();
            this.rbRNG = new System.Windows.Forms.RadioButton();
            this.rbXSD = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIATA = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbRest = new System.Windows.Forms.GroupBox();
            this.lbCarriers = new System.Windows.Forms.ListBox();
            this.gbSOAP = new System.Windows.Forms.GroupBox();
            this.lbSearched = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGetApi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbNode = new System.Windows.Forms.ComboBox();
            this.lbSorter = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearchedValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbConverter.SuspendLayout();
            this.gbRest.SuspendLayout();
            this.gbSOAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbName.Location = new System.Drawing.Point(275, 34);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbCountry.Location = new System.Drawing.Point(522, 34);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(49, 20);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "IATA:";
            // 
            // gbConverter
            // 
            this.gbConverter.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbConverter.Controls.Add(this.rbRNG);
            this.gbConverter.Controls.Add(this.rbXSD);
            this.gbConverter.Location = new System.Drawing.Point(923, 14);
            this.gbConverter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConverter.Name = "gbConverter";
            this.gbConverter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConverter.Size = new System.Drawing.Size(300, 154);
            this.gbConverter.TabIndex = 5;
            this.gbConverter.TabStop = false;
            this.gbConverter.Text = "Choose XSD or RGN:";
            // 
            // rbRNG
            // 
            this.rbRNG.AutoSize = true;
            this.rbRNG.Location = new System.Drawing.Point(172, 65);
            this.rbRNG.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbRNG.Name = "rbRNG";
            this.rbRNG.Size = new System.Drawing.Size(70, 24);
            this.rbRNG.TabIndex = 7;
            this.rbRNG.Text = "RNG";
            this.rbRNG.UseVisualStyleBackColor = true;
            // 
            // rbXSD
            // 
            this.rbXSD.AutoSize = true;
            this.rbXSD.Checked = true;
            this.rbXSD.Location = new System.Drawing.Point(34, 65);
            this.rbXSD.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbXSD.Name = "rbXSD";
            this.rbXSD.Size = new System.Drawing.Size(68, 24);
            this.rbXSD.TabIndex = 6;
            this.rbXSD.TabStop = true;
            this.rbXSD.Text = "XSD";
            this.rbXSD.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 32);
            this.txtName.TabIndex = 6;
            // 
            // txtIATA
            // 
            this.txtIATA.Location = new System.Drawing.Point(516, 75);
            this.txtIATA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIATA.Multiline = true;
            this.txtIATA.Name = "txtIATA";
            this.txtIATA.Size = new System.Drawing.Size(148, 32);
            this.txtIATA.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAdd.Location = new System.Drawing.Point(938, 182);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Add_ClickAsync);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnReset.Location = new System.Drawing.Point(1091, 183);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbRest
            // 
            this.gbRest.Controls.Add(this.lbCarriers);
            this.gbRest.Location = new System.Drawing.Point(28, 183);
            this.gbRest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRest.Name = "gbRest";
            this.gbRest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRest.Size = new System.Drawing.Size(444, 395);
            this.gbRest.TabIndex = 12;
            this.gbRest.TabStop = false;
            this.gbRest.Text = "Rest";
            // 
            // lbCarriers
            // 
            this.lbCarriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCarriers.ForeColor = System.Drawing.Color.Black;
            this.lbCarriers.FormattingEnabled = true;
            this.lbCarriers.ItemHeight = 22;
            this.lbCarriers.Location = new System.Drawing.Point(10, 31);
            this.lbCarriers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lbCarriers.Name = "lbCarriers";
            this.lbCarriers.Size = new System.Drawing.Size(412, 334);
            this.lbCarriers.TabIndex = 3;
            // 
            // gbSOAP
            // 
            this.gbSOAP.Controls.Add(this.lbSearched);
            this.gbSOAP.Location = new System.Drawing.Point(500, 183);
            this.gbSOAP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSOAP.Name = "gbSOAP";
            this.gbSOAP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSOAP.Size = new System.Drawing.Size(377, 395);
            this.gbSOAP.TabIndex = 13;
            this.gbSOAP.TabStop = false;
            this.gbSOAP.Text = "SOAP";
            // 
            // lbSearched
            // 
            this.lbSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSearched.ForeColor = System.Drawing.Color.Black;
            this.lbSearched.FormattingEnabled = true;
            this.lbSearched.ItemHeight = 22;
            this.lbSearched.Location = new System.Drawing.Point(0, 39);
            this.lbSearched.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lbSearched.Name = "lbSearched";
            this.lbSearched.Size = new System.Drawing.Size(360, 334);
            this.lbSearched.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(1050, 278);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 16;
            // 
            // btnGetApi
            // 
            this.btnGetApi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGetApi.Location = new System.Drawing.Point(938, 227);
            this.btnGetApi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetApi.Name = "btnGetApi";
            this.btnGetApi.Size = new System.Drawing.Size(112, 35);
            this.btnGetApi.TabIndex = 17;
            this.btnGetApi.Text = "GetApi";
            this.btnGetApi.UseVisualStyleBackColor = false;
            this.btnGetApi.Click += new System.EventHandler(this.btnGetApi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSearch.Location = new System.Drawing.Point(718, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(940, 352);
            this.lblSearchInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(0, 20);
            this.lblSearchInfo.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnExit.Location = new System.Drawing.Point(1017, 439);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbNode
            // 
            this.cbNode.FormattingEnabled = true;
            this.cbNode.Location = new System.Drawing.Point(38, 140);
            this.cbNode.Name = "cbNode";
            this.cbNode.Size = new System.Drawing.Size(121, 28);
            this.cbNode.TabIndex = 22;
            this.cbNode.SelectedIndexChanged += new System.EventHandler(this.cbNode_SelectedIndexChanged);
            // 
            // lbSorter
            // 
            this.lbSorter.AutoSize = true;
            this.lbSorter.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbSorter.Location = new System.Drawing.Point(38, 114);
            this.lbSorter.Name = "lbSorter";
            this.lbSorter.Size = new System.Drawing.Size(104, 20);
            this.lbSorter.TabIndex = 23;
            this.lbSorter.Text = "Sort RestApi:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbSearch.Location = new System.Drawing.Point(725, 34);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(64, 20);
            this.lbSearch.TabIndex = 24;
            this.lbSearch.Text = "Search:";
            // 
            // txtSearchedValue
            // 
            this.txtSearchedValue.Location = new System.Drawing.Point(718, 75);
            this.txtSearchedValue.Name = "txtSearchedValue";
            this.txtSearchedValue.Size = new System.Drawing.Size(131, 26);
            this.txtSearchedValue.TabIndex = 25;
            // 
            // Carriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1363, 622);
            this.Controls.Add(this.txtSearchedValue);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbSorter);
            this.Controls.Add(this.cbNode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGetApi);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbSOAP);
            this.Controls.Add(this.gbRest);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIATA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbConverter);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Carriers";
            this.Text = "Skyscanner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbConverter.ResumeLayout(false);
            this.gbConverter.PerformLayout();
            this.gbRest.ResumeLayout(false);
            this.gbSOAP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.GroupBox gbConverter;
        private System.Windows.Forms.RadioButton rbRNG;
        private System.Windows.Forms.RadioButton rbXSD;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIATA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbRest;
        private System.Windows.Forms.GroupBox gbSOAP;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lbCarriers;
        private System.Windows.Forms.Button btnGetApi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbSearched;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbNode;
        private System.Windows.Forms.Label lbSorter;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchedValue;
    }
}


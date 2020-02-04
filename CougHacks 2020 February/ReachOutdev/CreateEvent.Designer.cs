namespace CougHacks_2020_February
{
    partial class CreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvent));
            this.createTextboxEventName = new System.Windows.Forms.TextBox();
            this.createTextboxDesc = new System.Windows.Forms.TextBox();
            this.createLabelEventName = new System.Windows.Forms.Label();
            this.createLabelDesc = new System.Windows.Forms.Label();
            this.createComboMonth = new System.Windows.Forms.ComboBox();
            this.createComboDay = new System.Windows.Forms.ComboBox();
            this.createComboYear = new System.Windows.Forms.ComboBox();
            this.createLabelDate = new System.Windows.Forms.Label();
            this.createButtonCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTextboxEventName
            // 
            this.createTextboxEventName.Location = new System.Drawing.Point(45, 85);
            this.createTextboxEventName.Multiline = true;
            this.createTextboxEventName.Name = "createTextboxEventName";
            this.createTextboxEventName.Size = new System.Drawing.Size(545, 103);
            this.createTextboxEventName.TabIndex = 0;
            // 
            // createTextboxDesc
            // 
            this.createTextboxDesc.Location = new System.Drawing.Point(45, 417);
            this.createTextboxDesc.Multiline = true;
            this.createTextboxDesc.Name = "createTextboxDesc";
            this.createTextboxDesc.Size = new System.Drawing.Size(545, 326);
            this.createTextboxDesc.TabIndex = 1;
            // 
            // createLabelEventName
            // 
            this.createLabelEventName.AutoSize = true;
            this.createLabelEventName.BackColor = System.Drawing.Color.Transparent;
            this.createLabelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabelEventName.ForeColor = System.Drawing.Color.LightCyan;
            this.createLabelEventName.Location = new System.Drawing.Point(35, 27);
            this.createLabelEventName.Name = "createLabelEventName";
            this.createLabelEventName.Size = new System.Drawing.Size(299, 55);
            this.createLabelEventName.TabIndex = 2;
            this.createLabelEventName.Text = "Event Name";
            this.createLabelEventName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createLabelDesc
            // 
            this.createLabelDesc.AutoSize = true;
            this.createLabelDesc.BackColor = System.Drawing.Color.Transparent;
            this.createLabelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabelDesc.ForeColor = System.Drawing.Color.LightCyan;
            this.createLabelDesc.Location = new System.Drawing.Point(35, 359);
            this.createLabelDesc.Name = "createLabelDesc";
            this.createLabelDesc.Size = new System.Drawing.Size(275, 55);
            this.createLabelDesc.TabIndex = 3;
            this.createLabelDesc.Text = "Description";
            this.createLabelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createComboMonth
            // 
            this.createComboMonth.FormattingEnabled = true;
            this.createComboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.createComboMonth.Location = new System.Drawing.Point(44, 298);
            this.createComboMonth.Name = "createComboMonth";
            this.createComboMonth.Size = new System.Drawing.Size(148, 33);
            this.createComboMonth.TabIndex = 4;
            // 
            // createComboDay
            // 
            this.createComboDay.FormattingEnabled = true;
            this.createComboDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.createComboDay.Location = new System.Drawing.Point(242, 298);
            this.createComboDay.Name = "createComboDay";
            this.createComboDay.Size = new System.Drawing.Size(148, 33);
            this.createComboDay.TabIndex = 5;
            // 
            // createComboYear
            // 
            this.createComboYear.FormattingEnabled = true;
            this.createComboYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.createComboYear.Location = new System.Drawing.Point(442, 298);
            this.createComboYear.Name = "createComboYear";
            this.createComboYear.Size = new System.Drawing.Size(148, 33);
            this.createComboYear.TabIndex = 6;
            // 
            // createLabelDate
            // 
            this.createLabelDate.AutoSize = true;
            this.createLabelDate.BackColor = System.Drawing.Color.Transparent;
            this.createLabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabelDate.ForeColor = System.Drawing.Color.LightCyan;
            this.createLabelDate.Location = new System.Drawing.Point(35, 225);
            this.createLabelDate.Name = "createLabelDate";
            this.createLabelDate.Size = new System.Drawing.Size(314, 55);
            this.createLabelDate.TabIndex = 7;
            this.createLabelDate.Text = "Date (m/d/y):";
            this.createLabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createButtonCont
            // 
            this.createButtonCont.Location = new System.Drawing.Point(208, 798);
            this.createButtonCont.Name = "createButtonCont";
            this.createButtonCont.Size = new System.Drawing.Size(215, 56);
            this.createButtonCont.TabIndex = 8;
            this.createButtonCont.Text = "Continue";
            this.createButtonCont.UseVisualStyleBackColor = true;
            this.createButtonCont.Click += new System.EventHandler(this.createButtonCont_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 895);
            this.Controls.Add(this.createButtonCont);
            this.Controls.Add(this.createLabelDate);
            this.Controls.Add(this.createComboYear);
            this.Controls.Add(this.createComboDay);
            this.Controls.Add(this.createComboMonth);
            this.Controls.Add(this.createLabelDesc);
            this.Controls.Add(this.createLabelEventName);
            this.Controls.Add(this.createTextboxDesc);
            this.Controls.Add(this.createTextboxEventName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 966);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 966);
            this.Name = "CreateEvent";
            this.ShowIcon = false;
            this.Text = "CreateEvent";
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createTextboxEventName;
        private System.Windows.Forms.TextBox createTextboxDesc;
        private System.Windows.Forms.Label createLabelEventName;
        private System.Windows.Forms.Label createLabelDesc;
        private System.Windows.Forms.ComboBox createComboMonth;
        private System.Windows.Forms.ComboBox createComboDay;
        private System.Windows.Forms.ComboBox createComboYear;
        private System.Windows.Forms.Label createLabelDate;
        private System.Windows.Forms.Button createButtonCont;
    }
}
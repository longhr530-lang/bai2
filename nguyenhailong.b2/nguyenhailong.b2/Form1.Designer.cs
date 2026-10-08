namespace nguyenhailong.b2
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
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private void InitializeComponent()
        {
            lblTicketId = new Label();
            txtTicketId = new TextBox();
            lblRequester = new Label();
            txtRequester = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            grpPriority = new GroupBox();
            rbHigh = new RadioButton();
            rbNormal = new RadioButton();
            rbLow = new RadioButton();
            lblType = new Label();
            cbType = new ComboBox();
            grpDevices = new GroupBox();
            chkPhone = new CheckBox();
            chkPrinter = new CheckBox();
            chkLaptop = new CheckBox();
            chkDesktop = new CheckBox();
            pictureBox = new PictureBox();
            btnLoadImage = new Button();
            btnSubmit = new Button();
            btnReset = new Button();
            openFileDialog1 = new OpenFileDialog();
            grpPriority.SuspendLayout();
            grpDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(12, 15);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(57, 15);
            lblTicketId.TabIndex = 0;
            lblTicketId.Text = "Mã phiếu";
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(120, 12);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(200, 23);
            txtTicketId.TabIndex = 1;
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Location = new Point(12, 50);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(84, 15);
            lblRequester.TabIndex = 2;
            lblRequester.Text = "Người yêu cầu";
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(120, 47);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(200, 23);
            txtRequester.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 85);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(85, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Ngày ghi nhận";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(120, 79);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // grpPriority
            // 
            grpPriority.Controls.Add(rbHigh);
            grpPriority.Controls.Add(rbNormal);
            grpPriority.Controls.Add(rbLow);
            grpPriority.Location = new Point(12, 115);
            grpPriority.Name = "grpPriority";
            grpPriority.Size = new Size(308, 55);
            grpPriority.TabIndex = 6;
            grpPriority.TabStop = false;
            grpPriority.Text = "Mức độ ưu tiên";
            // 
            // rbHigh
            // 
            rbHigh.AutoSize = true;
            rbHigh.Location = new Point(208, 22);
            rbHigh.Name = "rbHigh";
            rbHigh.Size = new Size(74, 19);
            rbHigh.TabIndex = 2;
            rbHigh.Text = "Khẩn cấp";
            rbHigh.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(106, 22);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(83, 19);
            rbNormal.TabIndex = 1;
            rbNormal.Text = "Trung bình";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbLow
            // 
            rbLow.AutoSize = true;
            rbLow.Location = new Point(6, 22);
            rbLow.Name = "rbLow";
            rbLow.Size = new Size(52, 19);
            rbLow.TabIndex = 0;
            rbLow.Text = "Thấp";
            rbLow.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 185);
            lblType.Name = "lblType";
            lblType.Size = new Size(60, 15);
            lblType.TabIndex = 7;
            lblType.Text = "Loại sự cố";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cbType.Location = new Point(120, 182);
            cbType.Name = "cbType";
            cbType.Size = new Size(200, 23);
            cbType.TabIndex = 8;
            // 
            // grpDevices
            // 
            grpDevices.Controls.Add(chkPhone);
            grpDevices.Controls.Add(chkPrinter);
            grpDevices.Controls.Add(chkLaptop);
            grpDevices.Controls.Add(chkDesktop);
            grpDevices.Location = new Point(12, 220);
            grpDevices.Name = "grpDevices";
            grpDevices.Size = new Size(308, 95);
            grpDevices.TabIndex = 9;
            grpDevices.TabStop = false;
            grpDevices.Text = "Thiết bị ảnh hưởng";
            // 
            // chkPhone
            // 
            chkPhone.AutoSize = true;
            chkPhone.Location = new Point(6, 64);
            chkPhone.Name = "chkPhone";
            chkPhone.Size = new Size(80, 19);
            chkPhone.TabIndex = 3;
            chkPhone.Text = "Điện thoại";
            chkPhone.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            chkPrinter.AutoSize = true;
            chkPrinter.Location = new Point(106, 39);
            chkPrinter.Name = "chkPrinter";
            chkPrinter.Size = new Size(62, 19);
            chkPrinter.TabIndex = 2;
            chkPrinter.Text = "Máy in";
            chkPrinter.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(6, 39);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(63, 19);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkDesktop
            // 
            chkDesktop.AutoSize = true;
            chkDesktop.Location = new Point(106, 16);
            chkDesktop.Name = "chkDesktop";
            chkDesktop.Size = new Size(96, 19);
            chkDesktop.TabIndex = 0;
            chkDesktop.Text = "Máy tính bàn";
            chkDesktop.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(350, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(420, 280);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 10;
            pictureBox.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(350, 305);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(120, 30);
            btnLoadImage.TabIndex = 11;
            btnLoadImage.Text = "Tải ảnh lỗi";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(350, 352);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 35);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Gửi yêu cầu";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(500, 352);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 35);
            btnReset.TabIndex = 13;
            btnReset.Text = "Nhập lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(btnLoadImage);
            Controls.Add(pictureBox);
            Controls.Add(grpDevices);
            Controls.Add(cbType);
            Controls.Add(lblType);
            Controls.Add(grpPriority);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtRequester);
            Controls.Add(lblRequester);
            Controls.Add(txtTicketId);
            Controls.Add(lblTicketId);
            Name = "Form1";
            Text = "Form Tiếp nhận & Phân loại sự cố IT";
            grpPriority.ResumeLayout(false);
            grpPriority.PerformLayout();
            grpDevices.ResumeLayout(false);
            grpDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

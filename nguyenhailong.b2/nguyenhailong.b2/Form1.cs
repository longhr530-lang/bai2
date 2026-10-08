using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace nguyenhailong.b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set Vietnamese culture for date display
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            // Set defaults
            rbLow.Checked = true;
            if (cbType.Items.Count > 0) cbType.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var path = openFileDialog1.FileName;
                    using (var fs = File.OpenRead(path))
                    {
                        var img = Image.FromStream(fs);
                        // clone to avoid locking the file
                        pictureBox.Image = new Bitmap(img);
                        img.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var id = txtTicketId.Text.Trim();
            var requester = txtRequester.Text.Trim();
            var date = dtpDate.Value.ToString("dd/MM/yyyy");
            string priority = rbHigh.Checked ? "Khẩn cấp" : rbNormal.Checked ? "Trung bình" : "Thấp";
            var type = cbType.SelectedItem != null ? cbType.SelectedItem.ToString() : "(Chưa chọn)";

            var devices = new System.Collections.Generic.List<string>();
            if (chkDesktop.Checked) devices.Add("Máy tính bàn");
            if (chkLaptop.Checked) devices.Add("Laptop");
            if (chkPrinter.Checked) devices.Add("Máy in");
            if (chkPhone.Checked) devices.Add("Điện thoại");
            var devicesText = devices.Count > 0 ? string.Join(", ", devices) : "Không có";

            var hasImage = pictureBox.Image != null ? "Có" : "Không";

            var summary =
                $"--- Tóm tắt yêu cầu ---\n" +
                $"Mã phiếu: {id}\n" +
                $"Người yêu cầu: {requester}\n" +
                $"Ngày ghi nhận: {date}\n" +
                $"Mức độ ưu tiên: {priority}\n" +
                $"Loại sự cố: {type}\n" +
                $"Thiết bị ảnh hưởng: {devicesText}\n" +
                $"Ảnh lỗi: {hasImage}";

            MessageBox.Show(summary, "Yêu cầu hỗ trợ IT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Text = string.Empty;
            txtRequester.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            rbLow.Checked = true;
            cbType.SelectedIndex = cbType.Items.Count > 0 ? 0 : -1;
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;
            if (pictureBox.Image != null)
            {
                var img = pictureBox.Image;
                pictureBox.Image = null;
                img.Dispose();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab06
{
    public partial class frmXuat : Form
    {
        // Automatic Property: giữ số dòng, số cột
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        // Field: kích thước button và mức canh lề
        int h = 35, margin = 5;

        // Constructor không tham số để trình thiết kế (Designer) của Visual Studio vẫn mở được form
        public frmXuat() : this(1, 1)
        {
        }

        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent(); // khởi tạo Form & control

            // Gán số dòng, số cột
            this.SoDong = dong;
            this.SoCot = cot;

            // Thêm các control vào form
            Button btn = null;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    btn = new Button();
                    btn.Width = h; btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;

                    // gắn sự kiện cho button
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);

                    this.Controls.Add(btn);
                }
            }

            // chỉnh lại kích thước form
            this.ClientSize = new Size(SoCot * (h + margin + 1), SoDong * (h + margin + 1));
        }

        private void HoChuotLenButton(object sender, EventArgs e)
        {
            this.Text = (sender as Button).Tag.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }
    }
}

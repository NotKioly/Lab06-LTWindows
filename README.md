1 Mục tiêu 
 Làm việc với mảng 
 Truyền dữ liệu giữa các form 
2 Thực hiện 
2.1 Tạo form nhập liệu (frmNhapLieu) 
 
2.2 Tạo form xuất mảng (frmXuat) 
2.3 Viết code cho form frmXuat 
Để nhận giá trị số dòng, số cột cần 2 Property để giữ giá trị nó. Ngoài ra, có thể dùng các 
tham số (dạng Field) để lưu khoảng cách kích thước, mức canh lề, …
2.4 Xử lý nút khởi tạo ở form khởi tạo 
        private void btnKhoiTao_Click(object sender, EventArgs e) 
        { 
            int sodong, socot; 
            if (!int.TryParse(txtSoDong.Text, out sodong)) 
                sodong = 1; 
            if (!int.TryParse(txtSoCot.Text, out socot)) 
                socot = 1; 
            frmXuat frmX = new frmXuat(sodong, socot); 
            //canh giữa 
            frmX.StartPosition = FormStartPosition.CenterScreen; 
            frmX.ShowDialog();//hiện 
        } 

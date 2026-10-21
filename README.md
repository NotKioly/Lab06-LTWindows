# Lab 06 – Làm việc với mảng & truyền dữ liệu giữa các form

Bài thực hành môn **Windows Programming with C#** (Lab 06, Ths. Lương Trần Hy Hiến – Khoa CNTT, ĐH Sư phạm TP.HCM).

## Mục tiêu

- Làm việc với mảng (lưới nút theo số dòng × số cột).
- Truyền dữ liệu giữa các form (từ form nhập liệu sang form xuất).

## Mô tả chương trình

Chương trình gồm hai form:

| Form | Vai trò |
|------|---------|
| `frmNhapLieu` | Form "Nhập liệu": người dùng nhập **số dòng** và **số cột**, bấm **Khởi tạo form**. |
| `frmXuat` | Form xuất: sinh ra lưới nút bấm đánh số từ 1 đến `số dòng × số cột`. |

### Luồng hoạt động

1. Người dùng nhập số dòng vào `txtSoDong`, số cột vào `txtSoCot`.
2. Bấm `btnKhoiTao` → `btnKhoiTao_Click` đọc hai giá trị bằng `int.TryParse`
   (nhập sai, để trống hoặc nhỏ hơn 1 thì lấy giá trị mặc định là **1**).
3. Tạo `new frmXuat(sodong, socot)` – dữ liệu được truyền sang form xuất qua **constructor**
   và được lưu vào hai Automatic Property `SoDong`, `SoCot`.
4. `frmXuat` dùng hai vòng `for` lồng nhau để tạo các `Button`:
   - Số thứ tự của nút: `i * SoCot + j + 1`
   - Vị trí: `Left = margin * (j + 1) + h * j`, `Top = margin * (i + 1) + h * i`
   - Kích thước nút `h = 35`, khoảng cách `margin = 5` (hai Field của form).
5. Sau khi thêm xong, form tự chỉnh `ClientSize` cho vừa khít lưới nút.
6. `frmXuat` được hiện ở giữa màn hình bằng `ShowDialog()`.

### Tương tác trên form xuất

- **Click** vào một nút → hiện `MessageBox` chứa số của nút đó.
- **Rê chuột** lên một nút → tiêu đề form đổi thành `Dòng i cột j` (lấy từ thuộc tính `Tag` của nút, i và j tính từ 0).

### Ví dụ

Nhập **Số dòng = 3**, **Số cột = 4** → form xuất hiện 12 nút:

```
 1   2   3   4
 5   6   7   8
 9  10  11  12
```

## Cấu trúc thư mục

```
Lab06/
├── Lab06.csproj              # file project (SDK-style, net8.0-windows)
├── Program.cs                # điểm vào, chạy frmNhapLieu
├── frmNhapLieu.cs            # xử lý nút Khởi tạo (mục 2.4)
├── frmNhapLieu.Designer.cs   # giao diện form nhập liệu (mục 2.1)
├── frmXuat.cs                # property, field, tạo lưới nút, sự kiện (mục 2.3)
├── frmXuat.Designer.cs       # giao diện form xuất (mục 2.2)
└── README.md
```

## Yêu cầu

- Windows 10/11
- Visual Studio 2022 (workload **.NET desktop development**) hoặc **.NET 8 SDK**

## Cách chạy

**Cách 1 – Visual Studio:** mở file `Lab06.csproj` → nhấn **F5**.

**Cách 2 – dòng lệnh:** mở terminal tại thư mục `Lab06` rồi chạy:

```
dotnet run
```

**Dùng Visual Studio 2013 như đề gốc:** tạo mới một *Windows Forms Application* tên `Lab06`,
xóa `Form1`, rồi thêm (Add → Existing Item) các file `.cs` ở trên vào project
(không cần `Lab06.csproj`).

## Ghi chú: điểm khác với đề

- Thêm constructor không tham số `frmXuat()` (gọi `this(1, 1)`) để trình thiết kế của Visual Studio
  mở được form, vì Designer không chấp nhận constructor chỉ có tham số mặc định.
- Giá trị số dòng/số cột **nhỏ hơn 1** cũng được đổi thành 1 (đề chỉ xử lý trường hợp không parse được).
- Dùng `namespace Lab06` và `using` khai báo đầy đủ cho từng file.

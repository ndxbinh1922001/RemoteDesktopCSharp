# RemoteDesktopCSharp

## Đồ án cuối kỳ

***Đề tài: Chương trình điều khiển máy tính từ xa***

Nhóm 3

Thành viên nhóm:
* Lê Hồng Bằng - 19520396
* Nguyễn Đoàn Xuân Bình - 19521265
* Trần Hoàng Khang - 19521671

Môn: Lập trình mạng căn bản - NT106.L21.ANTN

### Mô hình

![image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/paradigm.png)

> Máy Server sẽ là máy tính điều khiển \
> Máy Client sẽ là máy tính bị điều khiển

***Các tính năng được chương trình cung cấp:***
* Cung cấp chức năng đăng nhập/đăng ký để sử dụng chương trình.
* Sử dụng database để lưu trữ tài khoản người dùng. 
* Cung cấp khả năng điều khiển một số hoạt động của một máy tính khác từ xa như (Sleep, Restart, Shutdown).
* Cung cấp thêm chức năng điều khiển máy tính khác bằng commandline với `cmd` .
* Máy server có thêm chức năng xem được màn hình của máy tính client.
* Có tính năng chat trao đổi thông tin giữa máy client và máy server.
* Hỗi trợ bảo mật dữ liệu khi trao đổi bằng AES.
* Cung cấp khả năng điều khiển nhiều máy tính cùng lúc (multiclient).

### Mô tả chi tiết

1. Tổng quát:

Ngôn ngữ sử dụng : C# 


### Hướng dẫn sử dụng

1. Đăng nhập/Đăng ký tài khoản

![image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/Sign.png)

> Sử dụng tài khoản đã có hoặc tạo mới tài khoản để sử dụng chương trình (cả bên client và server)

Giao diện sau khi đăng nhập của Client:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/client.png)

Giao diện sau khi đăng nhập của Server:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/server.png)


2. Kết nối hai máy tính

* Step 1: Nhập vào **port** bên phía server và click `Listen` để lắng nghe kết nối từ client. 

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/connect_server_ex.png)

* Step 2: Nhập vào **port** bên client (chú ý là giống bên phía server), và địa chỉ IP của máy server. 

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/connect_client_ex.png)

* Step 3: Nhấn connect bên phía client để hoàn thành kết nối

Giao diện sau khi hoàn tất kết nối bên phía server:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/connect_server_finish.png)

Giao diện sau khi hoàn tất kết nối bên phía client:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/connect_client_ex.png)

3. Sử dụng các tính năng trong chương trình

***Xem màn hình***

Nhấn `Screen` bên phía client để cho phép server có thể thấy được màn hình của client.

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/show_screen.png)

***Chức năng `Sleep`, `Restart`, `Shutdown`*** được sử dụng khi clink các button tương ứng bên phía server.

***Nhấn `Chat` bên phía server sau đó là nhấn `Chat` bên client để sử dụng chức năng chat và điều khiển máy bằng `cmd`***

Khung chat bên phía server:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/chat.png)

Khung chat bên phía client:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/chat_client.png)

> Nhập thông điệp và gửi qua lại bình thường giữa client và server 

> Sử dụng cú pháp: `cmd>>commandline` bên phía server  để sử dụng cmd bên client.

Example:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/cmd.png)

Kết quả thông tin lệnh cmd được trả về server:

![Image](https://github.com/Saluu10/Do_an_CK/blob/main/Image/cmd_result.png)

4. Điều khiển nhiều máy tính cùng lúc

### Demo via LAN

[Link demo]()

### Phân chia công việc

### Tổng kết


Tiêu chi | Mô tả |Điểm tối đa|Hoàn thành
---------|-------|---------------------|--------------|
Socket logic cơ bản |Đã mô tả ở phần trên| 3 | &#9745;
App logic + Socket logic nâng cao| Đã mô tả ở phần trên| 4 | &#9745;
I/O (File and Network)| Làm việc với các luồng nhập xuất| 0.5| &#9745;
Database| Kết nối làm việc với database| 0.5 |&#9745;
Thread| Áp dụng đa luồng| 0.5 |&#9745;
Sign up và Sign in| Đăng lý, đăng nhập, lưu trữ trạng thái |0.5 |&#9745;
Multiclient|Có nhiều client hoạt động trong mô hình |0.5|&#9745;
Multisever|Có nhiều server hoạt động trong mô hình |0.5|&#9744;
Cryptography| Mã hõa dữ liệu để bảo mật thông tin |0.5|&#9745;
Demo via LAN|Demo sử dụng mạng LAN |0.5|&#9745;
Demo via Internet|Demo sử dụng mạng Internet|0.5|&#9744;
Load Blancing|Phân chi công việc hợp lý cho các server |1|&#9744;



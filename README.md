"# NetCoreAPI" 
1.tìm hiểu cấu trúc trong.NET MVC
gồm 3 phần model(dữ liệu) , view(giao diện ) ,controller(điều khiển)
user sẽ gửi yêu cầu ( truy cập 1 url trên trình duyệt) =)) controller xử lý ( nhận yêu cầu và tương tác với model) = )) model truy xuất dữ liệu ( truy xuất dữ liệu từ database hoặc nguồn khác ) =))controller chọn view ( controller lấy dữ liệu từ model và chuyển đến view ) =)) view ( sử dụng dữ liệu từ model để tạo ra html và gửi về cho người dùng)
program.cs : điểm khởi đầu của ứng dụng và cấu hình máy chủ web
appsettings.json: lưu trữ cấu hình ứng dụng , chuỗi kết nối cơ sở dữ liệu
launchSetiing.json: cấu hình môi trường chạy 
2. tìm hiểu về định tuyeedn (route) trong .Net MVC
là cơ chế ánh xạ url yêu cầu đến từ trình duyệt tới 1 controller vaqf action cụ thể trong ứng dụng hđ như 1 hệ thống so khớp mẫu để xử lý request
cơ chế hoạt động : 
khi có 1 yêu cầu http đến , bộ định tuyến sẽ kiểm tra bảng route =)) khớp mẫu url đến với cái mẫu route được định nghĩa = )) nếu khớp thì xác định controller action tương ứng , trích xuất tham số và chuyển yêu cầu đến action đó
3.Tìm hiểu về Controller, View trong .Net MVC
*Controller
vai trò nhận http request từ trình duyệt xử lý logic gọi Model và chọn view để hiển thị
đặc điểm phải kế thừa lớp controller hoặc controllerBase trong Core
*view
chức năng hiển thị giao diện nhận dư liệu từ controller 
view nhận dữ liệu từ controller thông qua model 



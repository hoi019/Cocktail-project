// Khởi tạo các biến
let user = "";
let password = "";
const url = "https://localhost:44390"; // Thay URL_CUA_BAN bằng URL của API của bạn

// Lấy đối tượng lịch sử (history)
const history = window.history;

// Xử lý kiểm tra nếu có thông tin người dùng trong localStorage
if (localStorage.getItem("user-info")) {
  history.pushState("/add");
}

// Định nghĩa hàm login
async function login() {
  console.warn(user, password);
  const item = { user, password };
  
  try {
    let result = await fetch(url + "/api/Account/login", {
      method: 'POST',
      headers: {
        "Content-Type": "application/json",
        "Accept": 'application/json'
      },
      body: JSON.stringify(item) // Sửa từ JSON.string(item) thành JSON.stringify(item)
    });
    
    if (result.ok) {
      const data = await result.json();
      // Xử lý dữ liệu trả về ở đây
    } else {
      console.error("Lỗi trong quá trình gửi yêu cầu.");
    }
  } catch (error) {
    console.error("Lỗi trong quá trình gửi yêu cầu: " + error);
  }
}

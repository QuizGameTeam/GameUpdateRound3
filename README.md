# ANTIHACKER

## Hướng dẫn 

- Bản unity : 2021.3.18f1
- Ngôn ngữ sử dụng `C#`
- Quản lý dữ liệu data (các câu hỏi) : ScriptableObject
- Mở unity xem gameplay trong floder `Asset` -> `Scenes` -> `Round3`
- Trong cửa số project chọn `Intro` -> Ấn nút `Play` để test game
- Source code được quản lý trong floder `Scripts` -> `NewScripts`. 

    - Mỗi sence tương ứng với mỗi scripts (chính)
        - Sence `Intro` -> `IntroScripts`
        - Sence `Gameplay` ->  `GameplayScripts`
        - Sence `Phishing` và `Privacy` -> `StageSrcipts` 
    - Ngoài ra có srcipts(phụ) sẽ được gắn tương ứng với các object cần thiết.
    - Mở `Inspector` để quan sát chi tiết hơn ạ.

- Cơ chế game : `Intro` -> `GamePlay` -> `Phishing` / `Privacy`
- Setup giao diện màn hình `1920 x 1080`

- Chơi gameplay : floder tải hết tất cả trong floder [link sau](https://drive.google.com/drive/folders/1teIRrwk8wZjxbR8ykCw3xURe3ctVrQ9i?usp=drive_link)  -> chạy file `AntiHacker.exe` 

    ![Alt text](Report/gamelogo.png)

## Mô tả

- Game 2D phiêu lưu với những thử thách khác nhau liên quan đến các vấn đề bảo mật (đóng vai là hacker/ người điều tra số ). Đồng thời người chơi có thể vào `Learn` để học thêm kiến thức về bảo mật và làm các quiz nhỏ liên quan đến vấn đề này.

- Cách di chuyển
    
    - `D` : qua phải 

    - `W` : nhảy lên 

    - `A` : qua trái

    - `Esc`: Tạm dừng game


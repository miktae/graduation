import sys
import PythonMeasurement
import PythonDetection

for line in sys.stdin:
    # Đọc dữ liệu từ STDIN
    myString = line.strip()

    # Xử lý dữ liệu đo kích thước
    measurement_result = PythonMeasurement.measurement(myString)
    # Phát hiện lỗi bề mặt 
    detection_result = PythonDetection.run(myString)

    # Gửi kết quả trả về cho file C#
    print(measurement_result, detection_result)
    sys.stdout.flush()


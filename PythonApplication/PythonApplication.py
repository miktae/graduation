import sys
import PythonMeasurement
import PythonDetection

for line in sys.stdin:
    # Đọc dữ liệu từ STDIN
    imgPath = line.strip()

    # Phát hiện lỗi bề mặt 
    detection_result = PythonDetection.run(
                weights='weight/best.pt',
                data='data/data.yaml',
                source=imgPath,
                name = imgPath.replace('.jpeg', '_result.jpeg'),                                                                      
            )
    
    # Gửi kết quả trả về cho file C#
    if detection_result == "OK-1" or detection_result == "OK-2":
        # Xử lý dữ liệu đo kích thước
        measurement_result = PythonMeasurement.measurement(imgPath)
        print(measurement_result, detection_result)
    else:
        print(detection_result)
    sys.stdout.flush()
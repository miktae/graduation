"# graduation" 
Sửa code sau:
" // Định nghĩa đường dẫn đến file Python
            string pythonScriptPath = @"../../../PythonApplication/PythonApplication.py";

            // Tạo một ProcessStartInfo mới
            ProcessStartInfo startInfo = new ProcessStartInfo("python");
            startInfo.Arguments = pythonScriptPath;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            // Khởi chạy tiến trình Python
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            // Định nghĩa một chuỗi trong C#
            string myString = "E:/nckh_2023/nckh_2023/repo/Conn_PLC/Resources/ok.jpg";

            // Gửi chuỗi đến file Python
            process.StandardInput.WriteLine(myString);
            process.StandardInput.Flush();

            // Đọc kết quả trả về từ file Python
            string result = process.StandardOutput.ReadLine();

            // Hiển thị kết quả lên Label
            label10.Text = result;

            // Đóng tiến trình Python
            process.StandardInput.Close();
            process.WaitForExit();
" Code chạy Python trong C#

Trong Python:
"for line in sys.stdin:
    # Đọc dữ liệu từ STDIN
    myString = line.strip()

    # Xử lý dữ liệu
    result = detect(myString)

    # Gửi kết quả trả về cho file C#
    print(result)
    sys.stdout.flush()"
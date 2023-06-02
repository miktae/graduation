using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using S7.Net;


namespace Conn_PLC
{
    public partial class Form1 : Form
    {
        // Khởi tạo PLC
        Plc _plc;

        // Khai báo cho Camera
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        private Bitmap currentFrame;

        // Khai báo Class
        ReadFromPLC data_plc = new ReadFromPLC();

        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm camera được kết nối với máy tính vào danh sách
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                cbCamera.Items.Add(VideoCaptureDevice.Name);
            }

            lbPLCConn.Text = "";
        }

        // Nút bấm bật camera
        private void btnOnCam_Click(object sender, EventArgs e)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[cbCamera.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
        }

        // Hàm Hiển thị video lên picturebox
        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Hiển thị Video camera lên picturebox
            ptbVideo.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        // Nút bấm dừng Camera
        private void btnOffCam_Click(object sender, EventArgs e)
        {
            if (FinalVideo != null && FinalVideo.IsRunning)
            {
                FinalVideo.Stop();
                ptbVideo.Image = null;
            }
        }

        //Nút bấm chụp ảnh
        private void btnCupture_Click(object sender, EventArgs e)
        {
            
        }

        // Nút Bấm lưu File ảnh vừa chụp được
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        // Nút bấm kết nối với PLC
        private void btnConnPLC_Click(object sender, EventArgs e)
        {
            try
            {
                _plc = new Plc(CpuType.S71200, txtIP.Text, 0, 0);
                timerPLC.Interval = 1000;
                if(_plc.Open() == ErrorCode.NoError)
                {
                    MessageBox.Show("Sucessfull Connection", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timerPLC.Enabled = true;
                    lbPLCConn.Text = "PLC Connected";
                    lbPLCConn.ForeColor = Color.Green;
                    stdStatusConn.DiscreteValue1 = true;
                    stdStatusConn.DiscreteValue2 = false;
                }
                else
                {
                    MessageBox.Show("Connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbPLCConn.Text = "";
                    lbPLCConn.ForeColor = Color.Red;
                    stdStatusConn.DiscreteValue1 = false;
                    stdStatusConn.DiscreteValue2 = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No IP address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stdStatusConn.DiscreteValue1 = false;
                stdStatusConn.DiscreteValue2 = true;
            }
        }

        // NÚT BẤM NGÁT KẾT NỐI
        private void btnDisConnPLC_Click(object sender, EventArgs e)
        {
            timerPLC.Enabled = false;
            try
            {
                _plc.Close();
            }
            catch (Exception) { }
            lbPLCConn.Text = "PLC Disconnected";
            lbPLCConn.ForeColor = Color.Red;
            stdStatusConn.DiscreteValue1 = false;
            stdStatusConn.DiscreteValue2 = true;
        }

        // NÚT BẤM START
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(_plc.IsConnected == true)
                {
                    _plc.Write("DB2.DBX0.0", 1);
                    _plc.Write("DB2.DBX0.0", 0);
                    timerCamera.Enabled = true;
                    timerCamera.Interval = 2000;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("PLC Not Connected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // NÚT BẤM STOP
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (_plc.IsConnected == true)
                {
                    _plc.Write("DB2.DBX0.1", 1);
                    _plc.Write("DB2.DBX0.1", 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC Not Connected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you sure you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ĐỌC CÁC GIÁ TRỊ TỪ PLC
        private void Read_PLC()
        {
            if(_plc.IsConnected == true)
            {
                txtTotal.Text = data_plc.Qty_Total.ToString();
                txtOk.Text = data_plc.Qty_OK.ToString();
                txtNG.Text = data_plc.Qty_NG.ToString();
                txtCycle.Text = data_plc.Sys_Cycle.ToString();
            }
            else
            {
                txtTotal.Text = "";
                txtOk.Text = "";
                txtNG.Text = "";
                txtCycle.Text = "";
            }
        }

        // TIMER CHẠY PLC
        private void timerPLC_Tick(object sender, EventArgs e)
        {
            _plc.ReadClass(data_plc, 1);
            Read_PLC();

        }


        // HÀM CHỤP ẢNH VÀ LƯU ẢNH
        // img 
        private void Capture_Save()
        {
            if(data_plc.Capture == true)
            {
                if (ptbVideo.Image != null)
                {
                    Bitmap capturedImage = new Bitmap(ptbVideo.Image);
                    //capturedImage.Save("capturedImage.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    capturedImage = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(capturedImage);
                    ptbCapture.Image = capturedImage;
                }
                else
                {
                    MessageBox.Show("No Camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (ptbCapture.Image != null)
                {
                    // Tạo tên file với thời gian hiện tại
                    string fileName = "Image_" + DateTime.Now.ToString("HH_mm_ss_dd_MM_yyyy") + ".jpg";

                    // Tạo đường dẫn lưu file ảnh
                    string folderPath = "./PictureC#";


                    string filePath = Path.Combine(folderPath, fileName);

                    // Lưu ảnh vào thư mục được chỉ định
                    ptbCapture.Image.Save(filePath);

                    // Tạo đường dẫn lưu tệp .txt
                    string txtFileName =  "imgToRead.txt";
                    string folderTextPath = "./TextFile";
                    string txtFilePath = Path.Combine(folderTextPath, txtFileName);

                    // Nội dung muốn ghi vào tệp .txt
                    string text = filePath;

                    // Ghi nội dung vào tệp .txt
                    using (StreamWriter writer = new StreamWriter(txtFilePath))
                    {
                        writer.Write(text);
                    }

                    
                }
                else
                {
                    MessageBox.Show("There is no image to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timerCamera_Tick(object sender, EventArgs e)
        {
            Capture_Save();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ptbVideo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Định nghĩa đường dẫn đến file Python
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
        }
    }
}

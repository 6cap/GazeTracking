using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Numpy;
using OpenCvSharp;
using DlibDotNet;
using System.Collections.Generic;
using System.Linq;
using System;
using DlibDotNet.Extensions;
using Dlib = DlibDotNet.Dlib;



namespace WindowsFormsApp1dfadfdafasd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


            int frame = 0;
            int eye_left = 0;
            int eye_right = 0;
            int calibration; /*= calibration()*/
            int eye_left_pupil_x;
            int eye_left_pupil_y;
            int eye_right_pupil_x;
            int eye_right_pupil_y;
        
        public void init()
        {
            using (var face_detector = Dlib.GetFrontalFaceDetector());
            string cwd = GetFullPath("C: \Users\AnGyuChan\source\repos\WindowsFormsApp1dfadfdafasd"); //절대 주소로 지정
            var model_path = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat");
            this._predictor = 


        }
      
        public void _analyze()
        {

            
            /*Mat src = Cv2.ImShow();
            Mat dst = new Mat(src.Size(), MatType.CV_8UC1);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2GRAY);
            */
            
        }
        public void refresh(int fream)
        {
            this.frame = fream;
            this._analyze();
        }
        public object pupil_left_coords()
        {
            int x = eye_left.origin[0] + eye_left_pupil_x;
            int y = eye_left.origin[1] + eye_left_pupil_y;
            return (x, y);
        }
        public object pupil_right_coords()
        {
            int x = eye_right.origin[0] + eye_left_pupil_x;
            int y = eye_right.origin[1] + eye_left_pupil_y;
            return (x, y);
        }

        public int horizontal_ratio()
        {
            var pupil_left = this.eye_left.pupil.x / (this.eye_left.center[0] * 2 - 10);
            var pupil_right = this.eye_right.pupil.x / (this.eye_right.center[0] * 2 - 10);
            return (pupil_left + pupil_right) / 2;
        }

        public int vertical_ratio()
        {
            var pupil_left = this.eye_left.pupil.x / (this.eye_left.center[0] * 2 - 10);
            var pupil_right = this.eye_right.pupil.x / (this.eye_right.center[0] * 2 - 10);
            return (pupil_left + pupil_right) / 2;
        }

        public int is_right()
        {
            return this.horizontal_ratio() <= 0.35; 
        }

        public object is_left()
        {
            return this.horizontal_ratio() >= 0.65;
        }

        public object is_center()
        {
            return is_right() != true && is_left() != true;
        }

        public object is_blinking()
        {
                var blinking_ratio = (this.eye_left.blinking + this.eye_right.blinking) / 2;
                return blinking_ratio > 3.8;
        }

        
        """동공이 강조 표시된 메인 프레임을 반환합니다."""
        public object annotated_frame()
        {
            var frame = this.frame.ShallowCopy();

            var x_left, y_left = this.pupil_left_coords();//리턴값 우째 받아 오노
            var x_right, y_right = this.pupil_left_coords();//리턴값 우째 받아 오노


            Cv2.line(frame, (x_left - 5, y_left), (x_left + 5, y_left), color);//눈 선그리는거
            Cv2.line(frame, (x_left, y_left - 5), (x_left, y_left + 5), color);
            Cv2.line(frame, (x_right - 5, y_right), (x_right + 5, y_right), color);
            Cv2.line(frame, (x_right, y_right - 5), (x_right, y_right + 5), color);
            
        }







            private void button1_Click(object sender, EventArgs e)
                {

                }
                    
                
            }
        }
    }

  


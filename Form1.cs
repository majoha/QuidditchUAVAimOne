using System;
using System.Windows.Forms;
using EZ_B;


using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Tutorial_31___AR_Drone
{

    public partial class Form1 : Form
    {

        private Timer m_NonUrgentTimer;
        private Timer m_SemiUrgentTimer;
        private Camera _camera;

        //This tracks for a blue object
        private int iLowH = 82;
        private int iHighH = 179;
        private int iLowS = 100;
        private int iHighS = 100;
        private int iLowV = 60;
        private int iHighV = 100;


        //Snitch Variables//
        //store an array of the last points and draw a line
        private int objectPosX;
        private int objectPosY;
        private int objectLastX;
        private int objectLastY;

        private float distanceToObject = 0;
        private int widthOfObject = 52;
        private int focalOfLens = 203;//210//234
        ////////////////////

        //to check
        Size mySize = new Size();
        bool toTrackObject = false;

        //for debug//
        //Capture capture;

        public Form1()
        {

            InitializeComponent();

            //timer for polling non-urgent events//
            m_NonUrgentTimer = new Timer();
            m_NonUrgentTimer.Interval = 5000;
            m_NonUrgentTimer.Tick += m_timer_TickNonUrgent;
            m_NonUrgentTimer.Start();

            //timer for polling semi-urgent events//
            m_SemiUrgentTimer = new Timer();
            m_SemiUrgentTimer.Interval = 500;
            m_SemiUrgentTimer.Tick += m_timer_TickSemiUrgent;
            m_SemiUrgentTimer.Start();

            this.FormClosing += Form1_FormClosing;

            //this removes the right click ability from Emgu.CV.UI.ImageBox//
#if DEBUG
            thresholdImageDisplay.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            originalFeed.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
#endif

        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_NonUrgentTimer.Stop();
            m_NonUrgentTimer.Tick -= m_timer_TickNonUrgent;

            m_SemiUrgentTimer.Stop();
            m_SemiUrgentTimer.Tick -= m_timer_TickSemiUrgent;

        }

        //called every 5 seconds//
        void m_timer_TickNonUrgent(object sender, EventArgs e)
        {
            this.batteryLevelBar.Value = ezB_Connect1.EZB.ARDrone.CurrentNavigationData.BatteryLevel;
        }
        //called every 1/2 a second//
        void m_timer_TickSemiUrgent(object sender, EventArgs e)
        {

            //flight characteristics//
            this.currentUAVAltitudeTextbox.Text = ("altitude: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.Altitude.ToString());
            this.xUAVVelocityTextBox.Text = ("x velocity: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.VX.ToString());
            this.yUAVVelocityTextBox.Text = ("y velocity: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.VY.ToString());
            this.zUAVVelocityTextBox.Text = ("z velocity: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.VZ.ToString());

            //object characteristics//
            this.currentObjectAltitudeTextbox.Text = ("altitude: " + "NULL");
            this.xObjectVelocityTextBox.Text = ("x velocity: " + "NULL");
            this.yObjectVelocityTextBox.Text = ("y velocity: " + "NULL");
            this.zObjectVelocityTextBox.Text = ("z velocity: " + "NULL");
            this.posXTextBox.Text = ("posX: " + objectPosX.ToString());
            this.posYTextBox.Text = ("posY: " + objectPosY.ToString());
            this.distanceToObjectTextBox.Text = ("distance: " + distanceToObject.ToString());

            //This sets the erode and dilate values//
            this.mySize.Height = (int)erodeNumericUpDown.Value;
            this.mySize.Width = (int)erodeNumericUpDown.Value;


            if (toTrackTrackBar.Value == 0)
            {
                toTrackObject = false;
                toTrackTrackBar.BackColor = Color.Red;
                this.isTrackingLabel.Text = "Not Tracking";
            }
            if (toTrackTrackBar.Value == 1)
            {
                toTrackObject = true;
                toTrackTrackBar.BackColor = Color.Green;
                this.isTrackingLabel.Text = "Tracking";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we call this to set the default threshold values, these are the same values as those when the default button is pressed
            setDefaultThresholdValues();

            _camera = new Camera(ezB_Connect1.EZB);
            _camera.OnNewFrame += _camera_OnNewFrame;

            button2.Enabled = false;

            cbDroneVersion.Items.Clear();
            cbDroneVersion.Items.Add(EZ_B.ARDrone.ARDrone.ARDroneVersionEnum.V1);
            cbDroneVersion.SelectedIndex = 0;

            //for use with webcam instead of UAV//
            //capture = new Capture(0);
            //Application.Idle += processFrameAndUpdateGUI;

        }

        void _camera_OnNewFrame()
        {

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            //original//
            Image<Bgr, byte> originalImage = new Image<Bgr, byte>(_camera.GetCurrentBitmap);

            //to load from webcam when not using the Parrot//
            //Mat matOriginalImage;
            //matOriginalImage = capture.QueryFrame();
            //Image<Bgr, Byte> originalImage = matOriginalImage.ToImage<Bgr, Byte>();


            //----------------------------------------
            Mat HsvImage = new Mat();
            CvInvoke.CvtColor(originalImage, HsvImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            //----------------------------------------

            //----------------------------------------
            Mat thresholdImage = new Mat();
            CvInvoke.InRange(HsvImage, new ScalarArray(new MCvScalar(iLowH, iLowS, iLowV)), new ScalarArray(new MCvScalar(iHighH, iHighS, iHighV)), thresholdImage);
            //----------------------------------------

            //----------------------------------------
            //These are replicated above and made to be adjustable - review this alteration
            //Size mySize = new Size();
            //mySize.Width = 5;//5
            //mySize.Height = 5;
            Point myPoint = new Point();
            myPoint.X = -1;
            myPoint.Y = -1;


            Mat erodeAndDilateEllipse = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, mySize, myPoint);
            Emgu.CV.Structure.MCvScalar erodeAndDilateScalar = new Emgu.CV.Structure.MCvScalar();
            erodeAndDilateScalar.V0.Equals(1.0);
            CvInvoke.Erode(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
            CvInvoke.Erode(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);

            CvInvoke.Dilate(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
            CvInvoke.Dilate(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
            //----------------------------------------


            //----------------------------------------
            CvInvoke.Moments(thresholdImage);
            double m10 = CvInvoke.Moments(thresholdImage).M10;
            double m01 = CvInvoke.Moments(thresholdImage).M01;
            double mArea = CvInvoke.Moments(thresholdImage).M00;

            if (mArea > 10000 && toTrackObject)
            {

                objectPosX = (int)(m10 / mArea);
                objectPosY = (int)(m01 / mArea);

                //these are for the drawing of the line
                Point xAndYPoints = new Point();
                xAndYPoints.X = objectPosX;
                xAndYPoints.Y = objectPosY;


                //TODO: Change this variable name
                MCvScalar myColour = new MCvScalar(0, 0, 0);

                //we stop drawing if the object is no longer on the UAV screen//
                if (objectLastX >= 0 && objectLastY >= 0 && objectPosX >= 0 && objectPosY >= 0)
                {
                    CvInvoke.Line(originalImage, new Point(xAndYPoints.X, xAndYPoints.Y), new Point(objectLastX, objectLastY), myColour, 1);

                    int diameterOfObject = ((int)Math.Sqrt(mArea) / 14);

                    Rectangle myRectangle = new Rectangle(xAndYPoints.X - (diameterOfObject / 2), xAndYPoints.Y - (diameterOfObject / 2), diameterOfObject, diameterOfObject);
                    originalImage.Draw(myRectangle, new Bgr(Color.Crimson), 1);
                    
                    distanceToObject = (widthOfObject * focalOfLens) / myRectangle.Width;

                }
                objectLastX = objectPosX;
                objectLastY = objectPosY;
            }

            //screenDrawing(originalImage);

            //display the images//
            thresholdImageDisplay.Image = thresholdImage;
            originalFeed.Image = originalImage;

            //dispose of images//
            originalImage.Dispose();
            HsvImage.Dispose();
            thresholdImage.Dispose();
            stopWatch.Stop();
            double duration = stopWatch.ElapsedMilliseconds / 1000.0;
            //Console.WriteLine("That loop took " + duration + "s");
        }

        private void setDefaultThresholdValues()
        {

            //Sets the default threshold values//
            HueLowNumericUpDown.Value = 82;
            HueHighNumericUpDown.Value = 255;
            SaturationLowNumericUpDown.Value = 160;
            SaturationHighNumericUpDown.Value = 255;
            ValueLowNumericUpDown.Value = 60;
            ValueHighNumericUpDown.Value = 255;

            hueLowTrackbar.Value = (int)HueLowNumericUpDown.Value;
            saturationLowTrackbar.Value = (int)SaturationLowNumericUpDown.Value;
            valueLowTrackbar.Value = (int)ValueLowNumericUpDown.Value;

            hueHighTrackbar.Value = (int)HueHighNumericUpDown.Value;
            saturationHighTrackbar.Value = (int)SaturationHighNumericUpDown.Value;
            valueHighTrackbar.Value = (int)ValueHighNumericUpDown.Value;
            //Sets the default threshold values//

        }

        private void screenDrawing(Image<Bgr, Byte> originalImage)
        {

            Rectangle myRectangle = new Rectangle(100, 100, 30, 30);
            originalImage.Draw(myRectangle, new Bgr(Color.Crimson), 1);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbDroneVersion.SelectedItem == null)
            {

                MessageBox.Show("Select the version of your Drone");

                return;
            }

            EZ_B.ARDrone.ARDrone.ARDroneVersionEnum version = (EZ_B.ARDrone.ARDrone.ARDroneVersionEnum)cbDroneVersion.SelectedItem;

            ezB_Connect1.EZB.ARDrone.Connect(version);

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _camera.StopCamera();

            ezB_Connect1.EZB.ARDrone.StopVideo();

            ezB_Connect1.EZB.ARDrone.Disconnect();

            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set this to hello world in morse code//
            ezB_Connect1.EZB.ARDrone.PlayLedAnimation(EZ_B.ARDrone.Commands.LedAnimationEnum.BlinkGreen, 2, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //ezB_Connect1.EZB.ARDrone.TakeOff();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ezB_Connect1.EZB.ARDrone.Emergency();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            _camera.StartCamera(
              new ValuePair(Camera.CAMERA_NAME_AR_DRONE, Camera.CAMERA_NAME_AR_DRONE),
              panel1,
              320,
              240);

            ezB_Connect1.EZB.ARDrone.StartVideo();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            _camera.StopCamera();

            ezB_Connect1.EZB.ARDrone.StopVideo();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            ezB_Connect1.EZB.ARDrone.SetFlatTrim();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //ezB_Connect1.EZB.ARDrone.Hover();

        }

        private void button19_Click(object sender, EventArgs e)
        {

            ezB_Connect1.EZB.ARDrone.Land();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SendDefaultValues();
        }

        private void ezB_Connect1_Load(object sender, EventArgs e)
        {

        }

        private void cbDroneVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDroneVersion.SelectedIndex = 0;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.hueLabel, "Fill this out with what the hue does");
        }

        private void batteryLevelBar_Click(object sender, EventArgs e)
        {
            //TODO: Check wether we need this code.
            this.batteryLevelBar.Value = ezB_Connect1.EZB.ARDrone.CurrentNavigationData.BatteryLevel;
        }

        private void batteryLevelLabel_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            batteryLevelBar_Click(sender, e);
        }

        private void Hue_ValueChanged(object sender, EventArgs e)
        {
            iLowH = (int)HueLowNumericUpDown.Value;
            hueLowTrackbar.Value = iLowH;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            iHighH = (int)HueHighNumericUpDown.Value;
            hueHighTrackbar.Value = iHighH;
        }

        private void SaturationLow_ValueChanged(object sender, EventArgs e)
        {
            iLowS = (int)SaturationLowNumericUpDown.Value;
            saturationLowTrackbar.Value = iLowS;
        }

        private void SaturationHigh_ValueChanged(object sender, EventArgs e)
        {
            iHighS = (int)SaturationHighNumericUpDown.Value;
            saturationHighTrackbar.Value = iHighS;
        }

        private void ValueLow_ValueChanged(object sender, EventArgs e)
        {
            iLowV = (int)ValueLowNumericUpDown.Value;
            valueLowTrackbar.Value = iLowV;
        }

        private void ValueHigh_ValueChanged(object sender, EventArgs e)
        {

            iHighV = (int)ValueHighNumericUpDown.Value;
            valueHighTrackbar.Value = iHighV;
        }

        private void hueLowTrackbar_Scroll(object sender, EventArgs e)
        {
            HueLowNumericUpDown.Value = hueLowTrackbar.Value;
        }

        private void saturationLowTrackbar_Scroll(object sender, EventArgs e)
        {
            SaturationLowNumericUpDown.Value = saturationLowTrackbar.Value;
        }

        private void valueLowTrackbar_Scroll(object sender, EventArgs e)
        {
            ValueLowNumericUpDown.Value = valueLowTrackbar.Value;
        }

        private void hueHighTrackbar_Scroll(object sender, EventArgs e)
        {
            HueHighNumericUpDown.Value = hueHighTrackbar.Value;

        }

        private void saturationHighTrackbar_Scroll(object sender, EventArgs e)
        {
            SaturationHighNumericUpDown.Value = saturationHighTrackbar.Value;

        }

        private void valueHighTrackbar_Scroll(object sender, EventArgs e)
        {
            ValueHighNumericUpDown.Value = valueHighTrackbar.Value;
        }

        private void resetThresholdValues_Click(object sender, EventArgs e)
        {
            setDefaultThresholdValues();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void currentAltitudeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toTrackTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void posYTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void posXTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

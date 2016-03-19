using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

using EZ_B;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Tutorial_31___AR_Drone
{

    public partial class Form1 : Form
    {

        //these are the timers that will poll every x seconds//
        private Timer m_NonUrgentTimer;
        private Timer m_SemiUrgentTimer;

        //for parrot//
        private Camera _camera;

        //for webcam//
        //private Capture capture;

        //variables which dictate the speed at which the UAV will move when changing direction//
        float moveSensitivivivity = 0.20f;
        int moveSleepTime = 400;

        //this tracks for a blue object
        private int iLowH = 82;
        private int iHighH = 179;
        private int iLowS = 100;
        private int iHighS = 100;
        private int iLowV = 60;
        private int iHighV = 100;

        //Snitch Variables//
        private int objectPosX = 0;
        private int objectPosY = 0;
        private int objectLastX = 0;
        private int objectLastY = 0;

        private float distanceToObject = 0;//mm
        private int widthOfObject = 72;//mm
        /*These are the widths of objects used while developing
         * 
         * - Pledge container lid = 52mm
         * - orange hockey ball = 65mm
         * - purple lid = 72mm
         * 
         */
        private int focalOfLens = 203;//mm
        /*These are a list of focal lengths which depend on the debugging method i.e. webcam or Parrot
         *
         * - webcam = ~469mm //~770
         * - ARParrot = ~203mm //previous values 210, 234
         * 
         */
        //Snitch Variables//

        //PIDControllerXVariables//
        private float pGain = 0.50f;
        private float iGain = 0.00f;
        private float dGain = 0.00f;

        private float pCorrectionX = 0.0f;
        private float iCorrectionX = 0.0f;
        private float dCorrectionX = 0.0f;

        private float slopeX = 0.0f;
        private float lastErrorX = 0.0f;
        private float iCumErrorX = 0.0f;
        private float errorX = 0.0f;
        private float setPointX = 300.0f;//mm

        private float maxCorrectionX = 0.05f;
        private float minCorrectionX = -0.05f;
        //PIDControllerXVariables//

        //to check
        Size mySize = new Size();
        private bool toTrackObject = false;
        private bool toFollowObject = false;
        private bool toPredictObject = false;

        int temp = 1;

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

            //this removes the right click ability from the Emgu.CV.UI.ImageBox//
#if DEBUG
            thresholdImagePanel.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            originalFeedPanel.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
#endif

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we call this to set the default threshold values, these are the same values as those when the default button is pressed
            setDefaultThresholdValues();

            //For use with the Parrot//
            _camera = new Camera(ezB_Connect1.EZB);
            _camera.OnNewFrame += _camera_OnNewFrame;

            //for use with webcam instead of UAV//
            //capture = new Capture(0);
            //Application.Idle += processFrameAndUpdateGUI;

            stopVideoAndDisconnectButton.Enabled = false;

            cbDroneVersion.Items.Clear();
            cbDroneVersion.Items.Add(EZ_B.ARDrone.ARDrone.ARDroneVersionEnum.V1);
            cbDroneVersion.SelectedIndex = 0;

        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_NonUrgentTimer.Stop();
            m_NonUrgentTimer.Tick -= m_timer_TickNonUrgent;

            m_SemiUrgentTimer.Stop();
            m_SemiUrgentTimer.Tick -= m_timer_TickSemiUrgent;


            _camera.StopCamera();
            ezB_Connect1.EZB.ARDrone.StopVideo();
            ezB_Connect1.EZB.ARDrone.Disconnect();

            //for webcam//
            //capture.Stop();
            //capture.Dispose();
            //for webcam//

        }

        //this function is called every 5 seconds//
        //and updates non-urgent items//
        void m_timer_TickNonUrgent(object sender, EventArgs e)
        {
            batteryLevelLabel.Text = "Battery Level " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.BatteryLevel.ToString() + "%";
            batteryLevelBar.Value = ezB_Connect1.EZB.ARDrone.CurrentNavigationData.BatteryLevel;
        }

        //this function is called every 1/2 a second//
        //and updates semi urgent items//
        void m_timer_TickSemiUrgent(object sender, EventArgs e)
        {
            //flight characteristics//
            currentUAVAltitudeTextbox.Text = ("altitude: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.Altitude.ToString());
            xUAVVelocityTextBox.Text = ("x velocity: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.VX.ToString());
            yUAVVelocityTextBox.Text = ("y velocity: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.VY.ToString());
            zUAVVelocityTextBox.Text = ("z velocity: " + ezB_Connect1.EZB.ARDrone.CurrentNavigationData.VZ.ToString());

            //object characteristics//
            currentObjectAltitudeTextbox.Text = ("altitude: " + "NULL");
            xObjectVelocityTextBox.Text = ("x velocity: " + "NULL");
            yObjectVelocityTextBox.Text = ("y velocity: " + "NULL");
            zObjectVelocityTextBox.Text = ("z velocity: " + "NULL");
            posXTextBox.Text = ("posX: " + objectPosX.ToString());
            posYTextBox.Text = ("posY: " + objectPosY.ToString());
            distanceToObjectTextBox.Text = ("distance: " + distanceToObject.ToString());

            //This sets the erode and dilate values//
            this.mySize.Height = (int)erodeNumericUpDown.Value;
            this.mySize.Width = (int)erodeNumericUpDown.Value;

            //this is the logic for the trackbar values//
            //TODO: Perhaps move this to a seperate function//
            if (toTrackTrackBar.Value == 0)
            {
                toTrackObject = false;
                toTrackTrackBar.BackColor = Color.Red;
                this.isTrackingLabel.Text = "Not Tracking";
            }
            else if (toTrackTrackBar.Value == 1)
            {
                toTrackObject = true;
                toTrackTrackBar.BackColor = Color.Green;
                this.isTrackingLabel.Text = "Tracking...";
            }
            if (toFollowTrackBar.Value == 0 || toTrackTrackBar.Value == 0)
            {
                toFollowObject = false;
                toFollowTrackBar.BackColor = Color.Red;
                this.isfollowingLabel.Text = "Not Following";
            }
            else if (toFollowTrackBar.Value == 1 && toTrackTrackBar.Value == 1)
            {
                toFollowObject = true;
                toFollowTrackBar.BackColor = Color.Green;
                this.isfollowingLabel.Text = "Following...";
            }
            if (toPredictTrackBar.Value == 0 || toTrackTrackBar.Value == 0)
            {
                toPredictObject = false;
                toPredictTrackBar.BackColor = Color.Red;
                this.isPredictingLabel.Text = "Not Predicting";
            }
            else if (toPredictTrackBar.Value == 1 && toTrackTrackBar.Value == 1)
            {
                toPredictObject = true;
                toPredictTrackBar.BackColor = Color.Green;
                this.isPredictingLabel.Text = "Predicting...";

            }

        }

        //this function is called on new frame from the WEBCAM. So when debugging using that, edit this function//
        //void processFrameAndUpdateGUI(object sender, EventArgs arg)
        //{
        //    System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
        //    stopWatch.Start();

        //    //to load from webcam when not using the Parrot//
        //    Mat matOriginalImage;
        //    matOriginalImage = capture.QueryFrame();
        //    Image<Bgr, Byte> originalImage = matOriginalImage.ToImage<Bgr, Byte>();


        //    //----------------------------------------
        //    Mat HsvImage = new Mat();
        //    CvInvoke.CvtColor(originalImage, HsvImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
        //    //----------------------------------------

        //    //----------------------------------------
        //    Mat thresholdImage = new Mat();
        //    CvInvoke.InRange(HsvImage, new ScalarArray(new MCvScalar(iLowH, iLowS, iLowV)), new ScalarArray(new MCvScalar(iHighH, iHighS, iHighV)), thresholdImage);
        //    //----------------------------------------

        //    //----------------------------------------
        //    //These are replicated above and made to be adjustable - review this alteration
        //    //Size mySize = new Size();
        //    //mySize.Width = 5;
        //    //mySize.Height = 5;
        //    Point myPoint = new Point();
        //    myPoint.X = -1;
        //    myPoint.Y = -1;


        //    Mat erodeAndDilateEllipse = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, mySize, myPoint);
        //    Emgu.CV.Structure.MCvScalar erodeAndDilateScalar = new Emgu.CV.Structure.MCvScalar();
        //    erodeAndDilateScalar.V0.Equals(1.0);
        //    CvInvoke.Erode(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
        //    CvInvoke.Erode(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);

        //    CvInvoke.Dilate(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
        //    CvInvoke.Dilate(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
        //    //----------------------------------------


        //    //----------------------------------------
        //    CvInvoke.Moments(thresholdImage);
        //    double m10 = CvInvoke.Moments(thresholdImage).M10;
        //    double m01 = CvInvoke.Moments(thresholdImage).M01;
        //    double mArea = CvInvoke.Moments(thresholdImage).M00;

        //    //we check if the area is above a certain value otherwise it is probably noise//
        //    if (mArea > 10000 && toTrackObject)
        //    {

        //        objectPosX = (int)(m10 / mArea);
        //        objectPosY = (int)(m01 / mArea);

        //        //these are for the drawing of the line
        //        Point xAndYPoints = new Point();
        //        xAndYPoints.X = objectPosX;
        //        xAndYPoints.Y = objectPosY;


        //        //TODO: Change this variable name
        //        MCvScalar myColour = new MCvScalar(0, 0, 0);

        //        //we only draw if the object is on the UAV screen//
        //        if (objectLastX >= 0 && objectLastY >= 0 && objectPosX >= 0 && objectPosY >= 0)
        //        {
        //            //draws a line from last point to new point//
        //            //CvInvoke.Line(originalImage, new Point(xAndYPoints.X, xAndYPoints.Y), new Point(objectLastX, objectLastY), myColour, 1);

        //            int diameterOfObject = ((int)Math.Sqrt(mArea) / 14);//23//14

        //            Rectangle myRectangle = new Rectangle(xAndYPoints.X - (diameterOfObject / 2), xAndYPoints.Y - (diameterOfObject / 2), diameterOfObject, diameterOfObject);
        //            originalImage.Draw(myRectangle, new Bgr(Color.Crimson), 1);

        //            distanceToObject = (widthOfObject * focalOfLens) / myRectangle.Width;

        //            if (toFollowObject)
        //            {
        //                Console.WriteLine("Distance to the object is " + distanceToObject);
        //                if (distanceToObject > 200.0f)
        //                {
        //                    //Todo: add code that will allow the UAV to move according to the distance given above
        //                    moveUAVForwardPID(PIDControllerForward(distanceToObject));

        //                }
        //            }

        //        }
        //        objectLastX = objectPosX;
        //        objectLastY = objectPosY;
        //    }

        //    //screenDrawing(originalImage);

        //    //display the images//
        //    thresholdImagePanel.Image = thresholdImage;
        //    originalFeedPanel.Image = originalImage;

        //    //dispose of images//
        //    originalImage.Dispose();
        //    HsvImage.Dispose();
        //    thresholdImage.Dispose();
        //    stopWatch.Stop();
        //    double duration = stopWatch.ElapsedMilliseconds / 1000.0;
        //    //Console.WriteLine("That loop took " + duration + "s");

        //}

        //this function is called on new frame from the Parrot. So when debugging using that, edit this function//
        void _camera_OnNewFrame()
        {

            //original//
            Image<Bgr, byte> originalImage = new Image<Bgr, byte>(_camera.GetCurrentBitmap);

            //----------------------------------------
            Mat HsvImage = new Mat();
            CvInvoke.CvtColor(originalImage, HsvImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            //----------------------------------------

            //----------------------------------------
            Mat thresholdImage = new Mat();
            CvInvoke.InRange(HsvImage, new ScalarArray(new MCvScalar(iLowH, iLowS, iLowV)), new ScalarArray(new MCvScalar(iHighH, iHighS, iHighV)), thresholdImage);
            //----------------------------------------

            //----------------------------------------

            Point myPoint = new Point();
            myPoint.X = -1;
            myPoint.Y = -1;

            Mat erodeAndDilateEllipse = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, mySize, myPoint);
            Emgu.CV.Structure.MCvScalar erodeAndDilateScalar = new Emgu.CV.Structure.MCvScalar();
            CvInvoke.Erode(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
            //CvInvoke.Erode(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);

            CvInvoke.Dilate(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
            //CvInvoke.Dilate(thresholdImage, thresholdImage, erodeAndDilateEllipse, myPoint, 1, Emgu.CV.CvEnum.BorderType.Constant, erodeAndDilateScalar);
            //----------------------------------------


            //----------------------------------------
            CvInvoke.Moments(thresholdImage);
            double m10 = CvInvoke.Moments(thresholdImage).M10;
            double m01 = CvInvoke.Moments(thresholdImage).M01;
            double mArea = CvInvoke.Moments(thresholdImage).M00;

            //we check if the area is above a certain value otherwise it is probably noise//
            if (mArea >= 20000 && toTrackObject)
            {

                objectPosX = (int)(m10 / mArea);
                objectPosY = (int)(m01 / mArea);

                //these are for the drawing of the line
                Point xAndYPoints = new Point();
                xAndYPoints.X = objectPosX;
                xAndYPoints.Y = objectPosY;

                //TODO: Change this variable name
                MCvScalar myColour = new MCvScalar(0, 0, 0);

                //we only draw if the object is on the UAV screen//
                if (objectLastX >= 0 && objectLastY >= 0 && objectPosX >= 0 && objectPosY >= 0)
                {
                    CvInvoke.Line(originalImage, new Point(xAndYPoints.X, xAndYPoints.Y), new Point(objectLastX, objectLastY), myColour, 1);

                    int diameterOfObject = ((int)Math.Sqrt(mArea) / 14);

                    Rectangle myRectangle = new Rectangle(xAndYPoints.X - (diameterOfObject / 2), xAndYPoints.Y - (diameterOfObject / 2), diameterOfObject, diameterOfObject);
                    originalImage.Draw(myRectangle, new Bgr(Color.Crimson), 1);

                    if (myRectangle.Width > 0.0f)
                    {
                        distanceToObject = (widthOfObject * focalOfLens) / myRectangle.Width;

                        if (toFollowObject)
                        {
                            moveUAVForwardPID(PIDControllerForward(distanceToObject));
                        }
                    }

                }
                objectLastX = objectPosX;
                objectLastY = objectPosY;
            }

            //screenDrawing(originalImage);

            //display the images//
            thresholdImagePanel.Image = thresholdImage;
            originalFeedPanel.Image = originalImage;

            //dispose of images//
            originalImage.Dispose();
            HsvImage.Dispose();
            thresholdImage.Dispose();
        }

        private float PIDControllerForward(float distanceToObject)
        {
            //proportional
            errorX = distanceToObject - setPointX;
            pCorrectionX = pGain * errorX;

            //integral
            if (temp <= 5)
            {

                iCumErrorX += errorX;
                iCumErrorX /= temp;
                temp++;

            }
            else
            {

                temp = 1;
            }

            iCorrectionX = iGain * iCumErrorX;

            //derivative
            slopeX = errorX - lastErrorX;
            dCorrectionX = dGain * slopeX;

            lastErrorX = errorX;

            float xCorrection = (pCorrectionX + iCorrectionX + dCorrectionX);
            //scale the value to fit within the wanted moveSensitivity
            Console.WriteLine("The value of xCorrection is " + xCorrection);
            xCorrection /= 1000.0f;

            if (xCorrection > maxCorrectionX)
            {
                xCorrection = maxCorrectionX;
            }
            if (xCorrection < minCorrectionX)
            {

                xCorrection = minCorrectionX;
            }

            return xCorrection;
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

        private void conectToARDoneButton_Click(object sender, EventArgs e)
        {
            if (cbDroneVersion.SelectedItem == null)
            {

                MessageBox.Show("Select the version of your Drone");

                return;
            }

            EZ_B.ARDrone.ARDrone.ARDroneVersionEnum version = (EZ_B.ARDrone.ARDrone.ARDroneVersionEnum)cbDroneVersion.SelectedItem;

            ezB_Connect1.EZB.ARDrone.Connect(version);

            conectToARDoneButton.Enabled = false;
            stopVideoAndDisconnectButton.Enabled = true;
        }

        private void stopVideoAndDisconnectButton_Click(object sender, EventArgs e)
        {
            _camera.StopCamera();
            ezB_Connect1.EZB.ARDrone.StopVideo();
            ezB_Connect1.EZB.ARDrone.Disconnect();

            conectToARDoneButton.Enabled = true;
            stopVideoAndDisconnectButton.Enabled = false;
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.PlayLedAnimation(EZ_B.ARDrone.Commands.LedAnimationEnum.BlinkGreen, 2, 3);
        }

        private void startEnginesButton_Click(object sender, EventArgs e)
        {
            //ezB_Connect1.EZB.ARDrone.TakeOff();
        }

        private void emergencyButton_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.Emergency();
        }

        private void moveUAVUp_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, moveSensitivivivity, 0);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void moveUAVDown_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, -moveSensitivivivity, 0);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void moveUAVForward_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, -moveSensitivivivity, 0, 0);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void moveUAVForwardPID(float moveAmount)
        {
            //ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, -(moveAmount), 0, 0);

            //System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();

            Console.WriteLine("Moving towards the target at a rate of " + moveAmount);
        }

        private void moveUAVBackward_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, moveSensitivivivity, 0, 0);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void moveUAVLeftRoll_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(-moveSensitivivivity, 0, 0, 0);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();

        }

        private void moveUAVRightRoll_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(moveSensitivivivity, 0, 0, 0);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();

        }

        private void moveUAVAnticlockwiseYaw_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, 0, -moveSensitivivivity);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void moveUAVClockwiseYaw_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, 0, moveSensitivivivity);

            System.Threading.Thread.Sleep(moveSleepTime);

            ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void startVideoButton_Click(object sender, EventArgs e)
        {
            _camera.StartCamera(
              new ValuePair(Camera.CAMERA_NAME_AR_DRONE, Camera.CAMERA_NAME_AR_DRONE),
              sourceFeedPanel,
              320,
              240);

            ezB_Connect1.EZB.ARDrone.StartVideo();
        }

        private void stopVideoButton_Click(object sender, EventArgs e)
        {
            _camera.StopCamera();
            ezB_Connect1.EZB.ARDrone.StopVideo();
        }

        private void flatTrimButton_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.SetFlatTrim();
        }

        private void hoverButton_Click(object sender, EventArgs e)
        {
            //ezB_Connect1.EZB.ARDrone.Hover();
        }

        private void landButton_Click(object sender, EventArgs e)
        {
            ezB_Connect1.EZB.ARDrone.Land();
        }

        private void setDefaultsButton_Click(object sender, EventArgs e)
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

        private void thresholdImageDisplay_Click(object sender, EventArgs e)
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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_NonUrgentTimer.Stop();
            m_NonUrgentTimer.Tick -= m_timer_TickNonUrgent;

            m_SemiUrgentTimer.Stop();
            m_SemiUrgentTimer.Tick -= m_timer_TickSemiUrgent;

            _camera.StopCamera();
            ezB_Connect1.EZB.ARDrone.StopVideo();
            ezB_Connect1.EZB.ARDrone.Disconnect();

            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkForUpdates checkForUpdates = new checkForUpdates();
        }

        private void restartApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            m_NonUrgentTimer.Stop();
            m_NonUrgentTimer.Tick -= m_timer_TickNonUrgent;

            m_SemiUrgentTimer.Stop();
            m_SemiUrgentTimer.Tick -= m_timer_TickSemiUrgent;


            _camera.StopCamera();
            ezB_Connect1.EZB.ARDrone.StopVideo();
            ezB_Connect1.EZB.ARDrone.Disconnect();


            Application.Restart();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

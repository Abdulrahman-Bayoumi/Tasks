using System;
using OpenCvSharp;
namespace Taskday2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region grayscale
            //using var src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\images.png", ImreadModes.Color);
            //using var dst = new Mat();

            //Cv2.Canny(src, dst, 50, 200);
            //using (new Window("src image", src))
            //using (new Window("dst image", dst))
            //{
            //    Cv2.WaitKey();
            //}
            #endregion
            #region rotation
            //Mat mat = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\images.png", ImreadModes.Color);
            //Mat mat2 = new Mat();
            ////Next, compute the rotation point, which in this example,
            ////will be the center of the image. To do this, simply
            ////divide the image width and height by two, as shown below.
            //var imageCenter = new Point2f(mat.Cols / 2f, mat.Rows / 2f);
            /////the center point, about which the rotation occurs,
            /////the angle of rotation, in degrees (positive values, corresponding to counter clockwise rotation)
            //// scale
            //    var rotationMat = Cv2.GetRotationMatrix2D(imageCenter, 180,1.2);
            //    Cv2.WarpAffine(mat, mat2, rotationMat, mat.Size());
            //using (new Window("mat1", mat))

            //using (new Window("mat2", mat2,WindowFlags.Normal))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion
            #region brightness
            //Mat gray = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\images.jpg", ImreadModes.Color);
            //Mat gray2 = new Mat();
            //var alpha = 2;
            //var beta = 50;
            //Cv2.AddWeighted(gray, 2, gray, 0,100, gray2, -1);
            //using (new Window("mat1", gray))
            //using (new Window("mat2", gray2))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion
            #region darkness
            //Mat gray = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\images.jpg", ImreadModes.Color);
            //Mat gray2 = new Mat();
            //var alpha = 2;
            //var beta = 50;
            //Cv2.AddWeighted(gray, 2, gray, 0, -50, gray2, -1);
            //using (new Window("mat1", gray))
            //using (new Window("mat2", gray2))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion
            #region contrast law and high
            //Mat gray = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\b.png", ImreadModes.Grayscale);
            //Mat gray2 = new Mat();
            //Cv2.EqualizeHist(gray, gray2);
            //using (new Window("mat1", gray))
            //using (new Window("mat2", gray2))
            //{
            //    Cv2.WaitKey(0);
            //}


            #endregion
            #region match template
            //Mat gray = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\c1.png", ImreadModes.Grayscale);
            //Mat gray2 = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\c2.png", ImreadModes.Grayscale);
            //Mat gray3 = new Mat();
            //Cv2.MatchTemplate(gray, gray2, gray3, TemplateMatchModes.CCoeffNormed, null);
            //using (new Window("mat1", gray))
            //using (new Window("mat2", gray2))
            //using (new Window("mat3", gray3))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion
            #region remove noising by applay filter

            Mat gray = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\nois.png", ImreadModes.Grayscale);
            Mat outtt = new Mat();
            Mat blur = new Mat();
            Mat divide = new Mat();
            Mat thresh = new Mat();
            Mat mor = new Mat();
            //Mean filter blure image
            Cv2.MedianBlur(gray, outtt ,3);
            //blur
            Size s;
            s.Height = 0;
            s.Width = 0;
            Cv2.GaussianBlur(gray, blur, s, 33, 33, BorderTypes.Default);
            // divide
            Cv2.Divide(gray, blur,divide, 255);
            // otsu threshold
            Cv2.Threshold(divide, thresh, 0, 255, ThresholdTypes.Binary);
            // apply morphology
            Size s2=new Size(3,3);
            Mat kernel= Cv2.GetStructuringElement(MorphShapes.Rect, s2);
            Cv2.MorphologyEx(thresh, mor, MorphTypes.Close, kernel,null,1,BorderTypes.Constant);
            //max filter
            Mat maxuot = new Mat();
            Cv2.Dilate(gray, maxuot ,kernel);
            //min filter
            Mat minuot = new Mat();
            Cv2.Erode(gray, minuot, kernel);
            using (new Window("minfilter", minuot))
            using (new Window("maxfilter", maxuot)) 
            using (new Window("mat1", gray))
            using (new Window("mat2", blur))
            using (new Window("mat3", divide))
            using (new Window("mat5", mor))
            using (new Window("mean", outtt))
            {
                Cv2.WaitKey(0);
            }
            #endregion
        }
    }
}

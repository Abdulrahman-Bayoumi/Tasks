using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using OpenCvSharp;
using OpenCvSharp.XImgProc;
using static OpenCvSharp.FileStorage;

namespace taskday3
{
    class Program:Shap
    {
        static void Main(string[] args)
        {
            #region rezise type
            //cv2.INTER_AREA: This is used when we need to shrink an image.
            //cv2.INTER_CUBIC: This is slow but more efficient.
            //cv2.INTER_LINEAR: This is primarily used
            //when zooming is required.This is the default interpolation technique in OpenCV.
            #endregion
            #region up and down scale image
            //using var src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\python.png", ImreadModes.Color);
            //using var dst = new Mat();

            //int scale_percent = 200; // percent of original size
            //int width = (src.Width * scale_percent / 100);
            //int height = (src.Height * scale_percent / 100);
            //Size dim = new Size(width, height);

            //// resize image
            //Cv2.Resize(src, dst, dim, 0, 0, InterpolationFlags.Linear);
            //using (new Window("src image", src))
            //using (new Window("dst image", dst))
            //{
            //    Cv2.WaitKey();
            //}
            #endregion
            #region wdith or height only
            //using var src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\download.jpg", ImreadModes.Color);
            //using var dst = new Mat();

            //int width = 400;
            //int height = src.Height;
            //Size dim = new Size(width, height);
            //Size dim2 = new Size();
            //Cv2.Resize(src, dst, dim, 0, 0, InterpolationFlags.LinearExact);
            //// resize image
            ////Cv2.Resize(src, dst, dim2, .5, .5, InterpolationFlags.LinearExact);
            //using (new Window("src image", src))
            //using (new Window("dst image", dst))
            //{
            //    Cv2.WaitKey();
            //}
            #endregion
            #region histgram

            //Mat src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\images.jpg", ImreadModes.Grayscale);
            //// Histogram view
            //const int Width = 260, Height = 200;
            //Mat render = new Mat(new Size(Width, Height), MatType.CV_8UC3, Scalar.All(255));

            //// Calculate histogram
            //Mat hist = new Mat();
            //int[] hdims = { 256 }; // Histogram size for each dimension
            //Rangef[] ranges = { new Rangef(0, 256), }; // min/max 
            //Cv2.CalcHist(
            //    new Mat[] { src },
            //    new int[] { 0 },
            //    null,
            //    hist,
            //    1,
            //    hdims,
            //    ranges);

            //// Get the max value of histogram
            //double minVal, maxVal;
            //Cv2.MinMaxLoc(hist, out minVal, out maxVal);

            //Scalar color = Scalar.All(50);
            //// Scales and draws histogram
            //int binW = (int)((double)Width / hdims[0]);

            //hist = hist * (maxVal != 0 ? Height / maxVal : 0.0);
            //for (int j = 0; j < hdims[0]; ++j)
            //{
            //    Console.WriteLine($@"j:{j} P1: {j * binW},{render.Rows} P2:{(j + 1) * binW},{render.Rows - (int)hist.Get<float>(j)}");  //for Debug

            //    render.Rectangle(
            //        new Point(j * binW, render.Rows),
            //        new Point((j + 1) * binW, render.Rows - (int)(hist.Get<float>(j))),
            //        color,
            //        -1);
            //}

            //using (new Window("Image", src))
            //using (new Window("Histogram", render))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion
            #region skeleton by Morpology
            //Mat src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\skelet.png", ImreadModes.Grayscale);
            //Mat ds = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\skelet.png", ImreadModes.Grayscale);
            //Mat skel = Mat.Zeros(src.Rows ,src.Cols ,MatType.CV_8UC1);
            //Size sd = new Size(3, 3);
            //Cv2.GetStructuringElement(MorphShapes.Cross, sd);
            //Mat erod = new Mat();
            //Mat opening = new Mat();
            //Mat subb = new Mat();
            //int c = 6800;
            //while (c!=0)
            //{
            //    //Erosion
            //    Cv2.Erode(src, erod, Cv2.GetStructuringElement(MorphShapes.Cross, sd));
            //    // Cv2.Dilate(erod, temp, Cv2.GetStructuringElement(MorphShapes.Cross, sd));
            //    //        # Opening on eroded image
            //    Cv2.MorphologyEx(erod, opening, MorphTypes.Open, Cv2.GetStructuringElement(MorphShapes.Cross, sd));
            //    //   Subtract these two subb = erode - opening
            //    Cv2.Subtract(erod, opening, subb);
            //    //   Union of all previous sets
            //    Cv2.BitwiseOr(skel, subb, skel);
            //    erod.CopyTo(src);
            //   //  c=Cv2.CountNonZero(erod);
            //   // c = Cv2.CountNonZero(src);
            //    c = c - 1;
            //    // var zeros = (s) - x;
            //    // if zeros == size:
            //    //        done = True
            //}
            //    using (new Window("Image", ds))
            //    using (new Window("skeleton", skel))
            //    {
            //        Cv2.WaitKey(0);
            //    }

            #endregion
            #region skeleton by thin
            //Mat src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\skelet.png", ImreadModes.Grayscale);
            //Mat subb = new Mat();
            //CvXImgProc.Thinning(src, subb, ThinningTypes.GUOHALL);
            //using (new Window("Image", src))
            //using (new Window("skeleton", subb))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion
            #region Edge detection 
            //Mat src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\laplac.png", ImreadModes.Color);
            //Mat edge = new Mat();
            //#region laplac
            ////      Laplacian(src_gray, dst, ddepth, kernel_size, scale, delta, BORDER_DEFAULT);
            //Cv2.Laplacian(
            //          src            //source image
            //           , edge,      //desination image of the same size and the same number of channels as src
            //          MatType.CV_8U,          //desired depth of the destination image
            //          3,          //aperture size used to compute the second-derivative filters.
            //          1,         //optional scale factor for the computed Laplacian values. By default, no scalling is applied
            //          0,        //Optional delta value that is added to the results prior to storing them in dst.
            //          BorderTypes.Default  //pixel extrapolation method
            //          );
            ////edge.Abs();
            //using (new Window("Image", src))
            //using (new Window("skeleton", edge))
            //{
            //    Cv2.WaitKey(0);
            //}
            #endregion

            #region Sobel x and sobel Y
            // Mat edgex = new Mat();
            // Mat edgey = new Mat();
            // Mat sob = new Mat();
            // //order of the derivative x.
            ////order of the derivative y.
            // Cv2.Sobel(src, edgex, MatType.CV_8U, 1, 0, 3, 1, 0, BorderTypes.Default);
            // Cv2.Sobel(src, edgey, MatType.CV_8U, 0, 1, 3, 1, 0, BorderTypes.Default);
            // Cv2.BitwiseOr(edgex, edgey, sob, null);
            // #endregion
            #region canny
            // int ratio = 3;
            // Mat cann = new Mat();
            // //{                     //Min //Max
            //     Cv2.Canny(src, cann, 100, 100 * ratio);
            // //});

            #endregion
            // using (new Window("Image", src ))
            // using (new Window("edgelaplac", edge))
            // using (new Window("edgex", edgex))
            // using (new Window("edgey", edgey))
            // using (new Window("sobel", sob))
            // using (new Window("canny ", cann))


            // {
            //     Cv2.WaitKey(0);
            // }
            #endregion
            #region
            //Contours is in essence the outline of an object 
            //    where as blob detector is an algorithm on top of findContours and
            //    draw line in edge of image.
            //    Blob detector not only finds the boundaries, but also calculates
            //    the center and whether or not 
            //    it matches certain shapes and sizes that you define connected component is a group of
            //    pixels that are connected to each other such that each pixel in the group is connected to (or) has,
            //    at least one neighboring pixel belonging to the same group
            #endregion
            #region blob

            ////# Read image
            //Mat srcImage = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\bl.jpg", ImreadModes.Color);
            //Size s = new Size(3, 3);
            //Cv2.ImShow("Source", srcImage);
            //Cv2.WaitKey(1); // do events


            //var binaryImage = new Mat(srcImage.Size(), MatType.CV_8UC1);

            //Cv2.CvtColor(srcImage, binaryImage, ColorConversionCodes.BGRA2GRAY);
            //Cv2.Threshold(binaryImage, binaryImage, thresh: 120, maxval: 255, type: ThresholdTypes.Binary);

            //var detectorParams = new SimpleBlobDetector.Params
            //{
            //    //MinDistBetweenBlobs = 10, // 10 pixels between blobs
            //    //MinRepeatability = 1,

            //    //MinThreshold = 100,
            //    //MaxThreshold = 255,
            //    //ThresholdStep = 5,

            //    //FilterByArea = false,
            //    FilterByArea = true,
            //    MinArea =300, // 10 pixels squared
            //    MaxArea = 10000,

            //    FilterByCircularity = false,
            //    //FilterByCircularity = true,
            //    //MinCircularity = 0.001f,

            //    //FilterByConvexity = false,
            //    FilterByConvexity = true,
            //    MinConvexity = 0.001f,
            //    MaxConvexity = 1,

            //    FilterByInertia = false,
            //    //FilterByInertia = true,
            //    //MinInertiaRatio = 0.001f,

            //    //FilterByColor = false
            //    FilterByColor = true,
            //    BlobColor = 0 // to extract light blobs
            //};
            //var simpleBlobDetector = SimpleBlobDetector.Create(detectorParams);
            //var keyPoints = simpleBlobDetector.Detect(binaryImage);

            //Console.WriteLine("keyPoints: {0}", keyPoints.Length);
            //foreach (var keyPoint in keyPoints)
            //{
            //    Console.WriteLine("X: {0}, Y: {1}", keyPoint.Pt.X, keyPoint.Pt.Y);
            //}

            //var imageWithKeyPoints = new Mat();
            //Cv2.DrawKeypoints(
            //        image: binaryImage,
            //        keypoints: keyPoints,
            //        outImage: imageWithKeyPoints,
            //        color: Scalar.FromRgb(255, 0, 0),
            //        flags: DrawMatchesFlags.DrawRichKeypoints);


            //Cv2.ImShow("Key Points", imageWithKeyPoints);
            //Cv2.WaitKey(1); // do events


            //Cv2.WaitKey(0);

            //Cv2.DestroyAllWindows();
            //srcImage.Dispose();
            //imageWithKeyPoints.Dispose();
            #endregion
            #region Contour
           // Mat srcImage = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\bl.jpg", ImreadModes.Color);
           // Mat src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\bl.png", ImreadModes.Color);

           // Size s = new Size(512, 512);

           //     //Size dim2 = new Size();
           //Cv2.Resize(srcImage, srcImage, s, 0, 0, InterpolationFlags.LinearExact);

           // var binaryImage = new Mat(srcImage.Size(), MatType.CV_8UC1);
            
           // Cv2.CvtColor(srcImage, binaryImage, ColorConversionCodes.BGRA2GRAY);
           //  //Cv2.Threshold(binaryImage, binaryImage, thresh: 20, maxval: 255, type: ThresholdTypes.Binary);
           // //                        //Min //Max
           //     Cv2.Canny(binaryImage, binaryImage, 20, 255);
           // // 
           // Cv2.FindContours(binaryImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxNone);
           // Console.WriteLine("number on contours =" + Convert.ToString(contours));
           // foreach (Point[] conter in contours)
           // {
               
           //  Point[] outk= Cv2.ApproxPolyDP(conter, .01, true);
               
           //    Cv2.DrawContours(srcImage, outk, -1, Scalar.Green, 1);


           // }
           // using (new Window("Image", srcImage))
           // using (new Window("thres", binaryImage))
           // {
           //     Cv2.WaitKey(0);
           // }
            #endregion
            #region  
            

                Mat gray = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\shaps.png", ImreadModes.Grayscale);
                 Mat src = new Mat($"C:\\Users\\Abd-ElRahman\\OpenCvTest\\shaps.png", ImreadModes.Color);


                //Blurring to reduce high frequency noise to make our contour detection process more accurate.
                Mat blurred = new Mat();
                blurred = gray.GaussianBlur(new Size(5, 5), 0);

                //Binarization of the image.             
                Mat threshold = new Mat();
                threshold = blurred.Canny(60, 255);

                //find contours
                Point[][] contours;
                HierarchyIndex[] hierarchyIndexes;
                Cv2.FindContours(
                     threshold,
                     out contours,
                     out hierarchyIndexes,
                    RetrievalModes.Tree,
                     ContourApproximationModes.ApproxNone);
              Cv2.DrawContours(src, contours, -1, Scalar.Green, 3);

            //loop over the contours

            foreach (var c in contours)
                {
                    Moments m = Cv2.Moments(c);
                    Point pnt = new Point(m.M10 / m.M00, m.M01 / m.M00); //center point
                    Cv2.Circle(src, pnt, 5, Scalar.Red, -1);
                    string shape =Shap.GetShape(c); 
                    Cv2.PutText(src,shape, pnt, HersheyFonts.HersheySimplex, 0.5, Scalar.Green, 2);
                }

                using (new Window("src",  src))
                using (new Window("threshold", threshold))
            {
                Cv2.WaitKey(0);
            }

            #endregion

        }
    }
}

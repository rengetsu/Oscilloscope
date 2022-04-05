using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Oscilloscope
{
    /// <summary>
    /// Animation class to work with bitmap objects
    /// </summary>
    class Animations
    {
        /// <summary>
        /// Animated image object
        /// </summary>
        public Bitmap animatedImage;

        /// <summary>
        /// Currently animating
        /// </summary>
        public bool currentlyAnimating;

        /// <summary>
        /// Method to Creat new bitmap Object
        /// </summary>
        public void CreateBitmapObject(String bitmapName, String bitmapFormat = ".gif")
        {
            String ImagePath = bitmapName + bitmapFormat;
            //Create a Bitmpap Object.
            animatedImage = new Bitmap(ImagePath);
            currentlyAnimating = false;
        }
    }

    /// <summary>
    /// Class methods for form
    /// </summary>
    public class animateImage : Form
    {
        /// <summary>
        /// Using animations class
        /// </summary>
        Animations animations;

        /// <summary>
        /// Method to animate image
        /// </summary>
        public void AnimateImage()
        {
            if (!animations.currentlyAnimating)
            {
                //Begin the animation only once.
                ImageAnimator.Animate(animations.animatedImage, new EventHandler(OnFrameChanged));
                animations.currentlyAnimating = true;
            }
        }

        /// <summary>
        /// On animation form frame change
        /// </summary>
        /// <param name="o">Changed object</param>
        /// <param name="e">Exception</param>
        private void OnFrameChanged(object o, EventArgs e)
        {
            //Force a call to the Paint event handler.
            this.Invalidate();
        }

        /// <summary>
        /// On animation form paint
        /// </summary>
        /// <param name="e">Exception</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            //Begin the animation.
            AnimateImage();

            //Get the next frame ready for rendering.
            ImageAnimator.UpdateFrames();

            //Draw the next frame in the animation.
            e.Graphics.DrawImage(animations.animatedImage, new Point(0, 0));
        }

        /// <summary>
        /// Main animation method to animate image
        /// </summary>
        public static void Start()
        {
            Application.Run(new animateImage());
        }
    }
}

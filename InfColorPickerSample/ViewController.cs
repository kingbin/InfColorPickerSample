using System;

using UIKit;
using InfColorPicker;

namespace InfColorPickerSample
{
    public partial class ViewController : UIViewController
    {
        ColorSelectedDelegate selector;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ChangeColorButton.TouchUpInside += HandleTouchUpInsideWithStrongDelegate;
            selector = new ColorSelectedDelegate(this);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void HandleTouchUpInsideWithStrongDelegate(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
/*
            InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;
            picker.Delegate = selector;
            picker.PresentModallyOverViewController(this);
*/

            InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;
            picker.WeakDelegate = this;
            picker.SourceColor = this.View.BackgroundColor;
            picker.PresentModallyOverViewController(this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

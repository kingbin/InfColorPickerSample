﻿using System.Runtime.InteropServices;

using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace InfColorPicker
{
	static class CFunctions
	{
		// extern float pin (float minValue, float value, float maxValue);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern float pin (float minValue, float value, float maxValue);

		// extern void HSVtoRGB (float h, float s, float v, float *r, float *g, float *b);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void HSVtoRGB (float h, float s, float v, float* r, float* g, float* b);

		// extern void RGBToHSV (float r, float g, float b, float *h, float *s, float *v, BOOL preserveHS);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void RGBToHSV (float r, float g, float b, float* h, float* s, float* v, bool preserveHS);

/*
		// extern CGImageRef createSaturationBrightnessSquareContentImageWithHue (float hue);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe CGImageRef* createSaturationBrightnessSquareContentImageWithHue (float hue);

		// extern CGImageRef createHSVBarContentImage (InfComponentIndex barComponentIndex, float *hsv);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe CGImageRef* createHSVBarContentImage (InfComponentIndex barComponentIndex, float[] hsv);
*/


        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern unsafe CGImage createSaturationBrightnessSquareContentImageWithHue (float hue);

        // extern CGImageRef createHSVBarContentImage (InfComponentIndex barComponentIndex, float *hsv);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern unsafe CGImage createHSVBarContentImage (InfComponentIndex barComponentIndex, float[] hsv);

	}

	public enum InfComponentIndex : uint
	{
		Hue = 0,
		Saturation = 1,
		Brightness = 2
	}
}

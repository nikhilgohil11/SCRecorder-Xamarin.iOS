using System;
using AVFoundation;

namespace SCGRecorderBinding
{
	public enum SCWatermarkAnchorLocation : ulong /* nuint */ {
		SCWatermarkAnchorLocationTopLeft,
		SCWatermarkAnchorLocationTopRight,
		SCWatermarkAnchorLocationBottomLeft,
		SCWatermarkAnchorLocationBottomRight
	}

	public enum SCContextType : long /* nint */ {
		Auto,
		Metal,
		CoreGraphics,
		EAGL,
		Default,
		CPU
	}

	public enum SCFlashMode : long /* nint */ {
		Off = AVCaptureFlashMode.Off,
		On = AVCaptureFlashMode.On,
		Auto = AVCaptureFlashMode.Auto,
		Light
	}
}


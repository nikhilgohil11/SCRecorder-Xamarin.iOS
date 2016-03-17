namespace SCGRecorder {

	[Native]
	public enum <unamed-C-enum> : ulong /* nuint */ {
		SCWatermarkAnchorLocationTopLeft,
		SCWatermarkAnchorLocationTopRight,
		SCWatermarkAnchorLocationBottomLeft,
		SCWatermarkAnchorLocationBottomRight
	}

	[Native]
	public enum SCContextType : long /* nint */ {
		Auto,
		Metal,
		CoreGraphics,
		EAGL,
		Default,
		CPU
	}

	[Native]
	public enum SCFlashMode : long /* nint */ {
		Off = AVCaptureFlashModeOff,
		On = AVCaptureFlashModeOn,
		Auto = AVCaptureFlashModeAuto,
		Light
	}
}

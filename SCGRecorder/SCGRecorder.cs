namespace SCGRecorder {

	// @interface SCRecordSessionSegment : NSObject
	[BaseType (typeof (NSObject))]
	interface SCRecordSessionSegment {

		// -(instancetype)initWithURL:(NSURL *)url info:(NSDictionary *)info;
		[Export ("initWithURL:info:")]
		IntPtr Constructor (NSUrl url, NSDictionary info);

		// -(instancetype)initWithDictionaryRepresentation:(NSDictionary *)dictionary directory:(NSString *)directory;
		[Export ("initWithDictionaryRepresentation:directory:")]
		IntPtr Constructor (NSDictionary dictionary, string directory);

		// @property (nonatomic, strong) NSURL * url;
		[Export ("url", ArgumentSemantic.Retain)]
		NSUrl Url { get; set; }

		// @property (readonly, nonatomic) AVAsset * asset;
		[Export ("asset")]
		AVAsset Asset { get; }

		// @property (readonly, nonatomic) CMTime duration;
		[Export ("duration")]
		 Duration { get; }

		// @property (readonly, nonatomic) UIImage * thumbnail;
		[Export ("thumbnail")]
		UIImage Thumbnail { get; }

		// @property (readonly, nonatomic) UIImage * lastImage;
		[Export ("lastImage")]
		UIImage LastImage { get; }

		// @property (readonly, nonatomic) float frameRate;
		[Export ("frameRate")]
		float FrameRate { get; }

		// @property (readonly, nonatomic) NSDictionary * info;
		[Export ("info")]
		NSDictionary Info { get; }

		// @property (readonly, nonatomic) BOOL fileUrlExists;
		[Export ("fileUrlExists")]
		bool FileUrlExists { get; }

		// -(void)deleteFile;
		[Export ("deleteFile")]
		void DeleteFile ();

		// -(NSDictionary *)dictionaryRepresentation;
		[Export ("dictionaryRepresentation")]
		NSDictionary DictionaryRepresentation ();

		// +(NSURL *)segmentURLForFilename:(NSString *)filename andDirectory:(NSString *)directory;
		[Static, Export ("segmentURLForFilename:andDirectory:")]
		NSUrl SegmentURLForFilename (string filename, string directory);

		// +(SCRecordSessionSegment *)segmentWithURL:(NSURL *)url info:(NSDictionary *)info;
		[Static, Export ("segmentWithURL:info:")]
		SCRecordSessionSegment SegmentWithURL (NSUrl url, NSDictionary info);
	}

	// @interface SCRecordSession : NSObject
	[BaseType (typeof (NSObject))]
	interface SCRecordSession {

		// -(instancetype)initWithDictionaryRepresentation:(NSDictionary *)dictionaryRepresentation;
		[Export ("initWithDictionaryRepresentation:")]
		IntPtr Constructor (NSDictionary dictionaryRepresentation);

		// @property (readonly, nonatomic) NSString * identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic) NSDate * date;
		[Export ("date")]
		NSDate Date { get; }

		// @property (copy, nonatomic) NSString * segmentsDirectory;
		[Export ("segmentsDirectory")]
		string SegmentsDirectory { get; set; }

		// @property (copy, nonatomic) NSString * fileType;
		[Export ("fileType")]
		string FileType { get; set; }

		// @property (copy, nonatomic) NSString * fileExtension;
		[Export ("fileExtension")]
		string FileExtension { get; set; }

		// @property (readonly, nonatomic) NSURL * outputUrl;
		[Export ("outputUrl")]
		NSUrl OutputUrl { get; }

		// @property (readonly, nonatomic) NSArray * segments;
		[Export ("segments")]
		NSObject [] Segments { get; }

		// @property (readonly, nonatomic) CMTime duration;
		[Export ("duration")]
		 Duration { get; }

		// @property (readonly, atomic) CMTime segmentsDuration;
		[Export ("segmentsDuration")]
		 SegmentsDuration { get; }

		// @property (readonly, atomic) CMTime currentSegmentDuration;
		[Export ("currentSegmentDuration")]
		 CurrentSegmentDuration { get; }

		// @property (readonly, nonatomic) BOOL recordSegmentBegan;
		[Export ("recordSegmentBegan")]
		bool RecordSegmentBegan { get; }

		// @property (readonly, nonatomic, weak) SCRecorder * recorder;
		[Export ("recorder", ArgumentSemantic.Weak)]
		SCRecorder Recorder { get; }

		// +(instancetype)recordSession;
		[Static, Export ("recordSession")]
		SCRecordSession RecordSession ();

		// +(instancetype)recordSession:(NSDictionary *)dictionaryRepresentation;
		[Static, Export ("recordSession:")]
		SCRecordSession RecordSession (NSDictionary dictionaryRepresentation);

		// -(void)dispatchSyncOnSessionQueue:(void (^)())block;
		[Export ("dispatchSyncOnSessionQueue:")]
		void DispatchSyncOnSessionQueue (Action block);

		// -(void)removeSegment:(SCRecordSessionSegment *)segment;
		[Export ("removeSegment:")]
		void RemoveSegment (SCRecordSessionSegment segment);

		// -(void)removeSegmentAtIndex:(NSInteger)segmentIndex deleteFile:(BOOL)deleteFile;
		[Export ("removeSegmentAtIndex:deleteFile:")]
		void RemoveSegmentAtIndex (nint segmentIndex, bool deleteFile);

		// -(void)addSegment:(SCRecordSessionSegment *)segment;
		[Export ("addSegment:")]
		void AddSegment (SCRecordSessionSegment segment);

		// -(void)insertSegment:(SCRecordSessionSegment *)segment atIndex:(NSInteger)segmentIndex;
		[Export ("insertSegment:atIndex:")]
		void InsertSegment (SCRecordSessionSegment segment, nint segmentIndex);

		// -(void)removeAllSegments;
		[Export ("removeAllSegments")]
		void RemoveAllSegments ();

		// -(void)removeAllSegments:(BOOL)deleteFiles;
		[Export ("removeAllSegments:")]
		void RemoveAllSegments (bool deleteFiles);

		// -(void)removeLastSegment;
		[Export ("removeLastSegment")]
		void RemoveLastSegment ();

		// -(void)cancelSession:(void (^)())completionHandler;
		[Export ("cancelSession:")]
		void CancelSession (Action completionHandler);

		// -(AVAssetExportSession *)mergeSegmentsUsingPreset:(NSString *)exportSessionPreset completionHandler:(void (^)(NSURL *, NSError *))completionHandler;
		[Export ("mergeSegmentsUsingPreset:completionHandler:")]
		AVAssetExportSession MergeSegmentsUsingPreset (string exportSessionPreset, Action<NSUrl, NSError> completionHandler);

		// -(AVAsset *)assetRepresentingSegments;
		[Export ("assetRepresentingSegments")]
		AVAsset AssetRepresentingSegments ();

		// -(AVPlayerItem *)playerItemRepresentingSegments;
		[Export ("playerItemRepresentingSegments")]
		AVPlayerItem PlayerItemRepresentingSegments ();

		// -(void)appendSegmentsToComposition:(AVMutableComposition *)composition;
		[Export ("appendSegmentsToComposition:")]
		void AppendSegmentsToComposition (AVMutableComposition composition);

		// -(void)appendSegmentsToComposition:(AVMutableComposition *)composition audioMix:(AVMutableAudioMix *)audioMix;
		[Export ("appendSegmentsToComposition:audioMix:")]
		void AppendSegmentsToComposition (AVMutableComposition composition, AVMutableAudioMix audioMix);

		// -(NSDictionary *)dictionaryRepresentation;
		[Export ("dictionaryRepresentation")]
		NSDictionary DictionaryRepresentation ();

		// -(void)deinitialize;
		[Export ("deinitialize")]
		void Deinitialize ();

		// -(void)beginSegment:(NSError **)error;
		[Export ("beginSegment:")]
		void BeginSegment (out NSError error);

		// -(BOOL)endSegmentWithInfo:(NSDictionary *)info completionHandler:(void (^)(SCRecordSessionSegment *, NSError *))completionHandler;
		[Export ("endSegmentWithInfo:completionHandler:")]
		bool EndSegmentWithInfo (NSDictionary info, Action<SCRecordSessionSegment, NSError> completionHandler);
	}

	// @interface SCFilterAnimation : NSObject <NSCoding>
	[BaseType (typeof (NSObject))]
	interface SCFilterAnimation : NSCoding {

		// @property (readonly, nonatomic) NSString * key;
		[Export ("key")]
		string Key { get; }

		// @property (readonly, nonatomic) id startValue;
		[Export ("startValue")]
		NSObject StartValue { get; }

		// @property (readonly, nonatomic) id endValue;
		[Export ("endValue")]
		NSObject EndValue { get; }

		// @property (readonly, nonatomic) CFTimeInterval startTime;
		[Export ("startTime")]
		double StartTime { get; }

		// @property (readonly, nonatomic) CFTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// -(id)valueAtTime:(CFTimeInterval)time;
		[Export ("valueAtTime:")]
		NSObject ValueAtTime (double time);

		// -(BOOL)hasValueAtTime:(CFTimeInterval)time;
		[Export ("hasValueAtTime:")]
		bool HasValueAtTime (double time);

		// +(SCFilterAnimation *)filterAnimationForParameterKey:(NSString *)key startValue:(id)startValue endValue:(id)endValue startTime:(CFTimeInterval)startTime duration:(CFTimeInterval)duration;
		[Static, Export ("filterAnimationForParameterKey:startValue:endValue:startTime:duration:")]
		SCFilterAnimation FilterAnimationForParameterKey (string key, NSObject startValue, NSObject endValue, double startTime, double duration);
	}

	// @protocol SCFilterDelegate <NSObject, NSCopying>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCFilterDelegate : NSCopying {

		// @required -(void)filter:(SCFilter *)filter didChangeParameter:(NSString *)parameterKey;
		[Export ("filter:didChangeParameter:")]
		[Abstract]
		void DidChangeParameter (SCFilter filter, string parameterKey);

		// @required -(void)filter:(SCFilter *)filter willProcessImage:(CIImage *)image atTime:(CFTimeInterval)time;
		[Export ("filter:willProcessImage:atTime:")]
		[Abstract]
		void WillProcessImage (SCFilter filter, CIImage image, double time);

		// @required -(void)filterDidResetToDefaults:(SCFilter *)filter;
		[Export ("filterDidResetToDefaults:")]
		[Abstract]
		void FilterDidResetToDefaults (SCFilter filter);
	}

	// @interface SCFilter : NSObject <NSCoding>
	[BaseType (typeof (NSObject))]
	interface SCFilter : NSCoding {

		// -(instancetype)initWithCIFilter:(CIFilter *)filter;
		[Export ("initWithCIFilter:")]
		IntPtr Constructor (CIFilter filter);

		// @property (readonly, nonatomic) CIFilter * CIFilter;
		[Export ("CIFilter")]
		CIFilter CIFilter { get; }

		// @property (nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		// @property (assign, nonatomic) BOOL enabled;
		[Export ("enabled", ArgumentSemantic.UnsafeUnretained)]
		bool Enabled { get; set; }

		// @property (readonly, nonatomic) BOOL isEmpty;
		[Export ("isEmpty")]
		bool IsEmpty { get; }

		// @property (readonly, nonatomic) NSArray * subFilters;
		[Export ("subFilters")]
		NSObject [] SubFilters { get; }

		// @property (readonly, nonatomic) NSArray * animations;
		[Export ("animations")]
		NSObject [] Animations { get; }

		// @property (nonatomic, weak) id<SCFilterDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCFilterDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCFilterDelegate Delegate { get; set; }

		// -(id)parameterValueForKey:(NSString *)key;
		[Export ("parameterValueForKey:")]
		NSObject ParameterValueForKey (string key);

		// -(void)setParameterValue:(id)value forKey:(NSString *)key;
		[Export ("setParameterValue:forKey:")]
		void SetParameterValue (NSObject value, string key);

		// -(void)addAnimation:(SCFilterAnimation *)animation;
		[Export ("addAnimation:")]
		void AddAnimation (SCFilterAnimation animation);

		// -(SCFilterAnimation *)addAnimationForParameterKey:(NSString *)key startValue:(id)startValue endValue:(id)endValue startTime:(CFTimeInterval)startTime duration:(CFTimeInterval)duration;
		[Export ("addAnimationForParameterKey:startValue:endValue:startTime:duration:")]
		SCFilterAnimation AddAnimationForParameterKey (string key, NSObject startValue, NSObject endValue, double startTime, double duration);

		// -(void)removeAnimation:(SCFilterAnimation *)animation;
		[Export ("removeAnimation:")]
		void RemoveAnimation (SCFilterAnimation animation);

		// -(void)removeAllAnimations;
		[Export ("removeAllAnimations")]
		void RemoveAllAnimations ();

		// -(void)resetToDefaults;
		[Export ("resetToDefaults")]
		void ResetToDefaults ();

		// -(void)addSubFilter:(SCFilter *)subFilter;
		[Export ("addSubFilter:")]
		void AddSubFilter (SCFilter subFilter);

		// -(void)removeSubFilter:(SCFilter *)subFilter;
		[Export ("removeSubFilter:")]
		void RemoveSubFilter (SCFilter subFilter);

		// -(void)removeSubFilterAtIndex:(NSInteger)index;
		[Export ("removeSubFilterAtIndex:")]
		void RemoveSubFilterAtIndex (nint index);

		// -(void)insertSubFilter:(SCFilter *)subFilter atIndex:(NSInteger)index;
		[Export ("insertSubFilter:atIndex:")]
		void InsertSubFilter (SCFilter subFilter, nint index);

		// -(void)writeToFile:(NSURL *)fileUrl error:(NSError **)error;
		[Export ("writeToFile:error:")]
		void WriteToFile (NSUrl fileUrl, out NSError error);

		// -(CIImage *)imageByProcessingImage:(CIImage *)image;
		[Export ("imageByProcessingImage:")]
		CIImage ImageByProcessingImage (CIImage image);

		// -(CIImage *)imageByProcessingImage:(CIImage *)image atTime:(CFTimeInterval)time;
		[Export ("imageByProcessingImage:atTime:")]
		CIImage ImageByProcessingImage (CIImage image, double time);

		// +(SCFilter *)emptyFilter;
		[Static, Export ("emptyFilter")]
		SCFilter EmptyFilter ();

		// +(SCFilter *)filterWithCIFilter:(CIFilter *)CIFilter;
		[Static, Export ("filterWithCIFilter:")]
		SCFilter FilterWithCIFilter (CIFilter CIFilter);

		// +(SCFilter *)filterWithCIFilterName:(NSString *)name;
		[Static, Export ("filterWithCIFilterName:")]
		SCFilter FilterWithCIFilterName (string name);

		// +(SCFilter *)filterWithAffineTransform:(CGAffineTransform)affineTransform;
		[Static, Export ("filterWithAffineTransform:")]
		SCFilter FilterWithAffineTransform (CGAffineTransform affineTransform);

		// +(SCFilter *)filterWithData:(NSData *)data;
		[Static, Export ("filterWithData:")]
		SCFilter FilterWithData (NSData data);

		// +(SCFilter *)filterWithData:(NSData *)data error:(NSError **)error;
		[Static, Export ("filterWithData:error:")]
		SCFilter FilterWithData (NSData data, out NSError error);

		// +(SCFilter *)filterWithContentsOfURL:(NSURL *)url;
		[Static, Export ("filterWithContentsOfURL:")]
		SCFilter FilterWithContentsOfURL (NSUrl url);

		// +(SCFilter *)filterWithFilters:(NSArray *)filters;
		[Static, Export ("filterWithFilters:")]
		SCFilter FilterWithFilters (NSObject [] filters);

		// +(SCFilter *)filterWithCIImage:(CIImage *)image;
		[Static, Export ("filterWithCIImage:")]
		SCFilter FilterWithCIImage (CIImage image);
	}

	// @interface SCMediaTypeConfiguration : NSObject
	[BaseType (typeof (NSObject))]
	interface SCMediaTypeConfiguration {

		// @property (assign, nonatomic) BOOL enabled;
		[Export ("enabled", ArgumentSemantic.UnsafeUnretained)]
		bool Enabled { get; set; }

		// @property (assign, nonatomic) BOOL shouldIgnore;
		[Export ("shouldIgnore", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldIgnore { get; set; }

		// @property (assign, nonatomic) UInt64 bitrate;
		[Export ("bitrate", ArgumentSemantic.UnsafeUnretained)]
		ulong Bitrate { get; set; }

		// @property (copy, nonatomic) NSDictionary * options;
		[Export ("options", ArgumentSemantic.Copy)]
		NSDictionary Options { get; set; }

		// @property (copy, nonatomic) NSString * preset;
		[Export ("preset")]
		string Preset { get; set; }

		// -(NSDictionary *)createAssetWriterOptionsUsingSampleBuffer:(CMSampleBufferRef)sampleBuffer;
		[Export ("createAssetWriterOptionsUsingSampleBuffer:")]
		NSDictionary CreateAssetWriterOptionsUsingSampleBuffer (opaqueCMSampleBuffer sampleBuffer);
	}

	// @protocol SCVideoOverlay <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCVideoOverlay {

		// @optional -(void)updateWithVideoTime:(NSTimeInterval)time;
		[Export ("updateWithVideoTime:")]
		void UpdateWithVideoTime (double time);
	}

	// @interface SCVideoConfiguration : SCMediaTypeConfiguration
	[BaseType (typeof (SCMediaTypeConfiguration))]
	interface SCVideoConfiguration {

		// @property (assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.UnsafeUnretained)]
		CGSize Size { get; set; }

		// @property (assign, nonatomic) CGAffineTransform affineTransform;
		[Export ("affineTransform", ArgumentSemantic.UnsafeUnretained)]
		CGAffineTransform AffineTransform { get; set; }

		// @property (copy, nonatomic) NSString * codec;
		[Export ("codec")]
		string Codec { get; set; }

		// @property (copy, nonatomic) NSString * scalingMode;
		[Export ("scalingMode")]
		string ScalingMode { get; set; }

		// @property (assign, nonatomic) CMTimeScale maxFrameRate;
		[Export ("maxFrameRate", ArgumentSemantic.UnsafeUnretained)]
		int MaxFrameRate { get; set; }

		// @property (assign, nonatomic) CGFloat timeScale;
		[Export ("timeScale", ArgumentSemantic.UnsafeUnretained)]
		nfloat TimeScale { get; set; }

		// @property (assign, nonatomic) BOOL sizeAsSquare;
		[Export ("sizeAsSquare", ArgumentSemantic.UnsafeUnretained)]
		bool SizeAsSquare { get; set; }

		// @property (assign, nonatomic) BOOL shouldKeepOnlyKeyFrames;
		[Export ("shouldKeepOnlyKeyFrames", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldKeepOnlyKeyFrames { get; set; }

		// @property (nonatomic, strong) SCFilter * filter;
		[Export ("filter", ArgumentSemantic.Retain)]
		SCFilter Filter { get; set; }

		// @property (assign, nonatomic) BOOL keepInputAffineTransform;
		[Export ("keepInputAffineTransform", ArgumentSemantic.UnsafeUnretained)]
		bool KeepInputAffineTransform { get; set; }

		// @property (nonatomic, strong) AVVideoComposition * composition;
		[Export ("composition", ArgumentSemantic.Retain)]
		AVVideoComposition Composition { get; set; }

		// @property (nonatomic, strong) UIImage * watermarkImage;
		[Export ("watermarkImage", ArgumentSemantic.Retain)]
		UIImage WatermarkImage { get; set; }

		// @property (assign, nonatomic) CGRect watermarkFrame;
		[Export ("watermarkFrame", ArgumentSemantic.UnsafeUnretained)]
		CGRect WatermarkFrame { get; set; }

		// @property (assign, nonatomic) CGSize bufferSize;
		[Export ("bufferSize", ArgumentSemantic.UnsafeUnretained)]
		CGSize BufferSize { get; set; }

		// @property (assign, nonatomic) NSString * profileLevel;
		[Export ("profileLevel", ArgumentSemantic.UnsafeUnretained)]
		string ProfileLevel { get; set; }

		// @property (nonatomic, strong) UIView<SCVideoOverlay> * overlay;
		[Export ("overlay", ArgumentSemantic.Retain)]
		UIView Overlay { get; set; }

		// @property (assign, nonatomic) SCWatermarkAnchorLocation watermarkAnchorLocation;
		[Export ("watermarkAnchorLocation", ArgumentSemantic.UnsafeUnretained)]
		 WatermarkAnchorLocation { get; set; }

		// -(NSDictionary *)createAssetWriterOptionsWithVideoSize:(CGSize)videoSize;
		[Export ("createAssetWriterOptionsWithVideoSize:")]
		NSDictionary CreateAssetWriterOptionsWithVideoSize (CGSize videoSize);
	}

	// @interface SCAudioConfiguration : SCMediaTypeConfiguration
	[BaseType (typeof (SCMediaTypeConfiguration))]
	interface SCAudioConfiguration {

		// @property (assign, nonatomic) int sampleRate;
		[Export ("sampleRate", ArgumentSemantic.UnsafeUnretained)]
		int SampleRate { get; set; }

		// @property (assign, nonatomic) int channelsCount;
		[Export ("channelsCount", ArgumentSemantic.UnsafeUnretained)]
		int ChannelsCount { get; set; }

		// @property (assign, nonatomic) int format;
		[Export ("format", ArgumentSemantic.UnsafeUnretained)]
		int Format { get; set; }

		// @property (nonatomic, strong) AVAudioMix * audioMix;
		[Export ("audioMix", ArgumentSemantic.Retain)]
		AVAudioMix AudioMix { get; set; }
	}

	// @interface SCContext : NSObject
	[BaseType (typeof (NSObject))]
	interface SCContext {

		// @property (readonly, nonatomic) CIContext * CIContext;
		[Export ("CIContext")]
		CIContext CIContext { get; }

		// @property (readonly, nonatomic) SCContextType type;
		[Export ("type")]
		SCContextType Type { get; }

		// @property (readonly, nonatomic) EAGLContext * EAGLContext;
		[Export ("EAGLContext")]
		EAGLContext EAGLContext { get; }

		// @property (readonly, nonatomic) id<MTLDevice> MTLDevice;
		[Export ("MTLDevice")]
		MTLDevice MTLDevice { get; }

		// @property (readonly, nonatomic) CGContextRef CGContext;
		[Export ("CGContext")]
		CGContext CGContext { get; }

		// +(SCContext *)contextWithType:(SCContextType)type options:(NSDictionary *)options;
		[Static, Export ("contextWithType:options:")]
		SCContext ContextWithType (SCContextType type, NSDictionary options);

		// +(BOOL)supportsType:(SCContextType)contextType;
		[Static, Export ("supportsType:")]
		bool SupportsType (SCContextType contextType);

		// +(SCContextType)suggestedContextType;
		[Static, Export ("suggestedContextType")]
		SCContextType SuggestedContextType ();
	}

	// @protocol SCAssetExportSessionDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCAssetExportSessionDelegate {

		// @optional -(void)assetExportSessionDidProgress:(SCAssetExportSession *)assetExportSession;
		[Export ("assetExportSessionDidProgress:")]
		void AssetExportSessionDidProgress (SCAssetExportSession assetExportSession);

		// @optional -(BOOL)assetExportSession:(SCAssetExportSession *)assetExportSession shouldReginReadWriteOnInput:(AVAssetWriterInput *)writerInput fromOutput:(AVAssetReaderOutput *)output;
		[Export ("assetExportSession:shouldReginReadWriteOnInput:fromOutput:")]
		bool ShouldReginReadWriteOnInput (SCAssetExportSession assetExportSession, AVAssetWriterInput writerInput, AVAssetReaderOutput output);

		// @optional -(BOOL)assetExportSessionNeedsInputPixelBufferAdaptor:(SCAssetExportSession *)assetExportSession;
		[Export ("assetExportSessionNeedsInputPixelBufferAdaptor:")]
		bool AssetExportSessionNeedsInputPixelBufferAdaptor (SCAssetExportSession assetExportSession);
	}

	// @interface SCAssetExportSession : NSObject
	[BaseType (typeof (NSObject))]
	interface SCAssetExportSession {

		// -(instancetype)initWithAsset:(AVAsset *)inputAsset;
		[Export ("initWithAsset:")]
		IntPtr Constructor (AVAsset inputAsset);

		// @property (nonatomic, strong) AVAsset * inputAsset;
		[Export ("inputAsset", ArgumentSemantic.Retain)]
		AVAsset InputAsset { get; set; }

		// @property (nonatomic, strong) NSURL * outputUrl;
		[Export ("outputUrl", ArgumentSemantic.Retain)]
		NSUrl OutputUrl { get; set; }

		// @property (nonatomic, strong) NSString * outputFileType;
		[Export ("outputFileType", ArgumentSemantic.Retain)]
		string OutputFileType { get; set; }

		// @property (assign, nonatomic) SCContextType contextType;
		[Export ("contextType", ArgumentSemantic.UnsafeUnretained)]
		SCContextType ContextType { get; set; }

		// @property (readonly, nonatomic) SCVideoConfiguration * videoConfiguration;
		[Export ("videoConfiguration")]
		SCVideoConfiguration VideoConfiguration { get; }

		// @property (readonly, nonatomic) SCAudioConfiguration * audioConfiguration;
		[Export ("audioConfiguration")]
		SCAudioConfiguration AudioConfiguration { get; }

		// @property (readonly, nonatomic) NSError * error;
		[Export ("error")]
		NSError Error { get; }

		// @property (readonly, atomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { get; }

		// @property (assign, nonatomic) CMTimeRange timeRange;
		[Export ("timeRange", ArgumentSemantic.UnsafeUnretained)]
		 TimeRange { get; set; }

		// @property (assign, nonatomic) BOOL translatesFilterIntoComposition;
		[Export ("translatesFilterIntoComposition", ArgumentSemantic.UnsafeUnretained)]
		bool TranslatesFilterIntoComposition { get; set; }

		// @property (assign, nonatomic) BOOL shouldOptimizeForNetworkUse;
		[Export ("shouldOptimizeForNetworkUse", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldOptimizeForNetworkUse { get; set; }

		// @property (readonly, nonatomic) float progress;
		[Export ("progress")]
		float Progress { get; }

		// @property (nonatomic, weak) id<SCAssetExportSessionDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCAssetExportSessionDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCAssetExportSessionDelegate Delegate { get; set; }

		// -(void)cancelExport;
		[Export ("cancelExport")]
		void CancelExport ();

		// -(void)exportAsynchronouslyWithCompletionHandler:(void (^)())completionHandler;
		[Export ("exportAsynchronouslyWithCompletionHandler:")]
		void ExportAsynchronouslyWithCompletionHandler (Action completionHandler);
	}

	// @interface SCImageView : UIView
	[BaseType (typeof (UIView))]
	interface SCImageView {

		// @property (assign, nonatomic) SCContextType contextType;
		[Export ("contextType", ArgumentSemantic.UnsafeUnretained)]
		SCContextType ContextType { get; set; }

		// @property (nonatomic, strong) SCContext * context;
		[Export ("context", ArgumentSemantic.Retain)]
		SCContext Context { get; set; }

		// @property (nonatomic, strong) CIImage * CIImage;
		[Export ("CIImage", ArgumentSemantic.Retain)]
		CIImage CIImage { get; set; }

		// @property (assign, nonatomic) CFTimeInterval CIImageTime;
		[Export ("CIImageTime", ArgumentSemantic.UnsafeUnretained)]
		double CIImageTime { get; set; }

		// @property (assign, nonatomic) CGAffineTransform preferredCIImageTransform;
		[Export ("preferredCIImageTransform", ArgumentSemantic.UnsafeUnretained)]
		CGAffineTransform PreferredCIImageTransform { get; set; }

		// @property (assign, nonatomic) BOOL scaleAndResizeCIImageAutomatically;
		[Export ("scaleAndResizeCIImageAutomatically", ArgumentSemantic.UnsafeUnretained)]
		bool ScaleAndResizeCIImageAutomatically { get; set; }

		// -(void)setImageBySampleBuffer:(CMSampleBufferRef)sampleBuffer;
		[Export ("setImageBySampleBuffer:")]
		void SetImageBySampleBuffer (opaqueCMSampleBuffer sampleBuffer);

		// -(void)setImageByUIImage:(UIImage *)image;
		[Export ("setImageByUIImage:")]
		void SetImageByUIImage (UIImage image);

		// -(BOOL)loadContextIfNeeded;
		[Export ("loadContextIfNeeded")]
		bool LoadContextIfNeeded ();

		// -(CIImage *)renderedCIImageInRect:(CGRect)rect;
		[Export ("renderedCIImageInRect:")]
		CIImage RenderedCIImageInRect (CGRect rect);

		// -(UIImage *)renderedUIImageInRect:(CGRect)rect;
		[Export ("renderedUIImageInRect:")]
		UIImage RenderedUIImageInRect (CGRect rect);

		// -(CIImage *)renderedCIImage;
		[Export ("renderedCIImage")]
		CIImage RenderedCIImage ();

		// -(UIImage *)renderedUIImage;
		[Export ("renderedUIImage")]
		UIImage RenderedUIImage ();
	}

	// @interface SCPhotoConfiguration : NSObject
	[BaseType (typeof (NSObject))]
	interface SCPhotoConfiguration {

		// @property (assign, nonatomic) BOOL enabled;
		[Export ("enabled", ArgumentSemantic.UnsafeUnretained)]
		bool Enabled { get; set; }

		// @property (copy, nonatomic) NSDictionary * options;
		[Export ("options", ArgumentSemantic.Copy)]
		NSDictionary Options { get; set; }

		// -(NSDictionary *)createOutputSettings;
		[Export ("createOutputSettings")]
		NSDictionary CreateOutputSettings ();
	}

	// @interface SCRecorderTools : NSObject
	[BaseType (typeof (NSObject))]
	interface SCRecorderTools {

		// +(NSString *)bestCaptureSessionPresetCompatibleWithAllDevices;
		[Static, Export ("bestCaptureSessionPresetCompatibleWithAllDevices")]
		string BestCaptureSessionPresetCompatibleWithAllDevices ();

		// +(NSString *)bestCaptureSessionPresetForDevice:(AVCaptureDevice *)device withMaxSize:(CGSize)maxSize;
		[Static, Export ("bestCaptureSessionPresetForDevice:withMaxSize:")]
		string BestCaptureSessionPresetForDevice (AVCaptureDevice device, CGSize maxSize);

		// +(NSString *)bestCaptureSessionPresetForDevicePosition:(AVCaptureDevicePosition)devicePosition withMaxSize:(CGSize)maxSize;
		[Static, Export ("bestCaptureSessionPresetForDevicePosition:withMaxSize:")]
		string BestCaptureSessionPresetForDevicePosition (AVCaptureDevicePosition devicePosition, CGSize maxSize);

		// +(BOOL)formatInRange:(AVCaptureDeviceFormat *)format frameRate:(CMTimeScale)frameRate;
		[Static, Export ("formatInRange:frameRate:")]
		bool FormatInRange (AVCaptureDeviceFormat format, int frameRate);

		// +(BOOL)formatInRange:(AVCaptureDeviceFormat *)format frameRate:(CMTimeScale)frameRate dimensions:(CMVideoDimensions)videoDimensions;
		[Static, Export ("formatInRange:frameRate:dimensions:")]
		bool FormatInRange (AVCaptureDeviceFormat format, int frameRate,  videoDimensions);

		// +(CMTimeScale)maxFrameRateForFormat:(AVCaptureDeviceFormat *)format minFrameRate:(CMTimeScale)minFrameRate;
		[Static, Export ("maxFrameRateForFormat:minFrameRate:")]
		int MaxFrameRateForFormat (AVCaptureDeviceFormat format, int minFrameRate);

		// +(AVCaptureDevice *)videoDeviceForPosition:(AVCaptureDevicePosition)position;
		[Static, Export ("videoDeviceForPosition:")]
		AVCaptureDevice VideoDeviceForPosition (AVCaptureDevicePosition position);

		// +(NSArray *)assetWriterMetadata;
		[Static, Export ("assetWriterMetadata")]
		NSObject [] AssetWriterMetadata ();
	}

	// @interface SCRecorderTools (NSDate)
	[Category]
	[BaseType (typeof (NSDate))]
	interface SCRecorderTools {

		// -(NSString *)toISO8601;
		[Export ("toISO8601")]
		string ToISO8601 ();

		// +(NSDate *)fromISO8601:(NSString *)iso8601;
		[Static, Export ("fromISO8601:")]
		NSDate FromISO8601 (string iso8601);
	}

	// @protocol SCRecorderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCRecorderDelegate {

		// @optional -(void)recorder:(SCRecorder *)recorder didReconfigureVideoInput:(NSError *)videoInputError;
		[Export ("recorder:didReconfigureVideoInput:")]
		void DidReconfigureVideoInput (SCRecorder recorder, NSError videoInputError);

		// @optional -(void)recorder:(SCRecorder *)recorder didReconfigureAudioInput:(NSError *)audioInputError;
		[Export ("recorder:didReconfigureAudioInput:")]
		void DidReconfigureAudioInput (SCRecorder recorder, NSError audioInputError);

		// @optional -(void)recorder:(SCRecorder *)recorder didChangeFlashMode:(SCFlashMode)flashMode error:(NSError *)error;
		[Export ("recorder:didChangeFlashMode:error:")]
		void DidChangeFlashMode (SCRecorder recorder, SCFlashMode flashMode, NSError error);

		// @optional -(BOOL)recorderShouldAutomaticallyRefocus:(SCRecorder *)recorder;
		[Export ("recorderShouldAutomaticallyRefocus:")]
		bool RecorderShouldAutomaticallyRefocus (SCRecorder recorder);

		// @optional -(void)recorderWillStartFocus:(SCRecorder *)recorder;
		[Export ("recorderWillStartFocus:")]
		void RecorderWillStartFocus (SCRecorder recorder);

		// @optional -(void)recorderDidStartFocus:(SCRecorder *)recorder;
		[Export ("recorderDidStartFocus:")]
		void RecorderDidStartFocus (SCRecorder recorder);

		// @optional -(void)recorderDidEndFocus:(SCRecorder *)recorder;
		[Export ("recorderDidEndFocus:")]
		void RecorderDidEndFocus (SCRecorder recorder);

		// @optional -(void)recorderWillStartAdjustingExposure:(SCRecorder *)recorder;
		[Export ("recorderWillStartAdjustingExposure:")]
		void RecorderWillStartAdjustingExposure (SCRecorder recorder);

		// @optional -(void)recorderDidStartAdjustingExposure:(SCRecorder *)recorder;
		[Export ("recorderDidStartAdjustingExposure:")]
		void RecorderDidStartAdjustingExposure (SCRecorder recorder);

		// @optional -(void)recorderDidEndAdjustingExposure:(SCRecorder *)recorder;
		[Export ("recorderDidEndAdjustingExposure:")]
		void RecorderDidEndAdjustingExposure (SCRecorder recorder);

		// @optional -(void)recorder:(SCRecorder *)recorder didInitializeAudioInSession:(SCRecordSession *)session error:(NSError *)error;
		[Export ("recorder:didInitializeAudioInSession:error:")]
		void DidInitializeAudioInSession (SCRecorder recorder, SCRecordSession session, NSError error);

		// @optional -(void)recorder:(SCRecorder *)recorder didInitializeVideoInSession:(SCRecordSession *)session error:(NSError *)error;
		[Export ("recorder:didInitializeVideoInSession:error:")]
		void DidInitializeVideoInSession (SCRecorder recorder, SCRecordSession session, NSError error);

		// @optional -(void)recorder:(SCRecorder *)recorder didBeginSegmentInSession:(SCRecordSession *)session error:(NSError *)error;
		[Export ("recorder:didBeginSegmentInSession:error:")]
		void DidBeginSegmentInSession (SCRecorder recorder, SCRecordSession session, NSError error);

		// @optional -(void)recorder:(SCRecorder *)recorder didCompleteSegment:(SCRecordSessionSegment *)segment inSession:(SCRecordSession *)session error:(NSError *)error;
		[Export ("recorder:didCompleteSegment:inSession:error:")]
		void DidCompleteSegment (SCRecorder recorder, SCRecordSessionSegment segment, SCRecordSession session, NSError error);

		// @optional -(void)recorder:(SCRecorder *)recorder didAppendVideoSampleBufferInSession:(SCRecordSession *)session;
		[Export ("recorder:didAppendVideoSampleBufferInSession:")]
		void DidAppendVideoSampleBufferInSession (SCRecorder recorder, SCRecordSession session);

		// @optional -(void)recorder:(SCRecorder *)recorder didAppendAudioSampleBufferInSession:(SCRecordSession *)session;
		[Export ("recorder:didAppendAudioSampleBufferInSession:")]
		void DidAppendAudioSampleBufferInSession (SCRecorder recorder, SCRecordSession session);

		// @optional -(void)recorder:(SCRecorder *)recorder didSkipAudioSampleBufferInSession:(SCRecordSession *)session;
		[Export ("recorder:didSkipAudioSampleBufferInSession:")]
		void DidSkipAudioSampleBufferInSession (SCRecorder recorder, SCRecordSession session);

		// @optional -(void)recorder:(SCRecorder *)recorder didSkipVideoSampleBufferInSession:(SCRecordSession *)session;
		[Export ("recorder:didSkipVideoSampleBufferInSession:")]
		void DidSkipVideoSampleBufferInSession (SCRecorder recorder, SCRecordSession session);

		// @optional -(void)recorder:(SCRecorder *)recorder didCompleteSession:(SCRecordSession *)session;
		[Export ("recorder:didCompleteSession:")]
		void DidCompleteSession (SCRecorder recorder, SCRecordSession session);

		// @optional -(NSDictionary *)createSegmentInfoForRecorder:(SCRecorder *)recorder;
		[Export ("createSegmentInfoForRecorder:")]
		NSDictionary CreateSegmentInfoForRecorder (SCRecorder recorder);
	}

	// @interface SCSampleBufferHolder : NSObject
	[BaseType (typeof (NSObject))]
	interface SCSampleBufferHolder {

		// @property (assign, nonatomic) CMSampleBufferRef sampleBuffer;
		[Export ("sampleBuffer", ArgumentSemantic.UnsafeUnretained)]
		opaqueCMSampleBuffer SampleBuffer { get; set; }

		// +(SCSampleBufferHolder *)sampleBufferHolderWithSampleBuffer:(CMSampleBufferRef)sampleBuffer;
		[Static, Export ("sampleBufferHolderWithSampleBuffer:")]
		SCSampleBufferHolder SampleBufferHolderWithSampleBuffer (opaqueCMSampleBuffer sampleBuffer);
	}

	// @protocol SCPlayerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCPlayerDelegate {

		// @optional -(void)player:(SCPlayer *)player didPlay:(CMTime)currentTime loopsCount:(NSInteger)loopsCount;
		[Export ("player:didPlay:loopsCount:")]
		void DidPlay (SCPlayer player,  currentTime, nint loopsCount);

		// @optional -(void)player:(SCPlayer *)player didChangeItem:(AVPlayerItem *)item;
		[Export ("player:didChangeItem:")]
		void DidChangeItem (SCPlayer player, AVPlayerItem item);

		// @optional -(void)player:(SCPlayer *)player didReachEndForItem:(AVPlayerItem *)item;
		[Export ("player:didReachEndForItem:")]
		void DidReachEndForItem (SCPlayer player, AVPlayerItem item);

		// @optional -(void)player:(SCPlayer *)player itemReadyToPlay:(AVPlayerItem *)item;
		[Export ("player:itemReadyToPlay:")]
		void ItemReadyToPlay (SCPlayer player, AVPlayerItem item);

		// @optional -(void)player:(SCPlayer *)player didSetupSCImageView:(SCImageView *)SCImageView;
		[Export ("player:didSetupSCImageView:")]
		void DidSetupSCImageView (SCPlayer player, SCImageView SCImageView);
	}

	// @interface SCPlayer : AVPlayer
	[BaseType (typeof (AVPlayer))]
	interface SCPlayer {

		// @property (nonatomic, weak) id<SCPlayerDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCPlayerDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCPlayerDelegate Delegate { get; set; }

		// @property (assign, nonatomic) BOOL loopEnabled;
		[Export ("loopEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool LoopEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isSendingPlayMessages;
		[Export ("isSendingPlayMessages")]
		bool IsSendingPlayMessages { get; }

		// @property (readonly, nonatomic) BOOL isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// @property (assign, nonatomic) BOOL shouldSuppressPlayerRendering;
		[Export ("shouldSuppressPlayerRendering", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldSuppressPlayerRendering { get; set; }

		// @property (readonly, nonatomic) CMTime itemDuration;
		[Export ("itemDuration")]
		 ItemDuration { get; }

		// @property (readonly, nonatomic) CMTime playableDuration;
		[Export ("playableDuration")]
		 PlayableDuration { get; }

		// @property (assign, nonatomic) BOOL autoRotate;
		[Export ("autoRotate", ArgumentSemantic.UnsafeUnretained)]
		bool AutoRotate { get; set; }

		// @property (nonatomic, strong) SCImageView * SCImageView;
		[Export ("SCImageView", ArgumentSemantic.Retain)]
		SCImageView SCImageView { get; set; }

		// +(SCPlayer *)player;
		[Static, Export ("player")]
		SCPlayer Player ();

		// -(void)beginSendingPlayMessages;
		[Export ("beginSendingPlayMessages")]
		void BeginSendingPlayMessages ();

		// -(void)endSendingPlayMessages;
		[Export ("endSendingPlayMessages")]
		void EndSendingPlayMessages ();

		// -(void)setItemByStringPath:(NSString *)stringPath;
		[Export ("setItemByStringPath:")]
		void SetItemByStringPath (string stringPath);

		// -(void)setItemByUrl:(NSURL *)url;
		[Export ("setItemByUrl:")]
		void SetItemByUrl (NSUrl url);

		// -(void)setItemByAsset:(AVAsset *)asset;
		[Export ("setItemByAsset:")]
		void SetItemByAsset (AVAsset asset);

		// -(void)setItem:(AVPlayerItem *)item;
		[Export ("setItem:")]
		void SetItem (AVPlayerItem item);

		// -(void)setSmoothLoopItemByStringPath:(NSString *)stringPath smoothLoopCount:(NSUInteger)loopCount;
		[Export ("setSmoothLoopItemByStringPath:smoothLoopCount:")]
		void SetSmoothLoopItemByStringPath (string stringPath, nuint loopCount);

		// -(void)setSmoothLoopItemByUrl:(NSURL *)url smoothLoopCount:(NSUInteger)loopCount;
		[Export ("setSmoothLoopItemByUrl:smoothLoopCount:")]
		void SetSmoothLoopItemByUrl (NSUrl url, nuint loopCount);

		// -(void)setSmoothLoopItemByAsset:(AVAsset *)asset smoothLoopCount:(NSUInteger)loopCount;
		[Export ("setSmoothLoopItemByAsset:smoothLoopCount:")]
		void SetSmoothLoopItemByAsset (AVAsset asset, nuint loopCount);
	}

	// @protocol SCVideoPlayerViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCVideoPlayerViewDelegate {

		// @required -(void)videoPlayerViewTappedToPlay:(SCVideoPlayerView *)videoPlayerView;
		[Export ("videoPlayerViewTappedToPlay:")]
		[Abstract]
		void VideoPlayerViewTappedToPlay (SCVideoPlayerView videoPlayerView);

		// @required -(void)videoPlayerViewTappedToPause:(SCVideoPlayerView *)videoPlayerView;
		[Export ("videoPlayerViewTappedToPause:")]
		[Abstract]
		void VideoPlayerViewTappedToPause (SCVideoPlayerView videoPlayerView);
	}

	// @interface SCVideoPlayerView : UIView
	[BaseType (typeof (UIView))]
	interface SCVideoPlayerView {

		// -(instancetype)initWithPlayer:(SCPlayer *)player;
		[Export ("initWithPlayer:")]
		IntPtr Constructor (SCPlayer player);

		// @property (nonatomic, weak) id<SCVideoPlayerViewDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCVideoPlayerViewDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCVideoPlayerViewDelegate Delegate { get; set; }

		// @property (nonatomic, strong) SCPlayer * player;
		[Export ("player", ArgumentSemantic.Retain)]
		SCPlayer Player { get; set; }

		// @property (readonly, nonatomic) AVPlayerLayer * playerLayer;
		[Export ("playerLayer")]
		AVPlayerLayer PlayerLayer { get; }

		// @property (assign, nonatomic) BOOL tapToPauseEnabled;
		[Export ("tapToPauseEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool TapToPauseEnabled { get; set; }

		// +(void)setAutoCreatePlayerWhenNeeded:(BOOL)autoCreatePlayerWhenNeeded;
		[Static, Export ("setAutoCreatePlayerWhenNeeded:")]
		void SetAutoCreatePlayerWhenNeeded (bool autoCreatePlayerWhenNeeded);

		// +(BOOL)autoCreatePlayerWhenNeeded;
		[Static, Export ("autoCreatePlayerWhenNeeded")]
		bool AutoCreatePlayerWhenNeeded ();
	}

	// @interface SCFilterImageView : SCImageView
	[BaseType (typeof (SCImageView))]
	interface SCFilterImageView {

		// @property (nonatomic, strong) SCFilter * filter;
		[Export ("filter", ArgumentSemantic.Retain)]
		SCFilter Filter { get; set; }
	}

	// @protocol SCSwipeableFilterViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCSwipeableFilterViewDelegate {

		// @required -(void)swipeableFilterView:(SCSwipeableFilterView *)swipeableFilterView didScrollToFilter:(SCFilter *)filter;
		[Export ("swipeableFilterView:didScrollToFilter:")]
		[Abstract]
		void DidScrollToFilter (SCSwipeableFilterView swipeableFilterView, SCFilter filter);
	}

	// @interface SCSwipeableFilterView : SCImageView <UIScrollViewDelegate>
	[BaseType (typeof (SCImageView))]
	interface SCSwipeableFilterView : UIScrollViewDelegate {

		// @property (nonatomic, strong) NSArray * filters;
		[Export ("filters", ArgumentSemantic.Retain)]
		NSObject [] Filters { get; set; }

		// @property (nonatomic, strong) SCFilter * selectedFilter;
		[Export ("selectedFilter", ArgumentSemantic.Retain)]
		SCFilter SelectedFilter { get; set; }

		// @property (nonatomic, strong) SCFilter * preprocessingFilter;
		[Export ("preprocessingFilter", ArgumentSemantic.Retain)]
		SCFilter PreprocessingFilter { get; set; }

		// @property (nonatomic, weak) id<SCSwipeableFilterViewDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCSwipeableFilterViewDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCSwipeableFilterViewDelegate Delegate { get; set; }

		// @property (readonly, nonatomic) UIScrollView * selectFilterScrollView;
		[Export ("selectFilterScrollView")]
		UIScrollView SelectFilterScrollView { get; }

		// @property (assign, nonatomic) BOOL refreshAutomaticallyWhenScrolling;
		[Export ("refreshAutomaticallyWhenScrolling", ArgumentSemantic.UnsafeUnretained)]
		bool RefreshAutomaticallyWhenScrolling { get; set; }

		// -(void)scrollToFilter:(SCFilter *)filter animated:(BOOL)animated;
		[Export ("scrollToFilter:animated:")]
		void ScrollToFilter (SCFilter filter, bool animated);
	}

	// @protocol SCRecorderToolsViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SCRecorderToolsViewDelegate {

		// @optional -(void)recorderToolsView:(SCRecorderToolsView *)recorderToolsView didTapToFocusWithGestureRecognizer:(UIGestureRecognizer *)gestureRecognizer;
		[Export ("recorderToolsView:didTapToFocusWithGestureRecognizer:")]
		void DidTapToFocusWithGestureRecognizer (SCRecorderToolsView recorderToolsView, UIGestureRecognizer gestureRecognizer);
	}

	// @interface SCRecorderToolsView : UIView
	[BaseType (typeof (UIView))]
	interface SCRecorderToolsView {

		// @property (nonatomic, weak) id<SCRecorderToolsViewDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCRecorderToolsViewDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCRecorderToolsViewDelegate Delegate { get; set; }

		// @property (nonatomic, strong) SCRecorder * recorder;
		[Export ("recorder", ArgumentSemantic.Retain)]
		SCRecorder Recorder { get; set; }

		// @property (nonatomic, strong) UIImage * outsideFocusTargetImage;
		[Export ("outsideFocusTargetImage", ArgumentSemantic.Retain)]
		UIImage OutsideFocusTargetImage { get; set; }

		// @property (nonatomic, strong) UIImage * insideFocusTargetImage;
		[Export ("insideFocusTargetImage", ArgumentSemantic.Retain)]
		UIImage InsideFocusTargetImage { get; set; }

		// @property (assign, nonatomic) CGSize focusTargetSize;
		[Export ("focusTargetSize", ArgumentSemantic.UnsafeUnretained)]
		CGSize FocusTargetSize { get; set; }

		// @property (assign, nonatomic) CGFloat minZoomFactor;
		[Export ("minZoomFactor", ArgumentSemantic.UnsafeUnretained)]
		nfloat MinZoomFactor { get; set; }

		// @property (assign, nonatomic) CGFloat maxZoomFactor;
		[Export ("maxZoomFactor", ArgumentSemantic.UnsafeUnretained)]
		nfloat MaxZoomFactor { get; set; }

		// @property (assign, nonatomic) BOOL tapToFocusEnabled;
		[Export ("tapToFocusEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool TapToFocusEnabled { get; set; }

		// @property (assign, nonatomic) BOOL doubleTapToResetFocusEnabled;
		[Export ("doubleTapToResetFocusEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool DoubleTapToResetFocusEnabled { get; set; }

		// @property (assign, nonatomic) BOOL pinchToZoomEnabled;
		[Export ("pinchToZoomEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool PinchToZoomEnabled { get; set; }

		// @property (assign, nonatomic) BOOL showsFocusAnimationAutomatically;
		[Export ("showsFocusAnimationAutomatically", ArgumentSemantic.UnsafeUnretained)]
		bool ShowsFocusAnimationAutomatically { get; set; }

		// -(void)showFocusAnimation;
		[Export ("showFocusAnimation")]
		void ShowFocusAnimation ();

		// -(void)hideFocusAnimation;
		[Export ("hideFocusAnimation")]
		void HideFocusAnimation ();
	}

	// @interface SCSaveToCameraRoll (NSURL)
	[Category]
	[BaseType (typeof (NSURL))]
	interface SCSaveToCameraRoll {

		// -(void)saveToCameraRollWithCompletion:(void (^)(NSString *, NSError *))completion;
		[Export ("saveToCameraRollWithCompletion:")]
		void SaveToCameraRollWithCompletion (Action<NSString, NSError> completion);
	}

	// @interface SCSaveToCameraRoll (UIImage)
	[Category]
	[BaseType (typeof (UIImage))]
	interface SCSaveToCameraRoll {

		// -(void)saveToCameraRollWithCompletion:(void (^)(NSError *))completion;
		[Export ("saveToCameraRollWithCompletion:")]
		void SaveToCameraRollWithCompletion (Action<NSError> completion);
	}

	// @interface VideoComposition (SCFilter)
	[Category]
	[BaseType (typeof (SCFilter))]
	interface VideoComposition {

		// -(AVMutableVideoComposition *)videoCompositionWithAsset:(AVAsset *)asset;
		[iOS (9,0)]
		[Export ("videoCompositionWithAsset:")]
		AVMutableVideoComposition VideoCompositionWithAsset (AVAsset asset);
	}

	// @interface SCRecorder : NSObject <AVCaptureAudioDataOutputSampleBufferDelegate, AVCaptureVideoDataOutputSampleBufferDelegate, AVCaptureFileOutputRecordingDelegate>
	[BaseType (typeof (NSObject))]
	interface SCRecorder : AVCaptureAudioDataOutputSampleBufferDelegate, AVCaptureVideoDataOutputSampleBufferDelegate, AVCaptureFileOutputRecordingDelegate {

		// @property (readonly, nonatomic) SCVideoConfiguration * videoConfiguration;
		[Export ("videoConfiguration")]
		SCVideoConfiguration VideoConfiguration { get; }

		// @property (readonly, nonatomic) SCAudioConfiguration * audioConfiguration;
		[Export ("audioConfiguration")]
		SCAudioConfiguration AudioConfiguration { get; }

		// @property (readonly, nonatomic) SCPhotoConfiguration * photoConfiguration;
		[Export ("photoConfiguration")]
		SCPhotoConfiguration PhotoConfiguration { get; }

		// @property (readonly, nonatomic) BOOL videoEnabledAndReady;
		[Export ("videoEnabledAndReady")]
		bool VideoEnabledAndReady { get; }

		// @property (readonly, nonatomic) BOOL audioEnabledAndReady;
		[Export ("audioEnabledAndReady")]
		bool AudioEnabledAndReady { get; }

		// @property (readonly, nonatomic) BOOL isRecording;
		[Export ("isRecording")]
		bool IsRecording { get; }

		// @property (assign, nonatomic) SCFlashMode flashMode;
		[Export ("flashMode", ArgumentSemantic.UnsafeUnretained)]
		SCFlashMode FlashMode { get; set; }

		// @property (readonly, nonatomic) BOOL deviceHasFlash;
		[Export ("deviceHasFlash")]
		bool DeviceHasFlash { get; }

		// @property (assign, nonatomic) AVCaptureDevicePosition device;
		[Export ("device", ArgumentSemantic.UnsafeUnretained)]
		AVCaptureDevicePosition Device { get; set; }

		// @property (assign, nonatomic) CGFloat videoZoomFactor;
		[Export ("videoZoomFactor", ArgumentSemantic.UnsafeUnretained)]
		nfloat VideoZoomFactor { get; set; }

		// @property (assign, nonatomic) CGFloat maxVideoZoomFactor;
		[Export ("maxVideoZoomFactor", ArgumentSemantic.UnsafeUnretained)]
		nfloat MaxVideoZoomFactor { get; set; }

		// @property (assign, nonatomic) BOOL resetZoomOnChangeDevice;
		[Export ("resetZoomOnChangeDevice", ArgumentSemantic.UnsafeUnretained)]
		bool ResetZoomOnChangeDevice { get; set; }

		// @property (readonly, nonatomic) AVCaptureFocusMode focusMode;
		[Export ("focusMode")]
		AVCaptureFocusMode FocusMode { get; }

		// @property (readonly, nonatomic) BOOL isAdjustingFocus;
		[Export ("isAdjustingFocus")]
		bool IsAdjustingFocus { get; }

		// @property (readonly, nonatomic) BOOL isAdjustingExposure;
		[Export ("isAdjustingExposure")]
		bool IsAdjustingExposure { get; }

		// @property (copy, nonatomic) NSString * captureSessionPreset;
		[Export ("captureSessionPreset")]
		string CaptureSessionPreset { get; set; }

		// @property (assign, nonatomic) BOOL automaticallyConfiguresApplicationAudioSession;
		[Export ("automaticallyConfiguresApplicationAudioSession", ArgumentSemantic.UnsafeUnretained)]
		bool AutomaticallyConfiguresApplicationAudioSession { get; set; }

		// @property (readonly, nonatomic) AVCaptureSession * captureSession;
		[Export ("captureSession")]
		AVCaptureSession CaptureSession { get; }

		// @property (readonly, nonatomic) BOOL isPrepared;
		[Export ("isPrepared")]
		bool IsPrepared { get; }

		// @property (readonly, nonatomic) AVCaptureVideoPreviewLayer * previewLayer;
		[Export ("previewLayer")]
		AVCaptureVideoPreviewLayer PreviewLayer { get; }

		// @property (nonatomic, strong) UIView * previewView;
		[Export ("previewView", ArgumentSemantic.Retain)]
		UIView PreviewView { get; set; }

		// @property (nonatomic, strong) SCImageView * SCImageView;
		[Export ("SCImageView", ArgumentSemantic.Retain)]
		SCImageView SCImageView { get; set; }

		// @property (nonatomic, weak) id<SCRecorderDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCRecorderDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCRecorderDelegate Delegate { get; set; }

		// @property (nonatomic, strong) SCRecordSession * session;
		[Export ("session", ArgumentSemantic.Retain)]
		SCRecordSession Session { get; set; }

		// @property (assign, nonatomic) AVCaptureVideoOrientation videoOrientation;
		[Export ("videoOrientation", ArgumentSemantic.UnsafeUnretained)]
		AVCaptureVideoOrientation VideoOrientation { get; set; }

		// @property (assign, nonatomic) AVCaptureVideoStabilizationMode videoStabilizationMode;
		[Export ("videoStabilizationMode", ArgumentSemantic.UnsafeUnretained)]
		AVCaptureVideoStabilizationMode VideoStabilizationMode { get; set; }

		// @property (assign, nonatomic) BOOL autoSetVideoOrientation;
		[Export ("autoSetVideoOrientation", ArgumentSemantic.UnsafeUnretained)]
		bool AutoSetVideoOrientation { get; set; }

		// @property (assign, nonatomic) CMTimeScale frameRate;
		[Export ("frameRate", ArgumentSemantic.UnsafeUnretained)]
		int FrameRate { get; set; }

		// @property (assign, nonatomic) CMTime maxRecordDuration;
		[Export ("maxRecordDuration", ArgumentSemantic.UnsafeUnretained)]
		 MaxRecordDuration { get; set; }

		// @property (assign, nonatomic) BOOL fastRecordMethodEnabled;
		[Export ("fastRecordMethodEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool FastRecordMethodEnabled { get; set; }

		// @property (readonly, nonatomic) CGFloat ratioRecorded;
		[Export ("ratioRecorded")]
		nfloat RatioRecorded { get; }

		// @property (assign, nonatomic) BOOL initializeSessionLazily;
		[Export ("initializeSessionLazily", ArgumentSemantic.UnsafeUnretained)]
		bool InitializeSessionLazily { get; set; }

		// @property (assign, nonatomic) BOOL mirrorOnFrontCamera;
		[Export ("mirrorOnFrontCamera", ArgumentSemantic.UnsafeUnretained)]
		bool MirrorOnFrontCamera { get; set; }

		// @property (assign, nonatomic) BOOL keepMirroringOnWrite;
		[Export ("keepMirroringOnWrite", ArgumentSemantic.UnsafeUnretained)]
		bool KeepMirroringOnWrite { get; set; }

		// @property (readonly, nonatomic) BOOL exposureSupported;
		[Export ("exposureSupported")]
		bool ExposureSupported { get; }

		// @property (readonly, nonatomic) CGPoint exposurePointOfInterest;
		[Export ("exposurePointOfInterest")]
		CGPoint ExposurePointOfInterest { get; }

		// @property (readonly, nonatomic) BOOL focusSupported;
		[Export ("focusSupported")]
		bool FocusSupported { get; }

		// @property (readonly, nonatomic) CGPoint focusPointOfInterest;
		[Export ("focusPointOfInterest")]
		CGPoint FocusPointOfInterest { get; }

		// @property (readonly, nonatomic) BOOL subjectAreaChanged;
		[Export ("subjectAreaChanged")]
		bool SubjectAreaChanged { get; }

		// @property (readonly, nonatomic) NSError * error;
		[Export ("error")]
		NSError Error { get; }

		// @property (readonly, nonatomic) AVCaptureVideoDataOutput * videoOutput;
		[Export ("videoOutput")]
		AVCaptureVideoDataOutput VideoOutput { get; }

		// @property (readonly, nonatomic) AVCaptureAudioDataOutput * audioOutput;
		[Export ("audioOutput")]
		AVCaptureAudioDataOutput AudioOutput { get; }

		// @property (readonly, nonatomic) AVCaptureStillImageOutput * photoOutput;
		[Export ("photoOutput")]
		AVCaptureStillImageOutput PhotoOutput { get; }

		// @property (readonly, nonatomic) dispatch_queue_t sessionQueue;
		[Export ("sessionQueue")]
		DispatchQueue SessionQueue { get; }

		// -(CGFloat)maxVideoZoomFactorForDevice:(AVCaptureDevicePosition)devicePosition;
		[Export ("maxVideoZoomFactorForDevice:")]
		nfloat MaxVideoZoomFactorForDevice (AVCaptureDevicePosition devicePosition);

		// +(SCRecorder *)recorder;
		[Static, Export ("recorder")]
		SCRecorder Recorder ();

		// -(BOOL)prepare:(NSError **)error;
		[Export ("prepare:")]
		bool Prepare (out NSError error);

		// -(void)unprepare;
		[Export ("unprepare")]
		void Unprepare ();

		// -(BOOL)startRunning;
		[Export ("startRunning")]
		bool StartRunning ();

		// -(void)stopRunning;
		[Export ("stopRunning")]
		void StopRunning ();

		// -(void)beginConfiguration;
		[Export ("beginConfiguration")]
		void BeginConfiguration ();

		// -(void)commitConfiguration;
		[Export ("commitConfiguration")]
		void CommitConfiguration ();

		// -(void)switchCaptureDevices;
		[Export ("switchCaptureDevices")]
		void SwitchCaptureDevices ();

		// -(CGPoint)convertToPointOfInterestFromViewCoordinates:(CGPoint)viewCoordinates;
		[Export ("convertToPointOfInterestFromViewCoordinates:")]
		CGPoint ConvertToPointOfInterestFromViewCoordinates (CGPoint viewCoordinates);

		// -(CGPoint)convertPointOfInterestToViewCoordinates:(CGPoint)pointOfInterest;
		[Export ("convertPointOfInterestToViewCoordinates:")]
		CGPoint ConvertPointOfInterestToViewCoordinates (CGPoint pointOfInterest);

		// -(void)autoFocusAtPoint:(CGPoint)point;
		[Export ("autoFocusAtPoint:")]
		void AutoFocusAtPoint (CGPoint point);

		// -(void)continuousFocusAtPoint:(CGPoint)point;
		[Export ("continuousFocusAtPoint:")]
		void ContinuousFocusAtPoint (CGPoint point);

		// -(void)focusCenter;
		[Export ("focusCenter")]
		void FocusCenter ();

		// -(void)refocus;
		[Export ("refocus")]
		void Refocus ();

		// -(void)lockFocus;
		[Export ("lockFocus")]
		void LockFocus ();

		// -(BOOL)setActiveFormatWithFrameRate:(CMTimeScale)frameRate error:(NSError **)error;
		[Export ("setActiveFormatWithFrameRate:error:")]
		bool SetActiveFormatWithFrameRate (int frameRate, out NSError error);

		// -(BOOL)setActiveFormatWithFrameRate:(CMTimeScale)frameRate width:(int)width andHeight:(int)height error:(NSError **)error;
		[Export ("setActiveFormatWithFrameRate:width:andHeight:error:")]
		bool SetActiveFormatWithFrameRate (int frameRate, int width, int height, out NSError error);

		// -(void)record;
		[Export ("record")]
		void Record ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)pause:(void (^)())completionHandler;
		[Export ("pause:")]
		void Pause (Action completionHandler);

		// -(void)capturePhoto:(void (^)(NSError *, UIImage *))completionHandler;
		[Export ("capturePhoto:")]
		void CapturePhoto (Action<NSError, UIImage> completionHandler);

		// -(void)previewViewFrameChanged;
		[Export ("previewViewFrameChanged")]
		void PreviewViewFrameChanged ();

		// -(UIImage *)snapshotOfLastVideoBuffer;
		[Export ("snapshotOfLastVideoBuffer")]
		UIImage SnapshotOfLastVideoBuffer ();

		// +(SCRecorder *)sharedRecorder;
		[Static, Export ("sharedRecorder")]
		SCRecorder SharedRecorder ();

		// +(BOOL)isSessionQueue;
		[Static, Export ("isSessionQueue")]
		bool IsSessionQueue ();
	}

	// @interface SCRecordSessionManager : NSObject
	[BaseType (typeof (NSObject))]
	interface SCRecordSessionManager {

		// -(void)saveRecordSession:(SCRecordSession *)recordSession;
		[Export ("saveRecordSession:")]
		void SaveRecordSession (SCRecordSession recordSession);

		// -(void)removeRecordSession:(SCRecordSession *)recordSession;
		[Export ("removeRecordSession:")]
		void RemoveRecordSession (SCRecordSession recordSession);

		// -(BOOL)isSaved:(SCRecordSession *)recordSession;
		[Export ("isSaved:")]
		bool IsSaved (SCRecordSession recordSession);

		// -(void)removeRecordSessionAtIndex:(NSInteger)index;
		[Export ("removeRecordSessionAtIndex:")]
		void RemoveRecordSessionAtIndex (nint index);

		// -(NSArray *)savedRecordSessions;
		[Export ("savedRecordSessions")]
		NSObject [] SavedRecordSessions ();

		// +(SCRecordSessionManager *)sharedInstance;
		[Static, Export ("sharedInstance")]
		SCRecordSessionManager SharedInstance ();
	}
}

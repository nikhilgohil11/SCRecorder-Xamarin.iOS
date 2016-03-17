//
//  SCAssetExportSession.h
//  SCRecorder
//
//  Created by Simon CORSIN on 14/05/14.
//  Copyright (c) 2014 rFlex. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <AVFoundation/AVFoundation.h>
#import "SCFilter.h"
#import "SCVideoConfiguration.h"
#import "SCAudioConfiguration.h"
#import "SCContext.h"

@class SCAssetExportSession;
@protocol SCAssetExportSessionDelegate <NSObject>

@optional

- (void)assetExportSessionDidProgress:(SCAssetExportSession * )assetExportSession;

- (BOOL)assetExportSession:(SCAssetExportSession * )assetExportSession shouldReginReadWriteOnInput:(AVAssetWriterInput * )writerInput fromOutput:(AVAssetReaderOutput * )output;

- (BOOL)assetExportSessionNeedsInputPixelBufferAdaptor:(SCAssetExportSession * )assetExportSession;

@end

@interface SCAssetExportSession : NSObject

/**
 The input asset to use
 */
@property (strong, nonatomic) AVAsset *  inputAsset;

/**
 The outputUrl to which the asset will be exported
 */
@property (strong, nonatomic) NSURL *  outputUrl;

/**
 The type of file to be written by the export session
 */
@property (strong, nonatomic) NSString *  outputFileType;

/**
 The context type to use for rendering the images through a filter
 */
@property (assign, nonatomic) SCContextType contextType;

/**
 Access the configuration for the video.
 */
@property (readonly, nonatomic) SCVideoConfiguration *  videoConfiguration;

/**
 Access the configuration for the audio.
 */
@property (readonly, nonatomic) SCAudioConfiguration *  audioConfiguration;

/**
 If an error occured during the export, this will contain that error
 */
@property (readonly, nonatomic) NSError *  error;

/**
 Will be set to YES if cancelExport was called
 */
@property (readonly, atomic) BOOL cancelled;

/**
 The timeRange to read from the inputAsset
 */
@property (assign, nonatomic) CMTimeRange timeRange;

/**
 Whether the assetExportSession should automatically translate the filter into an AVVideoComposition.
 This won't be done if a composition has already been set in the videoConfiguration.
 Default is YES
 */
@property (assign, nonatomic) BOOL translatesFilterIntoComposition;

/**
 Indicates whether the movie should be optimized for network use.
 Default is NO
 */
@property (assign, nonatomic) BOOL shouldOptimizeForNetworkUse;

/**
 The current progress
 */
@property (readonly, nonatomic) float progress;

@property (weak, nonatomic)   id<SCAssetExportSessionDelegate> delegate;

- (  instancetype)init;

// Init with the inputAsset
- (  instancetype)initWithAsset:(AVAsset * )inputAsset;

/**
 Cancels exportAsynchronouslyWithCompletionHandler
 */
- (void)cancelExport;

/**
 Starts the asynchronous execution of the export session
 */
- (void)exportAsynchronouslyWithCompletionHandler:(void(^ )())completionHandler;

@end

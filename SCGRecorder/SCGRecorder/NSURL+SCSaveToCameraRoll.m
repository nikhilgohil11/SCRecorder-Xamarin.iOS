//
//  NSURL+SCSaveToCameraRoll.m
//  SCRecorder
//
//  Created by Simon Corsin on 10/10/15.
//  Copyright © 2015 rFlex. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "NSURL+SCSaveToCameraRoll.h"
#import "SCSaveToCameraRollOperation.h"

@implementation NSURL (SCSaveToCameraRoll)

- (void)saveToCameraRollWithCompletion:(void (^)(NSString * path, NSError * error))completion {
    SCSaveToCameraRollOperation *saveToCameraRoll = [SCSaveToCameraRollOperation new];
    [saveToCameraRoll saveVideoURL:self completion:completion];
}

@end

//
//  Haptic.h
//  UnityHaptic
//
//  Created by Christopher Figueroa on 11/29/17.
//  Copyright © 2017 kinifi. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface Haptic : NSObject

@property (nonatomic, strong) UINotificationFeedbackGenerator *notificationFeedback;

@property (nonatomic, strong) UIImpactFeedbackGenerator *notificationImpact;

-(void)PrepareImpact;

-(void)PrepareNotification;

//UIImpact methods
-(void)ImpactLight;

-(void)ImpactMedium;

-(void)ImpactHeavy;

//UInotification methods
-(void)HapticWarning;

-(void)HapticError;

-(void)HapticSuccess;

@end

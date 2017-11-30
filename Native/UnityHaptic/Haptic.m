//
//  Haptic.m
//  UnityHaptic
//
//  Created by Christopher Figueroa on 11/29/17.
//  Copyright © 2017 kinifi. All rights reserved.
//

#import "Haptic.h"
#import <UIKit/UIKit.h>

@implementation Haptic

-(void)PrepareImpact {
    [self.notificationImpact prepare];
}

-(void)PrepareNotification {
    [self.notificationFeedback prepare];
}

//Mark UIImpact

-(void)ImpactLight {
    self.notificationImpact = [[UIImpactFeedbackGenerator alloc] initWithStyle:(UIImpactFeedbackStyleLight)];
    
    [self.notificationImpact impactOccurred];
    _notificationImpact = nil;
}

-(void)ImpactMedium {
    self.notificationImpact = [[UIImpactFeedbackGenerator alloc] initWithStyle:(UIImpactFeedbackStyleMedium)];
    
    [self.notificationImpact impactOccurred];
    _notificationImpact = nil;
}

-(void)ImpactHeavy {
    self.notificationImpact = [[UIImpactFeedbackGenerator alloc] initWithStyle:(UIImpactFeedbackStyleHeavy)];
    
    [self.notificationImpact impactOccurred];
    _notificationImpact = nil;
}

///MARK UINotification

-(void)HapticError {
    self.notificationFeedback = [[UINotificationFeedbackGenerator alloc] init];
    
    [self.notificationFeedback notificationOccurred:(UINotificationFeedbackTypeError)];
    _notificationFeedback = nil;
}

-(void)HapticWarning {
    self.notificationFeedback = [[UINotificationFeedbackGenerator alloc] init];
    
    [self.notificationFeedback notificationOccurred:(UINotificationFeedbackTypeWarning)];
    _notificationFeedback = nil;
}

-(void)HapticSuccess {
    self.notificationFeedback = [[UINotificationFeedbackGenerator alloc] init];
    
    [self.notificationFeedback notificationOccurred:(UINotificationFeedbackTypeSuccess)];
    _notificationFeedback = nil;
}

@end


#pragma mark -
#pragma mark C Methods

#ifdef __cplusplus
extern "C" {
#endif
    
    static Haptic *hapticController = nil;
    
    void Initialize() {
        if(hapticController == nil) {
            hapticController = [[Haptic alloc] init];
            NSLog(@"Init has completed");
        }
        
    }
    
    ///Mark - Prepare Methods
    
    //Mark - notification methods
    
    void hapticSuccess() {
        //we need to prepare since the dev didn't
        [hapticController PrepareNotification];
        [hapticController HapticSuccess];
    }
    
    void hapticWarning() {
        //we need to prepare since the dev didn't
        [hapticController PrepareNotification];
        [hapticController HapticWarning];
    }
    
    void hapticError() {
        //we need to prepare since the dev didn't
        [hapticController PrepareNotification];
        [hapticController HapticError];
    }
    
    ///Mark - impact methods
    
    void impactLight() {
        //we need to prepare since the dev didn't
        [hapticController PrepareImpact];
        [hapticController ImpactLight];
    }
    
    void impactMedium() {
        //we need to prepare since the dev didn't
        [hapticController PrepareImpact];
        [hapticController ImpactMedium];
    }
    
    void impactHeavy() {
        //we need to prepare since the dev didn't
        [hapticController PrepareImpact];
        [hapticController ImpactHeavy];
    }
    
    
#ifdef __cplusplus
}
#endif

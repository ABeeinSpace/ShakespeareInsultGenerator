using System;
using Foundation;
using AppKit;

namespace InsultGenerator
{
    [Register("AppPreferences")]
    public class AppPreferences : NSObject
    {
        #region Computed Properties

        [Export("DefaultTouchBarState")]
        public bool TouchBarState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        #region Constructors
        
        public AppPreferences()
        {
            
        }
        
        #endregion
    }
}
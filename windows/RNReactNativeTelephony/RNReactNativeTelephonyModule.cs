using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNReactNativeTelephony
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeTelephonyModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeTelephonyModule"/>.
        /// </summary>
        internal RNReactNativeTelephonyModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeTelephony";
            }
        }
    }
}

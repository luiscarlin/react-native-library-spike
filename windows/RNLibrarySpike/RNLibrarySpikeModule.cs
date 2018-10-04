using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Library.Spike.RNLibrarySpike
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLibrarySpikeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLibrarySpikeModule"/>.
        /// </summary>
        internal RNLibrarySpikeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLibrarySpike";
            }
        }
    }
}

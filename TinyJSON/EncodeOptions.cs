﻿using System;


namespace TinyJSON
{
    [Flags]
    public enum EncodeOptions
    {
        /// <summary>
        /// Does not use any special logic when encoding.
        /// </summary>
        None = 0,
        /// <summary>
        /// The encoders output will be formatted to be more human readable. 
        /// </summary>
        PrettyPrint = 1 << 1,

        /// <summary>
        /// Tells the encoder to ignore writing TypeHints. 
        /// </summary>
        NoTypeHints = 1 << 2,

        /// <summary>
        /// By default private variables are not encoded and have to be encoded by
        /// putting the <see cref="ExcludeAttribute"/> on every one. You can skip this
        /// and improve encoding time by setting private variables to be encoded by default.
        /// </summary>
        EncodePrivateVariables = 1 << 3,

        /// <summary>
        /// If you want to encode objects faster you can disable the reflection 
        /// look up for Attributes. This will ignore all attributes in the class
        /// being decoded
        /// </summary>
        IgnoreAttributes = 1 << 4,


    }
}


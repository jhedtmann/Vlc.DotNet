﻿using System;
using Vlc.DotNet.Core.Interops.Signatures.TheLuggage;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcTheLuggageManager
    {
        public IntPtr GetMediaFromMediaPlayer(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetMediaFromMediaPlayer>().Invoke(mediaPlayerInstance);
        }
    }
}
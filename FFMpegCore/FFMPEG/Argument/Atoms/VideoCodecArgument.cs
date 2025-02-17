﻿using FFMpegCore.FFMPEG.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMpegCore.FFMPEG.Argument
{
    /// <summary>
    /// Represents video codec parameter for NVIDIA hardware processing
    /// </summary>
    public class VideoNVCodecArgument : Argument<VideoCodec>
    {
        public int Bitrate { get; protected set; } = 0;

        public VideoNVCodecArgument()
        {
        }

        public VideoNVCodecArgument(VideoCodec value) : base(value)
        {
        }

        public VideoNVCodecArgument(VideoCodec value, int bitrate) : base(value)
        {
            Bitrate = bitrate;
        }

        /// <summary>
        /// String representation of the argument for intel hardware proccessing
        /// </summary>
        /// <returns>String representation of the argument</returns>
        public override string GetStringValue()
        {
            return ArgumentStringifier.NVVideo(Value);
        }
    }

    /// <summary>
    /// Represents video codec parameter
    /// </summary>
    public class VideoIntelCodecArgument : Argument<VideoCodec>
    {
        public int Bitrate { get; protected set; } = 0;

        public VideoIntelCodecArgument()
        {
        }

        public VideoIntelCodecArgument(VideoCodec value) : base(value)
        {
        }

        public VideoIntelCodecArgument(VideoCodec value, int bitrate) : base(value)
        {
            Bitrate = bitrate;
        }

        /// <summary>
        /// String representation of the argument
        /// </summary>
        /// <returns>String representation of the argument</returns>
        public override string GetStringValue()
        {
            return ArgumentStringifier.IntelVideo(Value);
        }
    }

    /// <summary>
    /// Represents video codec parameter
    /// </summary>
    public class VideoCodecArgument : Argument<VideoCodec>
    {
        public int Bitrate { get; protected set; } = 0;

        public VideoCodecArgument()
        {
        }

        public VideoCodecArgument(VideoCodec value) : base(value)
        {
        }

        public VideoCodecArgument(VideoCodec value, int bitrate) : base(value)
        {
            Bitrate = bitrate;
        }

        /// <summary>
        /// String representation of the argument
        /// </summary>
        /// <returns>String representation of the argument</returns>
        public override string GetStringValue()
        {
            return ArgumentStringifier.Video(Value, Bitrate);  
        }
    }
}

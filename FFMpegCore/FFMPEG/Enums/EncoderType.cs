using System;

namespace FFMpegCore.FFMPEG.Enums
{
    public enum EncoderType
    {
        Software,
        Hardware_NVIDIA, // HWENC
        hardware_Intel // QSV
    }
}


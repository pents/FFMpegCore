namespace FFMpegCore.FFMPEG.Enums
{
    public enum VideoCodec
    {
        LibX264,
        LibVpx,
        LibTheora,
        Png,
        MpegTs,
        h264_nvenc,
        h264_qsv
    }

    public enum AudioCodec
    {
        Aac,
        LibVorbis
    }

    public enum Filter
    {
        H264_Mp4ToAnnexB,
        Aac_AdtstoAsc
    }

    public enum Channel
    {
        Audio,
        Video,
        Both
    }
}
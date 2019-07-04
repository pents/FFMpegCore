using System;
using System.Collections.Generic;
using System.Text;

namespace FFMpegCore.FFMPEG.Argument.Atoms
{
    public class HWAccelArgument : Argument
    {
        public HWAccelArgument()
        {
        }


        public override string GetStringValue()
        {
            return ArgumentStringifier.HWAccel();
        }
    }
}

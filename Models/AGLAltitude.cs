// ReSharper disable FieldCanBeMadeReadOnly.Global

using System.Runtime.InteropServices;

namespace fs2ff.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct AGLAltitude
    {
        public double AltitudeAboveGround;
    }
}

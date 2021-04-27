using Domain.Core.Enum.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Window
{
    public class WindowTiming
    {
        //Timing
        public WindowType Type { get; }
        public int WindowLength { get; }
        public bool HasWiffLag { get; }

        public WindowTiming(WindowType type, int windowLength, bool hasWiffLag)
        {
            Type = type;
            WindowLength = windowLength;
            HasWiffLag = hasWiffLag;
        }

        public bool Equals(WindowTiming other)
        {
            return Type == other.Type && WindowLength == other.WindowLength && HasWiffLag == other.HasWiffLag;
        }

        public WindowTiming Duplicate()
        {
            return new WindowTiming(Type, WindowLength, HasWiffLag);
        }
    }
}

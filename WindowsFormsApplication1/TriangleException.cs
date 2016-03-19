using System;

namespace WindowsFormsApplication1
{
    public class TriangleException : Exception
    {
        public string message { get; set; }

        public TriangleException(string message) { this.message = message; }
    }
}

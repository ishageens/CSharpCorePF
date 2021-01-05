using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public interface IKost
    {
        decimal Bedrag { get; }
        bool Menselijk { get; }
    }
}

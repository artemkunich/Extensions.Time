using System;

namespace Akunich.Extensions.Time;

internal sealed class SystemTimeProvider : ITimeProvider
{
    public DateTime GetLocalNow() => DateTime.Now;

    public DateTime GetUtcNow() => DateTime.UtcNow;
}
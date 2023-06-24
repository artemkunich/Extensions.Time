using System;

namespace Akunich.Extensions.Time;

public sealed class SystemTimeProvider : ITimeProvider
{
    public DateTime GetLocalNow() => DateTime.Now;

    public DateTime GetUtcNow() => DateTime.UtcNow;
}
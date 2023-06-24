using System;

namespace Akunich.Extensions.Time;

public interface ITimeProvider
{
    DateTime GetLocalNow();

    DateTime GetUtcNow();
}
using System;
using Fusillade;

namespace MovieDBSecond.Service
{
    public interface IApiService<T>
    {
        T GetApi(Priority priority);
    }
}

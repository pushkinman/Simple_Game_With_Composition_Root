using Core.Enum;
using UnityEngine;

namespace Interfaces
{
    public interface IResourcesManager
    {
        T1 LoadResource<T1, T2>(T2 resource) where T1 : Object where T2 : System.Enum;
    }
}
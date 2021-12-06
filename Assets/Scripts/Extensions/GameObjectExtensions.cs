﻿using UnityEngine;

namespace UnityEngine
{
    public static class GameObjectExtensions
    {
        public static T CreateGameObjectWithComponent<T>() where T : MonoBehaviour
        {
            var gameObj = new GameObject($"{typeof(T).Name}");
            var component = gameObj.AddComponent<T>();
            return component;
        }
    }
}
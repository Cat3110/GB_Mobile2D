using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _Root.Scripts
{
    internal abstract class BaseController : IDisposable
    {
        private List<BaseController> _baseControllers;
        private List<GameObject> _gameObjects;
        private bool _isDisposed;
  
        public void Dispose()
        {
            if (_isDisposed)
                return;

            _isDisposed = true;
            
            DisposeBaseControllers();
            DisposeGameObjects();
            
            OnDispose();
        }

        protected void AddController(BaseController baseController)
        {
            _baseControllers ??= new List<BaseController>();
            _baseControllers.Add(baseController);
        }

        protected void AddGameObjects(GameObject gameObject)
        {
            _gameObjects ??= new List<GameObject>();
            _gameObjects.Add(gameObject);
        }

        protected void DisposeBaseControllers()
        {
            if (_baseControllers == null)
                return;
            
            foreach (BaseController baseController in _baseControllers)
                baseController?.Dispose();
            
            _baseControllers.Clear();
        }

        protected void DisposeGameObjects()
        {
            if (_gameObjects == null)
                return;
            
            foreach (GameObject cachedGameObject in _gameObjects)
                Object.Destroy(cachedGameObject);
            
            _gameObjects.Clear();
        }

        protected virtual void OnDispose()
        {
            Dispose();
        }
    }
}
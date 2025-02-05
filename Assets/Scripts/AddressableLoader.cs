using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableLoader : MonoBehaviour
{
    private GameObject _loadedObject;

    public void LoadAsset() {
        UnloadAsset(); // Deletes the original one if exists

        int rand = Random.Range(1, 4);
        Addressables.InstantiateAsync($"TestAsset{rand}").Completed += handle => {
            if(handle.Status == AsyncOperationStatus.Succeeded) {
                _loadedObject = handle.Result;
            } else {
                Debug.LogError("Failed to load Asset");
            }
        };
    }

    public void UnloadAsset() {
        if(_loadedObject != null) {
            Addressables.ReleaseInstance(_loadedObject);
            _loadedObject = null;
        }
    }

    public void ExitGame() {
        Application.Quit();
    }
}

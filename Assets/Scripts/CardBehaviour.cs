using ScriptableObjectArchitecture;
using UnityEngine;

public class CardBehaviour : MonoBehaviour
{
    [SerializeField] private int imageToShowIndex;
    [SerializeField] private IntGameEvent showImageFromIndex;

    public void ShowNewImage()
    {
        showImageFromIndex.Raise(imageToShowIndex);
    }
}

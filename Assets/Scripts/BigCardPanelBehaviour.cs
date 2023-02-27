using UnityEngine;
using UnityEngine.UI;

public class BigCardPanelBehaviour : MonoBehaviour
{
    [SerializeField] private Sprite[] cardSprites;
    [SerializeField] private Image bigCardImage;
    [SerializeField] private CanvasGroup canvasGroup;

    public void ShowCardImage(int cardIndex)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        bigCardImage.sprite = cardSprites[cardIndex];
    }

    public void HidePanel()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}

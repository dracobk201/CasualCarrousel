using UnityEngine;
using UnityEngine.UI;

public class BigCardPanelBehaviour : MonoBehaviour
{
    [SerializeField] private Sprite[] cardSprites;
    [SerializeField] private Animator bigCardAnimator;
    [SerializeField] private Image bigCardImage;
    [SerializeField] private CanvasGroup canvasGroup;

    public void ShowCardImage(int cardIndex)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        bigCardImage.sprite = cardSprites[cardIndex];
        bigCardAnimator.SetTrigger("Begin");
    }

    public void HidePanel()
    {
        bigCardAnimator.SetTrigger("Intro");
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}

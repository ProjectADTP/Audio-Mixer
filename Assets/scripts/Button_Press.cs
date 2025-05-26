using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Button_Press : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Sprite _firstImage;
    [SerializeField] private Sprite _secondImage;
    
    private Image buttonImage;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_secondImage != null)
            buttonImage.sprite = _secondImage;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (_firstImage != null)
            buttonImage.sprite = _firstImage;
    }
}

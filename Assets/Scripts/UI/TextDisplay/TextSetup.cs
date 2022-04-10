using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class TextSetup : MonoBehaviour
{
    [SerializeField] protected TextSetup otherSetup;

    [SerializeField] protected TextMeshProUGUI _text;
    [SerializeField] private Image[] _images;

    protected void SetSprites(Sprite leftImage, Sprite rightImage)
    {
        if (leftImage != null)
        {
            _images[0].enabled = true;
            _images[0].sprite = leftImage;
        }
        else
            _images[0].enabled = false;
            
        if (rightImage != null)
        {
            _images[1].enabled = true;
            _images[1].sprite = rightImage;
        }
        else
            _images[1].enabled = false;
    }

    protected virtual void Show()
    {
        _text.gameObject.SetActive(true);
    }
    
    public virtual void Hide()
    {
        _images[0].gameObject.SetActive(false);
        _images[1].gameObject.SetActive(false);
        
        _text.gameObject.SetActive(false);
    }
}

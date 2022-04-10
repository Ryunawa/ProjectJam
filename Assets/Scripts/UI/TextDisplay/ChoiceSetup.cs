using UnityEngine;
using UnityEngine.UI;

public class ChoiceSetup : TextSetup
{
    private GameChoice _gc;

    [Space]
    
    [SerializeField] private Image _image;
    
    [Space]
    
    [SerializeField] private Text _firstChoiceText;
    [SerializeField] private GameObject _firstChoiceButton;
    
    [Space]
    
    [SerializeField] private Text _secondChoiceText;
    [SerializeField] private GameObject _secondChoiceButton;
    
    public void Setup(GameChoice gc)
    {
        otherSetup.Hide();
        Show();
        SetSprites(gc.LeftImage, gc.RightImage);

        _gc = gc;
        
        _text.text = gc.Text;
        
        //Editing the correct setup
        _firstChoiceText.text = gc.FirstChoice;
        _secondChoiceText.text = gc.SecondChoice;
    }

    public void Choose(int i) => _gc.Choose(i);

    protected override void Show()
    {
        base.Show();
        
        //Making sure choice dialog setup is active
        _firstChoiceButton.SetActive(true);
        _secondChoiceButton.SetActive(true);
        
        _image.gameObject.SetActive(true);
    }

    public override void Hide()
    {
        base.Hide();
        
        _firstChoiceButton.SetActive(false);
        _secondChoiceButton.SetActive(false);
        
        _image.gameObject.SetActive(false);
    }
}

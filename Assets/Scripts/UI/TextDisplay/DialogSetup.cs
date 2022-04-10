using UnityEngine;
using UnityEngine.UI;

public class DialogSetup : TextSetup
{
    [SerializeField] private GameObject _button;
    
    public void Setup(GameDialog gd)
    {
        otherSetup.Hide();
        Show();
        SetSprites(gd.LeftImage, gd.RightImage);
        
        //Editing the correct setup
        _text.text = gd.Text;
    }

    protected override void Show()
    {
        base.Show();
        
        //Making sure simple dialog setup is active
        _button.SetActive(true);
    }

    public override void Hide()
    {
        base.Hide();
        
        _button.SetActive(false);
    }
}

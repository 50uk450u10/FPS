using UnityEngine;
using UnityEngine.UI;

public class DamageScreen : MonoBehaviour
{
    [SerializeField] Image hurtScreen;
    [SerializeField] float alpha = 140;
    [SerializeField] float colorChangeRate;

    private void Update()
    {
        Color tempColor = hurtScreen.color;
        tempColor.a = tempColor.a > 0 ? tempColor.a - colorChangeRate * Time.deltaTime : 0;
        hurtScreen.color = tempColor;
    }

    public void setHurtScreen()
    {
        Color nuAlpha = hurtScreen.color;
        nuAlpha.a = alpha / 255f;
        hurtScreen.color = nuAlpha;
    }
}

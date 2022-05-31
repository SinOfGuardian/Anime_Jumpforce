using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtheartBar : MonoBehaviour
{
    public Sprite fullHeart, halfHeart, emptyHeart;
    Image heartimage;

    private void Awake()
    {
        heartimage = GetComponent<Image>();

    }
    public void SetHeartImage(Heartstatus status)
    {
        switch (status)
        {
            case Heartstatus.Empty:
                heartimage.sprite = emptyHeart;
                break;
            case Heartstatus.Half:
                heartimage.sprite = halfHeart;
                break;
            case Heartstatus.Full:
                heartimage.sprite = fullHeart;
                break;
        }
    }
}

public enum Heartstatus
{
    Empty = 0,
    Half = 1,
    Full = 2,

       
}
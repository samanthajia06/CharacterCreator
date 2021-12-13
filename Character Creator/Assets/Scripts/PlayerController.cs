using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;
    // public TextRenderer SetName(string);
    // public TextRenderer SetDescription(string);
    // public TextRenderer SetPrice(string);
    public void SetWeapon (Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }
    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
}

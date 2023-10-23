using UnityEngine;
using UnityEngine.UI;

public class CurrentWeaponView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Image _image;

    private void OnEnable()
    {
        _player.WeaponChanged += OnWeaponChanged;
    }

    private void OnDisable()
    {
        _player.WeaponChanged -= OnWeaponChanged;
    }

    private void OnWeaponChanged(Weapon weapon)
    {
        _image.sprite = weapon.Icon;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    [SerializeField] private int _bulletsPerShoot;
    [SerializeField] private float _shootDelayMilliseconds = 0.1f;

    public override void Shoot(Transform shootPoint)
    {
        StartCoroutine(ShootBullets(shootPoint));
    }

    private IEnumerator ShootBullets(Transform shootPoint)
    {
        for (int i = 0; i < _bulletsPerShoot; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(_shootDelayMilliseconds);
        }
    }
}

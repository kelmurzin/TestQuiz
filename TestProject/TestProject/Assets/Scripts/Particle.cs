using UnityEngine;

public class Particle : MonoBehaviour
{
    [SerializeField] private ParticleSystem StarExplosionFX;

    ParticleSystem.MainModule StarExplosion;

    private void Start()
    {
        StarExplosion = StarExplosionFX.main;
    }
    public void PlayExplosionFX(Vector2 position)
    {

        StarExplosionFX.transform.position = position;
        StarExplosionFX.Play();
    }

}

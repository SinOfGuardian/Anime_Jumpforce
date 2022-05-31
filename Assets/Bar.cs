using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public GameObject heartprefab;
    public chimera chimera;
     public Health playHealth;
    List<HealtheartBar> hearts = new List<HealtheartBar>();

   /* private void OnEnable()
    {
        playHealth.onPlayerDamaged += DrawHeart();
    }
    private void OnDisable()
    {
        playHealth.onPlayerDamaged -= DrawHeart();
        //playHealth.OnPlayerDamaged -= DrawHeart();
    }*/

    private void Start()
    {
        DrawHeart();
    }
    public void DrawHeart()
    {
        ClearHearts();

        //float maxHealthRemainder = playHealth.maxHealth % 2;
        int heartsToMake = (int)(playHealth.maxHealth / 2);//monsterdamage
        for (int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }
        for (int i = 0; i < hearts.Count; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(playHealth.currentHealth - (i * 2), 0, 2);
            hearts[i].SetHeartImage((Heartstatus)heartStatusRemainder);
        }

    }
    public void CreateEmptyHeart()
    {
        GameObject newheart = Instantiate(heartprefab);
        newheart.transform.SetParent(transform);

        HealtheartBar heartComponent = newheart.GetComponent<HealtheartBar>();
        heartComponent.SetHeartImage(Heartstatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HealtheartBar>();
    }
   
}

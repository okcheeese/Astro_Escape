using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarCollector : MonoBehaviour
{
    private int star = 0;
    public TMPro.TextMeshProUGUI starText;
    private bool canCollect = true;
    public float delay = 0.5f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Star" && canCollect)
        {
            StartCoroutine(CollectStar(other));
        }
    }

    private IEnumerator CollectStar(Collider starCollider)
    {
        canCollect = false;
        star++;
        starText.text = "STARS: " + star.ToString();
        
        // Debug.Log("Star collected");

        Destroy(starCollider.gameObject);
        yield return new WaitForSeconds(delay);
        canCollect = true;
    }
}
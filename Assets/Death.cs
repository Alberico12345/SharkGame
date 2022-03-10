using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject Shark;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Shark)
        {
            Debug.Log("death");
            other.isTrigger = false;
            other.gameObject.GetComponent<Movement>().moving = false;
            other.gameObject.transform.eulerAngles = new Vector3(
                other.gameObject.transform.eulerAngles.x + 180,
                other.gameObject.transform.eulerAngles.y + 180,
                other.gameObject.transform.eulerAngles.z
            );
            StartCoroutine("Lose");
        } 
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Lose");

    }
}

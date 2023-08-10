using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscreteBar : MonoBehaviour
{

    //Start is called before the first frame update
    public GameObject containerPrefab;

    public List<Image> existingContainers;

    public Color filledColor = Color.red;

    public Color emptyColor = Color.grey;

    public int defaultMax = 5;
    public int health;



    void Start()
    {
        setMax(defaultMax);
        SetValue(defaultMax);

        //SetValue(3);
    }



    public void setMax(int maxNumber)
    {
        for (int i = 0; i < existingContainers.Count; i++)
        {
            Destroy(existingContainers[i]);
        }
        existingContainers = new List<Image>();
        for (int i = 0; i < maxNumber; i++)
        {

            existingContainers.Add(Instantiate(containerPrefab, this.transform).GetComponent<Image>());
        }
    }


    public void SetValue(int value)
    {
        for (int i = 0; i < value; i++)
        {
            existingContainers[i].color = filledColor;
        }
        for (int i = value; i < existingContainers.Count; i++)
        {
            existingContainers[i].color = emptyColor;
        }
    }

}

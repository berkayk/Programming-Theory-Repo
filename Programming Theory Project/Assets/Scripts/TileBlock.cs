using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionMethods;

public class TileBlock : MonoBehaviour
{
    [SerializeField] protected Camera mainCamera;
    [SerializeField] private List<GameObject> grasses;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject stones;

    [SerializeField] private int grassesShown = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        Decorate();
    }

    protected void ToggleGrasses()
    {
        for (int i = 0; i < grasses.Count; i++)
        {
            grasses[i].SetActive(grassesShown > i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private IEnumerator ActivateCoin(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        coin.SetActive(true);
    }

    protected void ShowCoin(int seconds)
    {
        StartCoroutine(ActivateCoin(seconds));
    }
    
    /**
     * Randomly shows grasses
     */
    public virtual void Decorate()
    {
        grassesShown = Random.Range(0, grasses.Count);
        ShowGrasses(grassesShown);
        if (grassesShown > 0)
        {
            stones.SetActive(false);
        }
    }
    
    protected void ShowGrasses(int grassCount)
    {
        grassesShown = grassCount;
        ToggleGrasses();
    }
    
    protected void ToggleStones(bool isActive)
    {
        stones.SetActive(isActive);
    }

    public bool isCoinActive()
    {
        return coin.activeInHierarchy;
    }

    public virtual string GetName()
    {
        return "Tile block";
    }
}

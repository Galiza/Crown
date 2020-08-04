using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Dictionary<string, Vector3[]> tRPositions = new Dictionary<string, Vector3[]>();

    private bool hasCrossedPaths = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetCapTrailRendererPosition(string tagName, Vector3[] position)
    {
        if (tRPositions.ContainsKey(tagName))
        {
            tRPositions[tagName] = position;
            return;
        }
        tRPositions.Add(tagName, position);
    }

    public void HasCapCrossedPaths(string tagName, Vector3 currentPos)
    {
        foreach (KeyValuePair<string, Vector3[]> dictionary in tRPositions)
        {
            if (dictionary.Key != tagName)
            {
                foreach (Vector3 storedPos in dictionary.Value)
                {
                    if (storedPos.Equals(currentPos) && !storedPos.Equals(new Vector3()))
                    {
                        hasCrossedPaths = true;
                        Debug.Log("Crossed paths");
                        break;
                    }
                }
            }
        }
    }
}

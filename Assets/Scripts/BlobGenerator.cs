using UnityEngine;
using System.Collections;

public class BlobGenerator : MonoBehaviour {
    public GameObject blobPrefab;
    public GameObject blobs;
    public int numberOfBlobs;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


    private Color c1;
    private Color c2;
    private Color[] colors;

    void Start() {
        c1 = RandomColor();
        c2 = RandomColor();

        colors = new Color[] {c1, c2};

        PlaceBlobs();
    }

    Color RandomColor() {
        return new Color(Random.value, Random.value, Random.value);
    }

    void PlaceBlobs() {
        for (int i = 0; i < numberOfBlobs; i++) {
            GameObject blockClone = Instantiate(blobPrefab,
                                                new Vector3(Random.Range(xMin, xMax),
                                                            Random.Range(yMin, yMax),
                                                            0f),
                                                Quaternion.identity) as GameObject;
            SpriteRenderer sprite = blockClone.GetComponent<SpriteRenderer>();
            blockClone.transform.parent = blobs.transform;
            sprite.color = colors[Random.Range(0, colors.Length)];
        }
    }

}

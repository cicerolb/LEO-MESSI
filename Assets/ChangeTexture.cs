using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    public List<Texture> armColor = new List<Texture>();
    public List<Texture> faceColor = new List<Texture>();
    public List<Texture> kneeColor = new List<Texture>();

    public Material originalArmSkin;
    public Material originalFaceSkin;
    public Material originalKneeSkin;

    public Transform messi;
    // Start is called before the first frame update

    public void Start()
    {
        originalArmSkin.mainTexture = armColor[0];
        originalFaceSkin.mainTexture = faceColor[0];
        originalKneeSkin.mainTexture = kneeColor[0];

        messi = GetComponent<Transform>();

    }

        
    // Update is called once per frame


    public void ChangeHairColor()
    {
    
        
            int currentTextureIndex = armColor.IndexOf(originalArmSkin.mainTexture);
            currentTextureIndex++;

            if (currentTextureIndex >= armColor.Count)
            {
                currentTextureIndex = 0;
            }

            originalArmSkin.mainTexture = armColor[currentTextureIndex];

            int currentFaceTextureIndex = faceColor.IndexOf(originalFaceSkin.mainTexture);
            currentFaceTextureIndex++;

            if (currentFaceTextureIndex >= faceColor.Count)
            {
                currentFaceTextureIndex = 0;
            }

            originalFaceSkin.mainTexture = faceColor[currentFaceTextureIndex];

            int currentKneeTextureIndex = kneeColor.IndexOf(originalKneeSkin.mainTexture);
            currentKneeTextureIndex++;

            if (currentKneeTextureIndex >= kneeColor.Count)
            {
                currentKneeTextureIndex = 0;
            }

            originalKneeSkin.mainTexture = kneeColor[currentKneeTextureIndex];

        

    }

    public void Transform()
    {
        
    }
}

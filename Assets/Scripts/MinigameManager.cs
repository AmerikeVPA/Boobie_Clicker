using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MinigameManager : MonoBehaviour
{
    public List<string> Steps = new List<string>();
    public TextMeshPro selfExamInstruction;

    public void MoveImages(GameObject imageToMove)
    {
        Vector3 endV3 = new Vector3(imageToMove.transform.localPosition.x - 500f, imageToMove.transform.localPosition.y, imageToMove.transform.localPosition.z);
        StartCoroutine(MoveGraphic(imageToMove, endV3));
    }
    IEnumerator MoveGraphic(GameObject imageToMove, Vector3 endPos)
    {
        yield return new WaitForSeconds(0.1f);
        imageToMove.transform.localPosition = Vector3.MoveTowards(imageToMove.transform.localPosition, endPos, 37.5f);
        StartCoroutine(MoveGraphic(imageToMove, endPos));
    }
    public void FadeOut(Graphic affctdGrphc)
    {
        affctdGrphc.CrossFadeAlpha(0, .5f, false);
        Destroy(affctdGrphc.gameObject, 1.25f);
    }
    public void FadeIn(Graphic affctdGrphc) { affctdGrphc.CrossFadeAlpha(255, 1.5f, false); }
    public void DestroyObj(GameObject affctdObj) { Destroy(affctdObj, 1.5f); }

}
using UnityEngine;
using System.Runtime.InteropServices;

public class JavaFunctions : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void CheckGender(string gender);
    [DllImport("__Internal")]
    private static extern void EnterUser(string username);
    [DllImport("__Internal")]
    private static extern void SaveMoney(int money);
    [DllImport("__Internal")]
    private static extern void SaveImages(int images);
    public void ChooseGender(int genderIndex) {
		switch (genderIndex)
		{
            case 0:
                CheckGender("Male");
                break;
            case 1:
                CheckGender("Female");
                break;
            case 2:
                CheckGender("Non-Binary");
                break;
        }
    }
    public void ReadUser(string name) { EnterUser(name); }
    public void ReadMoney(int playerMoney) { SaveMoney(playerMoney); }
    public void ReadUnlocks(int playerImages) { SaveImages(playerImages); }
}
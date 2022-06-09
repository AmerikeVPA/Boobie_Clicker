using TMPro;
using UnityEngine;
using System.Runtime.InteropServices;

public class JavaFunctions : MonoBehaviour {

    int money, images;
    string user, gender;

    [DllImport("__Internal")]
    private static extern string SetUser(string gender, string user, int money, int images);
    [DllImport("__Internal")]
    private static extern string UpdateUser(string user, int money, int images);
    public void SendNewUser() { SetUser(gender, user, money, images); }
    public void ChangeUser() { UpdateUser(user, money, images); }
    public void ChooseGender(int genderIndex)
    {
		switch (genderIndex)
		{
            case 0:
                gender = ("Male");
                break;
            case 1:
                gender = ("Female");
                break;
            case 2:
                gender = ("Non-Binary");
                break;
        }
    }
    public void ReadUser(TextMeshProUGUI name) { user = name.text; }
    public void ReadMoney() { money = FindObjectOfType<Score>().money; }
    public void ReadUnlocks() { images = FindObjectOfType<GameManager>().unlocks; }
}
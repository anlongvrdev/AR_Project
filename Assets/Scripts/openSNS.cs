using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSNS : MonoBehaviour
{
    public void showFacebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100024356507704");
    }

    public void showMaps()
    {
        Application.OpenURL("https://maps.app.goo.gl/vNeqDTNypQYUHn6u8");
    }

    public void showLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/linh-nguy%E1%BB%85n-8b0260342/");
    }

    public void showYoutube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC4ZU46NCjcxpBCeRSb1_wKA");
    }
}

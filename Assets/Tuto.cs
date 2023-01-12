using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Tuto : MonoBehaviour
{
    public ScriptedJourney scriptedJourney;

    public int TutoInt;

    public bool TutoBool;

    public GameObject SideBar;

    public GameObject SideBarPicture;

    public GameObject SideBarPrenom1;
    public GameObject SideBarPrenom2;

    public GameObject SideBarDate;

    public GameObject SideBarChildren;

    public GameObject Doc11;
    public GameObject Doc12;

    public GameObject Doc21;
    public GameObject Doc22;

    public GameObject Doc31;
    public GameObject Doc32;

    public GameObject Doc41;
    public GameObject Doc42;

    public GameObject nam;
    public GameObject Date;

    public GameObject Henrich;
    public GameObject Pauline;

    public GameObject PaulineRep1;
    public GameObject PaulineRep2;
    public GameObject PaulineRep3;

    public GameObject skip;

    public TextMeshProUGUI HenrichText;
    public TextMeshProUGUI PaulineText;

    public TextMeshProUGUI PaulineTextRep1;
    public TextMeshProUGUI PaulineTextRep2;
    public TextMeshProUGUI PaulineTextRep3;

    [Range(0f, 31f)]
    public int day;
    [Range(0f,12f)]
    public int month;
    [Range(1870f,1927f)]
    public int year;
    
    public Slider sliderDay;
    public Slider sliderMonth;
    public Slider sliderYear;

    public TMP_Text textDay;
    public TextMeshProUGUI textMonth;
    public TextMeshProUGUI textYear;

    public int pageNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        TutoInt = 0;
        TutoBool = false;

        SideBar = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar");
        SideBarPicture = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/picture");
        SideBarPrenom1 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/prenom/Page1");
        SideBarPrenom2 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/prenom/Page2");
        SideBarDate = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/Date");
        SideBarChildren = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/Children");
        SideBar.SetActive(false);
        SideBarPicture.SetActive(false);
        SideBarPrenom1.SetActive(false);
        SideBarPrenom2.SetActive(false);
        SideBarDate.SetActive(false);
        SideBarChildren.SetActive(false);

        Doc11 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc1/1");
        Doc12 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc1/2");
        //Doc11.SetActive(false);
        Doc12.SetActive(false);

        Doc21 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc2/1");
        Doc22 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc2/2");
        Doc21.SetActive(false);
        Doc22.SetActive(false);

        Doc31 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc3/1");
        Doc32 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc3/2");
        Doc31.SetActive(false);
        Doc32.SetActive(false);

        Doc41 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc4/1");
        Doc42 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc4/2");
        Doc41.SetActive(false);
        Doc42.SetActive(false);

        Henrich = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Henrich");
        Pauline = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline");
        Henrich.SetActive(false);
        Pauline.SetActive(false);

        PaulineRep1 = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/rep1");
        PaulineRep2 = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/rep2");
        PaulineRep3 = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/rep3");

        skip = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Skip");
        skip.SetActive(false);

        HenrichText = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Henrich/Text").GetComponent<TextMeshProUGUI>();
        PaulineText = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/Text").GetComponent<TextMeshProUGUI>();

        PaulineTextRep1 = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/rep1/Text (TMP)").GetComponent<TextMeshProUGUI>();
        PaulineTextRep2 = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/rep2/Text (TMP)").GetComponent<TextMeshProUGUI>();
        PaulineTextRep3 = GameObject.Find("/-----UI-----/Canvas/RUELLE Mode/Pauline/rep3/Text (TMP)").GetComponent<TextMeshProUGUI>();

        PaulineRep1.SetActive(false);
        PaulineRep2.SetActive(false);
        PaulineRep3.SetActive(false);
    }

    void Update()
    {
         day = (int)sliderDay.value;
         month = (int)sliderMonth.value;
         year = (int)sliderYear.value;

        textDay.SetText(day.ToString());
        textMonth.SetText(month.ToString());
        textYear.SetText(year.ToString());

        Debug.Log(TutoInt);
        if (TutoInt == 1)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(true);
            Doc12.SetActive(false);
            Doc21.SetActive(false);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if(TutoInt == 2)
        {
            SideBar.SetActive(true);
            SideBarPicture.SetActive(true);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(true);
            Doc12.SetActive(false);
            Doc21.SetActive(false);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 3)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(true);
            Doc21.SetActive(false);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 4)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(false);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 5)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 6)
        {
            SideBar.SetActive(true);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(true);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 6)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 7)
        {
            SideBar.SetActive(true);
            SideBarPicture.SetActive(false);
            if (pageNum == 2)
            {SideBarPrenom1.SetActive(false); SideBarPrenom2.SetActive(true); }
            if (pageNum == 1)
            { SideBarPrenom2.SetActive(false); SideBarPrenom1.SetActive(true); }
            if(pageNum == 0) { SideBarPrenom1.SetActive(true); }
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 8)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarPrenom2.SetActive(false);
            nam.SetActive(false);
            Date.SetActive(true);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
            
        }
        if (TutoInt == 9)
        {
            SideBar.SetActive(true);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            Date.SetActive(false);
            SideBarDate.SetActive(true);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }

        if (day == 8 && month == 1 && year == 1922 && TutoInt< 10)
        {
            Debug.Log("dfvsnjk");
            TutoInt = 11;
            scriptedJourney.StatusTuto = 7;
        }

        if (TutoInt == 10 || TutoInt ==11)
        {
            Henrich.SetActive(true);
            Pauline.SetActive(false);
            skip.SetActive(true);
            HenrichText.SetText("Halo Fraulein. I am the Kriminalbersekretar Henrich Richtofen");
        }
        if (TutoInt == 12)
        {
            Henrich.SetActive(false);
            Pauline.SetActive(true);
            PaulineText.SetText("Hello Monsieur.... How can i help you?");
        }
        if (TutoInt == 13)
        {
            Henrich.SetActive(true);
            Pauline.SetActive(false);
            HenrichText.SetText("Ja. Have you heard some rumor or seen anything suspicious latly? Anything that have caught your attention?");
        }
        if (TutoInt == 14)
        {
            Henrich.SetActive(false);
            Pauline.SetActive(true);
            PaulineRep1.SetActive(true);
            PaulineRep2.SetActive(true);
            PaulineRep3.SetActive(true);
            skip.SetActive(false);
            PaulineTextRep1.SetText("I'm sorry, but i don't know anything. Nothing like that has caught my attention");
            PaulineTextRep2.SetText("Well... no");
            PaulineTextRep3.SetText("Maybe. There have been some rumors going around, but nothing too serious.");
        }
        if (TutoInt == 15)
        {
            Henrich.SetActive(true);
            Pauline.SetActive(false);
            PaulineRep1.SetActive(false);
            PaulineRep2.SetActive(false);
            PaulineRep3.SetActive(false);
            skip.SetActive(true);
            HenrichText.SetText("Naturlich… and have any of your acquaintances seemed suspicious recently?");
        }
        if (TutoInt == 16)
        {
            Henrich.SetActive(false);
            Pauline.SetActive(true);
            PaulineRep1.SetActive(true);
            PaulineRep2.SetActive(true);
            PaulineRep3.SetActive(true);
            skip.SetActive(false);
            PaulineTextRep1.SetText("Not that I’m aware of, no.");
            PaulineTextRep2.SetText("No, I’m very careful when it comes to my relations.");
            PaulineTextRep3.SetText("I don’t know, I didn’t notice anything.");
        }
        if (TutoInt == 17)
        {
            Henrich.SetActive(true);
            Pauline.SetActive(false);
            PaulineRep1.SetActive(false);
            PaulineRep2.SetActive(false);
            PaulineRep3.SetActive(false);
            skip.SetActive(true);
            HenrichText.SetText("I see. Thank you for letting me know. We’ll probably see each other again in the near future, so stay alert of your surroundings and the people you talk to. Have a good day.");
        }
        if(TutoInt == 18 && scriptedJourney.StatusTuto < 10)
        {
            Henrich.SetActive(false);
            Pauline.SetActive(false);
            PaulineRep1.SetActive(false);
            PaulineRep2.SetActive(false);
            PaulineRep3.SetActive(false);
            skip.SetActive(false);
            scriptedJourney.StatusTuto = 10;
        }
        if (TutoInt == 19)
        {
            SideBar.SetActive(true);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(false);
            Doc22.SetActive(false);
            Doc31.SetActive(true);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }

        if (TutoInt == 20)
        {
            SideBar.SetActive(true);
            SideBarPicture.SetActive(false);
            SideBarPrenom1.SetActive(false);
            SideBarDate.SetActive(true);
            SideBarChildren.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(false);
            Doc22.SetActive(false);
            Doc31.SetActive(true);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
        if (TutoInt == 20 && day == 14 && month == 8 && year == 1943)
        {
            TutoInt = 21;
            scriptedJourney.StatusTuto = 11;
        }




        //le check point 10 de journey status tuto ce fait ici
    }

    public void openSideButton()
    {
        
        if(TutoInt == 1)
        {
            TutoInt = 2;
        }
        if (TutoInt == 4)
        {
            TutoInt = 5;
        }
        if (TutoInt == 6)
        {
            TutoInt = 7;
        }
        if (TutoInt == 8)
        {
            TutoInt = 9;
        }
    }

    public void SidebarActualButton()
    {
        if (TutoInt == 2)
        {
            TutoInt = 3;
        }
        if (TutoInt == 7)
        {
            TutoInt = 8;
        }

        

    }
    public void switchPage()
    {
        pageNum = 2;
    }
    public void switchPageAGAIN()
    {
        pageNum = 1;
    }
    public void Skip()
    {
        Henrich.SetActive(true);
        Pauline.SetActive(false);
        if (TutoInt == 11)
        {Debug.Log("nrtb,klb,ertnko");
            TutoInt =121;
            StartCoroutine(ExampleCoroutine());
        }
        if (TutoInt == 12)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 131;
            StartCoroutine(ExampleCoroutine());
        }
        if (TutoInt == 13)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 141;
            StartCoroutine(ExampleCoroutine());
        }
        if (TutoInt == 14)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 151;
            StartCoroutine(ExampleCoroutine());
        }
        if (TutoInt == 15)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 161;
            StartCoroutine(ExampleCoroutine());
        }
        if (TutoInt == 16)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 171;
            StartCoroutine(ExampleCoroutine());
        }
        if (TutoInt == 17)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 181;
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        if (TutoInt == 121)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 12;
        }
        if (TutoInt == 131)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 13;
        }
        if (TutoInt == 141)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 14;
        }
        if (TutoInt == 151)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 15;
        }
        if (TutoInt == 161)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 16;
        }
        if (TutoInt == 171)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 17;
        }
        if (TutoInt == 181)
        {
            Debug.Log("nrtb,klb,ertnko");
            TutoInt = 18;
        }
    }
}

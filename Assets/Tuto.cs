using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public int TutoInt = 0;

    public bool TutoBool;

    public GameObject SideBar;

    public GameObject SideBarPicture;

    public GameObject SideBarPrenom;

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

    // Start is called before the first frame update
    void Start()
    {
        TutoInt = 0;
        TutoBool = false;

        SideBar = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar");
        SideBarPicture = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/picture");
        SideBarPrenom = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/prenom");
        SideBarDate = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/Date");
        SideBarChildren = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Sidebar/Children");
        SideBar.SetActive(false);
        SideBarPicture.SetActive(false);
        SideBarPrenom.SetActive(false);
        SideBarDate.SetActive(false);
        SideBarChildren.SetActive(false);
        SideBar.SetActive(false);

        Doc11 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc1/1");
        Doc12 = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/Tuto/Doc1/2");
        Doc11.SetActive(false);
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
    }

    void update()
    {
        if(TutoInt == 1)
        {
            SideBar.SetActive(false);
            SideBarPicture.SetActive(false);
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(true);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(false);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
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
            SideBarPrenom.SetActive(false);
            SideBarDate.SetActive(true);
            SideBarChildren.SetActive(false);
            SideBar.SetActive(false);
            Doc11.SetActive(false);
            Doc12.SetActive(false);
            Doc21.SetActive(true);
            Doc22.SetActive(false);
            Doc31.SetActive(false);
            Doc32.SetActive(false);
            Doc41.SetActive(false);
            Doc42.SetActive(false);
        }
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
    }

    public void SidebarActualButton()
    {
        if (TutoInt == 2)
        {
            TutoInt = 3;
        }
        if (TutoInt == 5)
        {
            TutoInt = 6;
        }
    }
}

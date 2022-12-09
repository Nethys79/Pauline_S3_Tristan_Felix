using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SheetManager : MonoBehaviour
{
    [Header("------Taille------")]
    public GameObject Taille;
    public TextMeshPro textTaille;
    public GameObject buttonTaille;
    [Header("------Nez------")]
    public GameObject textNez;
    public GameObject buttonNez;
    [Header("------Visage------")]
    public GameObject textVisage;
    public GameObject buttonVisage;
    [Header("------Yeux------")]
    public GameObject textYeux;
    public GameObject buttonYeux;
    [Header("------Teint------")]
    public GameObject textTeint;
    public GameObject buttonTeint;
    [Header("------Cheveux------")]
    public GameObject textCheveux;
    public GameObject buttonCheveux;
    [Header("------Signe Particulier------")]
    public GameObject textSigneParticulier;
    public GameObject buttonSigneParticulier;
    [Header("------Valable Du------")]
    public GameObject textValableDu;
    public GameObject buttonValableDu;
    [Header("------Au------")]
    public GameObject textAu;
    public GameObject buttonAu;
    [Header("------Delivré à------")]
    public GameObject textDelivrerA;
    public GameObject buttonDelivrerA;
    [Header("------Le------")]
    public GameObject textLe;
    public GameObject buttonLe;
    [Header("------Tampon------")]
    public GameObject textTampon;
    public GameObject buttonTampon;
    [Header("------Nom------")]
    public GameObject textNom;
    public GameObject buttonNom;
    [Header("------Prenom------")]
    public GameObject textPrenom;
    public GameObject buttonPrenom;
    [Header("------Né le------")]
    public GameObject textNeLe;
    public GameObject buttonNeLe;
    [Header("------Date 1------")]
    public GameObject textDate1;
    public GameObject buttonDate1;
    [Header("------Date 2------")]
    public GameObject textDate2;
    public GameObject buttonDate2;
    [Header("------à------")]
    public GameObject textà;
    public GameObject buttonà;
    [Header("------Sex------")]
    public GameObject textSex;
    public GameObject buttonSex;
    [Header("------Francais par------")]
    public GameObject textFrancaisPar;
    public GameObject buttonFrancaisPar;
    [Header("------Situation de famille------")]
    public GameObject textSituationDeFamille;
    public GameObject buttonSituationDeFamille;
    [Header("------Profession------")]
    public GameObject textProfession;
    public GameObject buttonProfession;

    private void Start()
    {
        Taille = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/TailleText");
        textTaille = Taille.GetComponent<TextMeshPro>();
        buttonTaille = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Taille");

        textNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/NezText");
        buttonNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Nez");

        textNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/VisageText");
        buttonVisage = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Visage");

        textNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/YeuxText");
        buttonYeux = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Yeux");

        textNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Teint.Text");
        buttonTeint = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Teint");

        textNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/CheveuxText");
        buttonCheveux = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Cheveux");

        textNez = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/SigneParticulierText");
        buttonSigneParticulier = GameObject.Find("/-----UI-----/Canvas/ZENITAL Mode/Panel/ret/Signe Particulier");
    }

    public void onClick()
    {
        //textTaille.a = 0;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PiketFunctionaris
{
	private string naam { get; set; }

	private string functie	{ get; set; }

	private bool beschikbaar	{ get; set; }

    private string wachtwoord	{ get; set; }

	private int incidentBeheerder { get; set; }

	private bool locatieBeheerder { get; set; }

	private bool actief 	{ get; set; }

	private string locatie	{ get; set; }

	private bool gebruikSms	{ get; set; }

	private bool gebruikEmail	{ get; set; }

    private bool gebruikApp { get; set; }

    private bool gebruikTextToSpeech { get; set; }

	public virtual IEnumerable<OproepFunctie> OproepFunctie	{ get; set; }

	public virtual void geefEmailAccount()
	{
		throw new System.NotImplementedException();
	}

	public virtual void geefTelefoonnummer()
	{
		throw new System.NotImplementedException();
	}

    public void setPiketFunctionaris(bool _actief, bool _beschikbaar, bool _gebruikSms, bool _gebruikEmail, bool _gebruikApp, bool _gebruikTextToSpeech, string _naam)
    {
        actief = _actief;
        beschikbaar = _beschikbaar;
        gebruikSms = _gebruikSms;
        gebruikEmail = _gebruikEmail;
        gebruikApp = _gebruikApp;
        gebruikTextToSpeech = _gebruikTextToSpeech;
        naam = _naam;
    }

    public bool getActief()
    {
        return actief;
    }

    public bool getBeschikbaar()
    {
        return beschikbaar;
    }

    public bool getGebruikSms()
    {
        return gebruikSms;
    }

    public bool getGebruikEmail()
    {
        return gebruikEmail;
    }
    public bool getGebruikApp()
    {
        return gebruikApp;
    }
    public bool getGebruikTextToSpeech()
    {
        return gebruikTextToSpeech;
    }
}

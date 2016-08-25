using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class OproepMelding
{
	private DateTime activering { get; set; }

	private DateTime gesloten  { get; set; }

	private int smsNr { get; set; }

	private string bericht { get; set; }

	private string capcode { get; set; }
    
    //private ArrayClass oproepFunctie  { get; set; }

    public virtual IEnumerable<ISms> SMS  { get; set; }

	public virtual IEnumerable<IApp> App { get; set; }

	public virtual IEnumerable<IEmail> Email { get; set; }

	public  void verstuurBericht()
    {
        //verstuur naar interface
    }

	public virtual void berichtenLog()
	{
		throw new System.NotImplementedException();
	}
	public virtual void geefLocatie()
	{
		throw new System.NotImplementedException();
	}

    public void setOproepMelding(DateTime _activering, int _smsNr, string _bericht, string _capcode) 
    {
        activering = _activering;  
        smsNr = _smsNr;
        bericht = _bericht;
        capcode = _capcode;
    }
}


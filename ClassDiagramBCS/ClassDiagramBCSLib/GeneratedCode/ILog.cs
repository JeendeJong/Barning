using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ILog 
{
	string bericht { get;set; }

	DateTime datumTijd { get;set; }

	string errorSoort { get;set; }

	ErrorLog ErrorLog { get;set; }

}


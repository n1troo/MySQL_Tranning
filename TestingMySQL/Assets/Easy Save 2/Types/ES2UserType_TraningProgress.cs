using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ES2UserType_TraningProgress : ES2Type
{
	public override void Write(object obj, ES2Writer writer)
	{
		TranningProgress data = (TranningProgress)obj;
		// Add your writer.Write calls here.
		writer.Write(data.Week);
		writer.Write(data.Day);
		writer.Write(data.Set);
		writer.Write(data.Level);

	}
	
	public override object Read(ES2Reader reader)
	{
		TranningProgress data = new TranningProgress();
		Read(reader, data);
		return data;
	}

	public override void Read(ES2Reader reader, object c)
	{
		TranningProgress data = (TranningProgress)c;
		// Add your reader.Read calls here to read the data into the object.
		data.Week = reader.Read<System.Int32>();
		data.Day = reader.Read<System.Int32>();
		data.Set = reader.Read<System.Int32>();
		data.Level = reader.Read<System.Int32>();

	}
	
	/* ! Don't modify anything below this line ! */
	public ES2UserType_TraningProgress():base(typeof(TranningProgress)){}
}
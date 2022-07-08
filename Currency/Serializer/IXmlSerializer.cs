using System.Collections.Generic;
using System.Text;

namespace Currency.Serializer
{
	internal interface IXmlSerializer
	{
		T Deserializer<T>(string value);

		string Serializer(object value);
	}
}
